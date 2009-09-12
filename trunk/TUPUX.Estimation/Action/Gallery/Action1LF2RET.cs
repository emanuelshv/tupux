using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.Estimation.Relationship;
using TUPUX.Estimation.File;

namespace TUPUX.Estimation.Action.Gallery
{
    class Action1LF2RET: AbstractAction
    {
        public override void Execute(UMLRelationship r, ActionMap map, List<PreFile> prefiles)
        {
            UMLClass a = null;
            UMLClass b = null;
            UMLClass ac = null;
            PreFile prefA;
            PreFile prefB;
            PreRET temp;

            RelationshipHelper.GetClasses(r, ref a, ref b, this.IsAlternate);


            if (r is UMLAssociation)
            {
                ac = ((UMLAssociation)r).AssociationClass;
            }

            prefA = PreFileHelper.GetPreFileWithClass(a, prefiles);
            prefB = PreFileHelper.GetPreFileWithClass(b, prefiles);

            if (prefA == null)
            {
                if (prefB == null)
                {
                    prefA = new PreFile();
                    prefA.Rets.Add(new PreRET());
                    prefA.Rets.Add(new PreRET());
                    prefA.Rets[0].Classes.Add(a);
                    prefA.Rets[1].Classes.Add(b);
                    prefiles.Add(prefA);

                    if (ac != null)
                    {
                        prefA.Rets.Add(new PreRET());
                        prefA.Rets[2].Classes.Add(ac);
                    }
                }
                else
                {
                    temp = new PreRET();
                    temp.Classes.Add(a);
                    prefB.Rets.Add(temp);
                }
            }
            else
            {
                if (prefB == null)
                {
                    temp = new PreRET();
                    temp.Classes.Add(b);
                    prefA.Rets.Add(temp);
                }
            }
        }
    }
}
