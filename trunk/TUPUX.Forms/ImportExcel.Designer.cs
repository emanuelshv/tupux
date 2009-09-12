namespace TUPUX.Forms
{
    partial class ImportExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportExcel));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.bgwImport = new System.ComponentModel.BackgroundWorker();
            this.pbImport = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.frmValidator = new CustomValidation.FormValidator();
            this.validationSummary = new CustomValidation.ValidationSummary();
            this.rfvFileName = new CustomValidation.RequiredFieldValidator();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectFile = new System.Windows.Forms.GroupBox();
            this.labelFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frmValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvFileName)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxSelectFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(35, 16);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(396, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(440, 14);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(74, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Open";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(439, 43);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // bgwImport
            // 
            this.bgwImport.WorkerReportsProgress = true;
            // 
            // pbImport
            // 
            this.pbImport.Location = new System.Drawing.Point(6, 32);
            this.pbImport.Name = "pbImport";
            this.pbImport.Size = new System.Drawing.Size(508, 23);
            this.pbImport.Step = 1;
            this.pbImport.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 16);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "label1";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(9, 31);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(57, 13);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "File Name:";
            // 
            // frmValidator
            // 
            this.frmValidator.HostingForm = this;
            this.frmValidator.ValidateOnAccept = false;
            // 
            // rfvFileName
            // 
            this.rfvFileName.ControlToValidate = this.txtFileName;
            this.rfvFileName.ErrorMessage = "The file name is empty";
            this.rfvFileName.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvFileName.Icon")));
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.pbImport);
            this.groupBoxStatus.Controls.Add(this.lblMessage);
            this.groupBoxStatus.Location = new System.Drawing.Point(12, 92);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(520, 66);
            this.groupBoxStatus.TabIndex = 6;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // groupBoxSelectFile
            // 
            this.groupBoxSelectFile.Controls.Add(this.labelFile);
            this.groupBoxSelectFile.Controls.Add(this.txtFileName);
            this.groupBoxSelectFile.Controls.Add(this.btnImport);
            this.groupBoxSelectFile.Controls.Add(this.btnSelectFile);
            this.groupBoxSelectFile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelectFile.Name = "groupBoxSelectFile";
            this.groupBoxSelectFile.Size = new System.Drawing.Size(520, 74);
            this.groupBoxSelectFile.TabIndex = 7;
            this.groupBoxSelectFile.TabStop = false;
            this.groupBoxSelectFile.Text = "Select File";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(6, 19);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(23, 13);
            this.labelFile.TabIndex = 3;
            this.labelFile.Text = "File";
            // 
            // ImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 164);
            this.Controls.Add(this.groupBoxSelectFile);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.lblFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportExcel";
            this.Text = "ImportExcel";
            ((System.ComponentModel.ISupportInitialize)(this.frmValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvFileName)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxSelectFile.ResumeLayout(false);
            this.groupBoxSelectFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnImport;
        private System.ComponentModel.BackgroundWorker bgwImport;
        private System.Windows.Forms.ProgressBar pbImport;
        private System.Windows.Forms.Label lblMessage;
        private CustomValidation.FormValidator frmValidator;
        private CustomValidation.ValidationSummary validationSummary;
        private CustomValidation.RequiredFieldValidator rfvFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.GroupBox groupBoxSelectFile;
        private System.Windows.Forms.Label labelFile;
    }
}