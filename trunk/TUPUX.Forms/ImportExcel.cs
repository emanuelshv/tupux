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
    public partial class ImportExcel : Form
    {   
        public ImportExcel()
        {
            InitializeComponent();
            lblMessage.Text = "";
            this.Height = 130;
            groupBoxStatus.Visible = false;
        }

        #region Events

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();            
            if (! String.IsNullOrEmpty(openFileDialog.FileName)) 
            {
                this.txtFileName.Text = openFileDialog.FileName;
                frmValidator.Validate();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {            
            if (frmValidator.IsValid)
            {
                bgwImport.WorkerReportsProgress = true;
                bgwImport.WorkerSupportsCancellation = true;

                this.Height = 198;
                groupBoxStatus.Visible = true;

                HelperImport importHelper = new HelperImport(this.txtFileName.Text);

                bgwImport.DoWork += new DoWorkEventHandler(importHelper.Import);
                bgwImport.ProgressChanged += new ProgressChangedEventHandler(bgwImport_ProgressChanged);
                bgwImport.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwImport_RunWorkerCompleted);
                btnImport.Enabled = false;
                bgwImport.RunWorkerAsync();
            }
        }

        private void bgwImport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) return;
            
            lblMessage.Visible = false;
            pbImport.Visible = false;
            btnImport.Enabled = true;
            MessageBox.Show(e.Result.ToString(), "Import elements");
            this.Close();
        }

        private void bgwImport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblMessage.Text = e.UserState.ToString();
            pbImport.Value = e.ProgressPercentage;
        }

        #endregion

    }
}