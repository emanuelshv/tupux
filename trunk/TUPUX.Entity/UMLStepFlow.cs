using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// This is an ActiveRecord class which wraps the StepFlow.
    /// </summary>
    [Serializable]
    [UMLClass(Constants.UMLStepFlow.CLASS, Constants.UMLStepFlow.STEREOTYPE)]
    public class UMLStepFlow :  ActiveRecord<UMLStepFlow>
    {
        public UMLStepFlow()
        {
            this.Stereotype = Constants.UMLStepFlow.STEREOTYPE;
        }

        private string _type;
        [UMLTag(Constants.Specification.PROFILE, Constants.Specification.TDS_STEPFLOW, "type")]
        public string Type
        {
            get { return this._type; }
            set
            {
                if (value != this._type)
                {
                    this._type = value;
                    NotifyPropertyChanged("Type");
                }
            }
        }
    }
}
