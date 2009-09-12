using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;
using TUPUX.Estimation;
using TUPUX.Estimation.Action;
using TUPUX.ActiveRecord;
using System.Collections;
using System.Threading;

namespace TUPUX.Forms
{
    public partial class frmFileGenerator : Form, TUPUX.Estimation.IGenerationStageObserver
    {
        private int stage;

        public frmFileGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Thread worker;
            FileGenerator fg = new FileGenerator();

            //reset all displays
            pbrMain.Value = 0;
            lblTask1.Visible = false;
            lblTask2.Visible = false;
            lblTask3.Visible = false;
            btnGenerate.Enabled = false;
            fg.CreateFiles(null);

            //worker = new Thread(new ParameterizedThreadStart(fg.CreateFiles));
            //worker.Start(this);

            //try
            //{
            //    while (worker.IsAlive)
            //    {
            //        Thread.Sleep(100);
            //        renderStage();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(this, ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //MessageBox.Show(this, "Files generated successfully!", "File Generation Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void renderStage()
        {
            if (stage == 1)
            {
                lblTask1.Visible = true;
                pbrMain.Value = 15;
            }
            else if (stage == 2)
            {
                lblTask2.Visible = true;
                pbrMain.Value = 80;
            }
            else if (stage == 3)
            {
                lblTask3.Visible = true;
                pbrMain.Value = 100;
                btnGenerate.Enabled = true;
            }
        }

        void IGenerationStageObserver.setStage(int stageNum)
        {
            this.stage = stageNum;
        }

    }
}