using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass("UMLAssociation")]
    public class UMLAssociation : ActiveRecord<UMLAssociation>, UMLRelationship
    {
        //ATTRIBUTES
        #region Attributes
        private UMLAssociationEnd _end1;
        private UMLAssociationEnd _end2;
        private UMLClass _associationClass;
        private string _dependencyType;
        #endregion

        //PROPERTIES
        #region Properties
        public UMLAssociationEnd End1
        {
            get { return this._end1; }
            set { this._end1 = value; }
        }

        public UMLAssociationEnd End2
        {
            get { return this._end2; }
            set { this._end2 = value; }
        }

        public UMLClass AssociationClass
        {
            get { return _associationClass; }
            set { _associationClass = value; }
        }

        [UMLTag(Constants.UMLAssociation.PROFILE, Constants.UMLAssociation.TDS_DEPENDENCY, "Dependency Type")]
        public string DependencyType
        {
            get {
                return _dependencyType;
            }
            set
            {
                _dependencyType = value;
            }
        }
        #endregion
    }
}
