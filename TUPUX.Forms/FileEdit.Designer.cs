namespace TUPUX.Forms
{
    partial class FileEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label detsLabel;
            System.Windows.Forms.Label retsLabel;
            System.Windows.Forms.Label typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileEdit));
            this.uMLFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.detsTextBox = new System.Windows.Forms.TextBox();
            this.retsTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbxFile = new System.Windows.Forms.GroupBox();
            this.rfvName = new CustomValidation.RequiredFieldValidator();
            this.rfvDets = new CustomValidation.RequiredFieldValidator();
            this.rfvRets = new CustomValidation.RequiredFieldValidator();
            this.rvDets = new CustomValidation.RangeValidator();
            this.rvRets = new CustomValidation.RangeValidator();
            this.frmValidator = new CustomValidation.FormValidator();
            this.validationSummary = new CustomValidation.ValidationSummary();
            nameLabel = new System.Windows.Forms.Label();
            detsLabel = new System.Windows.Forms.Label();
            retsLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFileBindingSource)).BeginInit();
            this.gbxFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvDets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvRets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvDets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvRets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // detsLabel
            // 
            detsLabel.AutoSize = true;
            detsLabel.Location = new System.Drawing.Point(6, 42);
            detsLabel.Name = "detsLabel";
            detsLabel.Size = new System.Drawing.Size(32, 13);
            detsLabel.TabIndex = 2;
            detsLabel.Text = "DET:";
            // 
            // retsLabel
            // 
            retsLabel.AutoSize = true;
            retsLabel.Location = new System.Drawing.Point(6, 68);
            retsLabel.Name = "retsLabel";
            retsLabel.Size = new System.Drawing.Size(32, 13);
            retsLabel.TabIndex = 4;
            retsLabel.Text = "RET:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(6, 95);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "Type:";
            // 
            // uMLFileBindingSource
            // 
            this.uMLFileBindingSource.DataSource = typeof(TUPUX.Entity.UMLFile);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLFileBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(109, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(205, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // detsTextBox
            // 
            this.detsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLFileBindingSource, "Dets", true));
            this.detsTextBox.Location = new System.Drawing.Point(109, 39);
            this.detsTextBox.Name = "detsTextBox";
            this.detsTextBox.Size = new System.Drawing.Size(61, 20);
            this.detsTextBox.TabIndex = 3;
            // 
            // retsTextBox
            // 
            this.retsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLFileBindingSource, "Rets", true));
            this.retsTextBox.Location = new System.Drawing.Point(109, 65);
            this.retsTextBox.Name = "retsTextBox";
            this.retsTextBox.Size = new System.Drawing.Size(61, 20);
            this.retsTextBox.TabIndex = 5;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLFileBindingSource, "Type", true));
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "ILF",
            "EIF"});
            this.typeComboBox.Location = new System.Drawing.Point(109, 92);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(253, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(172, 147);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbxFile
            // 
            this.gbxFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFile.Controls.Add(nameLabel);
            this.gbxFile.Controls.Add(this.nameTextBox);
            this.gbxFile.Controls.Add(this.detsTextBox);
            this.gbxFile.Controls.Add(typeLabel);
            this.gbxFile.Controls.Add(detsLabel);
            this.gbxFile.Controls.Add(this.typeComboBox);
            this.gbxFile.Controls.Add(this.retsTextBox);
            this.gbxFile.Controls.Add(retsLabel);
            this.gbxFile.Location = new System.Drawing.Point(12, 12);
            this.gbxFile.Name = "gbxFile";
            this.gbxFile.Size = new System.Drawing.Size(320, 129);
            this.gbxFile.TabIndex = 0;
            this.gbxFile.TabStop = false;
            this.gbxFile.Text = "File Info";
            // 
            // rfvName
            // 
            this.rfvName.ControlToValidate = this.nameTextBox;
            this.rfvName.ErrorMessage = "Name is empty";
            this.rfvName.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvName.Icon")));
            // 
            // rfvDets
            // 
            this.rfvDets.ControlToValidate = this.detsTextBox;
            this.rfvDets.ErrorMessage = "Dets is empty";
            this.rfvDets.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvDets.Icon")));
            // 
            // rfvRets
            // 
            this.rfvRets.ControlToValidate = this.retsTextBox;
            this.rfvRets.ErrorMessage = "Rets is empty";
            this.rfvRets.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvRets.Icon")));
            // 
            // rvDets
            // 
            this.rvDets.ControlToValidate = this.detsTextBox;
            this.rvDets.ErrorMessage = "Dets is not valid";
            this.rvDets.Icon = ((System.Drawing.Icon)(resources.GetObject("rvDets.Icon")));
            this.rvDets.MaximumValue = "1000";
            this.rvDets.MinimumValue = "0";
            this.rvDets.Type = CustomValidation.ValidationDataType.Integer;
            // 
            // rvRets
            // 
            this.rvRets.ControlToValidate = this.retsTextBox;
            this.rvRets.ErrorMessage = "Rets is not valid";
            this.rvRets.Icon = ((System.Drawing.Icon)(resources.GetObject("rvRets.Icon")));
            this.rvRets.MaximumValue = "1000";
            this.rvRets.MinimumValue = "0";
            this.rvRets.Type = CustomValidation.ValidationDataType.Integer;
            // 
            // frmValidator
            // 
            this.frmValidator.HostingForm = this;
            this.validationSummary.SetShowSummary(this.frmValidator, true);
            // 
            // FileEdit
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(344, 182);
            this.Controls.Add(this.gbxFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileEdit";
            this.TabText = "FileEdit";
            this.Text = "File Edit";
            ((System.ComponentModel.ISupportInitialize)(this.uMLFileBindingSource)).EndInit();
            this.gbxFile.ResumeLayout(false);
            this.gbxFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvDets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvRets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvDets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvRets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmValidator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource uMLFileBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox detsTextBox;
        private System.Windows.Forms.TextBox retsTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbxFile;
        private CustomValidation.RequiredFieldValidator rfvName;
        private CustomValidation.RequiredFieldValidator rfvDets;
        private CustomValidation.RequiredFieldValidator rfvRets;
        private CustomValidation.RangeValidator rvDets;
        private CustomValidation.RangeValidator rvRets;
        private CustomValidation.FormValidator frmValidator;
        private CustomValidation.ValidationSummary validationSummary;
    }
}