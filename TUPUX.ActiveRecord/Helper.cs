using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using log4net;

namespace TUPUX.ActiveRecord
{
    /// <summary>
    /// Contains functionality for actions that are not common to all elements
    /// </summary>
    public static class Helper
    {
        private static TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
        private static readonly ILog log = LogManager.GetLogger(typeof(Helper));

        public static void OpenFile(string name)
        {
            dataAccess.OpenProject(name);
        }

        /// <summary>
        /// Include a profile from the StarUML application
        /// </summary>
        /// <param name="name">Profile name</param>
        public static void IncludeProfile(string name)
        {
            try
            {
                dataAccess.IncludeProfile(name);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Get the current project
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetProject<T>()
            where T : ActiveRecord<T>, new()
        {
            T prj = new T();
            prj.Load(dataAccess.GetCurrentProject());

            return prj;
        }
        
        public static T GetCurrentElement<T>()
            where T : ActiveRecord<T>, new()
        {
            T e = new T();
            StarUML.IUMLModelElement elem = dataAccess.GetCurrentModel();

            if (e.IsKindOf(elem.GetClassName(), elem.StereotypeName))
            {
                e.Load(elem);
                return e;
            }

            return null;
        }

        /// <summary>
        /// Gets owner for this element
        /// </summary>
        /// <typeparam name="T">Owner Type</typeparam>
        /// <param name="element">Element</param>
        /// <returns>owner</returns>
        public static T GetOwner<T>(IUMLElement element)
            where T : ActiveRecord<T>, new()
        {
            //string path = element.PathName.Replace(element.Name, "");
            //path = path.Substring(0, path.Length - 2);

            string path = element.PathName.Substring(0, element.PathName.LastIndexOf(element.Name) - 2);
            StarUML.IUMLModelElement elem = dataAccess.FindModelByPathName(path);

            T e = new T();

            if (e.IsKindOf(elem.GetClassName(), elem.StereotypeName))
            {
                e.Load(elem);
                return e;
            }

            return null;
        }


        /// <summary>
        /// Get a default file in the project
        /// </summary>
        /// <typeparam name="T">Element type to return</typeparam>
        /// <param name="key">Element key for the model</param>
        /// <returns></returns>
        public static T GetAuxFile<T>(string key)
            where T : ActiveRecord<T>, new()
        {
            T aux = new T();
            aux.Load(dataAccess.GetAuxFile(key));
            return aux;
        }

        /// <summary>
        /// Create the association between two elements
        /// </summary>
        /// <typeparam name="T">Type for the first element</typeparam>
        /// <typeparam name="T2">Type for second element</typeparam>
        /// <param name="element1">First element</param>
        /// <param name="element2">Second element</param>
        /// <param name="ownerElement">Owner of the association</param>
        public static void CreateAssociation<T, T2>(T element1, T2 element2, IUMLElement ownerElement)
            where T : ActiveRecord<T>, new()
            where T2 : ActiveRecord<T2>, new()
        {
            try
            {
                StarUML.IUMLNamespace owner = dataAccess.FindModel(ownerElement.Guid) as StarUML.IUMLNamespace;
                StarUML.IUMLClassifier elementStarUML1 = dataAccess.FindModel(element1.Guid) as StarUML.IUMLClassifier;
                StarUML.IUMLClassifier elementStarUML2 = dataAccess.FindModel(element2.Guid) as StarUML.IUMLClassifier;

                dataAccess.Factory.CreateAssociation(owner, elementStarUML1, elementStarUML2);
            }
            catch (Exception ex)
            {
                log.Error("CreateAssociation", ex);
            }
        }

        /// <summary>
        /// Create the dependency between two elements
        /// </summary>
        /// <typeparam name="T">Type for the first element</typeparam>
        /// <typeparam name="T2">Type for second element</typeparam>
        /// <param name="client">Client for the dependency</param>
        /// <param name="supplier">Supplier for the dependency</param>
        /// <param name="stereoTypeName">Stereotype</param>
        /// <param name="ownerElement">Owner of the dependency</param>
        public static void CreateDependency<T, T2>(T client, T2 supplier, string stereoTypeName, IUMLElement ownerElement)
            where T : ActiveRecord<T>, new()
            where T2 : ActiveRecord<T2>, new()
        {
            try
            {
                StarUML.IUMLNamespace owner = dataAccess.FindModel(ownerElement.Guid) as StarUML.IUMLNamespace;
                StarUML.IUMLModelElement elementStarUML1 = dataAccess.FindModel(client.Guid) as StarUML.IUMLModelElement;
                StarUML.IUMLModelElement elementStarUML2 = dataAccess.FindModel(supplier.Guid) as StarUML.IUMLModelElement;

                StarUML.IUMLDependency dependency = dataAccess.Factory.CreateDependency(owner, elementStarUML1, elementStarUML2);
                dependency.SetStereotype(stereoTypeName);
            }
            catch (Exception ex)
            {
                log.Error("CreateDependency", ex);
            }
        }

        /// <summary>
        /// Create a diagram using list of the collaborations and files
        /// </summary>
        /// <typeparam name="List">Type for the first list</typeparam>
        /// <typeparam name="T">Type for the first element</typeparam>
        /// <typeparam name="List2">Type for second list</typeparam>
        /// <typeparam name="T2">Type for second element</typeparam>
        /// <param name="owner">Owner of the diagram</param>        
        /// <param name="listCollaboration">Collaboration</param>
        /// <param name="listFile">Files</param>
        /// <param name="fragmentName">File Name (ModelFragment)</param>
        /// <param name="diagramName">Diagram name included in the ModelFragment</param>
        public static void CreateDiagramCollaborationFiles<List, T, List2, T2>(IUMLElement owner, List listCollaboration, List2 listFile, string fragmentName, string diagramName)
            where T : ActiveRecord<T>, new()
            where T2 : ActiveRecord<T2>, new()
            where List : ActiveList<T, List>, new()
            where List2 : ActiveList<T2, List2>, new()
        {
            try
            {
                Dictionary<string, StarUML.IView> diagramElements = new Dictionary<string, StarUML.IView>();

                StarUML.IUMLPackage folder = dataAccess.FindModel(owner.Guid) as StarUML.IUMLPackage;
                StarUML.IDiagram diagram = dataAccess.ImportModelFragment(fragmentName, folder, diagramName);
                if (diagram != null)
                {
                    StarUML.IDiagramView diagramUseView = diagram.DiagramView;

                    foreach (IUMLElement item in listCollaboration)
                    {
                        StarUML.IUMLCollaboration collaboration = dataAccess.FindModel(item.Guid) as StarUML.IUMLCollaboration;
                        if (collaboration != null)
                        {
                            StarUML.IUMLCollaborationView view = dataAccess.Factory.CreateCollaborationView(diagramUseView, collaboration);
                            diagramElements.Add(item.Guid, view);
                            for (int i = 0; i < collaboration.GetClientDependencyCount(); i++)
                            {
                                StarUML.IUMLDependency dep = collaboration.GetClientDependencyAt(i);
                                StarUML.IUMLClass classAux = dep.Supplier as StarUML.IUMLClass;
                                StarUML.IUMLClassView viewClass = null;
                                if (diagramElements.ContainsKey(classAux.GetGuid()))
                                {
                                    viewClass = (StarUML.IUMLClassView)diagramElements[classAux.GetGuid()];
                                }
                                if (viewClass == null)
                                {
                                    viewClass = dataAccess.Factory.CreateClassView(diagramUseView, classAux);
                                    viewClass.SuppressOperations = true;
                                }

                                if (!diagramElements.ContainsKey(classAux.GetGuid()))
                                {
                                    diagramElements.Add(classAux.GetGuid(), viewClass);
                                }

                                dataAccess.Factory.CreateDependencyView(diagramUseView, dep, view, viewClass);
                            }
                        }
                    }

                    foreach (IUMLElement item in listFile)
                    {
                        StarUML.IUMLModelElement file = dataAccess.FindModel(item.Guid) as StarUML.IUMLModelElement;
                        if (!diagramElements.ContainsKey(file.GetGuid()))
                        {
                            StarUML.IUMLClassView viewClass = dataAccess.Factory.CreateClassView(diagramUseView, file as StarUML.IUMLClass);
                            viewClass.SuppressOperations = true;
                        }
                    }
                    diagramUseView.LayoutDiagram();
                }

            }
            catch (Exception ex)
            {
                log.Error("CreateDiagramCollaborationFiles", ex);
            }
        }

        /// <summary>
        /// Create a diagram using list of the phases and iterations
        /// </summary>
        /// <typeparam name="List">Type for the first list</typeparam>
        /// <typeparam name="T">Type for the first element</typeparam>
        /// <typeparam name="List2">Type second list</typeparam>
        /// <typeparam name="T2">Type for second element</typeparam>
        /// <param name="owner">Owner of the diagram</param>
        /// <param name="listPhases">Phases</param>
        /// <param name="listIterations">Iterations</param>
        /// <param name="fragmentName">File Name (ModelFragment)</param>
        /// <param name="diagramName">Diagram name included in the ModelFragment</param>
        public static void CreateDiagramPhaseIteration<List, T, List2, T2>(IUMLElement owner, List listPhases, List2 listIterations, string fragmentName, string diagramName)
            where T : ActiveRecord<T>, new()
            where T2 : ActiveRecord<T2>, new()
            where List : ActiveList<T, List>, new()
            where List2 : ActiveList<T2, List2>, new()
        {
            try
            {
                Dictionary<string, StarUML.IView> diagramElements = new Dictionary<string, StarUML.IView>();


                StarUML.IUMLPackage folder = dataAccess.FindModel(owner.Guid) as StarUML.IUMLPackage;
                StarUML.IDiagram diagram = dataAccess.ImportModelFragment(fragmentName, folder, diagramName);

                if (diagram != null)
                {
                    StarUML.IDiagramView diagramClassView = diagram.DiagramView;

                    foreach (IUMLElement item in listPhases)
                    {
                        StarUML.IUMLPackage phase = dataAccess.FindModel(item.Guid) as StarUML.IUMLPackage;
                        StarUML.IUMLPackageView view = dataAccess.Factory.CreatePackageView(diagramClassView, phase as StarUML.IUMLPackage);
                        view.StereotypeDisplay = StarUML.UMLStereotypeDisplayKind.sdkIcon;

                        diagramElements.Add(item.Guid, view);
                        for (int i = 0; i < phase.GetAssociationCount(); i++)
                        {
                            StarUML.IUMLAssociationEnd end = phase.GetAssociationAt(i);
                            StarUML.IUMLClass iteration = end.GetOtherSide().Participant as StarUML.IUMLClass;
                            StarUML.IUMLClassView viewClass = null;
                            if (diagramElements.ContainsKey(iteration.GetGuid()))
                            {
                                viewClass = (StarUML.IUMLClassView)diagramElements[iteration.GetGuid()];
                            }

                            if (viewClass == null)
                            {
                                viewClass = dataAccess.Factory.CreateClassView(diagramClassView, iteration);
                                viewClass.SuppressOperations = true;
                                viewClass.SuppressAttributes = true;
                                viewClass.StereotypeDisplay = StarUML.UMLStereotypeDisplayKind.sdkIcon;
                            }

                            if (!diagramElements.ContainsKey(iteration.GetGuid()))
                            {
                                diagramElements.Add(iteration.GetGuid(), viewClass);
                            }

                            dataAccess.Factory.CreateAssociationView(diagramClassView, end.Association, view, viewClass);
                        }
                    }
                                        
                    foreach (IUMLElement item in listIterations)
                    {                        
                        StarUML.IUMLModelElement iteration = dataAccess.FindModel(item.Guid) as StarUML.IUMLModelElement;
                                              
                        
                        if (!diagramElements.ContainsKey(iteration.GetGuid()))
                        {
                            StarUML.IUMLClassView viewClass = dataAccess.Factory.CreateClassView(diagramClassView, iteration as StarUML.IUMLClass);
                            viewClass.SuppressOperations = true;
                            viewClass.SuppressAttributes = true;
                            viewClass.StereotypeDisplay = StarUML.UMLStereotypeDisplayKind.sdkIcon;
                        }

                        for (int i = 0; i < iteration.GetClientDependencyCount(); i++)
                        {
                            StarUML.IUMLDependency dep = iteration.GetClientDependencyAt(i);
                            StarUML.IUMLClass classAux = dep.Supplier as StarUML.IUMLClass;
                            StarUML.IUMLClassView viewClass = null;
                            if (diagramElements.ContainsKey(classAux.GetGuid()))
                            {
                                viewClass = (StarUML.IUMLClassView)diagramElements[classAux.GetGuid()];
                            }
                            if (viewClass == null)
                            {
                                viewClass = dataAccess.Factory.CreateClassView(diagramClassView, classAux);
                                viewClass.SuppressOperations = true;
                            }
                            if (!diagramElements.ContainsKey(classAux.GetGuid()))
                            {
                                diagramElements.Add(classAux.GetGuid(), viewClass);
                            }
                            dataAccess.Factory.CreateDependencyView(diagramClassView, dep, diagramElements[iteration.GetGuid()], viewClass);
                        }

                    }
                    diagramClassView.LayoutDiagram();
                }
            }
            catch (Exception ex)
            {
                log.Error("CreateDiagramPhaseIteration", ex);
            }
        }
        
        /// <summary>
        /// Gets next element associated to this element, by association type "dependency"
        /// </summary>
        /// <param name="element">Element</param>
        /// <param name="stereoTypeDependency">Stereotype</param>
        /// <returns>Next element</returns>
        public static T GetNext<T>(IUMLElement element, string stereoTypeDependency)
            where T : ActiveRecord<T>, new()
        {
            T item = new T();
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = element.Guid;
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier && model.GetClientDependencyCount() > 0)
                {
                    for (int i = 0; i < model.GetClientDependencyCount(); i++)
                    {
                        StarUML.IUMLDependency depencency = model.GetClientDependencyAt(i);
                        StarUML.IUMLClassifier prevModel = (StarUML.IUMLClassifier)depencency.Supplier;

                        if (stereoTypeDependency.Equals(depencency.StereotypeName) &&
                            item.IsKindOf(prevModel.GetClassName(), prevModel.StereotypeName))
                        {
                            item.Load(prevModel);
                            return item;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return null;
        }

        /// <summary>
        /// Gets previus element associated to this element, by association type "dependency"
        /// </summary>
        /// <param name="element">Element</param>
        /// <param name="stereoTypeDependency">Stereotype</param>
        /// <returns>Previus element</returns>
        public static T GetPrev<T>(IUMLElement element, string stereoTypeDependency)
            where T : ActiveRecord<T>, new()
        {
            T item = new T();
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = element.Guid;
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier && model.GetSupplierDependencyCount() > 0)
                {
                    for (int i = 0; i < model.GetSupplierDependencyCount(); i++)
                    {
                        StarUML.IUMLDependency depencency = model.GetSupplierDependencyAt(i);
                        StarUML.IUMLClassifier prevModel = (StarUML.IUMLClassifier)depencency.Client;

                        if (stereoTypeDependency.Equals(depencency.StereotypeName) &&
                            item.IsKindOf(prevModel.GetClassName(), prevModel.StereotypeName))
                        {
                            item.Load(prevModel);
                            return item;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return null;
        }

        //RELATIONSHIPS
        public static ListType GetAssociationEndCollection<ItemType, ListType>(string key)
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            if (model is StarUML.IUMLAssociation)
            {
                StarUML.IUMLAssociation classifier = (StarUML.IUMLAssociation)model;

                for (int i = 0; i < classifier.GetConnectionCount(); i++)
                {
                    ItemType item = new ItemType();
                    StarUML.IUMLAssociationEnd end = classifier.GetConnectionAt(i);

                    if (end != null &&
                        item.IsKindOf(end.GetClassName(), end.StereotypeName))
                    {
                        item.Load(end);
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        public static ItemType GetAssociationEndParticipant<ItemType>(string key)
            where ItemType : ActiveRecord<ItemType>, new()
        {
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            if (model is StarUML.IUMLAssociationEnd)
            {
                StarUML.IUMLClassifier classifier = ((StarUML.IUMLAssociationEnd)model).Participant;
                ItemType item = new ItemType();

                if (classifier != null && item.IsKindOf(classifier.GetClassName(), classifier.StereotypeName))
                {
                    item.Load(classifier);
                    return item;
                }
            }
            return null;
        }

        public static ItemType GetAssociationClass<ItemType>(string key)
            where ItemType : ActiveRecord<ItemType>, new()
        {
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            if (model is StarUML.IUMLAssociation)
            {
                StarUML.IUMLAssociationClass associationClass = ((StarUML.IUMLAssociation)model).AssociationClass;
                if (associationClass != null)
                {
                    StarUML.IUMLClass classifier = associationClass.ClassSide;

                    ItemType item = new ItemType();

                    if (classifier != null && item.IsKindOf(classifier.GetClassName(), classifier.StereotypeName))
                    {
                        item.Load(classifier);
                        return item;
                    }
                }
            }
            return null;
        }

        public static ItemType GetGeneralizationParent<ItemType>(string key)
            where ItemType : ActiveRecord<ItemType>, new()
        {
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            if (model is StarUML.IUMLGeneralization)
            {
                StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)((StarUML.IUMLGeneralization)model).Parent;
                ItemType item = new ItemType();

                if (classifier != null && item.IsKindOf(classifier.GetClassName(), classifier.StereotypeName))
                {
                    item.Load(classifier);
                    return item;
                }
            }
            return null;
        }

        public static ItemType GetGeneralizationChild<ItemType>(string key)
            where ItemType : ActiveRecord<ItemType>, new()
        {
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            if (model is StarUML.IUMLGeneralization)
            {
                StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)((StarUML.IUMLGeneralization)model).Child;
                ItemType item = new ItemType();

                if (classifier != null && item.IsKindOf(classifier.GetClassName(), classifier.StereotypeName))
                {
                    item.Load(classifier);
                    return item;
                }
            }
            return null;
        }

        public static ItemType GetDependencyClient<ItemType>(string key)
            where ItemType : ActiveRecord<ItemType>, new()
        {
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            if (model is StarUML.IUMLDependency || model is StarUML.IUMLRealization)
            {
                StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)((StarUML.IUMLDependency)model).Client;
                ItemType item = new ItemType();

                if (classifier != null && item.IsKindOf(classifier.GetClassName(), classifier.StereotypeName))
                {
                    item.Load(classifier);
                    return item;
                }
            }
            return null;
        }

        public static ItemType GetDependencySupplier<ItemType>(string key)
            where ItemType : ActiveRecord<ItemType>, new()
        {
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            if (model is StarUML.IUMLDependency || model is StarUML.IUMLRealization)
            {
                StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)((StarUML.IUMLDependency)model).Supplier;
                ItemType item = new ItemType();

                if (classifier != null && item.IsKindOf(classifier.GetClassName(), classifier.StereotypeName))
                {
                    item.Load(classifier);
                    return item;
                }
            }
            return null;
        }

        public static void BeginUpdate()
        {
            dataAccess.BeginUpdate();
        }

        public static void EndUpdate()
        {
            dataAccess.EndUpdate();
        }

    }
}
