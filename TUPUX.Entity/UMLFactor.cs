using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;
using System.Xml.Serialization;
using System.Xml;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace TUPUX.Entity
{
    [Serializable]
    public class UMLFactor : ActiveRecord<UMLFactor>
    {
        #region Attributes and Properties

        private string _abbrev;
        
        private string _name;
                
        private bool editable;

        private string _selectedKey = String.Empty;

        private SerializableDictionary<string, double> _values;

        public string Abbrev
        {
            get
            {
                return _abbrev;
            }
            set
            {
                _abbrev = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public bool Editable
        {
            get { return editable; }
            set { editable = value; }
        }

        [XmlIgnore]
        public string SelectedKey
        {
            get
            {
                return _selectedKey;
            }
            set
            {
                _selectedKey = value;
                NotifyPropertyChanged("SelectedKey");
            }
        }

        public SerializableDictionary<string, double> Values
        {
            get
            {
                if (_values == null)
                    _values = new SerializableDictionary<string, double>();
                return _values;
            }
            set { _values = value; }
        }

        [XmlIgnore]
        public BindingList<string> ValuesKey
        {
            get
            {
                BindingList<string> result = new BindingList<string>();
                if (_values != null)
                {
                    foreach (string key in Values.Keys)
                    {
                        result.Add(key);
                    }
                }

                return result;
            }
        }

        public double SelectedValue
        {
            get
            {
                if (!String.IsNullOrEmpty(SelectedKey))
                {
                    return Values[SelectedKey];
                }

                return 1.0;
            }
        }

        public string DefinitionName
        {
            get
            {
                return String.Format("({0}){1}", Abbrev, Name);
            }
        }

        #endregion

        #region Methods

        public void SetSelected(string selectedKey)
        {
            _selectedKey = selectedKey;
        }

        #endregion
    }
}
