using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass("UMLGeneralization")]
    public class UMLGeneralization : ActiveRecord<UMLGeneralization>, UMLRelationship
    {
        //ATTRIBUTES
        #region Attributes
        private UMLClass _parent;
        private UMLClass _child;

        //PROPERTIES
        #region Properties
        public UMLClass Parent
        {
            get { return this._parent; }
            set { this._parent = value; }
        }
        #endregion

        public UMLClass Child
        {
            get { return _child; }
            set { _child = value; }
        }
        #endregion
    }
}
