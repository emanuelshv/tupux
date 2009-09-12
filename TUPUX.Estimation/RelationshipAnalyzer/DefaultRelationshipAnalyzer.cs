using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.Estimation.Action;
using TUPUX.Estimation.File;

namespace TUPUX.Estimation.RelationshipAnalyzer
{
    class DefaultRelationshipAnalyzer : IRelationshipAnalyzer
    {
        private ActionMap map;

        public DefaultRelationshipAnalyzer(String actionfilepath)
        {
            this.map = ActionReader.ReadFile(actionfilepath);
        }

        public List<UMLFile> CreateFiles(IDictionary relationships)
        {
            List<PreFile> prefiles = new List<PreFile>();
            List<PreRET> retsToDelete;
            List<UMLFile> files = new List<UMLFile>();
            IDictionary<String, String> tnamemap;
            IDictionary<String, UMLClass> tclasses;
            UMLFile tfile;
            String tname;
            int tdets;
            UMLAttribute tattrib;

            //1. PreFile Generation (Pre-Processing)
            foreach (DictionaryEntry entry in relationships)
            {
                UMLRelationship r = (UMLRelationship)entry.Value;

                ActionKey key = new ActionKey(r);

                AbstractAction action = map.GetAction(key);

                if (action != null)
                {
                    action.Execute(r, map, prefiles);
                }
                else
                {
                    throw new ArgumentException("There is no defined action for the actionKey given.");
                }
            }

            //2. File Generation (Processing)
            if (prefiles.Count == 0)
            {
                return null;
            }
            else
            {
                //2.1 Clean-up (eliminate parents in PreFiles - Generalization cases)
                foreach (PreFile prefile in prefiles)
                {
                    retsToDelete = new List<PreRET>();

                    foreach (PreRET preret in prefile.Rets)
                    {
                        foreach (PreRET parent in preret.Parents)
                        {
                            //2.1.1 Merge
                            preret.Merge(parent);

                            //mark parent ret for deletion
                            if (!retsToDelete.Contains(parent))
                            {
                                retsToDelete.Add(parent);
                            }
                        }
                    }

                    //2.1.2 Deletion (optimized since rets are only in one file)
                    foreach (PreRET retToDelete in retsToDelete)
                    {
                        prefile.Rets.Remove(retToDelete);
                    }

                    //2.1.3 File generation
                    tfile = new UMLFile();
                    //Rets
                    tfile.Rets = prefile.Rets.Count;
                    //Dets & Name
                    tdets = 0;
                    tname = "";
                    tnamemap = new Dictionary<String, String>();
                    tclasses = new Dictionary<String, UMLClass>();

                    foreach (PreRET ret in prefile.Rets)
                    {
                        UMLFile.RET tret = new UMLFile.RET();

                        foreach (UMLClass c in ret.Classes)
                        {
                            tnamemap[c.Name] = c.Name;

                            tret.Classes.Add(c);

                            if (!(tclasses.ContainsKey(c.Name)))
                            {
                                tclasses[c.Name] = c;
                                c.LoadAttributes();
                                tdets += c.Attributes.Count;
                                foreach (UMLAttribute attrib in c.Attributes)
                                {
                                    tattrib = new UMLAttribute();
                                    tattrib.Name = c.Name + "." + attrib.Name;
                                    tfile.Attributes.Add(tattrib);
                                }
                            }
                        }

                        tfile.RetsCollection.Add(tret);
                    }

                    foreach (KeyValuePair<String, String> kvp in tnamemap)
                    {
                        tname += kvp.Value + "_";
                    }

                    tfile.Dets = tdets;
                    tname = tname.Remove(tname.Length - 1, 1);
                    //limit File name size to 50 chars (could cause name collisions)
                    tfile.Name = tname.Length > 50 ? tname.Substring(1, 50) : tname;

                    files.Add(tfile);
                }

                return files;
            }
        }
    }
}
