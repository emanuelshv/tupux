using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;
using TUPUX.Entity.Constants;
using System.Reflection;
using log4net;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass(Constants.UMLFile.CLASS, Constants.UMLFile.STEREOTYPE)]
    public class UMLFile : ActiveRecord<UMLFile>
    {
        #region File Constants
        public const string TAG_DEFINITION_DETS = "DETs";
        public const string TAG_DEFINITION_RETS = "RETs";
        public const string TAG_DEFINITION_FPDISTRIBUTE = "Function Points To Distribute";
        public const string TAG_DEFINITION_FILE_TYPE = "File Type";                
        #endregion

        #region Attributes and Properties

        private List<RET> _retscollection = new List<RET>();

        private double _functionPointsDistribute;

        private string _type;

        private int _dets;
        
        private int _rets;

        private UMLAttributeCollection _attributes;
        
        private UMLCollaborationCollection _collaborations;

        private static readonly ILog log = LogManager.GetLogger(typeof(UMLFile));

        [UMLTag(UMLProfile.FILE, Constants.UMLFile.TDS_ESTIMATION, UMLFile.TAG_DEFINITION_FPDISTRIBUTE)]
        public double FunctionPointsDistribute
        {
            get 
            {
                return _functionPointsDistribute; 
            }
            set 
            {
                _functionPointsDistribute = value;
                NotifyPropertyChanged("FunctionPointsDistribute");
            }
        }

        [UMLTag(UMLProfile.FILE, Constants.UMLFile.TDS_ESTIMATION, UMLFile.TAG_DEFINITION_FILE_TYPE)]
        public string Type
        {
            get 
            {
                return _type; 
            }
            set
            {
                _type = value;
                NotifyPropertyChanged("Type");
            }
        }

        [UMLTag(UMLProfile.FILE, Constants.UMLFile.TDS_ESTIMATION, UMLFile.TAG_DEFINITION_DETS)]
        public int Dets
        {
            get 
            {
                return _dets; 
            }
            set
            {
                _dets = value;
                NotifyPropertyChanged("Dets");
            }
        }

        [UMLTag(UMLProfile.FILE, Constants.UMLFile.TDS_ESTIMATION, UMLFile.TAG_DEFINITION_RETS)]
        public int Rets
        {
            get 
            {
                return _rets; 
            }
            set 
            {
                _rets = value;
                NotifyPropertyChanged("Rets");
            }
        }

        public UMLCollaborationCollection Collaborations
        {
            get 
            {
                if (_collaborations == null)
                    // _collaborations = getCollaborationsAssociated();
                    _collaborations = new UMLCollaborationCollection();
                return _collaborations; 
            }
            set             
            { 
                _collaborations = value;                
            }
        }
        
        public UMLAttributeCollection Attributes
        {
            get 
            {
                if (_attributes == null)
                    //_attributes = GetAttributes();
                    _attributes = new UMLAttributeCollection();
                return _attributes; }
            set 
            {
                _attributes = value;                
            }
        }

        #endregion

        #region Methods

        #region Methods Load
        
        public void LoadCollections()
        {            
            Collaborations = getCollaborationsAssociated();
            Attributes = GetAttributes();
        }

        private UMLCollaborationCollection getCollaborationsAssociated()
        {
            return this.GetClientDependencies<UMLCollaboration, UMLCollaborationCollection>(Constants.UMLFile.STEREOTYPEDEPENDENCYFILE);            
        }
        
        private UMLAttributeCollection GetAttributes()
        {
            return this.GetAttributeCollection<UMLAttribute, UMLAttributeCollection>();
        }

        #endregion

        public void EstimateFunctionPoints()
        {   
            FunctionPointsDistribute = HelperEstimation.CalculateFileFunctionPoints(Type, Dets, Rets);
            if (this.Collaborations != null && this.Collaborations.Count > 0)
            {
                FunctionPointsDistribute = Math.Round(FunctionPointsDistribute/this.Collaborations.Count, 2);
            }
            //this.Save();
        }
        
        public void SaveImport()
        {
            base.Save();
            foreach (UMLAttribute a in Attributes)
            {
                a.Owner = this;
                a.Save();
            }
        }

        public List<RET> RetsCollection
        {
            get { return _retscollection; }
            set { _retscollection = value; }
        }
        #endregion

        #region InnerClass RET
        public class RET
        {
            List<UMLClass> classes = new List<UMLClass>();

            public List<UMLClass> Classes
            {
                get { return classes; }
                set { classes = value; }
            }

        }
        #endregion
    }
}
