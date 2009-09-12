using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass(Constants.UMLParameter.CLASS)]
    public class UMLParameter : ActiveRecord<UMLParameter>
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

        private int _direction;
        [UMLProperty("DirectionKind")]
        public int Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
            }
        }
    }
}
