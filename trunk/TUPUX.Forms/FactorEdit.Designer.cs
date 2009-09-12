namespace TUPUX.Forms
{
    partial class FactorEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label abrevLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactorEdit));
            this.abrevTextBox = new System.Windows.Forms.TextBox();
            this.uMLFactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.gbxValues = new System.Windows.Forms.GroupBox();
            this.txtXH = new System.Windows.Forms.TextBox();
            this.txtVH = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtVL = new System.Windows.Forms.TextBox();
            this.lblXH = new System.Windows.Forms.Label();
            this.lblVH = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblVL = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxFactor = new System.Windows.Forms.GroupBox();
            this.rfvAbbrev = new CustomValidation.RequiredFieldValidator();
            this.rfvName = new CustomValidation.RequiredFieldValidator();
            this.frmValidator = new CustomValidation.FormValidator();
            this.vsFactor = new CustomValidation.ValidationSummary();
            this.rvVL = new CustomValidation.RangeValidator();
            this.rvL = new CustomValidation.RangeValidator();
            this.rvH = new CustomValidation.RangeValidator();
            this.rvVH = new CustomValidation.RangeValidator();
            this.rvXH = new CustomValidation.RangeValidator();
            abrevLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorBindingSource)).BeginInit();
            this.gbxValues.SuspendLayout();
            this.gbxFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfvAbbrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvVH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvXH)).BeginInit();
            this.SuspendLayout();
            // 
            // abrevLabel
            // 
            abrevLabel.AutoSize = true;
            abrevLabel.Location = new System.Drawing.Point(6, 16);
            abrevLabel.Name = "abrevLabel";
            abrevLabel.Size = new System.Drawing.Size(69, 13);
            abrevLabel.TabIndex = 0;
            abrevLabel.Text = "Abbreviation:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 42);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // abrevTextBox
            // 
            this.abrevTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLFactorBindingSource, "Abbrev", true));
            this.abrevTextBox.Location = new System.Drawing.Point(96, 13);
            this.abrevTextBox.Name = "abrevTextBox";
            this.abrevTextBox.Size = new System.Drawing.Size(100, 20);
            this.abrevTextBox.TabIndex = 1;
            // 
            // uMLFactorBindingSource
            // 
            this.uMLFactorBindingSource.DataSource = typeof(TUPUX.Entity.UMLFactor);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLFactorBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(96, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(234, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // gbxValues
            // 
            this.gbxValues.Controls.Add(this.txtXH);
            this.gbxValues.Controls.Add(this.txtVH);
            this.gbxValues.Controls.Add(this.txtH);
            this.gbxValues.Controls.Add(this.txtN);
            this.gbxValues.Controls.Add(this.txtL);
            this.gbxValues.Controls.Add(this.txtVL);
            this.gbxValues.Controls.Add(this.lblXH);
            this.gbxValues.Controls.Add(this.lblVH);
            this.gbxValues.Controls.Add(this.lblH);
            this.gbxValues.Controls.Add(this.lblN);
            this.gbxValues.Controls.Add(this.lblL);
            this.gbxValues.Controls.Add(this.lblVL);
            this.gbxValues.Location = new System.Drawing.Point(12, 88);
            this.gbxValues.Name = "gbxValues";
            this.gbxValues.Size = new System.Drawing.Size(358, 182);
            this.gbxValues.TabIndex = 4;
            this.gbxValues.TabStop = false;
            this.gbxValues.Text = "Values";
            // 
            // txtXH
            // 
            this.txtXH.Location = new System.Drawing.Point(87, 151);
            this.txtXH.Name = "txtXH";
            this.txtXH.Size = new System.Drawing.Size(55, 20);
            this.txtXH.TabIndex = 11;
            // 
            // txtVH
            // 
            this.txtVH.Location = new System.Drawing.Point(87, 125);
            this.txtVH.Name = "txtVH";
            this.txtVH.Size = new System.Drawing.Size(55, 20);
            this.txtVH.TabIndex = 9;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(87, 99);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(55, 20);
            this.txtH.TabIndex = 7;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(87, 73);
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.Size = new System.Drawing.Size(55, 20);
            this.txtN.TabIndex = 5;
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(87, 47);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(55, 20);
            this.txtL.TabIndex = 3;
            // 
            // txtVL
            // 
            this.txtVL.Location = new System.Drawing.Point(87, 21);
            this.txtVL.Name = "txtVL";
            this.txtVL.Size = new System.Drawing.Size(55, 20);
            this.txtVL.TabIndex = 1;
            // 
            // lblXH
            // 
            this.lblXH.AutoSize = true;
            this.lblXH.Location = new System.Drawing.Point(44, 154);
            this.lblXH.Name = "lblXH";
            this.lblXH.Size = new System.Drawing.Size(22, 13);
            this.lblXH.TabIndex = 10;
            this.lblXH.Text = "XH";
            // 
            // lblVH
            // 
            this.lblVH.AutoSize = true;
            this.lblVH.Location = new System.Drawing.Point(44, 125);
            this.lblVH.Name = "lblVH";
            this.lblVH.Size = new System.Drawing.Size(22, 13);
            this.lblVH.TabIndex = 8;
            this.lblVH.Text = "VH";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(44, 98);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(15, 13);
            this.lblH.TabIndex = 6;
            this.lblH.Text = "H";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(44, 73);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 4;
            this.lblN.Text = "N";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(44, 50);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(13, 13);
            this.lblL.TabIndex = 2;
            this.lblL.Text = "L";
            // 
            // lblVL
            // 
            this.lblVL.AutoSize = true;
            this.lblVL.Location = new System.Drawing.Point(44, 24);
            this.lblVL.Name = "lblVL";
            this.lblVL.Size = new System.Drawing.Size(20, 13);
            this.lblVL.TabIndex = 0;
            this.lblVL.Text = "VL";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(113, 276);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(194, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxFactor
            // 
            this.gbxFactor.Controls.Add(abrevLabel);
            this.gbxFactor.Controls.Add(this.abrevTextBox);
            this.gbxFactor.Controls.Add(this.nameTextBox);
            this.gbxFactor.Controls.Add(nameLabel);
            this.gbxFactor.Location = new System.Drawing.Point(12, 12);
            this.gbxFactor.Name = "gbxFactor";
            this.gbxFactor.Size = new System.Drawing.Size(358, 70);
            this.gbxFactor.TabIndex = 0;
            this.gbxFactor.TabStop = false;
            this.gbxFactor.Text = "Factor Info";
            // 
            // rfvAbbrev
            // 
            this.rfvAbbrev.ControlToValidate = this.abrevTextBox;
            this.rfvAbbrev.ErrorMessage = "Abbreviation is empty";
            this.rfvAbbrev.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvAbbrev.Icon")));
            // 
            // rfvName
            // 
            this.rfvName.ControlToValidate = this.nameTextBox;
            this.rfvName.ErrorMessage = "Name is Empty";
            this.rfvName.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvName.Icon")));
            // 
            // frmValidator
            // 
            this.vsFactor.SetDisplayMode(this.frmValidator, CustomValidation.ValidationSummaryDisplayMode.List);
            this.vsFactor.SetErrorCaption(this.frmValidator, "Error Factor");
            this.vsFactor.SetErrorMessage(this.frmValidator, "These filds have errors");
            this.frmValidator.HostingForm = this;
            this.vsFactor.SetShowSummary(this.frmValidator, true);
            // 
            // rvVL
            // 
            this.rvVL.ControlToValidate = this.txtVL;
            this.rvVL.ErrorMessage = "VL(Very Low) is not valid";
            this.rvVL.Icon = ((System.Drawing.Icon)(resources.GetObject("rvVL.Icon")));
            this.rvVL.MaximumValue = "100";
            this.rvVL.MinimumValue = "0";
            this.rvVL.Type = CustomValidation.ValidationDataType.Double;
            // 
            // rvL
            // 
            this.rvL.ControlToValidate = this.txtL;
            this.rvL.ErrorMessage = "L(Low) is not valid";
            this.rvL.Icon = ((System.Drawing.Icon)(resources.GetObject("rvL.Icon")));
            this.rvL.MaximumValue = "100";
            this.rvL.MinimumValue = "0";
            this.rvL.Type = CustomValidation.ValidationDataType.Double;
            // 
            // rvH
            // 
            this.rvH.ControlToValidate = this.txtH;
            this.rvH.ErrorMessage = "H(High) is not valid";
            this.rvH.Icon = ((System.Drawing.Icon)(resources.GetObject("rvH.Icon")));
            this.rvH.MaximumValue = "100";
            this.rvH.MinimumValue = "0";
            this.rvH.Type = CustomValidation.ValidationDataType.Double;
            // 
            // rvVH
            // 
            this.rvVH.ControlToValidate = this.txtVH;
            this.rvVH.ErrorMessage = "VH(Very High) is not valid";
            this.rvVH.Icon = ((System.Drawing.Icon)(resources.GetObject("rvVH.Icon")));
            this.rvVH.MaximumValue = "100";
            this.rvVH.MinimumValue = "0";
            this.rvVH.Type = CustomValidation.ValidationDataType.Double;
            // 
            // rvXH
            // 
            this.rvXH.ControlToValidate = this.txtXH;
            this.rvXH.ErrorMessage = "XH(Extra High) is not valid";
            this.rvXH.Icon = ((System.Drawing.Icon)(resources.GetObject("rvXH.Icon")));
            this.rvXH.MaximumValue = "100";
            this.rvXH.MinimumValue = "0";
            this.rvXH.Type = CustomValidation.ValidationDataType.Double;
            // 
            // FactorEdit
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(383, 307);
            this.Controls.Add(this.gbxFactor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbxValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FactorEdit";
            this.Text = "FactorEdit";
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorBindingSource)).EndInit();
            this.gbxValues.ResumeLayout(false);
            this.gbxValues.PerformLayout();
            this.gbxFactor.ResumeLayout(false);
            this.gbxFactor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfvAbbrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvVH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvXH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource uMLFactorBindingSource;
        private System.Windows.Forms.TextBox abrevTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox gbxValues;
        private System.Windows.Forms.Label lblVH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblVL;
        private System.Windows.Forms.TextBox txtXH;
        private System.Windows.Forms.TextBox txtVH;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtVL;
        private System.Windows.Forms.Label lblXH;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxFactor;
        private CustomValidation.RequiredFieldValidator rfvAbbrev;
        private CustomValidation.RequiredFieldValidator rfvName;
        private CustomValidation.FormValidator frmValidator;
        private CustomValidation.ValidationSummary vsFactor;
        private CustomValidation.RangeValidator rvVL;
        private CustomValidation.RangeValidator rvL;
        private CustomValidation.RangeValidator rvH;
        private CustomValidation.RangeValidator rvVH;
        private CustomValidation.RangeValidator rvXH;
    }
}