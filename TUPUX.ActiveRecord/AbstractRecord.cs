using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Xml.Serialization;
//using SubSonic.Utilities;
using System.Collections.Generic;
using System.Reflection;
using log4net;

namespace TUPUX.ActiveRecord
{
    /// <summary>
    /// Base class for persisting objects. Follows the "Active Record Design Pattern".
    /// You can read more on this pattern at http://en.wikipedia.org/wiki/Active_Record
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public abstract class AbstractRecord<T> : IUMLElement, IEditableObject, INotifyPropertyChanged where T : AbstractRecord<T>, new()
    {
        private IUMLElement _owner;

        [XmlIgnore]
        public IUMLElement Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        private string _guid;
        public string Guid
        {
            get { return _guid; }
        }

        private string _name;

        [UMLProperty("Name")]
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != this._name)
                {
                    this._name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private string _pathName;

        [UMLProperty("Pathname", IsReadOnly = true)]
        public string PathName
        {
            get { return _pathName; }
            set
            {
                if (value != this._pathName)
                {
                    this._pathName = value;
                    NotifyPropertyChanged("PathName");
                }
            }
        }

        private string _stereotype;
        [UMLProperty("StereotypeName")]
        public string Stereotype
        {
            get { return _stereotype; }
            set
            {
                if (value != this._stereotype)
                {
                    this._stereotype = value;
                    NotifyPropertyChanged("StereotypeName");
                }
            }
        }

        private string _documentation;
        [UMLProperty("Documentation")]
        public string Documentation
        {
            get
            {
                return _documentation;
            }
            set
            {
                if (value != this._documentation)
                {
                    this._documentation = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private int _visibility;
        [UMLProperty("Visibility")]
        public int Visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
                _visibility = value;
            }
        }


        private static readonly ILog log = LogManager.GetLogger(typeof(AbstractRecord<T>));

        #region State Properties
        private RecordState _state = RecordState.Created;

        /// <summary>
        /// By Default the value is Created;
        /// </summary>
        //[XmlIgnore]
        //[HiddenForDataBinding(true)]
        public RecordState State
        {
            get { return _state; }
        }

        /// <summary>
        /// Change state to delete
        /// </summary>
        public void MarkDeleted()
        {
            if (this._state == RecordState.Loaded || this._state == RecordState.Modified)
                this._state = RecordState.Deleted;
        }

        /// <summary>
        /// Change state to created
        /// </summary>
        public void MarkCreated()
        {
            this._state = RecordState.Created;
        }

        /// <summary>
        /// Change state to loaded
        /// </summary>
        public void MarkLoaded()
        {
            if (this._state == RecordState.Created || this._state == RecordState.Modified)
                this._state = RecordState.Loaded;
        }

        /// <summary>
        /// Change state to modified
        /// </summary>
        public void MarkModified()
        {
            if (this._state == RecordState.Loaded)
                this._state = RecordState.Modified;
        }
        #endregion

        #region Loaders

        public void LoadCurrent()
        {
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
            StarUML.IUMLModelElement elem = dataAccess.GetCurrentModel();

            if (elem != null && IsKindOf(elem.GetClassName(), elem.StereotypeName, true))
            {
                Load(elem);
            }
        }

        public virtual void Load()
        {
            this.Load(this.GetKey());
        }

        public virtual void Load(object key)
        {
            if (key != null)
            {
                TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

                StarUML.IUMLModelElement model = dataAccess.FindModel(key.ToString());

                this.Load(model);
            }
        }

        public virtual void Load(DataRow row)
        {
            PropertyInfo[] propertyList = typeof(T).GetProperties();

            foreach (PropertyInfo property in propertyList)
            {
                try
                {
                    if (property.CanWrite)
                    {
                        object value = row[property.Name];
                        property.SetValue(this, value, null);
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Load - property", ex);
                }
            }
        }

        /// <summary>
        /// Load this element using a StarUML element
        /// </summary>
        /// <param name="model">StarUML element</param>
        public virtual void Load(StarUML.IUMLModelElement model)
        {
            if (model != null)
            {
                this.LoadKey(model);

                PropertyInfo[] propertyList = typeof(T).GetProperties();

                foreach (PropertyInfo property in propertyList)
                {
                    object[] attributeList = property.GetCustomAttributes(true);

                    foreach (object attributte in attributeList)
                    {
                        if (attributte is UMLPropertyAttribute)
                        {
                            try
                            {
                                object value = model.MOF_GetAttribute((attributte as UMLPropertyAttribute).PropertyName);

                                if (property.PropertyType.Equals(typeof(Boolean)))
                                {
                                    value = Convert.ToBoolean(value);
                                }

                                if (property.Name.Equals("Visibility"))
                                {
                                    value = model.Visibility;
                                }

                                property.SetValue(this, value, null);
                            }
                            catch (Exception ex)
                            {
                                log.Error("Load - attribute", ex);
                            }

                        }

                        if (attributte is UMLTagAttribute)
                        {
                            try
                            {
                                object value = null;

                                UMLTagAttribute tagAttribute = (UMLTagAttribute)attributte;

                                if (property.PropertyType.Equals(typeof(Boolean)))
                                {
                                    value = model.GetTaggedValueAsBoolean(tagAttribute.ProfileName, tagAttribute.TagDefinitionSetName, tagAttribute.TagDefinitionName);
                                }
                                else if (property.PropertyType.Equals(typeof(int)))
                                {
                                    value = model.GetTaggedValueAsInteger(tagAttribute.ProfileName, tagAttribute.TagDefinitionSetName, tagAttribute.TagDefinitionName);
                                }
                                else if (property.PropertyType.Equals(typeof(Double)))
                                {
                                    value = model.GetTaggedValueAsReal(tagAttribute.ProfileName, tagAttribute.TagDefinitionSetName, tagAttribute.TagDefinitionName);
                                }
                                else if (property.PropertyType.Equals(typeof(String)))
                                {
                                    value = model.GetTaggedValueAsString(tagAttribute.ProfileName, tagAttribute.TagDefinitionSetName, tagAttribute.TagDefinitionName);
                                }

                                property.SetValue(this, value, null);
                            }
                            catch (Exception ex)
                            {
                                log.Error("Load Tag", ex);
                            }

                        }
                    }
                }

                this.MarkLoaded();
            }
        }

        /// <summary>
        /// Allocate the key to this element
        /// </summary>
        /// <param name="model">StarUML element</param>
        private void LoadKey(StarUML.IUMLModelElement model)
        {
            this._guid = model.GetGuid();
        }

        #endregion

        #region Utility

        /// <summary>
        /// Copies the current instance to a new instance
        /// </summary>
        /// <returns>New instance of current object</returns>
        public T Clone()
        {

            T thisInstance = new T();

            //foreach (TableSchema.TableColumnSetting setting in columnSettings)
            //{
            //    thisInstance.SetColumnValue(setting.ColumnName, setting.CurrentValue);
            //}

            PropertyInfo[] propertyList = typeof(T).GetProperties();

            foreach (PropertyInfo property in propertyList)
            {
                try
                {
                    if (property.CanWrite)
                    {
                        object value = property.GetValue(this, null);
                        property.SetValue(thisInstance, value, null);
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Load - property", ex);
                }
            }

            return thisInstance;

        }

        #endregion

        /// <summary>
        /// Gets tag value as string associated to this element
        /// </summary>
        /// <param name="profileName">Porifle name</param>
        /// <param name="tagDefinitionSetName">Tag definition set name</param>
        /// <param name="tagDefinitionName">Tag definition name</param>
        /// <returns>Tag value</returns>
        protected string GetTagValueAsString(string profileName, string tagDefinitionSetName, string tagDefinitionName)
        {
            try
            {
                TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
                string pathname = this.GetKey().ToString();
                StarUML.IUMLModelElement model = dataAccess.FindModel(pathname);
                return model.GetTaggedValueAsString(profileName, tagDefinitionSetName, tagDefinitionName);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }

            return String.Empty;
        }

        /// <summary>
        /// Sets tag value as string associated to this element
        /// </summary>
        /// <param name="profileName">Porifle name</param>
        /// <param name="tagDefinitionSetName">Tag definition set name</param>
        /// <param name="tagDefinitionName">Tag definition name</param>        
        /// <param name="value">value</param>        
        protected void SetTagValueAsString(string profileName, string tagDefinitionSetName, string tagDefinitionName, string value)
        {
            try
            {
                TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
                string pathname = this.GetKey().ToString();
                StarUML.IUMLModelElement model = dataAccess.FindModel(pathname);
                model.SetTaggedValueAsString(profileName, tagDefinitionSetName, tagDefinitionName, value);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Clear the elements in the tag collection associated to this element
        /// </summary>
        /// <param name="profileName">Profile name</param>
        /// <param name="tagDefinitionSetName">Tag definition set name</param>
        /// <param name="tagDefinitionName">Tag definition name</param>
        protected void ClearTagCollection(string profileName, string tagDefinitionSetName, string tagDefinitionName)
        {
            try
            {
                TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
                string pathname = this.GetKey().ToString();
                StarUML.IUMLModelElement model = dataAccess.FindModel(pathname);
                if (model.GetTaggedValueAsReferenceCount(profileName, tagDefinitionSetName, tagDefinitionName) > 0)
                {
                    model.SetTaggedValueAsDefault(profileName, tagDefinitionSetName, tagDefinitionName);
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        protected void AddElementToTagCollection(string profileName, string tagDefinitionSetName, string tagDefinitionName, IUMLElement element)
        {
            try
            {
                TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
                string key = this.GetKey().ToString();
                string keyAdd = element.Guid;
                StarUML.IUMLModelElement model = dataAccess.FindModel(key);
                StarUML.IUMLModelElement modelToAdd = dataAccess.FindModel(keyAdd);
                model.AddReferenceToTaggedValue(profileName, tagDefinitionSetName, tagDefinitionName, modelToAdd);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        protected void RemoveElementTagCollection(string profileName, string tagDefinitionSetName, string tagDefinitionName, IUMLElement element)
        {
            try
            {
                TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
                string key = this.GetKey().ToString();
                string keyRemove = element.Guid;
                StarUML.IUMLModelElement model = dataAccess.FindModel(key);
                StarUML.IUMLModelElement modelToRemove = dataAccess.FindModel(keyRemove);
                int position = model.IndexOfReferenceFromTaggedValue(profileName, tagDefinitionSetName, tagDefinitionName, modelToRemove);
                model.DeleteReferenceFromTaggedValue(profileName, tagDefinitionSetName, tagDefinitionName, position);
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
        }

        /// <summary>
        /// Saves elements in the tag collection
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to use with a parameter</typeparam>
        /// <param name="list">Elements to save</param>
        /// <param name="profileName">Profile name</param>
        /// <param name="tagDefinitionSetName">Tag definition set name</param>
        /// <param name="tagDefinitionName">Tag definition name</param>
        protected void SaveTagCollection<ItemType, ListType>(ListType list,
            string profileName, string tagDefinitionSetName, string tagDefinitionName
            )
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            foreach (ItemType item in list)
            {
                string keyReference = item.GetKey().ToString();
                StarUML.IUMLModelElement tagItem = dataAccess.FindModel(keyReference);
                model.AddReferenceToTaggedValue(profileName, tagDefinitionSetName, tagDefinitionName, tagItem);
            }
        }

        /// <summary>
        /// Gets elements in the tag collection encapsulate each element in the collection in a ItemType
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <param name="profileName">Profile name</param>
        /// <param name="tagDefinitionSetName">Tag definition set name</param>
        /// <param name="tagDefinitionName">Tag definition name</param>
        /// <returns>List</returns>
        protected ListType GetTagCollection<ItemType, ListType>(string profileName, string tagDefinitionSetName, string tagDefinitionName)
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                for (int i = 0; i < model.GetTaggedValueAsReferenceCount(profileName, tagDefinitionSetName, tagDefinitionName); i++)
                {
                    ItemType item = new ItemType();
                    StarUML.IUMLModelElement tagItem = (StarUML.IUMLModelElement)model.GetTaggedValueAsReferenceAt(profileName, tagDefinitionSetName, tagDefinitionName, i);

                    if (item.IsKindOf(tagItem.GetClassName(), tagItem.StereotypeName))
                    {
                        item.Load(tagItem);
                        list.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }


        /// <summary>
        /// Gets elements associate to this element, by association type "association"
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <returns></returns>
        protected ListType GetAssociateCollection<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);
            try
            {

                if (model is StarUML.IUMLClassifier)
                {
                    StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                    for (int i = 0; i < classifier.GetAssociationCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLAssociationEnd end = classifier.GetAssociationAt(i);
                        StarUML.IUMLClassifier classfierAssociation = end.GetOtherSide().Participant;

                        if (item.IsKindOf(classfierAssociation.GetClassName(), classfierAssociation.StereotypeName))
                        {
                            item.Load(classfierAssociation);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }

        /// <summary>
        /// Gets owned elements type Collaboration
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <returns></returns>
        protected ListType GetCollaborationCollection<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier)
                {
                    StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                    for (int i = 0; i < classifier.GetOwnedCollaborationCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLCollaboration element = classifier.GetOwnedCollaborationAt(i);

                        if (item.IsKindOf(element.GetClassName(), element.StereotypeName))
                        {
                            item.Load(element);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }

        /// <summary>
        /// Gets elements associated to this element, by association type dependency        
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <returns></returns>
        protected ListType GetSupplierDependencies<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLNamespace)
                {
                    StarUML.IUMLNamespace classifier = (StarUML.IUMLNamespace)model;

                    for (int i = 0; i < classifier.GetClientDependencyCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLDependency dependency = classifier.GetClientDependencyAt(i);

                        if (item.IsKindOf(dependency.Supplier.GetClassName(), dependency.Supplier.StereotypeName))
                        {
                            item.Load(dependency.Supplier);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }


        /// <summary>
        /// Gets elements associated to this element, by association type dependency
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <param name="stereoTypeDependency">Stereotype</param>
        /// <returns></returns>
        protected ListType GetSupplierDependencies<ItemType, ListType>(string stereoTypeDependency)
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLNamespace)
                {
                    StarUML.IUMLNamespace classifier = (StarUML.IUMLNamespace)model;

                    for (int i = 0; i < classifier.GetClientDependencyCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLDependency dependency = classifier.GetClientDependencyAt(i);

                        if (stereoTypeDependency.Equals(dependency.StereotypeName)
                            &&
                            item.IsKindOf(dependency.Supplier.GetClassName(), dependency.Supplier.StereotypeName))
                        {
                            item.Load(dependency.Supplier);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }

        /// <summary>
        /// Gets elements associated to this element, by association type dependency
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <returns></returns>
        protected ListType GetClientDependencies<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLNamespace)
                {

                    StarUML.IUMLNamespace classifier = (StarUML.IUMLNamespace)model;

                    for (int i = 0; i < classifier.GetSupplierDependencyCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLDependency dependency = classifier.GetSupplierDependencyAt(i);

                        if (item.IsKindOf(dependency.Client.GetClassName(), dependency.Client.StereotypeName))
                        {
                            item.Load(dependency.Client);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }


        /// <summary>
        /// Gets elements associated to this element, by association type dependency        
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <param name="stereoTypeDependency">Stereotype</param>
        /// <returns></returns>
        protected ListType GetClientDependencies<ItemType, ListType>(string stereoTypeDependency)
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);


            try
            {
                if (model is StarUML.IUMLNamespace)
                {

                    StarUML.IUMLNamespace classifier = (StarUML.IUMLNamespace)model;

                    for (int i = 0; i < classifier.GetSupplierDependencyCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLDependency dependency = classifier.GetSupplierDependencyAt(i);

                        if (stereoTypeDependency.Equals(dependency.StereotypeName)
                            &&
                            item.IsKindOf(dependency.Client.GetClassName(), dependency.Client.StereotypeName))
                        {
                            item.Load(dependency.Client);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }


        /// <summary>
        /// Gets attributes that has this element
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <returns></returns>
        protected ListType GetAttributeCollection<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier)
                {
                    StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                    for (int i = 0; i < classifier.GetAttributeCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLAttribute element = classifier.GetAttributeAt(i);

                        if (item.IsKindOf(element.GetClassName(), element.StereotypeName))
                        {
                            item.Load(element);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }

        /// <summary>
        /// Gets elements owned by this element
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <returns></returns>
        protected ListType GetOwnedElements<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier)
                {
                    StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                    for (int i = 0; i < classifier.GetOwnedElementCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLModelElement owned = classifier.GetOwnedElementAt(i);

                        if (item.IsKindOf(owned.GetClassName(), owned.StereotypeName))
                        {
                            item.Load(owned);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }

        /// <summary>
        /// Gets elements owned recursively, looking at the packages, subsystems and models
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <param name="key">Key element</param>
        /// <returns></returns>
        protected ListType GetOwnedElementsByKeyRecursive<ItemType, ListType>(string key)
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier)
                {

                    StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                    for (int i = 0; i < classifier.GetOwnedElementCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLModelElement owned = classifier.GetOwnedElementAt(i);

                        if (owned is StarUML.IUMLModel || owned is StarUML.IUMLPackage || owned is StarUML.IUMLSubsystem)
                        {
                            list.AddRange(GetOwnedElementsByKeyRecursive<ItemType, ListType>(owned.GetGuid()));
                        }

                        if (item.IsKindOf(owned.GetClassName(), owned.StereotypeName))
                        {
                            item.Load(owned);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }

        /// <summary>
        /// Gets elements owned using a key to get the owned element
        /// </summary>
        /// <typeparam name="ItemType">Element type used in the list</typeparam>
        /// <typeparam name="ListType">List Type to return</typeparam>
        /// <param name="key">Key element</param>
        /// <returns></returns>
        protected ListType GetOwnedElementsByKey<ItemType, ListType>(string key)
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier)
                {
                    StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                    for (int i = 0; i < classifier.GetOwnedElementCount(); i++)
                    {
                        ItemType item = new ItemType();
                        StarUML.IUMLModelElement owned = classifier.GetOwnedElementAt(i);

                        if (item.IsKindOf(owned.GetClassName(), owned.StereotypeName))
                        {
                            item.Load(owned);
                            list.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }

        /// <summary>
        /// Reviewing whether the class name and the stereotype match with the current element
        /// </summary>
        /// <param name="className">Class name</param>
        /// <param name="stereotype">Stereotype</param>
        /// <returns></returns>
        public bool IsKindOf(string className, string stereotype)
        {
            return this.IsKindOf(className, stereotype, true);
        }

        /// <summary>
        /// Reviewing whether the class name and the stereotype match with the current element.
        /// If strictCompare is false the method ingnore the param Stereotype when the class not define the array of stereotyTUPUX.
        /// </summary>
        /// <param name="className">Class name</param>
        /// <param name="stereotype">Stereotype</param>
        /// <returns></returns>
        public bool IsKindOf(string className, string stereotype, bool strictCompare)
        {
            string itemClassName = this.GetUMLClassName();
            string[] itemStereotypes = this.GetStereotypeNames();

            if (className.Equals(itemClassName))
            {
                if (strictCompare)
                {
                    if (itemStereotypes == null)
                    {
                        if (String.IsNullOrEmpty(stereotype)) return true;
                    }
                    else
                    {
                        foreach (string itemStereotype in itemStereotypes)
                        {
                            if (itemStereotype.Equals(stereotype))
                            {
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    if ((itemStereotypes == null) || (itemStereotypes.Length == 0)) return true;

                    foreach (string itemStereotype in itemStereotypes)
                    {
                        if (itemStereotype.Equals(stereotype))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Get name of StarUML's class declared for this element
        /// </summary>
        /// <returns></returns>
        protected string GetUMLClassName()
        {
            UMLClassAttribute[] attributeList = (UMLClassAttribute[])typeof(T).GetCustomAttributes(typeof(UMLClassAttribute), false);


            foreach (UMLClassAttribute attributte in attributeList)
            {
                return attributte.ClassName;
            }

            return null;
        }
        /// <summary>
        /// Get stereotypes declared for this element
        /// </summary>
        /// <returns></returns>
        private string[] GetStereotypeNames()
        {
            UMLClassAttribute[] attributeList = (UMLClassAttribute[])typeof(T).GetCustomAttributes(typeof(UMLClassAttribute), false);

            foreach (UMLClassAttribute attributte in attributeList)
            {
                return attributte.StereotypeNames;
            }

            return null;
        }


        protected object GetKey()
        {
            if (this.Guid != null)
                return this.Guid;
            return String.Empty;

            //PropertyInfo[] propertyList = typeof(T).GetProperties();

            //foreach (PropertyInfo property in propertyList)
            //{
            //    UMLKeyAttribute[] attributeList = (UMLKeyAttribute[])property.GetCustomAttributes(typeof(UMLKeyAttribute), false);

            //    foreach (UMLKeyAttribute attributte in attributeList)
            //    {
            //        return property.GetValue(this, null);
            //    }
            //}

            //return null;
        }

        protected ListType GetAssociationCollection<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string pathname = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(pathname);

            if (model is StarUML.IUMLClassifier)
            {
                StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                for (int i = 0; i < classifier.GetAssociationCount(); i++)
                {
                    ItemType item = new ItemType();
                    StarUML.IUMLAssociationEnd end = classifier.GetAssociationAt(i);
                    StarUML.IUMLRelationship classfierAssociation = end.Association;

                    if (classfierAssociation != null &&
                        item.IsKindOf(classfierAssociation.GetClassName(), classfierAssociation.StereotypeName))
                    {
                        item.Load(classfierAssociation);
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        protected ListType GetGeneralizationCollection<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string pathname = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(pathname);

            if (model is StarUML.IUMLClassifier)
            {
                StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                for (int i = 0; i < classifier.GetGeneralizationCount(); i++)
                {
                    ItemType item = new ItemType();
                    StarUML.IUMLGeneralization gen = classifier.GetGeneralizationAt(i);

                    if (gen != null &&
                        item.IsKindOf(gen.GetClassName(), gen.StereotypeName))
                    {
                        item.Load(gen);
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        protected ListType GetDependencyCollection<ItemType, ListType>()
            where ItemType : ActiveRecord<ItemType>, new()
            where ListType : ActiveList<ItemType, ListType>, new()
        {
            ListType list = new ListType();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string pathname = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(pathname);

            if (model is StarUML.IUMLClassifier)
            {
                StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                for (int i = 0; i < classifier.GetClientDependencyCount(); i++)
                {
                    ItemType item = new ItemType();
                    StarUML.IUMLDependency dep = classifier.GetClientDependencyAt(i);

                    if (dep != null &&
                        item.IsKindOf(dep.GetClassName(), dep.StereotypeName))
                    {
                        item.Load(dep);
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        #region IUMLElement Members

        private List<IUMLElement> GetOwnedElements(Type[] types)
        {
            List<IUMLElement> list = new List<IUMLElement>();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier)
                {
                    StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                    for (int i = 0; i < classifier.GetOwnedElementCount(); i++)
                    {
                        StarUML.IUMLModelElement owned = classifier.GetOwnedElementAt(i);

                        foreach (Type type in types)
                        {
                            IUMLElement item = (IUMLElement)Activator.CreateInstance(type);

                            if (item.IsKindOf(owned.GetClassName(), owned.StereotypeName))
                            {
                                item.Load(owned);
                                item.Owner = this;
                                list.Add(item);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }


        private List<IUMLElement> GetCollaborationElements(Type[] types)
        {
            List<IUMLElement> list = new List<IUMLElement>();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier)
                {
                    StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                    for (int i = 0; i < classifier.GetOwnedCollaborationCount(); i++)
                    {
                        StarUML.IUMLModelElement owned = classifier.GetOwnedCollaborationAt(i);

                        foreach (Type type in types)
                        {
                            IUMLElement item = (IUMLElement)Activator.CreateInstance(type);
                            if (item.IsKindOf(owned.GetClassName(), owned.StereotypeName))
                            {
                                item.Load(owned);
                                item.Owner = this;
                                list.Add(item);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }


        public List<IUMLElement> GetOwnedElements()
        {
            List<IUMLElement> list = new List<IUMLElement>();

            UMLRelationAttribute[] attributeList = (UMLRelationAttribute[])typeof(T).GetCustomAttributes(typeof(UMLRelationAttribute), false);

            foreach (UMLRelationAttribute attribute in attributeList)
            {
                Type[] types = attribute.Types;

                //foreach (Type type in types)
                //{
                switch (attribute.RelationType)
                {
                    case UMLRelationType.Collaboration:
                        list.AddRange(this.GetCollaborationElements(types));
                        break;
                    case UMLRelationType.Owned:
                        list.AddRange(this.GetOwnedElements(types));
                        break;
                    case UMLRelationType.Attribute:
                        list.AddRange(this.GetAttributeElements(types));
                        break;
                    default:
                        break;
                }
                //}
            }
            return list;
        }

        private List<IUMLElement> GetAttributeElements(Type[] types)
        {
            List<IUMLElement> list = new List<IUMLElement>();

            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();

            string key = this.GetKey().ToString();
            StarUML.IUMLModelElement model = dataAccess.FindModel(key);

            try
            {
                if (model is StarUML.IUMLClassifier)
                {
                    StarUML.IUMLClassifier classifier = (StarUML.IUMLClassifier)model;

                    for (int i = 0; i < classifier.GetAttributeCount(); i++)
                    {
                        StarUML.IUMLModelElement owned = classifier.GetAttributeAt(i);

                        foreach (Type type in types)
                        {
                            IUMLElement item = (IUMLElement)Activator.CreateInstance(type);
                            if (item.IsKindOf(owned.GetClassName(), owned.StereotypeName))
                            {
                                item.Load(owned);
                                item.Owner = this;
                                list.Add(item);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("", ex);
            }
            return list;
        }

        #endregion


        #region IEditableObject Members
        Dictionary<PropertyInfo, object> _oldValues = new Dictionary<PropertyInfo, object>();
        private bool _editing;

        public void BeginEdit()
        {
            if (!_editing)
            {
                PropertyInfo[] properties = typeof(T).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    if (property.CanWrite)
                        _oldValues.Add(property, property.GetValue(this, null));
                }
            }
            _editing = true;
        }

        public void CancelEdit()
        {
            if (_editing)
            {
                foreach (KeyValuePair<PropertyInfo, object> oldValue in _oldValues)
                {
                    oldValue.Key.SetValue(this, oldValue.Value, null);
                }
                _oldValues.Clear();
            }
            _editing = false;
        }

        public void EndEdit()
        {
            if (_editing)
            {
                _oldValues.Clear();
                _editing = false;
            }
        }

        #endregion


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
            this.MarkModified();

        }
        #endregion
    }

    [AttributeUsage(AttributeTargets.Property)]
    sealed class HiddenForDataBindingAttribute : Attribute
    {
        private readonly bool _isHidden;
        public HiddenForDataBindingAttribute()
        {
        }

        public HiddenForDataBindingAttribute(bool isHidden)
        {
            _isHidden = isHidden;
        }

        public bool IsHidden
        {
            get { return _isHidden; }
        }
    }
}
