using System;
using System.Collections.Generic;
using System.Text;

namespace TUPUX.ActiveRecord
{
    public enum UMLRelationType
    {
        Collaboration,
        Owned,
        Attribute
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple=true)]
    public class UMLRelationAttribute : Attribute
    {
        #region Attributes
        private UMLRelationType _relationType;
        private Type[] _types;

        #endregion

        #region Properties
        public Type[] Types
        {
            get { return _types; }
            set { _types = value; }
        }
        public UMLRelationType RelationType
        {
            get { return _relationType; }
            set { _relationType = value; }
        }

        #endregion

        public UMLRelationAttribute(UMLRelationType relationType, params Type[] types)
        {
            this.RelationType = relationType;
            this.Types = types;
        }
    }
}
