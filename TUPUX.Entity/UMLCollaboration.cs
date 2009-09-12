using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;
using TUPUX.Entity.Constants;
using log4net;
using System.Reflection;

namespace TUPUX.Entity
{
    /// <summary>
    /// Class for managing the transactions
    /// </summary>
    [Serializable]
    [UMLClass(Constants.UMLCollaboration.CLASS)]
    public class UMLCollaboration : ActiveRecord<UMLCollaboration>
    {

        #region Collaboration Constants
        public const string TAG_DEFINITION_TYPE = "Type";
        public const string TAG_DEFINITION_GENERATE_ACTION = "Generate Action";
        public const string TAG_DEFINITION_SEND_MESSAGE = "Send Message";
        public const string TAG_DEFINITION_DETS = "DETs";
        public const string TAG_DEFINITION_STEPS = "Steps";
        public const string TAG_DEFINITION_ACTION_FUNCTION_POINTS = "Action Function Points";
        public const string TAG_DEFINITION_TOTAL_FUNCTION_POINTS = "Total Function Points";
        public const string TAG_DEFINITION_FILES_FUNCTION_POINTS = "Files Associated Function Points";        
        #endregion

        #region Attributes and Properties

        private string _type;

        private bool _sendMessage;

        private bool _generateAction;
        
        private double _actionFunctionPoints;

        private double _filesFunctionPoints;
        
        private double _totalFunctionPoints;

        private UMLFileCollection _files;

        private UMLAttributeCollection _dets;

        private UMLStepFlowCollection _steps;

