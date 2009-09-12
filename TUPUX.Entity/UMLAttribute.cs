using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass(Constants.UMLAttribute.CLASS)]
    public class UMLAttribute : ActiveRecord<UMLAttribute>
    {

        private string _type;
        [UMLProperty("TypeExpression")]
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                NotifyPropertyChanged("Type");
            }
        }
    }
}
