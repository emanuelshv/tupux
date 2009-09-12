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
    }
}