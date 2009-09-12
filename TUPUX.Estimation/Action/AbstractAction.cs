using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.Entity;
using TUPUX.Estimation.File;

namespace TUPUX.Estimation.Action
{
    public abstract class AbstractAction
    {
        //ATTRIBUTES
        #region Attributes
        private bool isAlternate;
        #endregion

        //PROPERTIES
        #region Properties
        public bool IsAlternate
        {
            get { return this.isAlternate; }
            set { this.isAlternate = value; }
        }
        #endregion

        //METHODS
        #region Methods
        public abstract void Execute(UMLRelationship r, ActionMap map, List<PreFile> files);
        #endregion
    }
}
