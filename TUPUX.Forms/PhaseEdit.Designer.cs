namespace TUPUX.Forms
{
    partial class PhaseEdit
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label applyEstimationLabel;
            System.Windows.Forms.Label totalFunctionPointsLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhaseEdit));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.uMLPhaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applyEstimationCheckBox = new System.Windows.Forms.CheckBox();
            this.actionFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.fileFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.totalFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.uMLIterationDataGridView = new System.Windows.Forms.DataGridView();
            this.uMLIterationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxIterations = new System.Windows.Forms.GroupBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductivity = new System.Windows.Forms.TextBox();
            this.txtEAF = new System.Windows.Forms.TextBox();
            this.rfvName = new CustomValidation.RequiredFieldValidator();
            this.formValidator = new CustomValidation.FormValidator();
            this.validationSummary = new CustomValidation.ValidationSummary();
            this.cvEAF = new CustomValidation.CustomValidator();
            this.cvProductivity = new CustomValidation.CustomValidator();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealEfford = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealProductivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estimacion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EstimatedEffort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedProductivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            applyEstimationLabel = new System.Windows.Forms.Label();
            totalFunctionPointsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uMLPhaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationBindingSource)).BeginInit();
            this.groupBoxIterations.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvEAF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvProductivity)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // applyEstimationLabel
            // 
            applyEstimationLabel.AutoSize = true;
            applyEstimationLabel.Location = new System.Drawing.Point(308, 20);
            applyEstimationLabel.Name = "applyEstimationLabel";
            applyEstimationLabel.Size = new System.Drawing.Size(87, 13);
            applyEstimationLabel.TabIndex = 2;
            applyEstimationLabel.Text = "Apply Estimation:";
            // 
            // totalFunctionPointsLabel
            // 
            totalFunctionPointsLabel.AutoSize = true;
            totalFunctionPointsLabel.Location = new System.Drawing.Point(450, 231);
            totalFunctionPointsLabel.Name = "totalFunctionPointsLabel";
            totalFunctionPointsLabel.Size = new System.Drawing.Size(34, 13);
            totalFunctionPointsLabel.TabIndex = 8;
            totalFunctionPointsLabel.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 0;
            label1.Text = "EAF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(308, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 13);
            label2.TabIndex = 2;
            label2.Text = "Productivity:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLPhaseBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(99, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(203, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // uMLPhaseBindingSource
            // 
            this.uMLPhaseBindingSource.DataSource = typeof(TUPUX.Entity.UMLPhase);
            // 
            // applyEstimationCheckBox
            // 
            this.applyEstimationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uMLPhaseBindingSource, "ApplyEstimation", true));
            this.applyEstimationCheckBox.Location = new System.Drawing.Point(401, 15);
            this.applyEstimationCheckBox.Name = "applyEstimationCheckBox";
            this.applyEstimationCheckBox.Size = new System.Drawing.Size(104, 24);
            this.applyEstimationCheckBox.TabIndex = 3;
            // 
            // actionFunctionPointsTextBox
            // 
            this.actionFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLPhaseBindingSource, "ActionFunctionPoints", true));
            this.actionFunctionPointsTextBox.Location = new System.Drawing.Point(618, 228);
            this.actionFunctionPointsTextBox.Name = "actionFunctionPointsTextBox";
            this.actionFunctionPointsTextBox.ReadOnly = true;
            this.actionFunctionPointsTextBox.Size = new System.Drawing.Size(136, 20);
            this.actionFunctionPointsTextBox.TabIndex = 5;
            this.actionFunctionPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileFunctionPointsTextBox
            // 
            this.fileFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLPhaseBindingSource, "FileFunctionPoints", true));
            this.fileFunctionPointsTextBox.Location = new System.Drawing.Point(490, 228);
            this.fileFunctionPointsTextBox.Name = "fileFunctionPointsTextBox";
            this.fileFunctionPointsTextBox.ReadOnly = true;
            this.fileFunctionPointsTextBox.Size = new System.Drawing.Size(122, 20);
            this.fileFunctionPointsTextBox.TabIndex = 7;
            this.fileFunctionPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalFunctionPointsTextBox
            // 
            this.totalFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLPhaseBindingSource, "TotalFunctionPoints", true));
            this.totalFunctionPointsTextBox.Location = new System.Drawing.Point(760, 228);
            this.totalFunctionPointsTextBox.Name = "totalFunctionPointsTextBox";
            this.totalFunctionPointsTextBox.ReadOnly = true;
            this.totalFunctionPointsTextBox.Size = new System.Drawing.Size(123, 20);
            this.totalFunctionPointsTextBox.TabIndex = 9;
            this.totalFunctionPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uMLIterationDataGridView
            // 
            this.uMLIterationDataGridView.AllowUserToAddRows = false;
            this.uMLIterationDataGridView.AllowUserToDeleteRows = false;
            this.uMLIterationDataGridView.AutoGenerateColumns = false;
            this.uMLIterationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.RealEfford,
            this.RealProductivity,
            this.EAF,
            this.Estimacion,
            this.EstimatedEffort,
            this.EstimatedProductivity,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.First,
            this.Last,
            this.MRE});
            this.uMLIterationDataGridView.DataSource = this.uMLIterationBindingSource;
            this.uMLIterationDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.uMLIterationDataGridView.Location = new System.Drawing.Point(3, 16);
            this.uMLIterationDataGridView.Name = "uMLIterationDataGridView";
            this.uMLIterationDataGridView.RowHeadersWidth = 20;
            this.uMLIterationDataGridView.Size = new System.Drawing.Size(880, 206);
            this.uMLIterationDataGridView.TabIndex = 0;
            this.uMLIterationDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uMLIterationDataGridView_CellClick);
            this.uMLIterationDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uMLIterationDataGridView_CellMouseDoubleClick);
            this.uMLIterationDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.uMLIterationDataGridView_DataError);
            // 
            // uMLIterationBindingSource
            // 
            this.uMLIterationBindingSource.DataSource = typeof(TUPUX.Entity.UMLIteration);
            // 
            // groupBoxIterations
            // 
            this.groupBoxIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIterations.Controls.Add(this.uMLIterationDataGridView);
            this.groupBoxIterations.Controls.Add(this.fileFunctionPointsTextBox);
            this.groupBoxIterations.Controls.Add(totalFunctionPointsLabel);
            this.groupBoxIterations.Controls.Add(this.totalFunctionPointsTextBox);
            this.groupBoxIterations.Controls.Add(this.actionFunctionPointsTextBox);
            this.groupBoxIterations.Location = new System.Drawing.Point(12, 128);
            this.groupBoxIterations.Name = "groupBoxIterations";
            this.groupBoxIterations.Size = new System.Drawing.Size(886, 257);
            this.groupBoxIterations.TabIndex = 11;
            this.groupBoxIterations.TabStop = false;
            this.groupBoxIterations.Text = "Iterations";
            // 
            // btnEstimate
            // 
            this.btnEstimate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstimate.Location = new System.Drawing.Point(568, 391);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(151, 23);
            this.btnEstimate.TabIndex = 10;
            this.btnEstimate.Text = "Estimate Function Points";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(806, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(725, 391);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(nameLabel);
            this.groupBoxInfo.Controls.Add(this.nameTextBox);
            this.groupBoxInfo.Controls.Add(applyEstimationLabel);
            this.groupBoxInfo.Controls.Add(this.applyEstimationCheckBox);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(886, 52);
            this.groupBoxInfo.TabIndex = 15;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Phase Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductivity);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtEAF);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 52);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History Information";
            // 
            // txtProductivity
            // 
            this.txtProductivity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLPhaseBindingSource, "ProductivityHistory", true));
            this.txtProductivity.Location = new System.Drawing.Point(401, 17);
            this.txtProductivity.Name = "txtProductivity";
            this.txtProductivity.Size = new System.Drawing.Size(203, 20);
            this.txtProductivity.TabIndex = 3;
            // 
            // txtEAF
            // 
            this.txtEAF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLPhaseBindingSource, "EAFHistory", true));
            this.txtEAF.Location = new System.Drawing.Point(99, 17);
            this.txtEAF.Name = "txtEAF";
            this.txtEAF.Size = new System.Drawing.Size(203, 20);
            this.txtEAF.TabIndex = 1;
            // 
            // rfvName
            // 
            this.rfvName.ControlToValidate = this.nameTextBox;
            this.rfvName.ErrorMessage = "Name is empty";
            this.rfvName.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvName.Icon")));
            // 
            // formValidator
            // 
            this.formValidator.HostingForm = this;
            // 
            // cvEAF
            // 
            this.cvEAF.ControlToValidate = this.txtEAF;
            this.cvEAF.ErrorMessage = "EAF is invalid";
            this.cvEAF.Icon = ((System.Drawing.Icon)(resources.GetObject("cvEAF.Icon")));
            this.cvEAF.Validating += new CustomValidation.CustomValidator.ValidatingEventHandler(this.cvEAF_Validating);
            // 
            // cvProductivity
            // 
            this.cvProductivity.ControlToValidate = this.txtProductivity;
            this.cvProductivity.ErrorMessage = "Productivity in invalid";
            this.cvProductivity.Icon = ((System.Drawing.Icon)(resources.GetObject("cvProductivity.Icon")));
            this.cvProductivity.Validating += new CustomValidation.CustomValidator.ValidatingEventHandler(this.cvProductivity_Validating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.FillWeight = 91.08049F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Iteration Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // RealEfford
            // 
            this.RealEfford.DataPropertyName = "RealEffort";
            this.RealEfford.HeaderText = "Real Effort";
            this.RealEfford.Name = "RealEfford";
            // 
            // RealProductivity
            // 
            this.RealProductivity.DataPropertyName = "RealProductivity";
            this.RealProductivity.HeaderText = "Real Productivity";
            this.RealProductivity.Name = "RealProductivity";
            // 
            // EAF
            // 
            this.EAF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EAF.DataPropertyName = "EAF";
            this.EAF.FillWeight = 40F;
            this.EAF.HeaderText = "EAF";
            this.EAF.Name = "EAF";
            this.EAF.ReadOnly = true;
            // 
            // Estimacion
            // 
            this.Estimacion.HeaderText = "   ";
            this.Estimacion.Name = "Estimacion";
            this.Estimacion.ReadOnly = true;
            this.Estimacion.Width = 20;
            // 
            // EstimatedEffort
            // 
            this.EstimatedEffort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstimatedEffort.DataPropertyName = "EstimatedEffort";
            this.EstimatedEffort.FillWeight = 91.08049F;
            this.EstimatedEffort.HeaderText = "Estimated Effort";
            this.EstimatedEffort.Name = "EstimatedEffort";
            this.EstimatedEffort.ReadOnly = true;
            // 
            // EstimatedProductivity
            // 
            this.EstimatedProductivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstimatedProductivity.DataPropertyName = "EstimatedProductivity";
            this.EstimatedProductivity.FillWeight = 91.08049F;
            this.EstimatedProductivity.HeaderText = "Estimated Productivity";
            this.EstimatedProductivity.Name = "EstimatedProductivity";
            this.EstimatedProductivity.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ApplyEstimation";
            this.dataGridViewCheckBoxColumn1.FillWeight = 91.08049F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "ApplyEstimation";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FileFunctionPoints";
            this.dataGridViewTextBoxColumn3.FillWeight = 91.08049F;
            this.dataGridViewTextBoxColumn3.HeaderText = "File UFP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ActionFunctionPoints";
            this.dataGridViewTextBoxColumn4.FillWeight = 91.08049F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Transaction UFP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalFunctionPoints";
            this.dataGridViewTextBoxColumn5.FillWeight = 91.08049F;
            this.dataGridViewTextBoxColumn5.HeaderText = "UFP";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // First
            // 
            this.First.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.First.DataPropertyName = "First";
            this.First.HeaderText = "First";
            this.First.Name = "First";
            this.First.ReadOnly = true;
            this.First.Visible = false;
            // 
            // Last
            // 
            this.Last.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Last.DataPropertyName = "Last";
            this.Last.HeaderText = "Last";
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            this.Last.Visible = false;
            // 
            // MRE
            // 
            this.MRE.DataPropertyName = "MRE";
            this.MRE.HeaderText = "MRE";
            this.MRE.Name = "MRE";
            this.MRE.ReadOnly = true;
            // 
            // PhaseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.groupBoxIterations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhaseEdit";
            this.TabText = "Phase Edit";
            this.Text = "Phase Edit";
            ((System.ComponentModel.ISupportInitialize)(this.uMLPhaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationBindingSource)).EndInit();
            this.groupBoxIterations.ResumeLayout(false);
            this.groupBoxIterations.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvEAF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvProductivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource uMLPhaseBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox applyEstimationCheckBox;
        private System.Windows.Forms.TextBox actionFunctionPointsTextBox;
        private System.Windows.Forms.TextBox fileFunctionPointsTextBox;
        private System.Windows.Forms.TextBox totalFunctionPointsTextBox;
        private System.Windows.Forms.BindingSource uMLIterationBindingSource;
        private System.Windows.Forms.DataGridView uMLIterationDataGridView;
        private System.Windows.Forms.GroupBox groupBoxIterations;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductivity;
        private System.Windows.Forms.TextBox txtEAF;
        private CustomValidation.RequiredFieldValidator rfvName;
        private CustomValidation.FormValidator formValidator;
        private CustomValidation.ValidationSummary validationSummary;
        private CustomValidation.CustomValidator cvEAF;
        private CustomValidation.CustomValidator cvProductivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealEfford;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealProductivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAF;
        private System.Windows.Forms.DataGridViewButtonColumn Estimacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedEffort;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedProductivity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn First;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRE;
    }
}