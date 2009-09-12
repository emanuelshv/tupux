using System;
using System.Collections.Generic;
using System.Text;
using EnvDTE80;
using EnvDTE;
using System.Reflection;
using TUPUX.ActiveRecord;
using TUPUX.Entity.Constants;
using System.IO;
using System.ComponentModel;
using System.Xml;

namespace TUPUX.Entity
{
    /// <summary>
    /// Utility class to provide documentation for various types where available with the assembly
    /// </summary>
    public class DocsByReflection
    {
        /// <summary>
        /// Provides the documentation comments for a specific method
        /// </summary>
        /// <param name="methodInfo">The MethodInfo (reflection data ) of the member to find documentation for</param>
        /// <returns>The XML fragment describing the method</returns>
        public static XmlNode XMLFromMember(MethodInfo methodInfo)
        {
            // Calculate the parameter string as this is in the member name in the XML
            string parametersString = "";
            foreach (ParameterInfo parameterInfo in methodInfo.GetParameters())
            {
                if (parametersString.Length > 0)
                {
                    parametersString += ",";
                }

                parametersString += parameterInfo.ParameterType.FullName;
            }

            //AL: 15.04.2008 ==> BUG-FIX remove “()” if parametersString is empty
            if (parametersString.Length > 0)
                return XMLFromName(methodInfo.DeclaringType, 'M', methodInfo.Name + "(" + parametersString + ")");
            else
                return XMLFromName(methodInfo.DeclaringType, 'M', methodInfo.Name);
        }

        /// <summary>
        /// Provides the documentation comments for a specific member
        /// </summary>
        /// <param name="memberInfo">The MemberInfo (reflection data) or the member to find documentation for</param>
        /// <returns>The XML fragment describing the member</returns>
        public static XmlNode XMLFromMember(MemberInfo memberInfo)
        {
            // First character [0] of member type is prefix character in the name in the XML
            return XMLFromName(memberInfo.DeclaringType, memberInfo.MemberType.ToString()[0], memberInfo.Name);
        }

        /// <summary>
        /// Provides the documentation comments for a specific type
        /// </summary>
        /// <param name="type">Type to find the documentation for</param>
        /// <returns>The XML fragment that describes the type</returns>
        public static XmlNode XMLFromType(Type type)
        {
            // Prefix in type names is T
            return XMLFromName(type, 'T', "");
        }

        /// <summary>
        /// Obtains the XML Element that describes a reflection element by searching the 
        /// members for a member that has a name that describes the element.
        /// </summary>
        /// <param name="type">The type or parent type, used to fetch the assembly</param>
        /// <param name="prefix">The prefix as seen in the name attribute in the documentation XML</param>
        /// <param name="name">Where relevant, the full name qualifier for the element</param>
        /// <returns>The member that has a name that describes the specified reflection element</returns>
        private static XmlNode XMLFromName(Type type, char prefix, string name)
        {
            string fullName;

            if (String.IsNullOrEmpty(name))
            {
                fullName = prefix + ":" + type.FullName;
            }
            else
            {
                fullName = prefix + ":" + type.FullName + "." + name;
            }

            XmlDocument xmlDocument = XMLFromAssembly(type.Assembly);

            
            XmlNode matchedElement = null;

            if (xmlDocument != null)
            {
                foreach (XmlNode doc in xmlDocument.ChildNodes)
                {
                    if (doc.Name.Equals("doc"))
                    {
                        foreach (XmlNode members in doc.ChildNodes)
                        {
                            if (members.Name.Equals("members"))
                            {
                                foreach (XmlNode member in members.ChildNodes)
                                {
                                    if (member.Attributes != null && member.Attributes["name"] != null && member.Attributes["name"].Value.Equals(fullName))
                                    {
                                        matchedElement = member;
                                    }
                                }
                            }
                        }
                    }
                }

                //foreach (XmlElement xmlElement in xmlDocument["doc"]["members"])
                //{
                //    if (xmlElement.Attributes["name"].Value.Equals(fullName))
                //    {
                //        if (matchedElement != null)
                //        {

                //        }

                //        matchedElement = xmlElement;
                //    }
                //}
            }
            return matchedElement;
        }

