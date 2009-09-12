using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// This is an ActiveRecord class which wraps the Flow.
    /// </summary>
    [Serializable]
    //[UMLClass(Constants.UMLFlow.CLASS,
    //    Constants.UMLFlow.STEREOTYPE_BASIC,
    //    Constants.UMLFlow.STEREOTYPE_ALTERNATIVE,
    //    Constants.UMLFlow.STEREOTYPE_EXCEPTIONAL
    //    )]
    [UMLClass(Constants.UMLFlow.CLASS,
        Constants.UMLFlow.STEREOTYPE
        )]
    [UMLRelation(UMLRelationType.Attribute, typeof(UMLStepFlow))]
    public class UMLFlow : ActiveRecord<UMLFlow>
    {
        public UMLFlow()
        {
            this.Stereotype = Constants.UMLFlow.STEREOTYPE;
        }

        private string _type;
        [UMLTag(Constants.Specification.PROFILE, Constants.Specification.TDS_FLOW, "type")]
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

        #region IUMLFlow Members
        public UMLStepFlowCollection GetStepFlows()
        {
            return this.GetAttributeCollection<UMLStepFlow, UMLStepFlowCollection>();
        }

        #endregion
    }
}
