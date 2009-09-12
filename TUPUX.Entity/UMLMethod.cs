using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass(Constants.UMLMethod.CLASS)]
    public class UMLMethod : ActiveRecord<UMLMethod>
    {
        UMLParameterCollection _parameters;

        public UMLParameterCollection Parameters
        {
            get 
            {
                if (_parameters == null)
                    _parameters = new UMLParameterCollection();
                return _parameters; 
            }
            set 
            {
                _parameters = value; 
            }
        }
        public void Save()
        {
            base.Save();
            foreach (UMLParameter a in Parameters)
            {
                a.Owner = this;
                a.Save();
            }
        }
    }
}
