using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;

namespace TUPUX.Forms
{
    public partial class ImportSolution : Form
    {
        private DialogResult _result;
        public ImportSolution()
        {
            InitializeComponent();
            this.groupBoxStatus.Visible = false;
            lblMessage.Text = "";
            this.Height = 181;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            _result = openFileDialog.ShowDialog();
            if (_result == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.FileName;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (_result == DialogResult.OK)
            {
                SolutionImport.IncludeClass = checkBoxClass.Checked;
                SolutionImport.IncludeEnumeration = checkBoxEnumeration.Checked;
                SolutionImport.IncludeInterface = checkBoxInterface.Checked;
                SolutionImport.File = openFileDialog.FileName;
                ChangeState(false);

                bgwImport.WorkerReportsProgress = true;
                bgwImport.WorkerSupportsCancellation = true;

                bgwImport.DoWork += new DoWorkEventHandler(SolutionImport.OpenSolution);
                bgwImport.ProgressChanged += new ProgressChangedEventHandler(bgwImport_ProgressChanged);
                bgwImport.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwImport_RunWorkerCompleted);
                btnImport.Enabled = false;
                bgwImport.RunWorkerAsync();
                //SolutionImport.OpenSolution(openFileDialog.FileName);                
            }
        }

        void bgwImport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChangeState(true);
        }

        void bgwImport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblMessage.Text = e.UserState.ToString();
            pbImport.Value = e.ProgressPercentage;
        }

        private void ChangeState(bool enabled)
        {
            btnImport.Enabled = enabled;
            btnOpen.Enabled = enabled;
            checkBoxClass.Enabled = enabled;
            checkBoxInterface.Enabled = enabled;
            checkBoxEnumeration.Enabled = enabled;
            this.groupBoxStatus.Visible = !enabled;

            if (enabled)
            {
                this.Height = 181;
            }
            else
            {
                this.Height = 255;
            }
        }
    }
}