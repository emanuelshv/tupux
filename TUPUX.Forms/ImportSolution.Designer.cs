namespace TUPUX.Forms
{
    partial class ImportSolution
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBoxElements = new System.Windows.Forms.GroupBox();
            this.checkBoxInterface = new System.Windows.Forms.CheckBox();
            this.checkBoxEnumeration = new System.Windows.Forms.CheckBox();
            this.checkBoxClass = new System.Windows.Forms.CheckBox();
            this.pbImport = new System.Windows.Forms.ProgressBar();
            this.bgwImport = new System.ComponentModel.BackgroundWorker();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectFile = new System.Windows.Forms.GroupBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.groupBoxElements.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxSelectFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(39, 18);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(390, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(435, 16);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(435, 45);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupBoxElements
            // 
            this.groupBoxElements.Controls.Add(this.checkBoxInterface);
            this.groupBoxElements.Controls.Add(this.checkBoxEnumeration);
            this.groupBoxElements.Controls.Add(this.checkBoxClass);
            this.groupBoxElements.Location = new System.Drawing.Point(11, 45);
            this.groupBoxElements.Name = "groupBoxElements";
            this.groupBoxElements.Size = new System.Drawing.Size(418, 86);
            this.groupBoxElements.TabIndex = 3;
            this.groupBoxElements.TabStop = false;
            this.groupBoxElements.Text = "Elements";
            // 
            // checkBoxInterface
            // 
            this.checkBoxInterface.AutoSize = true;
            this.checkBoxInterface.Checked = true;
            this.checkBoxInterface.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInterface.Location = new System.Drawing.Point(7, 63);
            this.checkBoxInterface.Name = "checkBoxInterface";
            this.checkBoxInterface.Size = new System.Drawing.Size(68, 17);
            this.checkBoxInterface.TabIndex = 2;
            this.checkBoxInterface.Text = "Interface";
            this.checkBoxInterface.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnumeration
            // 
            this.checkBoxEnumeration.AutoSize = true;
            this.checkBoxEnumeration.Checked = true;
            this.checkBoxEnumeration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnumeration.Location = new System.Drawing.Point(7, 40);
            this.checkBoxEnumeration.Name = "checkBoxEnumeration";
            this.checkBoxEnumeration.Size = new System.Drawing.Size(85, 17);
            this.checkBoxEnumeration.TabIndex = 1;
            this.checkBoxEnumeration.Text = "Enumeration";
            this.checkBoxEnumeration.UseVisualStyleBackColor = true;
            // 
            // checkBoxClass
            // 
            this.checkBoxClass.AutoSize = true;
            this.checkBoxClass.Checked = true;
            this.checkBoxClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClass.Location = new System.Drawing.Point(7, 20);
            this.checkBoxClass.Name = "checkBoxClass";
            this.checkBoxClass.Size = new System.Drawing.Size(51, 17);
            this.checkBoxClass.TabIndex = 0;
            this.checkBoxClass.Text = "Class";
            this.checkBoxClass.UseVisualStyleBackColor = true;
            // 
            // pbImport
            // 
            this.pbImport.Location = new System.Drawing.Point(6, 19);
            this.pbImport.Name = "pbImport";
            this.pbImport.Size = new System.Drawing.Size(298, 23);
            this.pbImport.Step = 1;
            this.pbImport.TabIndex = 4;
            // 
            // bgwImport
            // 
            this.bgwImport.WorkerReportsProgress = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(311, 19);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "label1";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.pbImport);
            this.groupBoxStatus.Controls.Add(this.lblMessage);
            this.groupBoxStatus.Location = new System.Drawing.Point(2, 149);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(516, 68);
            this.groupBoxStatus.TabIndex = 6;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // groupBoxSelectFile
            // 
            this.groupBoxSelectFile.Controls.Add(this.labelFile);
            this.groupBoxSelectFile.Controls.Add(this.groupBoxElements);
            this.groupBoxSelectFile.Controls.Add(this.txtFileName);
            this.groupBoxSelectFile.Controls.Add(this.btnImport);
            this.groupBoxSelectFile.Controls.Add(this.btnOpen);
            this.groupBoxSelectFile.Location = new System.Drawing.Point(2, 1);
            this.groupBoxSelectFile.Name = "groupBoxSelectFile";
            this.groupBoxSelectFile.Size = new System.Drawing.Size(516, 142);
            this.groupBoxSelectFile.TabIndex = 7;
            this.groupBoxSelectFile.TabStop = false;
            this.groupBoxSelectFile.Text = "Select File";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(10, 21);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(23, 13);
            this.labelFile.TabIndex = 4;
            this.labelFile.Text = "File";
            // 
            // ImportSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 149);
            this.Controls.Add(this.groupBoxSelectFile);
            this.Controls.Add(this.groupBoxStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportSolution";
            this.Text = "ImportSolution";
            this.groupBoxElements.ResumeLayout(false);
            this.groupBoxElements.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxSelectFile.ResumeLayout(false);
            this.groupBoxSelectFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupBoxElements;
        private System.Windows.Forms.CheckBox checkBoxInterface;
        private System.Windows.Forms.CheckBox checkBoxEnumeration;
        private System.Windows.Forms.CheckBox checkBoxClass;
        private System.Windows.Forms.ProgressBar pbImport;
        private System.ComponentModel.BackgroundWorker bgwImport;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.GroupBox groupBoxSelectFile;
        private System.Windows.Forms.Label labelFile;
    }
}