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
    public partial class PhaseEdit : FormEdit
    {
        #region Attributes and Properties

        public UMLPhase Phase
        {
            get { return _element as UMLPhase; }
            set { _element = value; }
        }

        private bool _changed = true;

        #endregion

        public PhaseEdit(UMLPhase phase)
        {
            InitializeComponent();            
            Phase = phase;            
            PhaseLoad();
        }

        public PhaseEdit()
        {
            InitializeComponent();
            PhaseLoad();
        }

        #region Events
        
        private void btnEstimate_Click(object sender, EventArgs e)
        {
            if (Phase.ApplyEstimation)
            {
                if (this.Phase.EstimateFunctionPoints())
                {
                    LoadBinding();
                    this.uMLPhaseBindingSource.ResetBindings(false);
                    this.uMLIterationBindingSource.ResetBindings(false);
                    MessageBox.Show("Estimation complete", "Estimation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The model is not valid please review the relationship betwen iterations", "Estimation Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You can't apply estimation to this phase", "Estimation Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DoSave();
            this._changed = false;            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {            
            DoSave();
            this._changed = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uMLIterationDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UMLIteration iteration = (UMLIteration)this.uMLIterationDataGridView.Rows[e.RowIndex].DataBoundItem;
                FormEdit form = FormsFactory.GetFormEdit(iteration);
                if (this.DockPanel == null)
                {
                    form.Show();
                }
                else
                {
                    form.Show(this.DockPanel);
                }
            }
        }

        #endregion

        #region Methods

        private void PhaseLoad()
        {
            Phase.LoadCollections();
            LoadBinding();
        }

        private void LoadBinding()
        {
            this.uMLPhaseBindingSource.DataSource = Phase;
            this.uMLIterationBindingSource.DataSource = Phase.Iterations;
        }

        protected override void DoSave()
        {
            Phase.MarkModified();
            this.Phase.SaveEdit();
        }

        protected override bool IsChanged()
        {
            _changed = this.Phase.State != TUPUX.ActiveRecord.RecordState.Loaded;
            return _changed;
        }

        #endregion

        private void uMLIterationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (this.uMLIterationDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                {
                    UMLIteration iteration = (UMLIteration)this.uMLIterationDataGridView.Rows[e.RowIndex].DataBoundItem;
                    FactorList factorList = new FactorList(iteration.Factors);
                    factorList.ShowDialog();
                    if (factorList.Change)
                    {
                        iteration.Factors = factorList.Factors;
                        iteration.EAF = factorList.Total;
                        iteration.SaveFactors();
                    }
                }
            }
        }

        private void cvProductivity_Validating(object sender, CustomValidation.CustomValidator.ValidatingCancelEventArgs e)
        {
            if (this.txtProductivity.Text.Length == 0)
            {
                e.Valid = true;
                this.txtProductivity.Text = "0";
            }
            int aux = 0;
            e.Valid = int.TryParse(this.txtProductivity.Text, out aux);
        }

        private void cvEAF_Validating(object sender, CustomValidation.CustomValidator.ValidatingCancelEventArgs e)
        {
            if (this.txtEAF.Text.Length == 0)
            {
                e.Valid = true;
                this.txtEAF.Text = "1";
            }
            int aux = 0;
            e.Valid = int.TryParse(this.txtEAF.Text, out aux);
        }

        private void uMLIterationDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        //private void uMLIterationDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        UMLIteration iteration = (UMLIteration)this.uMLIterationDataGridView.Rows[e.RowIndex].DataBoundItem;
        //        iteration.Save();
        //    }
        //}
    }
}