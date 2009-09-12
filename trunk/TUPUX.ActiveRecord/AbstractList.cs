using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using log4net;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Xsl;
using System.Xml;

namespace TUPUX.ActiveRecord
{
    [Serializable]
    class ListComparer<ItemType> : Comparer<ItemType>
        where ItemType : AbstractRecord<ItemType>, new()
    {
        private string columnName;

        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }
        private bool ascending;

        public bool Ascending
        {
            get { return ascending; }
            set { ascending = value; }
        }

        private DbType dbType = DbType.String;

        public DbType DBType
        {
            get { return dbType; }
            set { dbType = value; }
        }

        private static readonly ILog log = LogManager.GetLogger(typeof(ListComparer<ItemType>));

        public override int Compare(ItemType x, ItemType y)
        {

            //object xVal = x.GetColumnValue<object>(columnName);
            //object yVal = y.GetColumnValue<object>(columnName);
            //int result;

            //if (dbType == DbType.String || dbType == DbType.Guid)
            //{
            //    string sX = xVal.ToString();
            //    string sY = yVal.ToString();
            //    result = sX.CompareTo(sY);
            //}
            //else if (dbType == DbType.DateTime)
            //{
            //    DateTime dX = Convert.ToDateTime(xVal);
            //    DateTime dY = Convert.ToDateTime(yVal);
            //    result = dX.CompareTo(dY);
            //}
            //else if (dbType == DbType.Boolean)
            //{
            //    bool bX = Convert.ToBoolean(xVal);
            //    bool bY = Convert.ToBoolean(yVal);
            //    result = bX.CompareTo(bY);
            //}
            //else
            //{
            //    double dX = Convert.ToDouble(xVal);
            //    double dY = Convert.ToDouble(yVal);
            //    result = dX.CompareTo(dY);
            //}

            //if (!ascending)
            //{
            //    result *= -1;
            //}
            //return result;
            throw new NotImplementedException();
        }
    }

    [Serializable]
    public abstract class AbstractList<ItemType, ListType> : List<ItemType>, ITypedList
        where ItemType : AbstractRecord<ItemType>, new()
        where ListType : AbstractList<ItemType, ListType>, new()
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ListComparer<ItemType>));

        public void Sort(string columnName, bool ascending)
        {
            //if(!String.IsNullOrEmpty(columnName))
            //{
            //    ListComparer<ItemType> compare = new ListComparer<ItemType>();
            //    ItemType item = new ItemType();
            //    DbType dbType = item.GetDBType(columnName);
            //    compare.Ascending = ascending;
            //    compare.ColumnName = columnName;
            //    compare.DBType = dbType;

            //    Sort(compare);
            //}
            throw new NotImplementedException();
        }

        public virtual void Load(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                ItemType item = new ItemType();
                item.Load(row);
                this.Add(item);
            }
        }

        public virtual void SaveToExcel(string outPath)
        {
            XmlSerializer xml = new XmlSerializer(this.GetType());
            //string outPath = @"D:\";
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");
            Stream stream = File.Open(outPath + "Collection.xml", FileMode.Create, FileAccess.Write);

            xml.Serialize(stream, this, namespaces);
            stream.Close();

            //XslTransform transformer = new XslTransform();
            XslCompiledTransform transformer = new XslCompiledTransform();
            
            transformer.Load(@"D:\Excel.xslt");

            transformer.Transform(outPath + "Collection.xml", outPath + "Collection_output.xls");
        }

        #region WHERE and ORDER BY

        public ListType Load()
        {
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
            StarUML.IUMLProject prj = dataAccess.GetCurrentProject();

            if (prj != null)
            {
                try
                {
                    List<StarUML.IUMLModelElement> listPkg = dataAccess.GetModelElements(prj);

                    List<StarUML.IUMLModelElement> list = dataAccess.GetModelElements((StarUML.IUMLClassifier)listPkg[0]);

                    foreach (StarUML.IUMLModelElement itemList in list)
                    {
                        ItemType item = new ItemType();
                        item.Load(itemList);
                        this.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    log.Error("", ex);
                }
            }
            return this as ListType;
        }

        //public ListType LoadProject()
        //{
        //    TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
        //    StarUML.IUMLProject prj = dataAccess.GetCurrentProject();

        //    ItemType item = new ItemType();
        //    item.Load(prj);
        //    this.Add(item);

        //    return this as ListType;
        //}

        #endregion

        #region ITypedList Members

        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return String.Empty;
        }

        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            try
            {
                if ((listAccessors == null) || listAccessors.Length == 0)
                {
                    return GetPropertyDescriptors(typeof(ItemType));
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return null;
        }

        #endregion

        private static PropertyDescriptorCollection GetPropertyDescriptors(Type typeOfObject)
        {
            PropertyDescriptorCollection typePropertiesCollection = TypeDescriptor.GetProperties(typeOfObject);
            ArrayList propertyDescriptorsToUse = new ArrayList();
            try
            {
                foreach (PropertyDescriptor property in typePropertiesCollection)
                {
                    HiddenForDataBindingAttribute hiddenAttribute = (HiddenForDataBindingAttribute)property.Attributes[typeof(HiddenForDataBindingAttribute)];

                    if (hiddenAttribute != null && hiddenAttribute.IsHidden)
                    {
                        continue;
                    }
                    propertyDescriptorsToUse.Add(property);
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return new PropertyDescriptorCollection((PropertyDescriptor[])propertyDescriptorsToUse.ToArray(typeof(PropertyDescriptor)));
        }
    }
}
