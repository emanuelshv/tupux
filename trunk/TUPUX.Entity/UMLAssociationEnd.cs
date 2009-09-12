using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    //ENUMERATIONS
    #region Enumerations
    public enum AggregationKind
    {
        NONE,
        AGGREGATE,
        COMPOSITE
    }

    public enum MultiplicityKind
    {
        ZEROTOONE,
        ONE,
        ZEROTOMANY,
        ONETOMANY,
        MANY
    }
    #endregion

    [Serializable]
    [UMLClass("UMLAssociationEnd")]
    public class UMLAssociationEnd : ActiveRecord<UMLAssociationEnd>
    {


        //ATTRIBUTES
        #region Attributes
        private string _aggregation;
        private string _multiplicity;
        private UMLClass _participant;
        #endregion

        //PROPERTIES
        #region Properties
        [UMLProperty("Aggregation")]
        public string Aggregation
        {
            get { return _aggregation; }
            set { _aggregation = value; }
        }

        public AggregationKind AggregationKind
        {
            get
            {
                switch (this._aggregation)
                {
                    case "akNone": return AggregationKind.NONE; break;
                    case "akAggregate": return AggregationKind.AGGREGATE; break;
                    case "akComposite": return AggregationKind.COMPOSITE; break;
                    default: return AggregationKind.NONE;
                }
            }
        }

        [UMLProperty("Multiplicity")]
        public string Multiplicity
        {
            get { return _multiplicity; }
            set { _multiplicity = value; }
        }

        public MultiplicityKind MultiplicityKind
        {
            get
            {
                switch (this._multiplicity)
                {
                    case "0..1": return MultiplicityKind.ZEROTOONE; break;
                    case "1": return MultiplicityKind.ONE; break;
                    case "0..*": return MultiplicityKind.ZEROTOMANY; break;
                    case "1..*": return MultiplicityKind.ONETOMANY; break;
                    case "*": return MultiplicityKind.MANY; break;
                    default: return MultiplicityKind.MANY;
                }
            }
        }

        public UMLClass Participant
        {
            get { return _participant; }
            set { _participant = value; }
        }
        #endregion
    }
}
