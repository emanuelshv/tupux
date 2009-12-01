using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TUPUX.Entity;

namespace TUPUX.Estimation.Action
{
    public class ActionKey
    {
        //CONSTANTS
        #region Constants
        //ACTION-NAMESPACE
        public const String ACTIONNAMESPACE = "TUPUX.Estimation.Action.Gallery.";
        //ENTRY-TYPE
        public abstract class EntryType
        {
            public const String ASSOCIATION = "1";
            public const String GENERALIZATION = "2";
            public const String REALIZATION = "3";
            public const String ASSOCIATIONCLASS = "4";
        }
        //END TYPES
        public abstract class EndType
        {
            public const string NONE = "0";
            public const string AGGREGATION = "1";
            public const string COMPOSITION = "2";
            public const string GENERALIZATION = "3";
            public const string REALIZATION = "4";
        }
        //MULTIPLICITIES
        public abstract class MultiplicityType
        {
            public const string ZEROTOONE = "0";
            public const string ONE = "1";
            public const string ZEROTOMANY = "2";
            public const string ONETOMANY = "3";
            public const string MANY = "4";
        }
        //DEPENDENCIES
        public abstract class DependencyType
        {
            public const string DEPENDENT = "D";
            public const string INDEPENDENT = "I";
        }
        #endregion

        //ATTRIBUTES
        #region Attributes
        private String _key;
        private String _actionType;
        #endregion

        //CONSTRUCTORS
        #region Constructors
        public ActionKey(String processedEntry)
        {
            this._actionType = processedEntry[0].ToString();
            this._key = processedEntry.Substring(1, processedEntry.Length - 1);
        }

        public ActionKey(UMLRelationship r)
        {
            ProcessRelationship(r);
        }
        #endregion

        //PROPERTIES
        #region Properties
        public String Key
        {
            get { return this._key; }
        }

        public ActionKey AlternateKey
        {
            get
            {
                char[] array;
                char temp;

                array = this._key.ToCharArray();

                if (this._actionType != ActionKey.EntryType.ASSOCIATIONCLASS)
                {
                    temp = array[0];
                    array[0] = array[1];
                    array[1] = temp;
                }

                if (this._actionType == ActionKey.EntryType.ASSOCIATION)
                {
                    temp = array[2];
                    array[2] = array[3];
                    array[3] = temp;
                }

                return new ActionKey(this._actionType + new String(array));
            }
        }

        public String ActionType
        {
            get { return this._actionType; }
        }
        #endregion

        //METHODS
        #region Methods
        private void ProcessRelationship(UMLRelationship r)
        {
            string end1type;
            string end2type;
            string end1mult;
            string end2mult;
            string dependency;

            //For all relationship types
            if (r is UMLAssociation)
            {
                this._actionType = ActionKey.EntryType.ASSOCIATION;
            }
            else if (r is UMLGeneralization)
            {
                this._actionType = ActionKey.EntryType.GENERALIZATION;
            }
            else if (r is UMLRealization)
            {
                this._actionType = ActionKey.EntryType.REALIZATION;
            }
            else
            {
                throw new ArgumentException("");
            }
            //Associations to AssociationClasses are not treated independently in StarUML and hence are
            //not considered here

            //Associations
            if (r is UMLAssociation)
            {
                switch (((UMLAssociation)r).End1.AggregationKind)
                {
                    case AggregationKind.AGGREGATE: end1type = EndType.AGGREGATION; break;
                    case AggregationKind.COMPOSITE: end1type = EndType.COMPOSITION; break;
                    case AggregationKind.NONE: end1type = EndType.NONE; break;
                    default: end1type = EndType.NONE; break;
                }

                switch (((UMLAssociation)r).End2.AggregationKind)
                {
                    case AggregationKind.AGGREGATE: end2type = EndType.AGGREGATION; break;
                    case AggregationKind.COMPOSITE: end2type = EndType.COMPOSITION; break;
                    case AggregationKind.NONE: end2type = EndType.NONE; break;
                    default: end2type = EndType.NONE; break;
                }

                switch (((UMLAssociation)r).End1.MultiplicityKind)
                {
                    case MultiplicityKind.MANY: end1mult = MultiplicityType.MANY; break;
                    case MultiplicityKind.ONE: end1mult = MultiplicityType.ONE; break;
                    case MultiplicityKind.ONETOMANY: end1mult = MultiplicityType.ONETOMANY; break;
                    case MultiplicityKind.ZEROTOMANY: end1mult = MultiplicityType.ZEROTOMANY; break;
                    case MultiplicityKind.ZEROTOONE: end1mult = MultiplicityType.ZEROTOONE; break;
                    default: end1mult = MultiplicityType.MANY; break;
                }

                switch (((UMLAssociation)r).End2.MultiplicityKind)
                {
                    case MultiplicityKind.MANY: end2mult = MultiplicityType.MANY; break;
                    case MultiplicityKind.ONE: end2mult = MultiplicityType.ONE; break;
                    case MultiplicityKind.ONETOMANY: end2mult = MultiplicityType.ONETOMANY; break;
                    case MultiplicityKind.ZEROTOMANY: end2mult = MultiplicityType.ZEROTOMANY; break;
                    case MultiplicityKind.ZEROTOONE: end2mult = MultiplicityType.ZEROTOONE; break;
                    default: end2mult = MultiplicityType.MANY; break;
                }

                if (end1type.Equals(EndType.COMPOSITION) ||
                    end2type.Equals(EndType.COMPOSITION))                
                {
                    dependency = "D";
                }
                else
                {
                    if (((UMLAssociation)r).DependencyType.Equals("D"))
                    {
                        dependency = "D";
                    }
                    else
                    {
                        dependency = "I";
                    }
                }
                
                //if (((UMLAssociation)r).Stereotype != null)
                //{
                //    if (((UMLAssociation)r).Stereotype.Equals("D"))
                //    {
                //        dependency = "D";
                //    }
                //    else if (((UMLAssociation)r).Stereotype.Equals("I"))
                //    {
                //        dependency = "I";
                //    }
                //    else
                //    {
                //        throw new ArgumentException("Only dependent and independent dependency-types are allowed.");
                //    }
                //}
                //else
                //{
                //    dependency = "D";
                //}

                //FIN_HARDCODE
                this._key = end1type + end2type + end1mult + end2mult + dependency;
            }

            //Generalizations
            if (r is UMLGeneralization)
            {
                end1type = EndType.GENERALIZATION;
                end2type = EndType.NONE;

                this._key = end1type.ToString() + end2type.ToString();
            }

            //Realizations
            if (r is UMLRealization)
            {
                end1type = EndType.REALIZATION;
                end2type = EndType.NONE;

                this._key = end1type.ToString() + end2type.ToString();
            }
        }
        #endregion
    }
}
