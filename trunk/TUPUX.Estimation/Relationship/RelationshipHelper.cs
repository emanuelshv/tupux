using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;

namespace TUPUX.Estimation.Relationship
{
    class RelationshipHelper
    {
        public static void GetClasses(UMLRelationship r, ref UMLClass a, ref UMLClass b, bool isAlternate)
        {
            if (r is UMLAssociation)
            {
                if (isAlternate)
                {
                    a = ((UMLAssociation)r).End2.Participant;
                    b = ((UMLAssociation)r).End1.Participant;
                }
                else
                {
                    a = ((UMLAssociation)r).End1.Participant;
                    b = ((UMLAssociation)r).End2.Participant;
                }
            }
            else if (r is UMLGeneralization)
            {
                a = ((UMLGeneralization)r).Parent;
                b = ((UMLGeneralization)r).Child;
            }
            else if (r is UMLRealization)
            {
                a = ((UMLRealization)r).Supplier;
                b = ((UMLRealization)r).Client;
            }
        }
    }
}
