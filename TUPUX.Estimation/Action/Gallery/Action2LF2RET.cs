using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.Estimation.Relationship;
using TUPUX.Estimation.File;
using TUPUX.ActiveRecord;

namespace TUPUX.Estimation.Action.Gallery
{
    /*
     * This action creates two different Files containing the two classes involved in the relationship. If the
     * relationship is an association and it contains an association-class, then it creates a third File 
     * containing the association-class by itself.
     */
    class Action2LF2RET : AbstractAction
    {
        public override void Execute(UMLRelationship r, ActionMap map, List<PreFile> prefiles)
        {
            UMLClass a=null;
            UMLClass b=null;
            int defaultDetsA = 0;
            int defaultDetsB = 0;
            PreFile temp, tempA, tempB;

            RelationshipHelper.GetClasses(r, ref a, ref b, this.IsAlternate, ref defaultDetsA, ref defaultDetsB);

            //1st File
            if ((tempA = PreFileHelper.GetPreFileWithClass(a, prefiles)) == null)
            {
                tempA = new PreFile();
                tempA.Rets.Add(new PreRET());
                tempA.Rets[0].Classes.Add(a);
                prefiles.Add(tempA);
            }
            tempA.DefaultDets += defaultDetsA;

            //2nd File
            if ((tempB = PreFileHelper.GetPreFileWithClass(b, prefiles)) == null)
            {
                tempB = new PreFile();
                tempB.Rets.Add(new PreRET());
                tempB.Rets[0].Classes.Add(b);                
                prefiles.Add(tempB);
            }

            tempB.DefaultDets += defaultDetsB;

            //3rd File (only if there is an Association-Class)
            if (r is UMLAssociation)
            {
                if (((UMLAssociation)r).AssociationClass != null)
                {
                    UMLClass dependencyClass = null;
                    UMLClass associationClass = ((UMLAssociation)r).AssociationClass;
                    UMLDependencyCollection dependencies = associationClass.GetDependencies();
                    
                    foreach (UMLDependency d in dependencies)
                    {
                        d.Client = Helper.GetDependencyClient<UMLClass>(d.Guid);
                        d.Supplier = Helper.GetDependencySupplier<UMLClass>(d.Guid);

                        if ((d.Client.Guid == associationClass.Guid && d.Supplier.Guid == a.Guid) ||
                            (d.Supplier.Guid == associationClass.Guid && d.Client.Guid == a.Guid))
                            dependencyClass = a;
                        else if ((d.Client.Guid == associationClass.Guid && d.Supplier.Guid == b.Guid) ||
                            (d.Supplier.Guid == associationClass.Guid && d.Client.Guid == b.Guid))
                            dependencyClass = b;
                    }
                    if (dependencyClass == null)
                    {
                        //temp = PreFileHelper.GetPreFileWithClass(a, prefiles);
                        //if (temp == null)
                        temp = new PreFile();
                        temp.Rets.Add(new PreRET());
                        temp.Rets[0].Classes.Add(((UMLAssociation)r).AssociationClass);
                        prefiles.Add(temp);
                    }
                    else if (dependencyClass == a)
                    {
                        PreRET pret = new PreRET();
                        pret.Classes.Add(associationClass);
                        tempA.Rets.Add(pret);
                    }
                    else if (dependencyClass == b)
                    {
                        PreRET pret = new PreRET();
                        pret.Classes.Add(associationClass);
                        tempB.Rets.Add(pret);
                    }
                }
            }
        }
    }
}
