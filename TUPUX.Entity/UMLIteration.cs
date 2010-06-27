using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;
using System.IO;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass(Constants.UMLIteration.CLASS, Constants.UMLIteration.STEREOTYPE)]
    public class UMLIteration : ActiveRecord<UMLIteration>
    {
        #region Iteration Constants
        // TagDefinition
        public const string TagDefinitionApplyEstimation = "Apply Estimation";
        public const string TagDefinitionFileFP = "File Function Points";
        public const string TagDefinitionActionFP = "File Actions Function Points";
        public const string TagDefinitionTotalFP = "Total Function Points";
        public const string TagUseCaseList = "Use Case List";
        public const string TagDefinitionEAF = "EAF";
        public const string TagDefinitionEstimatedProductivity = "Estimated Productivity";
        public const string TagDefinitionRealEffort = "Real Effort";
        public const string TagDefinitionRealProductivity = "Real Productivity";
        public const string TagDefinitionEstimatedEffort = "Estimated Effort";
        public const string TagDefinitionEAFHistory = "EAF";
        public const string TagDefinitionProductivityHistory = "Productivity";

        #endregion

        #region Attributes  and Properties

        private bool _applyEstimation;

        private double _fileFunctionPoints;

        private double _actionFunctionPoints;

        private double _totalFunctionPoints;

        private UMLUseCaseCollection _useCases;

        private UMLIteration _next;

        private UMLIteration _prev;

        private bool _first;

        private bool _last;

        private double _estimatedEffort;

        private double _realEffort;

        private double _realProductivity;

        private double _estimatedproductivity;

        private double _EAF;

        private double _productivityHistory;

        private double _EAFHistory;

        private UMLFactorCollection _factors;

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagDefinitionApplyEstimation)]
        public bool ApplyEstimation
        {
            get 
            {
                return _applyEstimation; 
            }
            set 
            {
                _applyEstimation = value;                
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagDefinitionFileFP)]
        public double FileFunctionPoints
        {
            get 
            {
                return _fileFunctionPoints; 
            }
            set 
            {
                _fileFunctionPoints = value;
                NotifyPropertyChanged("ApplyEstimation");
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagDefinitionActionFP)]
        public double ActionFunctionPoints
        {
            get 
            {
                return _actionFunctionPoints;                
            }
            set 
            {
                _actionFunctionPoints = value;
                NotifyPropertyChanged("ApplyEstimation");
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagDefinitionTotalFP)]
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

        public UMLUseCaseCollection UseCases
        {
            get
            {
                if (_useCases == null)
                    //_useCases = getUseCases();
                    _useCases = new UMLUseCaseCollection();
                return _useCases;
            }
            set 
            {
                _useCases = value;
                NotifyPropertyChanged("UseCases");
            }
        }
        
        public UMLIteration Next
        {
            get
            {
                return _next;
            }
            set 
            { 
                _next = value; 
            }
        }

        public UMLIteration Prev
        {
            get
            {
                return _prev;
            }
            set 
            {
                _prev = value; 
            }
        }
        
        public bool First
        {
            get 
            {
                return _first; 
            }
            set 
            {
                _first = value; 
            }
        }
        
        public bool Last
        {
            get 
            { 
                return _last; 
            }
            set 
            {
                _last = value; 
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagDefinitionEAF)]
        public double EAF
        {
            get 
            { 
                return _EAF;
            }
            set 
            {
                _EAF = value;
                NotifyPropertyChanged("EAF");
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagDefinitionEstimatedProductivity)]
        public double EstimatedProductivity
        {
            get 
            {
                return _estimatedproductivity; 
            }
            set 
            {
                _estimatedproductivity = value;
                NotifyPropertyChanged("EstimatedProductivity");
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagDefinitionRealEffort)]
        public double RealEffort
        {
            get 
            { 
                return _realEffort; 
            }
            set 
            {
                _realEffort = value;
                NotifyPropertyChanged("RealEffort");
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagDefinitionRealProductivity)]
        public double RealProductivity
        {
            get
            {
                return _realProductivity;
            }
            set
            {
                _realProductivity = value;
                NotifyPropertyChanged("RealProductivity");
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagDefinitionEstimatedEffort)]
        public double EstimatedEffort
        {
            get 
            { 
                return _estimatedEffort; 
            }
            set 
            {
                _estimatedEffort = value;
                NotifyPropertyChanged("EstimatedEffort");
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_HISTORYVALUES, UMLIteration.TagDefinitionProductivityHistory)]
        public double ProductivityHistory
        {
            get 
            { 
                return _productivityHistory; 
            }
            set 
            { 
                _productivityHistory = value;
                NotifyPropertyChanged("ProductivityHistory");
            }
        }

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_HISTORYVALUES, UMLIteration.TagDefinitionEAFHistory)]
        public double EAFHistory
        {
            get 
            { 
                if (_EAFHistory <=0)
                    _EAFHistory = 1;
                return _EAFHistory; 
            }
            set 
            {
                _EAFHistory = value;
                NotifyPropertyChanged("EAFHistory");
            }
        }

        public UMLFactorCollection Factors
        {
            get
            {
                if (_factors == null)
                    //_factors = getFactors();
                    _factors = new UMLFactorCollection();
                return _factors;
            }
            set 
            {
                _factors = value;
                NotifyPropertyChanged("Factors");
            }
        }


        public Double MRE
        {
            get
            {
                double mre = Math.Abs(RealProductivity - EstimatedProductivity);
                if (RealProductivity > 0) mre = mre / RealProductivity;
                else mre = 0;
                return mre;
            }
        }

        #endregion

        #region Constructor

        #endregion

        #region Methods

        #region Methods Load

        public void LoadCollections()
        {            
            _factors = getFactors();
            _useCases = getUseCases();
            
            if (_prev == null)
            {
                _prev = Helper.GetPrev<UMLIteration>(this, Constants.UMLIteration.STEREOTYPEITERATIONPRECEDENCE);
            }
            if (_next == null)
            {
                _next = Helper.GetNext<UMLIteration>(this, Constants.UMLIteration.STEREOTYPEITERATIONPRECEDENCE);
            }
        }

        private UMLFactorCollection getFactors()
        {
            UMLFactorCollection result = UMLFactorCollection.GetFactors(false);
            foreach (UMLFactor factor in result)
            {
                factor.SetSelected(GetTagValueAsString(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_FATORS, factor.DefinitionName));
            }
            return result;
        }

        private UMLUseCaseCollection getUseCases()
        {
            return this.GetTagCollection<UMLUseCase, UMLUseCaseCollection>(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagUseCaseList);
        }

        private UMLCollaborationCollection getCollaborationUseCase()
        {
            UMLCollaborationCollection collection = new UMLCollaborationCollection();
            foreach (UMLUseCase useCase in UseCases)
            {
                useCase.Collaborations = useCase.GetCollaborations();
                if (useCase.Collaborations == null)
                    useCase.GetCollaborations();
                collection.AddRange(useCase.Collaborations);

            }
            return collection;
        }

        #endregion

        public void EstimateFunctionPoints()
        {
            //if (UseCases == null)
            //    GetUseCases();
            ClearVariables();
            EstimateEAF();
            EstimateProductivity();

            foreach (UMLUseCase usecase in UseCases)
            {
                usecase.GetCollaborations();

                usecase.EstimateFunctionPoints(EstimatedProductivity);
                
                ActionFunctionPoints += usecase.ActionFunctionPoints;
                FileFunctionPoints += usecase.FileFunctionPoints;
                TotalFunctionPoints += usecase.TotalFunctionPoints;
            }

            
            EstimatedEffort = Math.Round(TotalFunctionPoints * EstimatedProductivity, 2);
            if (TotalFunctionPoints > 0)
                RealProductivity = Math.Round(RealEffort / TotalFunctionPoints, 2);
            else
                RealProductivity = 0;
            //this.Save();
        }
                
        public void SaveImport()
        {
            base.Save();
            foreach (UMLUseCase useCase in UseCases)
            {
                useCase.SaveImport();
            }

            this.ClearTagCollection(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagUseCaseList);
            this.SaveTagCollection<UMLUseCase, UMLUseCaseCollection>(this.UseCases, Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagUseCaseList);

            if (this.Prev != null)
            {
                Helper.CreateDependency<UMLIteration, UMLIteration>(this.Prev, this, Constants.UMLIteration.STEREOTYPEITERATIONPRECEDENCE, this.Owner);
            }
        }
        
        public void SaveEdit()
        {
            MarkModified();
            Save();
            this.ClearTagCollection(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagUseCaseList);
            this.SaveTagCollection<UMLUseCase, UMLUseCaseCollection>(this.UseCases, Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagUseCaseList);

            SaveFactors();

            foreach(UMLUseCase usecase in UseCases)
            {
                usecase.Save();
            }

            MarkLoaded();
        }

        public void SaveFactors()
        {
            base.Save();
            foreach (UMLFactor factor in Factors)
            {
                SetTagValueAsString(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_FATORS, factor.DefinitionName, factor.SelectedKey);
                factor.MarkLoaded();
            }
        }

        private void ClearVariables()
        {
            ActionFunctionPoints = 0;
            FileFunctionPoints = 0;
            TotalFunctionPoints = 0;
            EstimatedEffort = 0;
        }
        
        private void EstimateEAF()
        {
            EAF = 1.0;
            foreach (UMLFactor factor in Factors)
            {
                double value = factor.SelectedValue;
                if (value > 0)
                {
                    EAF = Math.Round(EAF*value,2);
                }
            }
        }
        
        private void EstimateProductivity()
        {
            if (Prev == null)
            {
                EstimatedProductivity = Math.Round(EAF * ProductivityHistory / EAFHistory, 2);
            }
            else
            {
                EstimatedProductivity = Math.Round(EAF * Prev.EstimatedProductivity / Prev.EAF, 2);                
            }
        }
        
        public void RemoveUseCaseToTag(UMLUseCase usecase)
        {
            RemoveElementTagCollection(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagUseCaseList, usecase);
        }

        public void AddUseCaseToTag(UMLUseCase usecase)
        {
            AddElementToTagCollection(Constants.UMLProfile.ESTIMATION, Constants.UMLIteration.TDS_ESTIMATION, UMLIteration.TagUseCaseList, usecase);
        }

        #endregion
    }
}
