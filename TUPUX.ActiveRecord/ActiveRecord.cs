using System;
using System.Data;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using log4net;

namespace TUPUX.ActiveRecord
{
    [Serializable]
    public abstract class ActiveRecord<T> : AbstractRecord<T> where T : AbstractRecord<T>, new()
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ActiveRecord<T>));

        protected ActiveRecord()
        {
            MarkCreated();
        }

        #region Fetchers


        /// <summary>
        /// Returns a record for this keyValue
        /// </summary>
        /// <param name="keyValue">Key Value</param>
        /// <returns></returns>
        public static T FetchByID(Guid keyValue)
        {
            return fetchByID(keyValue);
        }

        /// <summary>
        /// Returns a record for this keyValue
        /// </summary>
        /// <param name="keyValue">Key Value</param>
        /// <returns></returns>
        public static T FetchByID(Guid? keyValue)
        {
            return fetchByID(keyValue);
        }

        /// <summary>
        /// Returns a record for this keyValue
        /// </summary>
        /// <param name="keyValue">Key Value</param>
        /// <returns></returns>
        public static T FetchByID(string keyValue)
        {
            return fetchByID(keyValue);
        }

        /// <summary>
        /// Returns a record for this keyValue
        /// </summary>
        /// <param name="keyValue">Key Value</param>
        /// <returns></returns>
        private static T fetchByID(object keyValue)
        {
            //if (keyValue == null)
            //{
            //    return null;
            //}
            ////makes sure the table schema is loaded
            //T item = new T();

            ////build the query
            //Query q = new Query(BaseSchema);
            //q.AddWhere(BaseSchema.PrimaryKey.ColumnName, Comparison.Equals, keyValue);

            ////load the reader
            //IDataReader rdr = DataService.GetReader(q.BuildSelectCommand());
            //if (rdr.Read())
            //{
            //    item.Load(rdr);
            //}
            //rdr.Close();
            //if (!item._isNew && item.IsLoaded)
            //{
            //    return item;
            //}
            //return null;
            throw new NotImplementedException();
        }

        #endregion

        #region CommandMethods


        #endregion

        #region Persistence

        /// <summary>
        /// Executes before any operations occur within ActiveRecord Save() 
        /// </summary>
        protected virtual void BeforeValidate() { }

        /// <summary>
        /// Executes on existing records after validation and before the update command has been generated.
        /// </summary>
        protected virtual void BeforeUpdate() { }

        /// <summary>
        /// Executes on existing records after validation and before the insert command has been generated.
        /// </summary>
        protected virtual void BeforeInsert() { }

        /// <summary>
        /// Executes after all steps have been performed for a successful ActiveRecord Save()
        /// </summary>
        protected virtual void AfterCommit() { }

        /// <summary>
        /// Saves this object's state to the selected Database.
        /// </summary>
        public void Save()
        {
            if ((State == RecordState.Created) || (State == RecordState.Modified))
            {
                #region Load Model
                PropertyInfo[] propertyList = typeof(T).GetProperties();

                TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
                StarUML.IUMLModelElement model;

                if (this.State == RecordState.Created)
                {
                    string methodName = "Create" + this.GetUMLClassName().Replace("UML", String.Empty);
                    MethodInfo createMethod = typeof(StarUML.IUMLFactory).GetMethod(methodName);

                    List<object> parameters = new List<object>();
                    ParameterInfo[] parameterList = createMethod.GetParameters();

                    foreach (ParameterInfo parameterInfo in parameterList)
                    {
                        if (parameterInfo.Name.Equals("AOwner") || 
                            parameterInfo.Name.Equals("AClassifier") ||
                            parameterInfo.Name.Equals("ABehavioralFeature") ||
                            parameterInfo.Name.Equals("AEnumeration"))                        
                        {
                            parameters.Add(dataAccess.FindModel(this.Owner.Guid));
                        }                            
                        else
                        {
                            parameters.Add(null);
                        }
                    }

                    model = (StarUML.IUMLModelElement)createMethod.Invoke(dataAccess.Factory, parameters.ToArray());
                }
                else
                {
                    model = dataAccess.FindModel(this.GetKey().ToString());
                }
                #endregion

                #region Update Model Properties
                foreach (PropertyInfo property in propertyList)
                {
                    object[] attributeList = property.GetCustomAttributes(true);

                    foreach (object attribute in attributeList)
                    {
                        if (attribute is UMLPropertyAttribute)
                        {
                            try
                            {
                                UMLPropertyAttribute modelAttribute = (attribute as UMLPropertyAttribute);

                                if (!modelAttribute.IsReadOnly)
                                {
                                    object value = property.GetValue(this, null);
                                    PropertyInfo modelProperty = typeof(StarUML.IUMLModelElement).GetProperty(modelAttribute.PropertyName);

                                    if (modelProperty == null)
                                    {
                                        modelProperty = typeof(StarUML.IUMLGeneralizableElement).GetProperty(modelAttribute.PropertyName);
                                    }

                                    if (value != null)
                                    {
                                        if (modelAttribute.PropertyName.Equals("DirectionKind"))
                                        {
                                            modelProperty = typeof(StarUML.IUMLParameter).GetProperty(modelAttribute.PropertyName);
                                        }

                                        if (modelAttribute.PropertyName.Equals("StereotypeName"))
                                        {
                                            model.SetStereotype(value.ToString());

                                        }
                                        else if (modelAttribute.PropertyName.Equals("TypeExpression"))
                                        {
                                            if (model is StarUML.IUMLParameter)
                                            {
                                                ((StarUML.IUMLParameter)model).SetType2(value.ToString());
                                            }
                                            else if (model is StarUML.IUMLAttribute)
                                            {
                                                ((StarUML.IUMLAttribute)model).SetType2(value.ToString());
                                            }
                                        }                                        
                                        else if (modelProperty != null)
                                        {
                                            modelProperty.SetValue(model, value, null);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                log.Error("", ex);
                            }

                        }

                        if (attribute is UMLTagAttribute)
                        {
                            try
                            {
                                UMLTagAttribute tagAttribute = (UMLTagAttribute)attribute;
                                object value = property.GetValue(this, null);

                                if (value != null)
                                {
                                    if (property.PropertyType == typeof(String))
                                    {
                                        model.SetTaggedValueAsString(tagAttribute.ProfileName, tagAttribute.TagDefinitionSetName, tagAttribute.TagDefinitionName, value.ToString());
                                    }
                                    else if (property.PropertyType == typeof(Double))
                                    {
                                        model.SetTaggedValueAsReal(tagAttribute.ProfileName, tagAttribute.TagDefinitionSetName, tagAttribute.TagDefinitionName, (Double)value);
                                    }
                                    else if (property.PropertyType == typeof(int))
                                    {
                                        model.SetTaggedValueAsInteger(tagAttribute.ProfileName, tagAttribute.TagDefinitionSetName, tagAttribute.TagDefinitionName, (int)value);
                                    }
                                    else if (property.PropertyType == typeof(bool))
                                    {
                                        model.SetTaggedValueAsBoolean(tagAttribute.ProfileName, tagAttribute.TagDefinitionSetName, tagAttribute.TagDefinitionName, (bool)value);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                log.Error("", ex);
                            }

                        }
                    }


                }
                #endregion

                this.Load(model);
                MarkLoaded();
            }
        }

        /// <summary>
        /// Delete itseft
        /// </summary>
        public void Delete()
        {
            if ((State == RecordState.Loaded) || (State == RecordState.Modified))
            {
                TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
                dataAccess.DeleteModel(this.Guid);
            }
            MarkDeleted();
        }

        /// <summary>
        /// If the record contains Deleted or IsDeleted flag columns, sets them to true. If not, invokes Destroy()
        /// </summary>
        public static void Delete(string guid)
        {
            //return DeleteByParameter(BaseSchema.PrimaryKey.ColumnName, keyID, null);
            TUPUX.Access.DataAccess dataAccess = new TUPUX.Access.DataAccess();
            dataAccess.DeleteModel(guid);
        }

        #endregion


    }
}
