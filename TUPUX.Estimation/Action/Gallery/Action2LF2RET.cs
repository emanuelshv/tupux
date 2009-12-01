using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.Estimation.Relationship;
using TUPUX.Estimation.File;

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
            PreFile temp;

            RelationshipHelper.GetClasses(r, ref a, ref b, this.IsAlternate, ref defaultDetsA, ref defaultDetsB);

            //1st File
            if ((temp = PreFileHelper.GetPreFileWithClass(a, prefiles)) == null)
            {
                temp = new PreFile();
                temp.Rets.Add(new PreRET());
                temp.Rets[0].Classes.Add(a);                
                prefiles.Add(temp);
            }
            temp.DefaultDets += defaultDetsA;

            //2nd File
            if ((temp = PreFileHelper.GetPreFileWithClass(b, prefiles)) == null)
            {
                temp = new PreFile();
                temp.Rets.Add(new PreRET());
                temp.Rets[0].Classes.Add(b);                
                prefiles.Add(temp);
            }
            temp.DefaultDets += defaultDetsB;

            //3rd File (only if there is an Association-Class)
            if (r is UMLAssociation)
            {
                if (((UMLAssociation)r).AssociationClass != null)
                {
                    temp = new PreFile();
                    temp.Rets.Add(new PreRET());
                    temp.Rets[0].Classes.Add(((UMLAssociation)r).AssociationClass);
                    prefiles.Add(temp);
                }
            }
        }
    }
}
