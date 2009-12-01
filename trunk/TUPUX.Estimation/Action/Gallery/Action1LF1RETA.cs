using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.Estimation.File;
using TUPUX.Estimation.Relationship;

namespace TUPUX.Estimation.Action.Gallery
{
    /*
     * This action creates 1 Abstract File, one Real File, and only 1 RET. This is used for generalization-type
     * relationships.
     */
    class Action1LF1RETA : AbstractAction
    {
        public override void Execute(UMLRelationship r, ActionMap map, List<PreFile> prefiles)
        {
            UMLClass a = null;
            UMLClass b = null;
            int defaultDetsA = 0;
            int defaultDetsB = 0;
            PreFile prefA;
            PreFile prefB;
            PreRET temp;

            RelationshipHelper.GetClasses(r, ref a, ref b, this.IsAlternate, ref defaultDetsA, ref defaultDetsB);

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
                    prefA.Rets[1].Parents.Add(prefA.Rets[0]);

                    prefiles.Add(prefA);
                }
                else
                {
                    temp = new PreRET();
                    temp.Classes.Add(a);
                    prefB.Rets.Add(temp);

                    foreach (PreRET ret in PreFileHelper.GetPreRETsWithClass(b, prefB))
                    {
                        ret.Parents.Add(temp);
                    }
                }
            }
            else
            {
                if (prefB == null)
                {
                    temp = new PreRET();
                    temp.Classes.Add(b);
                    prefA.Rets.Add(temp);

                    foreach (PreRET ret in PreFileHelper.GetPreRETsWithClass(a, prefA))
                    {
                        temp.Parents.Add(ret);
                    }
                }
                else
                {
                    foreach (PreRET retparent in PreFileHelper.GetPreRETsWithClass(a, prefA))
                    {
                        foreach (PreRET retchild in PreFileHelper.GetPreRETsWithClass(b, prefB))
                        {
                            retchild.Parents.Add(retparent);
                            //Merging to form the Real RET is done in the FileProcessing
                        }
                    }

                    prefA.Merge(prefB);
                    prefiles.Remove(prefB);
                }
            }
        }
    }
}
