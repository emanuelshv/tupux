using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;
using System.IO;

namespace TUPUX.Forms
{
    public partial class IterationEdit : FormEdit
    {
        #region Attributes and Properties

        public UMLIteration Iteration
        {
            get { return _element as UMLIteration; }
            set { _element = value; }
        }

        private bool _changed = true;

        #endregion

        public IterationEdit(UMLIteration iteration)
        {
            InitializeComponent();
            Iteration = iteration;
            IterationLoad();
        }

        public IterationEdit()
        {
            InitializeComponent();
            //Iteration = UMLIteration.GetCurrentElement();
            IterationLoad();
        }

        #region Events

        private void btnUseCaseSelect_Click(object sender, EventArgs e)
        {
            ItemSelect<UMLUseCase, UMLUseCaseCollection> useCaseSelect = new ItemSelect<UMLUseCase, UMLUseCaseCollection>(Iteration.UseCases);
            useCaseSelect.ShowDialog(this);            
            if (useCaseSelect.DialogResult == DialogResult.OK)
            {
                Iteration.UseCases = useCaseSelect.SelectedList;
                foreach (UMLUseCase usecase in useCaseSelect.SelectedList)
                {                    
                    usecase.Iteration = this.Iteration;
                }
                this.useCasesBindingSource.DataSource = Iteration.UseCases;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DoSave();           
            this.Close();
        }
                
        private void btnPrev_Click(object sender, EventArgs e)
        {
            //IterationEdit iterationEdit = new IterationEdit((UMLIteration)Iteration.Prev);
            //iterationEdit.Show(this.DockPanel);
            FormEdit form = FormsFactory.GetFormEdit(Iteration.Prev);
            if (this.DockPanel == null)
            {
                form.Show();
            }
            else
            {
                form.Show(this.DockPanel);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //IterationEdit iterationEdit = new IterationEdit((UMLIteration)Iteration.Next);
            //iterationEdit.Show(this.DockPanel);
            FormEdit form = FormsFactory.GetFormEdit(Iteration.Next);
            if (this.DockPanel == null)
            {                
                form.Show();
            }
            else
            {
                form.Show(this.DockPanel);
            }            
        }

        private void btnFactores_Click(object sender, EventArgs e)
        {
            FactorList factorList = new FactorList(this.Iteration.Factors);
            factorList.ShowDialog();
            if (factorList.Change)
            {
                this.Iteration.Factors = factorList.Factors;
                this.Iteration.EAF = factorList.Total;
                this.EAFTextBox.Text =  factorList.Total.ToString();
            }
        }

        #endregion

        #region Methods

        private void IterationLoad()
        {
            Iteration.LoadCollections();
            this.uMLIterationBindingSource.DataSource = Iteration;
            this.useCasesBindingSource.DataSource = Iteration.UseCases;

            if (Iteration.Prev == null)
            {
                this.btnPrev.Enabled = false;
            }

            if (Iteration.Next == null)
            {
                this.btnNext.Enabled = false;
            }

            if (Iteration.Next != null && Iteration.Prev == null)
            {
                prevProductivityTextBox.Enabled = true;
                prevEAFTextBox.Enabled = true;
            }

            this.btnPrev.Visible = false;
            this.btnNext.Visible = false;
        }

        protected override void DoSave()
        {
            //this.useCaseBindingSource.EndEdit();
            Iteration.SaveEdit();
        }

        protected override bool IsChanged()
        {
            _changed = this.Iteration.State != TUPUX.ActiveRecord.RecordState.Loaded;

            foreach (UMLFactor factor in Iteration.Factors)
            {
                _changed |= factor.State != TUPUX.ActiveRecord.RecordState.Loaded;
            }

            return _changed;
        }

        #endregion
    }
}