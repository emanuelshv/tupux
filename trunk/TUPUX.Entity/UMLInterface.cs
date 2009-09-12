using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass(Constants.UMLInterface.CLASS)]
    public class UMLInterface : ActiveRecord<UMLInterface>
    {
        private UMLAttributeCollection _attributes;

        public UMLAttributeCollection Attributes
        {
            get
            {
                if (_attributes == null)
                {
                    _attributes = new UMLAttributeCollection();
                }
                return _attributes;
            }
            set
            {
                _attributes = value;
            }
        }

        public void Save()
        {
            base.Save();
            foreach (UMLAttribute a in Attributes)
            {
                a.Owner = this;
                a.Save();
            }
        }
    }
}
