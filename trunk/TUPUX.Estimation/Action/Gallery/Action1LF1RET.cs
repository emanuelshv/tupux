using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.Estimation.File;
using TUPUX.Estimation.Relationship;

namespace TUPUX.Estimation.Action.Gallery
{
    /*
     * This action creates 1 File with 1 RET. If Files or RETs containing the involved classes already
     * exist, then it merges said Files or RETs.
     */
    class Action1LF1RET : AbstractAction
    {
        public override void Execute(UMLRelationship r, ActionMap map, List<PreFile> prefiles)
        {
            UMLClass a = null;
            UMLClass b = null;
            UMLClass ac = null;
            PreFile prefA;
            PreFile prefB;

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
                    prefA.Rets[0].Classes.Add(a);
                    prefA.Rets[0].Classes.Add(b);

                    if (ac != null)
                    {
                        prefA.Rets[0].Classes.Add(ac);
                    }

                    prefiles.Add(prefA);
                }
                else
                {
                    foreach (PreRET ret in PreFileHelper.GetPreRETsWithClass(b, prefB))
                    {
                        ret.Classes.Add(a);
                        if (ac != null)
                        {
                            ret.Classes.Add(ac);
                        }
                    }
                }
            }
            else
            {
                if (prefB == null)
                {
                    foreach (PreRET ret in PreFileHelper.GetPreRETsWithClass(a, prefA))
                    {
                        ret.Classes.Add(b);
                        if (ac != null)
                        {
                            ret.Classes.Add(ac);
                        }
                    }
                }
                else
                {
                    foreach (PreRET reta in PreFileHelper.GetPreRETsWithClass(a, prefA))
                    {
                        foreach (PreRET retb in PreFileHelper.GetPreRETsWithClass(b, prefB))
                        {
                            reta.Merge(retb);
                            prefB.Rets.Remove(retb);

                            if (ac != null)
                            {
                                reta.Classes.Add(ac);
                            }
                        }
                    }

                    prefA.Merge(prefB);
                    prefiles.Remove(prefB);
                }
            }
        }
    }
}
