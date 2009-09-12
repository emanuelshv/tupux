using System;
using System.Collections.Generic;
using System.Text;

namespace TUPUX.ActiveRecord
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class UMLClassAttribute : Attribute
    {
        private string _className;

        private string[] _stereotypeNames;

        public string[] StereotypeNames
        {
            get { return _stereotypeNames; }
            set { _stereotypeNames = value; }
        }

        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public UMLClassAttribute(string className)
        {
            this.ClassName = className;
        }

        public UMLClassAttribute(string className, params string[] stereotypeNames)
        {
            this.ClassName = className;
            this.StereotypeNames = stereotypeNames;
        }
    }
}