        private static readonly ILog log = LogManager.GetLogger(typeof(UMLCollaboration));

        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_TYPE)]
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


        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_SEND_MESSAGE)]
        public bool SendMessage
        {
            get
            {
                return _sendMessage;
            }
            set
            {
                _sendMessage = value;
                NotifyPropertyChanged("SendMessage");
            }
        }

        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_GENERATE_ACTION)]
        public bool GenerateAction
        {
            get 
            {
                return _generateAction; 
            }
            set
            {
                _generateAction = value;
                NotifyPropertyChanged("GenerateAction");
            }
        }


        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_ACTION_FUNCTION_POINTS)]
        public double ActionFunctionPoints
        {
            get 
            {
                return _actionFunctionPoints;
            }
            set
            {
                _actionFunctionPoints = value;
                NotifyPropertyChanged("ActionFunctionPoints");
            }
        }

        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_FILES_FUNCTION_POINTS)]
        public double FilesFunctionPoints
        {
            get 
            { 
                return _filesFunctionPoints;
            }
            set
            {
                _filesFunctionPoints = value;
                NotifyPropertyChanged("FilesFunctionPoints");
            }
        }

        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_TOTAL_FUNCTION_POINTS)]
        public double TotalFunctionPoints
        {
            get 
            {
                return _totalFunctionPoints; 
            }
            set 
            {
                _totalFunctionPoints = value;
                NotifyPropertyChanged("TotalFunctionPoints");
            }
        }

        public UMLFileCollection Files
        {
            get 
            {
                if (_files == null)
                    //_files = getFiles();
                    _files = new UMLFileCollection();
                return _files; 
            }
            set 
            { 
                _files = value; 
            }
        }

        public UMLAttributeCollection Dets
        {
            get             
            {
                if (_dets == null)
                    //_dets = getDets();
                    _dets = new UMLAttributeCollection();
                return _dets; 
            }
            set             
            { 
                _dets = value; 
            }
        }


        public UMLStepFlowCollection Steps
        {
            get
            {
                if (_steps == null)
                    _steps = new UMLStepFlowCollection();
                return _steps; 
            }
            set 
            { 
                _steps = value; 
            }
        }

        #endregion

        #region Methods

        #region Methods Load

        /// <summary>
        /// Loads all collections
        /// </summary>
        public void LoadCollections()
        {
            if (Owner == null)
            {
                Owner = Helper.GetOwner<UMLUseCase>(this);
            }
            _dets = getDets();
            _files = getFiles();
            _steps = getSteps();            
        }

        /// <summary>
        /// Gets the steps in the tag collection
        /// </summary>
        /// <returns></returns>
        private UMLStepFlowCollection getSteps()
        {
            return this.GetTagCollection<UMLStepFlow, UMLStepFlowCollection>(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_STEPS);
        }

        /// <summary>
        /// Gets the associated files
        /// </summary>
        /// <returns></returns>
        private UMLFileCollection getFiles()
        {
            return this.GetSupplierDependencies<UMLFile, UMLFileCollection>(Constants.UMLFile.STEREOTYPEDEPENDENCYFILE);            
        }

        /// <summary>
        /// Gets the Dets in the tag colleccion
        /// </summary>
        /// <returns></returns>
        private UMLAttributeCollection getDets()
        {
            return this.GetTagCollection<UMLAttribute, UMLAttributeCollection>(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_DETS);
        }

        #endregion

        /// <summary>
        /// Calculates funcion points
        /// </summary>
        public void EstimateFunctionPoints()
        {
            ClearVariables();

            int numberDets = Dets.Count;

            if (SendMessage)
            {
                numberDets++;
            }
            if (GenerateAction)
            {
                numberDets++;
            }

            ActionFunctionPoints = HelperEstimation.CalculateActionFunctionPoints(Type, numberDets, Files.Count);

            foreach (UMLFile file in Files)
            {
                FilesFunctionPoints += (double)file.FunctionPointsDistribute;                
            }


            TotalFunctionPoints = Math.Round(ActionFunctionPoints + FilesFunctionPoints, 2);
            //this.Save();
        }

        /// <summary>
        /// Clear 
        /// </summary>
        private void ClearVariables()
        {
            ActionFunctionPoints = 0;
            FilesFunctionPoints = 0;
            TotalFunctionPoints = 0;
        }
        
        /// <summary>
        /// Adds a new det
        /// </summary>
        /// <param name="attribute"></param>
        public void AddDet(UMLAttribute attribute)
        {
            if (!Dets.Contains(attribute))
            {
                Dets.Add(attribute);
                NotifyPropertyChanged("AddDet");
            }
        }

        /// <summary>
        /// Removes a det
        /// </summary>
        /// <param name="attribute"></param>
        public void RemoveDet(UMLAttribute attribute)
        {
            foreach (UMLAttribute det in Dets)
            {
                if (det.Guid == attribute.Guid)
                {
                    Dets.Remove(det);
                    NotifyPropertyChanged("RemoveDet");
                    break;
                }
            }
        }

        /// <summary>
        /// Gets the auxiliary file
        /// </summary>
        /// <returns></returns>
        public UMLFile GetFileAux()
        {
            return Helper.GetAuxFile<UMLFile>(this.GetKey().ToString());
        }

        /// <summary>
        /// Saves this after an edition
        /// </summary>
        public void SaveEdit()
        { 
            Save();
            this.ClearTagCollection(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_DETS);
            this.SaveTagCollection<UMLAttribute, UMLAttributeCollection>(this.Dets, UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_DETS);

            this.ClearTagCollection(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_STEPS);
            this.SaveTagCollection<UMLStepFlow, UMLStepFlowCollection>(this.Steps, UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_STEPS);
        }

        /// <summary>
        /// Saves this for importation
        /// </summary>
        public void SaveImport()
        {
            base.Save();

            this.ClearTagCollection(UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_DETS);
            this.SaveTagCollection<UMLAttribute, UMLAttributeCollection>(this.Dets, UMLProfile.ESTIMATION, Constants.UMLCollaboration.TDS_ESTIMATION, UMLCollaboration.TAG_DEFINITION_DETS);
            
            foreach (UMLFile file in Files)
            {
                Helper.CreateDependency<UMLCollaboration, UMLFile>(this, file, Constants.UMLFile.STEREOTYPEDEPENDENCYFILE, this.Owner);
            }
        }

        /// <summary>
        /// Adds a new step
        /// </summary>
        /// <param name="uMLStepFlow"></param>
        public void AddStep(UMLStepFlow uMLStepFlow)
        {
            if (!Steps.Contains(uMLStepFlow))
            {
                Steps.Add(uMLStepFlow);
                NotifyPropertyChanged("AddStep");
            }
        }

        /// <summary>
        /// Removes a step
        /// </summary>
        /// <param name="uMLStepFlow"></param>
        public void RemoveStep(UMLStepFlow uMLStepFlow)
        {
            foreach (UMLStepFlow s in Steps)
            {
                if (s.Guid == uMLStepFlow.Guid)
                {
                    Steps.Remove(s);
                    NotifyPropertyChanged("RemoveStep");
                    break;
                }
            }
        }

        #endregion
    }
}
