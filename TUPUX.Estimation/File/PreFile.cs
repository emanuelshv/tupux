using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;

namespace TUPUX.Estimation.File
{
    public class PreFile
    {
        //Attributes
        #region Attributes
        private List<PreRET> rets;
        #endregion

        //Constructors
        #region Constructors
        public PreFile()
        {
            rets = new List<PreRET>();
        }
        #endregion

        //Properties
        #region Properties
        public List<PreRET> Rets
        {
            get { return rets; }
            set { rets = value; }
        }
        #endregion

        public void Merge(PreFile file)
        {
            foreach (PreRET ret in file.Rets)
            {
                rets.Add(ret);
            }
        }
    }
}
