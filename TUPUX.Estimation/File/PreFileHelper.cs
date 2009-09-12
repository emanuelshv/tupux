using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;

namespace TUPUX.Estimation.File
{
    class PreFileHelper
    {
        //PreFile Methods
        #region PreFile Methods

        public static PreFile GetPreFileWithClass(UMLClass c, List<PreFile> prefiles)
        {
            foreach (PreFile p in prefiles)
            {
                foreach (PreRET r in p.Rets)
                {
                    foreach (UMLClass d in r.Classes)
                    {
                        if (d.Guid.Equals(c.Guid))
                        {
                            return p;
                        }
                    }
                }
            }
            return null;
        }
        #endregion

        //PreRET Methods
        #region PreRET Methods
        public static List<PreRET> GetPreRETsWithClass(UMLClass c, PreFile p)
        {
            List<PreRET> rets = new List<PreRET>();

            foreach (PreRET r in p.Rets)
            {
                foreach (UMLClass d in r.Classes)
                {
                    if (d.Guid.Equals(c.Guid))
                    {
                        rets.Add(r);
                    }
                }
            }
            if (rets.Count == 0)
            {
                return null;
            }
            else
            {
                return rets;
            }
        }
        #endregion
    }
}
