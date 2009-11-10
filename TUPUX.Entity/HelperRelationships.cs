using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    public class HelperRelationships
    {
        public static IDictionary GetRelationships(UMLClassCollection classes)
        {
            IDictionary relationships = new Hashtable();

            foreach (UMLClass var in classes)
            {
                UMLAssociationCollection associationCollection = var.GetAssociations();

                foreach (UMLAssociation association in associationCollection)
                {
                    if (!(relationships.Contains(association.Guid)))
                    {
                        UMLAssociationEndCollection associationEndCollection = Helper.GetAssociationEndCollection<UMLAssociationEnd, UMLAssociationEndCollection>(association.Guid);
                        association.End1 = associationEndCollection[0];
                        association.End2 = associationEndCollection[1];
                        association.End1.Participant = Helper.GetAssociationEndParticipant<UMLClass>(associationEndCollection[0].Guid);
                        association.End2.Participant = Helper.GetAssociationEndParticipant<UMLClass>(associationEndCollection[1].Guid);
                        association.AssociationClass = Helper.GetAssociationClass<UMLClass>(association.Guid);
                        relationships.Add(association.Guid, association);
                    }
                }

                UMLGeneralizationCollection generalizationCollection = var.GetGeneralizations();

                foreach (UMLGeneralization generalization in generalizationCollection)
                {
                    generalization.Child = Helper.GetGeneralizationChild<UMLClass>(generalization.Guid);
                    generalization.Parent = Helper.GetGeneralizationParent<UMLClass>(generalization.Guid);
                    relationships.Add(generalization.Guid, generalization);
                }

                UMLRealizationCollection realizationCollection = var.GetRealizations();

                foreach (UMLRealization realization in realizationCollection)
                {
                    realization.Client = Helper.GetDependencyClient<UMLClass>(realization.Guid);
                    realization.Supplier = Helper.GetDependencySupplier<UMLClass>(realization.Guid);
                    relationships.Add(realization.Guid, realization);
                }

                UMLDependencyCollection dependencyCollection = var.GetDependencies();

                foreach (UMLDependency dependency in dependencyCollection)
                {
                    dependency.Client = Helper.GetDependencyClient<UMLClass>(dependency.Guid);
                    dependency.Supplier = Helper.GetDependencySupplier<UMLClass>(dependency.Guid);
                    relationships.Add(dependency.Guid, dependency);
                }

                
            }

            return relationships;
        }
    }
}
