using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass(Constants.UMLClass.CLASS)]
    public class UMLClass : ActiveRecord<UMLClass>
    {
        private UMLAttributeCollection _attributes;

        public UMLAttributeCollection Attributes
        {
            get 
            {
                if (_attributes == null)
                {
                    _attributes = new UMLAttributeCollection();
                }
                return _attributes; 
            }
            set 
            {
                _attributes = value; 
            }
        }


        private UMLMethodCollection _methods;

        public UMLMethodCollection Methods
        {
            get
            {
                if (_methods == null)
                {
                    _methods = new UMLMethodCollection();
                }
                return _methods;
            }
            set
            {
                _methods = value;
            }
        }

        private bool _isAbstract;
        [UMLProperty("IsAbstract")]
        public bool IsAbstract
        {
            get 
            {
                return _isAbstract; 
            }
            set
            {
                _isAbstract = value; 
            }
        }

        
        public void Save()
        {
            base.Save();
            foreach (UMLAttribute a in Attributes)
            {
                a.Owner = this;
                a.Save();
            }

            foreach (UMLMethod m in Methods)
            {
                m.Owner = this;
                m.Save();
            }
        }


        public void LoadAttributes()
        {
            Attributes = GetAttributes();
        }

        //METHODS
        #region Methods
        public UMLAssociationCollection GetAssociations()
        {
            return this.GetAssociationCollection<UMLAssociation, UMLAssociationCollection>();
        }

        public UMLGeneralizationCollection GetGeneralizations()
        {
            return this.GetGeneralizationCollection<UMLGeneralization, UMLGeneralizationCollection>();
        }

        public UMLRealizationCollection GetRealizations()
        {
            return this.GetDependencyCollection<UMLRealization, UMLRealizationCollection>();
        }

        public UMLDependencyCollection GetDependencies()
        {
            return this.GetDependencyCollection<UMLDependency, UMLDependencyCollection>();
        }


        private UMLAttributeCollection GetAttributes()
        {
            return this.GetAttributeCollection<UMLAttribute, UMLAttributeCollection>();
        }
        #endregion
    }
}
