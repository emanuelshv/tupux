using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass(Constants.UMLEnumeration.CLASS)]
    public class UMLEnumeration : ActiveRecord<UMLEnumeration>
    {
        private UMLEnumerationLiteralCollection _literals;

        public UMLEnumerationLiteralCollection Literals
        {
            get
            {
                if (_literals == null)
                {
                    _literals = new UMLEnumerationLiteralCollection();
                }
                return _literals;
            }
            set
            {
                _literals = value;
            }
        }

        public void Save()
        {
            base.Save();
            foreach (UMLEnumerationLiteral a in Literals)
            {
                a.Owner = this;
                a.Save();
            }
        }
    }
}
