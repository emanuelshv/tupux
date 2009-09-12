using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using TUPUX.ActiveRecord;
using System.Runtime.Serialization.Formatters.Binary;
using TUPUX.Entity.Constants;
using System.Xml.Serialization;
using System.Xml.Xsl;
using System.Xml;
using log4net;
using System.Reflection;

namespace TUPUX.Entity
{

    #region Helper Estimation

    #region XML Dictionary

    /// <summary>
    /// Serializable dictionary 
    /// </summary>
    /// <typeparam name="TKey">Type for Dictionary Key</typeparam>
    /// <typeparam name="TValue">Type for Dictionary Value</typeparam>
    [XmlRoot("Dictionary")]
    public class SerializableDictionary<TKey, TValue>

        : Dictionary<TKey, TValue>, IXmlSerializable
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(SerializableDictionary<TKey, TValue>));

        #region IXmlSerializable Members

        public System.Xml.Schema.XmlSchema GetSchema()
        {

            return null;

        }


        /// <summary>
        /// Load elements using a Xmlreader
        /// </summary>
        /// <param name="reader">Reader</param>
        public void ReadXml(System.Xml.XmlReader reader)
        {
            XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();

            if (wasEmpty)
                return;

            while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
            {
                try
                {
                    reader.ReadStartElement("item");
                    reader.ReadStartElement("key");

                    TKey key = (TKey)keySerializer.Deserialize(reader);
                    reader.ReadEndElement();
                    reader.ReadStartElement("value");

                    TValue value = (TValue)valueSerializer.Deserialize(reader);
                    reader.ReadEndElement();

                    this.Add(key, value);

                    reader.ReadEndElement();
                    reader.MoveToContent();
                }
                catch (Exception ex)
                {
                    log.Error("", ex);
                }
            }

            reader.ReadEndElement();
        }


        /// <summary>
        /// Save elements using a XMLWriter
        /// </summary>
        /// <param name="writer">Writer</param>
        public void WriteXml(System.Xml.XmlWriter writer)
        {

            XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

            foreach (TKey key in this.Keys)
            {
                try
                {
                    writer.WriteStartElement("item");
                    writer.WriteStartElement("key");
                    keySerializer.Serialize(writer, key);
                    writer.WriteEndElement();
                    writer.WriteStartElement("value");

                    TValue value = this[key];
                    valueSerializer.Serialize(writer, value);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                catch (Exception ex)
                {
                    log.Error("", ex);
                }
            }

        }

        #endregion

    }

    #endregion

    #region Estimation Constants

    /// <summary>
    /// Contains constants for action type
    /// the types are:
    ///     EI: External Input
    ///     EO: External Output
    ///     EQ: External InQuiry
    /// </summary>
    public class UMLActionType
    {
        public const string EI = "EI";
        public const string EO = "EO";
        public const string EQ = "EQ";
    }

    /// <summary>
    /// Contains constants for rating
    /// </summary>
    public class UMLRating
    {
        public const string Low = "Low";
        public const string Avarage = "Avarage";
        public const string High = "High";
    }

    /// <summary>
    /// Contians constants for file type
    /// ILF: Internal Logical File
    /// EIF: External Input File
    /// </summary>
    public class UMLFileType
    {

        public const string ILF = "ILF";
        public const string EIF = "EIF";
    }

    #endregion

    /// <summary>
    /// It contains methods for calculating points function and management of factors 
    /// </summary>
    public static class HelperEstimation
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(HelperEstimation));

        #region Action

        /// <summary>
        /// Calculates the function points for the transactions
        /// </summary>
        /// <param name="type">Transaction type</param>
        /// <param name="dets">Number of Dets</param>
        /// <param name="ftrs">Number of files associated</param>
        /// <returns>Transaction value</returns>
        public static double CalculateActionFunctionPoints(string type, int dets, int ftrs)
        {
            string rating = "";
            rating = GetActionRating(type, dets, ftrs);
            return GetActionValueTransaction(type, rating);
        }

        /// <summary>
        /// Get rating for the transaction
        /// </summary>
        /// <param name="type">Transaction type</param>
        /// <param name="dets">Number of Dets</param>
        /// <param name="ftrs">Number of files associated</param>
        /// <returns>Transaction rating</returns>
        private static string GetActionRating(string type, int dets, int ftrs)
        {
            switch (type)
            {
                case UMLActionType.EI:
                    {
                        if (ftrs == 0 || ftrs == 1)
                        {
                            if (dets > 0 && dets <= 4)
                                return UMLRating.Low;
                            if (dets > 4 && dets <= 15)
                                return UMLRating.Low;
                            if (dets > 15)
                                return UMLRating.Avarage;
                        }
                        if (ftrs == 2)
                        {
                            if (dets > 0 && dets <= 4)
                                return UMLRating.Low;
                            if (dets > 4 && dets <= 15)
                                return UMLRating.Avarage;
                            if (dets > 15)
                                return UMLRating.High;
                        }
                        if (ftrs > 2)
                        {
                            if (dets > 0 && dets <= 4)
                                return UMLRating.Avarage;
                            else if (dets > 4 && dets <= 15)
                                return UMLRating.High;
                            else if (dets > 15)
                                return UMLRating.High;
                        }

                    }
                    break;
                case UMLActionType.EO:
                case UMLActionType.EQ:
                    {
                        if (ftrs == 0 || ftrs == 1)
                        {
                            if (dets > 0 && dets <= 5)
                                return UMLRating.Low;
                            if (dets > 5 && dets <= 19)
                                return UMLRating.Low;
                            if (dets > 19)
                                return UMLRating.Avarage;
                        }
                        if (ftrs == 2)
                        {
                            if (dets > 0 && dets <= 5)
                                return UMLRating.Low;
                            if (dets > 5 && dets <= 19)
                                return UMLRating.Avarage;
                            if (dets > 19)
                                return UMLRating.High;
                        }
                        if (ftrs > 2)
                        {
                            if (dets > 0 && dets <= 5)
                                return UMLRating.Avarage;
                            else if (dets > 5 && dets <= 19)
                                return UMLRating.High;
                            else if (dets > 19)
                                return UMLRating.High;
                        }


                    }
                    break;
            }
            return "";
        }

        /// <summary>
        /// Get value for the transaction 
        /// </summary>
        /// <param name="actiontype">Transaction type</param>
        /// <param name="rating">Rating</param>
        /// <returns>Transaction value</returns>
        private static double GetActionValueTransaction(string actiontype, string rating)
        {
            switch (actiontype)
            {
                case UMLActionType.EO:
                    switch (rating)
                    {
                        case UMLRating.Low: return 4;
                        case UMLRating.Avarage: return 5;
                        case UMLRating.High: return 7;
                    }
                    break;
                case UMLActionType.EI:
                case UMLActionType.EQ:
                    switch (rating)
                    {
                        case UMLRating.Low: return 3;
                        case UMLRating.Avarage: return 4;
                        case UMLRating.High: return 6;
                    }
                    break;
            }

            return 0;
        }

        #endregion

        #region File

        /// <summary>
        /// Calculates the function points for the file
        /// </summary>
        /// <param name="filetype">File type</param>
        /// <param name="dets">Number of Dets</param>
        /// <param name="rets">Number of Rets</param>
        /// <returns>File value</returns>
        public static double CalculateFileFunctionPoints(string filetype, int dets, int rets)
        {
            string rating = GetFileRating(dets, rets);
            return GetFileValue(filetype, rating);
        }

        /// <summary>
        /// Get Rating for the file
        /// </summary>
        /// <param name="dets">Number of Dets</param>
        /// <param name="rets">Number of Rets</param>
        /// <returns>File rating</returns>
        private static string GetFileRating(int dets, int rets)
        {
            if (rets == 1)
            {
                if (dets > 0 && dets < 20)
                {
                    return UMLRating.Low;
                }
                if (dets >= 20 && dets <= 50)
                {
                    return UMLRating.Low;
                }
                if (dets > 50)
                {
                    return UMLRating.Avarage;
                }
            }
            else if (rets >= 2 && rets <= 5)
            {
                if (dets > 0 && dets < 20)
                {
                    return UMLRating.Low;
                }
                if (dets >= 20 && dets <= 50)
                {
                    return UMLRating.Avarage;
                }
                if (dets > 50)
                {
                    return UMLRating.High;
                }
            }
            else if (rets > 5)
            {
                if (dets > 0 && dets < 20)
                {
                    return UMLRating.Avarage;
                }
                if (dets >= 20 && dets <= 50)
                {
                    return UMLRating.High;
                }
                if (dets > 50)
                {
                    return UMLRating.High;
                }
            }

            return "";
        }

        /// <summary>
        /// Get value for the file
        /// </summary>
        /// <param name="fileType">File type</param>
        /// <param name="rating">File rating</param>
        /// <returns>File value</returns>
        private static double GetFileValue(string fileType, string rating)
        {
            if (fileType == UMLFileType.ILF)
            {
                switch (rating)
                {
                    case UMLRating.Low: return 7;
                    case UMLRating.Avarage: return 10;
                    case UMLRating.High: return 15;
                    default: return 0;
                }
            }
            else if (fileType == UMLFileType.EIF)
            {
                switch (rating)
                {
                    case UMLRating.Low: return 5;
                    case UMLRating.Avarage: return 7;
                    case UMLRating.High: return 10;
                    default: return 0;
                }
            }

            return 0;

        }

        #endregion

        #region Factors Write Profile

        #region Factors Serialize and Deserialize

        #region Binary

        /// <summary>
        /// Saves the object(list) in a binary file
        /// </summary>
        /// <typeparam name="ListType">List type</typeparam>
        /// <param name="filename">File name</param>
        /// <param name="item">List</param>
        public static void BinarySerialize<ListType>(string filename, ListType item)
        {

            FileStream fileStreamObject;
            fileStreamObject = new FileStream(filename, FileMode.Create);

            try
            {

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStreamObject, item);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            finally
            {

                fileStreamObject.Close();

            }

        }

        /// <summary>
        /// Gets a object using a binary file
        /// </summary>
        /// <typeparam name="ListType">List type</typeparam>
        /// <param name="filename">File name</param>
        /// <returns>Object(List)</returns>
        public static ListType BinaryDeserialize<ListType>(string filename)
        {

            FileStream fileStreamObject;

            ListType result = default(ListType);
            fileStreamObject = new FileStream(filename, FileMode.Open);

            try
            {

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                result = (ListType)(binaryFormatter.Deserialize(fileStreamObject));
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            finally
            {

                fileStreamObject.Close();

            }

            return result;
        }

        #endregion

        #region XML

        /// <summary>
        /// Saves the object(list) in a xml file
        /// </summary>
        /// <typeparam name="ListType">List type</typeparam>
        /// <param name="fileName">File name</param>
        /// <param name="item">List</param>
        public static void XMLSerialize<ListType>(string fileName, ListType item)
        {
            // Serialize the cards to a file

            StreamWriter writer = null;
            Stream serializationStream = new MemoryStream();
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(ListType));
                writer = new StreamWriter(fileName);
                ser.Serialize(writer, item);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }

            finally
            {
                if (writer != null) writer.Close();

                writer = null;
            }


        }

        /// <summary>
        /// Gets a object using a Xml file
        /// </summary>
        /// <typeparam name="ListType">List type</typeparam>
        /// <param name="fileName">File name</param>
        /// <returns>Object(List)</returns>
        public static ListType XMLDeserialize<ListType>(string fileName)
        {
            StreamReader reader = null;
            ListType facts = default(ListType);
            try
            {
                // Deserialize

                XmlSerializer ser = new XmlSerializer(typeof(ListType));
                reader = new StreamReader(fileName);
                facts = (ListType)ser.Deserialize(reader);
                if (facts == null)
                {
                    throw new NullReferenceException("Invalid reference");
                }
            } // try
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            finally
            {
                if (reader != null) reader.Close();
                reader = null;
            } // finally

            return facts;
        }

        #endregion

        #endregion

        #region Constants

        // Sections in the profile
        public const string BEGINSECTIONFACTOR = "<!--Begin Edit TagDefinition Factors-->";
        public const string ENDSECTIONFACTOR = "<!--End Edit TagDefinition Factors-->";


        // Paths for the files 
        public const string PATH_PROFILE = @"\profiles\estimation\Estimation.prf";
        public const string PATH_FACTORS = @"\profiles\estimation\factors.xml";

        public const string PATH_PROFILE_DEFAULT = @"\default\Estimation.prf";
        public const string PATH_FACTORS_DEFAULT = @"\default\factores_default.xml";

        public const string PATH_XSL = @"\default\TransformXMLFactors.xslt";
        public const string PATH_OUTTEMP = @"\default\outXML.xml";


        #endregion

        /// <summary>
        /// Saves the factors list in the profile file
        /// </summary>
        /// <typeparam name="ListType">List type</typeparam>
        /// <param name="appPath">Application path</param>
        /// <param name="item">Factors List</param>
        public static void WriteFactorsInProfile<ListType>(ListType item)
        {
            string appPath = TUPUX.Entity.Constants.AppPath.Path;
            HelperEstimation.XMLSerialize<ListType>( appPath + PATH_FACTORS, item);
            string line = String.Empty;
            try
            {
                // Read Profile
                using (StreamReader sr = new StreamReader(appPath + PATH_PROFILE))
                {
                    line = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }

            if (!String.IsNullOrEmpty(line))
            {
                int beginSection = line.IndexOf(BEGINSECTIONFACTOR);
                int endSection = line.IndexOf(ENDSECTIONFACTOR);

                string section = line.Substring(beginSection + BEGINSECTIONFACTOR.Length, endSection - (beginSection + BEGINSECTIONFACTOR.Length));
                XslCompiledTransform xslTransformer = new XslCompiledTransform();

                using (Stream xsltFile = new FileStream(appPath + PATH_XSL, FileMode.Open))
                {
                    using (XmlReader styleSheetReader = XmlReader.Create(xsltFile))
                    {
                        xslTransformer.Load(styleSheetReader);
                        xslTransformer.Transform(appPath + PATH_FACTORS, appPath + PATH_OUTTEMP);
                    }
                }

                using (StreamReader read = new StreamReader(appPath + PATH_OUTTEMP))
                {
                    read.ReadLine();
                    line = line.Replace(section, "\n" + read.ReadToEnd() + "\n");
                }

                using (StreamWriter sw = new StreamWriter(appPath + PATH_PROFILE))
                {
                    sw.Write(line);
                }

                Helper.IncludeProfile(UMLProfile.ESTIMATION);
            }
        }

        /// <summary>
        /// Resets the default profile file
        /// </summary>
        /// <param name="appPath">Application path</param>
        public static void ResetProfile()
        {
            string appPath = TUPUX.Entity.Constants.AppPath.Path;
            using (StreamWriter sw = new StreamWriter(appPath + PATH_PROFILE))
            {
                string line;
                using (StreamReader read = new StreamReader(appPath + PATH_PROFILE_DEFAULT))
                {
                    line = read.ReadToEnd();
                }
                sw.Write(line);
            }

            Helper.IncludeProfile(UMLProfile.ESTIMATION);
        }

        #endregion

    }

    #endregion




}
