using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass("UMLRealization")]
    public class UMLRealization : ActiveRecord<UMLRealization>, UMLRelationship
    {
        //ATTRIBUTES
        #region Attributes
        private UMLClass _client;
        private UMLClass _supplier;
        #endregion

        //PROPERTIES
        #region Properties
        public UMLClass Client
        {
            get { return _client; }
            set { _client = value; }
        }

        public UMLClass Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
        #endregion
    }
}
