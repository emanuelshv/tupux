using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using TUPUX.Entity;

namespace TUPUX.Estimation.File
{
    public class PreRET
    {
        private List<UMLClass> classes;
        private List<PreRET> parents;

        //Constructors
        #region Constructors
        public PreRET()
        {
            this.classes = new List<UMLClass>();
            this.parents = new List<PreRET>();
        }
        #endregion

        //Properties
        #region Properties
        public List<UMLClass> Classes
        {
            get { return classes; }
            set { classes = value; }
        }

        public List<PreRET> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public bool IsAbstract
        {
            get
            {
                return (this.parents.Count > 0);
            }
        }
        #endregion

        //Methods
        #region Methods
        public void Merge(PreRET ret)
        {
            List<UMLClass> tclasses = new List<UMLClass>();
            bool found;

            tclasses.AddRange(classes);

            foreach (UMLClass c in ret.Classes)
            {
                foreach (UMLClass d in classes)
                {
                    found = false;

                    if (d.Guid.Equals(c.Guid))
                    {
                        found = true;
                        break;
                    }

                    if (!found)
                    {
                        tclasses.Add(c);
                    }
                }
            }

            this.classes = tclasses;
        }
        #endregion
    }
}
