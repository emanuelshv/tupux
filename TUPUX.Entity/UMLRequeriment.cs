using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// This is an ActiveRecord class which wraps the Requeriment.
    /// </summary>
    [UMLClass(Constants.UMLRequeriment.CLASS,
       Constants.UMLRequeriment.STEREOTYPE
        )]
    public class UMLRequeriment : ActiveRecord<UMLRequeriment>
    {
        public UMLRequeriment()
        {
            this.Stereotype = Constants.UMLRequeriment.STEREOTYPE;
        }

        private string _type;
        [UMLTag(Constants.Specification.PROFILE, Constants.Specification.TDS_USECASE, "type")]
        public string Type
        {
            get { return _type; }
            set
            {
                if (value != this._type)
                {
                    this._type = value;
                    NotifyPropertyChanged("Type");
                }
            }
        }

        private string _dificulty;
        [UMLTag(Constants.Specification.PROFILE, Constants.Specification.TDS_USECASE, "dificulty")]
        public string Dificulty
        {
            get { return _dificulty; }
            set
            {
                if (value != this._dificulty)
                {
                    this._dificulty = value;
                    NotifyPropertyChanged("Dificulty");
                }
            }
        }

        private string _priority;
        [UMLTag(Constants.Specification.PROFILE, Constants.Specification.TDS_USECASE, "priority")]
        public string Priority
        {
            get { return _priority; }
            set
            {
                if (value != this._priority)
                {
                    this._priority = value;
                    NotifyPropertyChanged("Priority");
                }
            }
        }

        private string _description;
        [UMLTag(Constants.Specification.PROFILE, Constants.Specification.TDS_FLOW, "description")]
        public string Description
        {
            get { return _description; }
            set
            {
                if (value != this._description)
                {
                    this._description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }
    }
}
