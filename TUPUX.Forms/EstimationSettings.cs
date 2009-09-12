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
    public partial class EstimationSettings : Form
    {
        #region Attributes and Properties
        
        UMLPhaseCollection _phases;

        #endregion
        
        public EstimationSettings()
        {
            InitializeComponent();
            UMLProject project = UMLProject.GetInstance();
            _phases = project.GetUMLPhases();            
            this.uMLPhaseCollectionBindingSource.DataSource = _phases;
            if (_phases.Count < 1)
                this.btnGenerate.Enabled = false;
        }

        #region Events
        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool complete = true;
            foreach (UMLPhase phase in _phases)
            {
                if (phase.ApplyEstimation)
                {
                    phase.LoadCollections();

                    bool errorinphase = phase.EstimateFunctionPoints();
                    if (errorinphase)
                    {
                        phase.MarkModified();
                        phase.SaveEdit();
                    }
                    else
                    {
                        complete &= errorinphase;
                    }
                }
            }
            
            this.uMLPhaseCollectionBindingSource.DataSource = _phases;
            
            this.uMLPhaseCollectionDataGridView.EndEdit();
            
            if(complete)
                MessageBox.Show("Estimation complete", "Estimation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Estimation complete with errors please review your models.", "Estimation message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.uMLPhaseCollectionDataGridView.Invalidate();
        }

        #endregion
    }
}