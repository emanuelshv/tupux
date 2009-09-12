using System;
using System.Collections.Generic;
using System.Text;

namespace TUPUX.ActiveRecord
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class UMLPropertyAttribute : Attribute
    {
        private string _propertyName;
        private bool _isReadOnly;

        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set { _isReadOnly = value; }
        }

        public string PropertyName
        {
            get { return _propertyName; }
            set { _propertyName = value; }
        }

        public UMLPropertyAttribute(string propertyName)
        {
            this.PropertyName = propertyName;
        }
    }
}
