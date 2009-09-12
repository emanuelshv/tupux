using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;

namespace TUPUX.Entity
{
    /// <summary>
    /// This is an ActiveRecord class which wraps the UseCase.
    /// </summary>
    [Serializable]
    [UMLClass(Constants.UMLUseCase.CLASS)]
    [UMLRelation(UMLRelationType.Collaboration, typeof(UMLCollaboration))]
    [UMLRelation(UMLRelationType.Owned, typeof(UMLFlow))]
    public class UMLUseCase : ActiveRecord<UMLUseCase>
    {
        private string _type;
        [UMLTag(Constants.Specification.PROFILE, Constants.Specification.TDS_USECASE, "type")]
        public string Type
        {
            get { return _type; }
            set
            {
                if (value != this._type)
                {
                    this._type = value;
                    NotifyPropertyChanged("Type");
                }
            }
        }

        private string _purpose;
        [UMLTag(Constants.Specification.PROFILE, Constants.Specification.TDS_USECASE, "purpose")]
        public string Purpose
        {
            get { return _purpose; }
            set
            {
                if (value != this._purpose)
                {
                    this._purpose = value;
                    NotifyPropertyChanged("Purpose");
                }
            }
        }

        private string _resume;
        [UMLTag(Constants.Specification.PROFILE, Constants.Specification.TDS_USECASE, "resume")]
        public string Resume
        {
            get { return _resume; }
            set
            {
                if (value != this._resume)
                {
                    this._resume = value;
                    NotifyPropertyChanged("Resume");
                }
            }
        }




        private double _fileFunctionPoints;

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLUseCase.TDS_ESTIMATION, "File Function Points")]
        public double FileFunctionPoints
        {
            get             
            {
                return _fileFunctionPoints; 
            }
            set 
            {
                _fileFunctionPoints = value;
                NotifyPropertyChanged("FileFunctionPoints");
            }
        }

        private double _actionFunctionPoints;

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLUseCase.TDS_ESTIMATION, "File Actions Function Points")]
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

        private double _totalFunctionPoints;

        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLUseCase.TDS_ESTIMATION, "Total Function Points")]
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

        private double _estimatedEffort;
        [UMLTag(Constants.UMLProfile.ESTIMATION, Constants.UMLUseCase.TDS_ESTIMATION, "Estimated Effort")]
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


        public UMLFlowCollection GetFlows()
        {
            return this.GetOwnedElements<UMLFlow, UMLFlowCollection>();
        }

        public UMLRequerimentCollection GetRequeriments()
        {
            return this.GetAssociateCollection<UMLRequeriment, UMLRequerimentCollection>();
        }

        #region IUMLModel Members

        private UMLCollaborationCollection _collaborations;
				
        public UMLCollaborationCollection Collaborations
        {
            get 
            {
                if (_collaborations == null)
                    _collaborations = new UMLCollaborationCollection();
                return _collaborations; 
            }
            set { _collaborations = value; }
        }

        public UMLCollaborationCollection GetCollaborations()
        {
            Collaborations = this.GetCollaborationCollection<UMLCollaboration, UMLCollaborationCollection>();
            return Collaborations;
        }

        public void Save()
        {
            base.Save();
            foreach (UMLCollaboration col in Collaborations)
            {
                col.Save();
            }           


            if (IterationOld != null)
            {
                IterationOld.RemoveUseCaseToTag(this);
            }
            if (Iteration != null)
            {
                Iteration.AddUseCaseToTag(this);
                this.ClearTagCollection(Constants.UMLProfile.ESTIMATION, Constants.UMLUseCase.TDS_ESTIMATION, "Iteration Associated");
                UMLIterationCollection collection = new UMLIterationCollection();
                collection.Add(Iteration);
                this.SaveTagCollection<UMLIteration, UMLIterationCollection>(collection, Constants.UMLProfile.ESTIMATION, Constants.UMLUseCase.TDS_ESTIMATION, "Iteration Associated");
            }
        }

        public void SaveImport()
        {
            base.Save();
            foreach (UMLCollaboration col in Collaborations)
            {
                col.SaveImport();
            }
        }

        #endregion




        private UMLIteration _iterationOld;

        public UMLIteration IterationOld
        {
            get
            {
                return _iterationOld;
            }
            set { _iterationOld = value; }
        }

        private UMLIteration _iteration;

        public UMLIteration Iteration
        {
            get
            {
                return _iteration;
            }
            set 
            {
                if (_iteration != value)
                {
                    _iteration = value;
                    NotifyPropertyChanged("Iteration");
                }
            }
        }

        public UMLIteration GetIteration()
        {
            UMLIterationCollection iterations = this.GetTagCollection<UMLIteration, UMLIterationCollection>(Constants.UMLProfile.ESTIMATION, Constants.UMLUseCase.TDS_ESTIMATION, "Iteration Associated");
            if (iterations != null && iterations.Count > 0)
                Iteration = iterations[0];
            return Iteration;
        }


        public void EstimateFunctionPoints(double estimatedProductivity)
        {
            //if (UseCases == null)
            //    GetUseCases();
            ClearVariables();
            
            foreach (UMLCollaboration collaboration in Collaborations)
            {
                collaboration.LoadCollections();
                collaboration.EstimateFunctionPoints();
                ActionFunctionPoints += collaboration.ActionFunctionPoints;
                FileFunctionPoints += collaboration.FilesFunctionPoints;
                TotalFunctionPoints += collaboration.TotalFunctionPoints;
            }

            EstimatedEffort = Math.Round(TotalFunctionPoints * estimatedProductivity, 2);
            //this.Save();
        }

        private void ClearVariables()
        {
            ActionFunctionPoints = 0;
            FileFunctionPoints = 0;
            TotalFunctionPoints = 0;
            EstimatedEffort = 0;
        }

    }
}