        /// <summary>
        /// A cache used to remember Xml documentation for assemblies
        /// </summary>
        static Dictionary<Assembly, XmlDocument> cache = new Dictionary<Assembly, XmlDocument>();

        /// <summary>
        /// A cache used to store failure exceptions for assembly lookups
        /// </summary>
        static Dictionary<Assembly, Exception> failCache = new Dictionary<Assembly, Exception>();

        /// <summary>
        /// Obtains the documentation file for the specified assembly
        /// </summary>
        /// <param name="assembly">The assembly to find the XML document for</param>
        /// <returns>The XML document</returns>
        /// <remarks>This version uses a cache to preserve the assemblies, so that 
        /// the XML file is not loaded and parsed on every single lookup</remarks>
        public static XmlDocument XMLFromAssembly(Assembly assembly)
        {
            if (failCache.ContainsKey(assembly))
            {
                throw failCache[assembly];
            }

            try
            {

                if (!cache.ContainsKey(assembly))
                {
                    // load the docuemnt into the cache
                    cache[assembly] = XMLFromAssemblyNonCached(assembly);
                }

                return cache[assembly];
            }
            catch (Exception exception)
            {
                failCache[assembly] = exception;
                throw exception;
            }
        }

        /// <summary>
        /// Loads and parses the documentation file for the specified assembly
        /// </summary>
        /// <param name="assembly">The assembly to find the XML document for</param>
        /// <returns>The XML document</returns>
        private static XmlDocument XMLFromAssemblyNonCached(Assembly assembly)
        {
            string assemblyFilename = assembly.CodeBase;

            const string prefix = "file:///";

            if (assemblyFilename.StartsWith(prefix))
            {
                StreamReader streamReader = null;

                try
                {
                    streamReader = new StreamReader(Path.ChangeExtension(assemblyFilename.Substring(prefix.Length), ".xml"));
                }
                catch (FileNotFoundException exception)
                {
                    
                }

                if (streamReader != null)
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(streamReader);
                    return xmlDocument;
                }
            }

