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
        private int defaultDets = 0;
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

        public int DefaultDets
        {
            get { return defaultDets; }
            set { defaultDets = value; }
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
