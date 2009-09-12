using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;
using TUPUX.Entity.Constants;

namespace TUPUX.Entity
{
    [Serializable]
    [UMLClass(Constants.UMLPhase.CLASS, Constants.UMLPhase.STEREOTYPE)]
    [UMLRelation(UMLRelationType.Owned, typeof(UMLIteration))]
    public class UMLPhase : ActiveRecord<UMLPhase>
    {
        #region Phase Constants
        // TagDefinition
        public const string TagDefinitionApplyEstimation = "Apply Estimation";
        public const string TagDefinitionFileFP = "Phase File Function Points";
        public const string TagDefinitionActionFP = "Phase Actions Function Points";
        public const string TagDefinitionTotalFP = "Total Function Points";

        #endregion

        #region Attributes  and Properties

        private bool _applyEstimation;

        private double _fileFunctionPoints;

        private double _actionFunctionPoints;

        private double _totalFunctionPoints;

        private UMLIterationCollection _iterations;

        private UMLFileCollection _filesProject;

        private UMLIteration _firsIteration;

        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLPhase.TDS_ESTIMATION, UMLPhase.TagDefinitionApplyEstimation)]
        public bool ApplyEstimation
        {
            get
            {
                return _applyEstimation;
            }
            set
            {
                _applyEstimation = value;
                NotifyPropertyChanged("ApplyEstimation");
            }
        }

        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLPhase.TDS_ESTIMATION, UMLPhase.TagDefinitionFileFP)]
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

        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLPhase.TDS_ESTIMATION, UMLPhase.TagDefinitionActionFP)]
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

        [UMLTag(UMLProfile.ESTIMATION, Constants.UMLPhase.TDS_ESTIMATION, UMLPhase.TagDefinitionTotalFP)]
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

        public UMLIterationCollection Iterations
        {
            get
            {
                if (_iterations == null)
                {
                    //_iterations = getIterations();
                    //loadIterationPrecedence();
                    Iterations = new UMLIterationCollection();
                }
                return _iterations;
            }
            set
            {
                _iterations = value;
            }
        }

        public UMLFileCollection FilesProject
        {
            get
            {
                if (_filesProject == null)
                    //_filesProject = getFilesProject();
                    _filesProject = new UMLFileCollection();
                return _filesProject;
            }
            set
            {
                _filesProject = value;
            }
        }

        public UMLIteration FirsIteration
        {
            get
            {
                return _firsIteration;
            }
            set
            {
                _firsIteration = value;
            }
        }

        #endregion

        #region Methods
        #region Methods Load

        public void LoadCollections()
        {
            _iterations = getIterations();
            loadIterationPrecedence();
            _filesProject = getFilesProject();
            LoadIterations();           
        }

        private void LoadIterations()
        {
            foreach (UMLIteration i in Iterations)
            {
                i.LoadCollections();
            }
        }
        private UMLFileCollection getFilesProject()
        {
            return UMLProject.GetInstance().GetUMLFiles();
        }
        private UMLIterationCollection getIterations()
        {
            return this.GetAssociateCollection<UMLIteration, UMLIterationCollection>();
        }

        private void loadIterationPrecedence()
        {
            foreach (UMLIteration i in Iterations)
            {
                UMLIteration aux;

                aux = Helper.GetNext<UMLIteration>(i, Constants.UMLIteration.STEREOTYPEITERATIONPRECEDENCE);
                if (aux != null)
                    i.Next = GetIteration(aux.Guid);
                else
                    i.Last = true;


                aux = Helper.GetPrev<UMLIteration>(i, Constants.UMLIteration.STEREOTYPEITERATIONPRECEDENCE);
                if (aux != null)
                    i.Prev = GetIteration(aux.Guid);
                else
                {
                    i.First = true;
                    FirsIteration = i;
                }
            }
        }





        #endregion

        public bool EstimateFunctionPoints()
        {
            UMLIteration iteration = FirsIteration;


            if (iteration != null)
            {
                EstimateFunctionPoinsForAllFiles();
                ClearVariables();

                //foreach(UMLIteration iteration in Iterations)
                //{
                //    iteration.EstimateFunctionPoints();
                //    this.ActionFunctionPoints += iteration.ActionFunctionPoints;
                //    this.FileFunctionPoints += iteration.FileFunctionPoints;
                //    this.TotalFunctionPoints += iteration.TotalFunctionPoints;
                //}              

                while (iteration != null)
                {
                    iteration.EstimateFunctionPoints();
                    this.ActionFunctionPoints += iteration.ActionFunctionPoints;
                    this.FileFunctionPoints += iteration.FileFunctionPoints;
                    this.TotalFunctionPoints += iteration.TotalFunctionPoints;

                    iteration = iteration.Next;
                }
                //this.Save();

                return true;
            }
            return false;

        }

        private UMLIteration GetIteration(string key)
        {
            foreach (UMLIteration i in Iterations)
            {
                if (i.Guid == key)
                {
                    return i;
                }
            }

            return null;
        }

        public void Save()
        {
            base.Save();
            foreach (UMLIteration iteration in Iterations)
            {
                iteration.MarkModified();
                iteration.Save();
            }

            foreach (UMLFile f in FilesProject)
            {
                f.MarkModified();
                f.Save();
            }

        }


        public void SaveEdit()
        {
            base.Save();
            foreach (UMLIteration iteration in Iterations)
            {
                iteration.MarkModified();
                iteration.SaveEdit();
            }

            foreach (UMLFile f in FilesProject)
            {
                f.MarkModified();
                f.Save();
            }
        }

        public void SaveImport()
        {
            base.Save();
            foreach (UMLIteration iteration in Iterations)
            {
                iteration.SaveImport();
                Helper.CreateAssociation<UMLPhase, UMLIteration>(this, iteration, this.Owner);
            }
        }

        private void ClearVariables()
        {
            ActionFunctionPoints = 0;
            FileFunctionPoints = 0;
            TotalFunctionPoints = 0;
        }

        private void EstimateFunctionPoinsForAllFiles()
        {
            foreach (UMLFile f in FilesProject)
            {
                f.LoadCollections();
                f.EstimateFunctionPoints();
                f.MarkModified();
                f.Save();
            }
        }

        #endregion
    }
}