            return null;
        }
    }

    public static class SolutionImport
    {
        public static bool IncludeClass = true;
        public static bool IncludeEnumeration = true;
        public static bool IncludeInterface = true;
        public static string File = "";
        private static BackgroundWorker bwAsync = null;

        /// <summary>
        /// Adds message to the background worker
        /// </summary>
        /// <param name="percentage">Percentage</param>
        /// <param name="message">Message</param>
        private static void addMessageBackgroundWorker(int percentage, string message)
        {
            if (bwAsync != null)
            {
                bwAsync.ReportProgress(percentage, message);
            }
        }

        public static void OpenSolution(object sender, DoWorkEventArgs e)
        {
            bwAsync = sender as BackgroundWorker;
            EnvDTE80.DTE2 dte = null;
            Dictionary<string, IUMLElement> listElements = new Dictionary<string, IUMLElement>();
            try
            {
                dte = (EnvDTE80.DTE2)Microsoft.VisualBasic.Interaction.CreateObject("VisualStudio.DTE.8.0", "");
                

                Solution2 soln = (Solution2)dte.Solution;

                soln.Open(File);


                SolutionBuild2 build = (SolutionBuild2)soln.SolutionBuild;

                addMessageBackgroundWorker(0, "Building Solution...");

                build.SolutionConfigurations.Item("Debug").Activate();

                build.Clean(true);

                build.Build(true);
                                

                UMLModel model = Helper.GetCurrentElement<UMLModel>();
                if (build.LastBuildInfo == 0 && model != null)
                {
                    IUMLElement solutionUML = new UMLPackage();
                    solutionUML.Name = Path.GetFileName(soln.FileName);
                    solutionUML.Owner = model;
                    listElements.Add(solutionUML.Name, solutionUML);

                    
                    for (int i = 1; i <= soln.Projects.Count; i++)
                    {                        
                        Project project = soln.Projects.Item(i);
                        
                        if (project.Properties != null)
                        {                            
                            string fullPath = (string)project.Properties.Item("FullPath").Value;
                            string outputfileName = (string)project.Properties.Item("OutputFileName").Value;
                            Assembly assembly = Assembly.LoadFile(fullPath + @"Bin\Debug\" + outputfileName);


                            IUMLElement projectUML = new UMLPackage();
                            projectUML.Name = project.Name;
                            listElements.Add(project.Name, projectUML);
                            projectUML.Owner = solutionUML;

                            addMessageBackgroundWorker(0, "Processing Types: \n" + project.Name);

                            foreach (Type type in assembly.GetTypes())
                            {
                                
                                if (type.MemberType == MemberTypes.TypeInfo)
                                {
                                    IUMLElement element = null;

                                    if (type.IsEnum && IncludeEnumeration)
                                    {
                                        element = new UMLEnumeration();
                                        element.Name = type.Name;
                                        ((UMLEnumeration)element).Literals = GetLiterals(type);
                                    }
                                    else
                                    {
                                        if (type.IsClass && IncludeClass)
                                        {
                                            element = new UMLClass();
                                            element.Name = type.Name;
                                            ((UMLClass)element).Attributes = GetProperties(type);
                                            ((UMLClass)element).Attributes.AddRange(GetStaticAndConstants(type));
                                            ((UMLClass)element).Methods = GetMethods(type);
                                            if (type.IsGenericType)
                                            {
                                                element.Name = element.Name.Substring(0, element.Name.IndexOf("`"));

                                                element.Name += "<";
                                                foreach (Type t in type.GetGenericArguments())
                                                {
                                                    element.Name += t.Name + ",";
                                                }

                                                element.Name = element.Name.TrimEnd(',');
                                                element.Name += ">";
                                            }
                                        }
                                        else if (type.IsInterface && IncludeInterface)
                                        {
                                            element = new UMLInterface();
                                            element.Name = type.Name;
                                            ((UMLInterface)element).Attributes = GetProperties(type);

                                        }
                                    }

                                    if (element != null)
                                    {
                                        IUMLElement owner = null;

                                        if (type.Namespace == null)
                                        {
                                            owner = projectUML;
                                        }
                                        else if (listElements.ContainsKey(type.Namespace))
                                        {
                                            owner = listElements[type.Namespace];
                                        }
                                        else
                                        {
                                            owner = new UMLPackage();
                                            //if(type.Namespace.Contains(projectUML.Name))
                                            //{
                                            //    owner.Name = type.Namespace.Replace(projectUML.Name, "");
                                            //}
                                            owner.Stereotype = "ClassPackage";
                                            owner.Name = type.Namespace;
                                            owner.Owner = projectUML;                                            
                                            listElements.Add(type.Namespace, owner);
                                        }

                                        element.Owner = owner;
                                        if ((type.Attributes & TypeAttributes.Public) == TypeAttributes.Public)
                                        {
                                            element.Visibility = Visibility.Public;
                                        }
                                        else
                                        {
                                            element.Visibility = Visibility.Private;
                                        }

                                        XmlNode node = DocsByReflection.XMLFromType(type);
                                        if(node != null)
                                        {
                                            element.Documentation = node.InnerXml.Trim();
                                        }

                                        if (!listElements.ContainsKey(type.Namespace + "." + type.Name))
                                        {
                                            listElements.Add(type.Namespace + "." + type.Name, element);
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

                else
                { 
                     // Error Build
                }
                soln.Close(true);

            }
            catch (SystemException ex)
            {
                //MessageBox.Show("ERROR: " + ex);
            }
            finally
            {
                if (dte != null)
                {
                    dte.Quit();
                }
            }

            Helper.BeginUpdate();
            addMessageBackgroundWorker(0, "Init import...");
            int pos = 0;
            foreach (IUMLElement element in listElements.Values)
            {
                pos++;
                addMessageBackgroundWorker( (pos*100)/listElements.Count,"Creating: \n" + element.Name);
                element.GetType().InvokeMember("Save", BindingFlags.Default | BindingFlags.InvokeMethod, null, element, new object[] { });
                
            }
            addMessageBackgroundWorker(100, "End import");
            Helper.EndUpdate();
        }

        private static UMLEnumerationLiteralCollection GetLiterals(Type type)
        {
            UMLEnumerationLiteralCollection attributes = new UMLEnumerationLiteralCollection();

            foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                if (field.IsLiteral)
                {
                    UMLEnumerationLiteral attribute = new UMLEnumerationLiteral();
                    attribute.Name = field.Name;                    
                    attributes.Add(attribute);
                }
            }
            return attributes;
        }

        private static UMLAttributeCollection GetStaticAndConstants(Type type)
        {
            UMLAttributeCollection attributes = new UMLAttributeCollection();

            foreach (FieldInfo filed in type.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                if (filed.DeclaringType == type && !filed.IsSpecialName)
                {
                    UMLAttribute attribute = new UMLAttribute();
                    attribute.Name = filed.Name;
                    attribute.Type = filed.FieldType.Name;
                    attributes.Add(attribute);
                }
            }
            return attributes;
        }

        private static UMLAttributeCollection GetProperties(Type type)
        {
            UMLAttributeCollection attributes = new UMLAttributeCollection();

            foreach (PropertyInfo property in type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance))
            {
                if (property.DeclaringType == type && !property.IsSpecialName)
                {
                    MethodInfo methodInfo = property.GetGetMethod(true);

                    if (methodInfo != null)
                    {
                        UMLAttribute attribute = new UMLAttribute();
                        attribute.Name = property.Name;
                        attribute.Type = property.PropertyType.Name;
                                                
                        if (methodInfo.IsPublic)
                        {
                            attribute.Visibility = Visibility.Public;
                        }
                        if (methodInfo.IsPrivate)
                        {
                            attribute.Visibility = Visibility.Private;
                        }
                        if (methodInfo.IsFamily)
                        {
                            attribute.Visibility = Visibility.Protected;
                        }
                        attributes.Add(attribute);
                    }

                }
            }
            return attributes;
        }

        private static UMLMethodCollection GetMethods(Type type)
        {
            UMLMethodCollection methods = new UMLMethodCollection();

            foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance))
            {
                if (methodInfo.DeclaringType == type && !methodInfo.IsSpecialName)
                {
                    UMLMethod method = new UMLMethod();
                    method.Name = methodInfo.Name;
                    
                    XmlNode node = DocsByReflection.XMLFromMember(methodInfo);
                    if (node != null)
                    {
                        method.Documentation = node.InnerXml.Trim();
                        //method.Documentation = DocsByReflection.XMLFromMember(methodInfo).ToString();
                    }
                    if (methodInfo.IsPublic)
                    {
                        method.Visibility = Visibility.Public;
                    }
                    if (methodInfo.IsPrivate)
                    {
                        method.Visibility = Visibility.Private;
                    }
                    if (methodInfo.IsFamily)
                    {
                        method.Visibility = Visibility.Protected;
                    }

                    if (methodInfo.IsGenericMethod)
                    {
                        
                    }

                    ParameterInfo returned = methodInfo.ReturnParameter;
                    if (!returned.ParameterType.Name.Equals("Void"))
                    {
                        UMLParameter p = new UMLParameter();
                        p.Name = "return";
                        p.Type = returned.ParameterType.Name;
                        p.Direction = Direction.RETURN;
                        method.Parameters.Add(p);
                    }

                    foreach (ParameterInfo parameter in methodInfo.GetParameters())
                    {
                        UMLParameter p = new UMLParameter();
                        p.Name = parameter.Name;
                        p.Type = parameter.ParameterType.Name;
                        p.Direction = Direction.IN;
                        method.Parameters.Add(p);
                    }
                    methods.Add(method);
                }
            }
            return methods;
        }
    }
}
