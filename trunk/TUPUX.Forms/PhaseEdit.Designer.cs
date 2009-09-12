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
            System.Windows.Forms.Label actionFunctionPointsLabel;
            System.Windows.Forms.Label fileFunctionPointsLabel;
            System.Windows.Forms.Label totalFunctionPointsLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.uMLPhaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applyEstimationCheckBox = new System.Windows.Forms.CheckBox();
            this.actionFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.fileFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.totalFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.uMLIterationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedEffort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedProductivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uMLIterationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxIterations = new System.Windows.Forms.GroupBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBoxEstimation = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            nameLabel = new System.Windows.Forms.Label();
            applyEstimationLabel = new System.Windows.Forms.Label();
            actionFunctionPointsLabel = new System.Windows.Forms.Label();
            fileFunctionPointsLabel = new System.Windows.Forms.Label();
            totalFunctionPointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uMLPhaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationBindingSource)).BeginInit();
            this.groupBoxIterations.SuspendLayout();
            this.groupBoxEstimation.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
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
            applyEstimationLabel.Location = new System.Drawing.Point(6, 48);
            applyEstimationLabel.Name = "applyEstimationLabel";
            applyEstimationLabel.Size = new System.Drawing.Size(87, 13);
            applyEstimationLabel.TabIndex = 2;
            applyEstimationLabel.Text = "Apply Estimation:";
            // 
            // actionFunctionPointsLabel
            // 
            actionFunctionPointsLabel.AutoSize = true;
            actionFunctionPointsLabel.Location = new System.Drawing.Point(6, 16);
            actionFunctionPointsLabel.Name = "actionFunctionPointsLabel";
            actionFunctionPointsLabel.Size = new System.Drawing.Size(116, 13);
            actionFunctionPointsLabel.TabIndex = 4;
            actionFunctionPointsLabel.Text = "Action Function Points:";
            // 
            // fileFunctionPointsLabel
            // 
            fileFunctionPointsLabel.AutoSize = true;
            fileFunctionPointsLabel.Location = new System.Drawing.Point(6, 42);
            fileFunctionPointsLabel.Name = "fileFunctionPointsLabel";
            fileFunctionPointsLabel.Size = new System.Drawing.Size(102, 13);
            fileFunctionPointsLabel.TabIndex = 6;
            fileFunctionPointsLabel.Text = "File Function Points:";
            // 
            // totalFunctionPointsLabel
            // 
            totalFunctionPointsLabel.AutoSize = true;
            totalFunctionPointsLabel.Location = new System.Drawing.Point(6, 68);
            totalFunctionPointsLabel.Name = "totalFunctionPointsLabel";
            totalFunctionPointsLabel.Size = new System.Drawing.Size(110, 13);
            totalFunctionPointsLabel.TabIndex = 8;
            totalFunctionPointsLabel.Text = "Total Function Points:";
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
            this.applyEstimationCheckBox.Location = new System.Drawing.Point(99, 43);
            this.applyEstimationCheckBox.Name = "applyEstimationCheckBox";
            this.applyEstimationCheckBox.Size = new System.Drawing.Size(104, 24);
            this.applyEstimationCheckBox.TabIndex = 3;
            // 
            // actionFunctionPointsTextBox
            // 
            this.actionFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLPhaseBindingSource, "ActionFunctionPoints", true));
            this.actionFunctionPointsTextBox.Location = new System.Drawing.Point(128, 13);
            this.actionFunctionPointsTextBox.Name = "actionFunctionPointsTextBox";
            this.actionFunctionPointsTextBox.ReadOnly = true;
            this.actionFunctionPointsTextBox.Size = new System.Drawing.Size(75, 20);
            this.actionFunctionPointsTextBox.TabIndex = 5;
            this.actionFunctionPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileFunctionPointsTextBox
            // 
            this.fileFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLPhaseBindingSource, "FileFunctionPoints", true));
            this.fileFunctionPointsTextBox.Location = new System.Drawing.Point(128, 39);
            this.fileFunctionPointsTextBox.Name = "fileFunctionPointsTextBox";
            this.fileFunctionPointsTextBox.ReadOnly = true;
            this.fileFunctionPointsTextBox.Size = new System.Drawing.Size(75, 20);
            this.fileFunctionPointsTextBox.TabIndex = 7;
            this.fileFunctionPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalFunctionPointsTextBox
            // 
            this.totalFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLPhaseBindingSource, "TotalFunctionPoints", true));
            this.totalFunctionPointsTextBox.Location = new System.Drawing.Point(128, 65);
            this.totalFunctionPointsTextBox.Name = "totalFunctionPointsTextBox";
            this.totalFunctionPointsTextBox.ReadOnly = true;
            this.totalFunctionPointsTextBox.Size = new System.Drawing.Size(75, 20);
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
            this.EstimatedEffort,
            this.EAF,
            this.EstimatedProductivity,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.First,
            this.Last});
            this.uMLIterationDataGridView.DataSource = this.uMLIterationBindingSource;
            this.uMLIterationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uMLIterationDataGridView.Location = new System.Drawing.Point(3, 16);
            this.uMLIterationDataGridView.Name = "uMLIterationDataGridView";
            this.uMLIterationDataGridView.ReadOnly = true;
            this.uMLIterationDataGridView.RowHeadersWidth = 20;
            this.uMLIterationDataGridView.Size = new System.Drawing.Size(880, 147);
            this.uMLIterationDataGridView.TabIndex = 0;
            this.uMLIterationDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uMLIterationDataGridView_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.FillWeight = 91.08049F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // EstimatedEffort
            // 
            this.EstimatedEffort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstimatedEffort.DataPropertyName = "EstimatedEffort";
            this.EstimatedEffort.FillWeight = 91.08049F;
            this.EstimatedEffort.HeaderText = "EstimatedEffort";
            this.EstimatedEffort.Name = "EstimatedEffort";
            this.EstimatedEffort.ReadOnly = true;
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
            // EstimatedProductivity
            // 
            this.EstimatedProductivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstimatedProductivity.DataPropertyName = "EstimatedProductivity";
            this.EstimatedProductivity.FillWeight = 91.08049F;
            this.EstimatedProductivity.HeaderText = "EstimatedProductivity";
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FileFunctionPoints";
            this.dataGridViewTextBoxColumn3.FillWeight = 91.08049F;
            this.dataGridViewTextBoxColumn3.HeaderText = "FileFunctionPoints";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ActionFunctionPoints";
            this.dataGridViewTextBoxColumn4.FillWeight = 91.08049F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ActionFunctionPoints";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalFunctionPoints";
            this.dataGridViewTextBoxColumn5.FillWeight = 91.08049F;
            this.dataGridViewTextBoxColumn5.HeaderText = "TotalFunctionPoints";
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
            this.groupBoxIterations.Location = new System.Drawing.Point(12, 111);
            this.groupBoxIterations.Name = "groupBoxIterations";
            this.groupBoxIterations.Size = new System.Drawing.Size(886, 166);
            this.groupBoxIterations.TabIndex = 11;
            this.groupBoxIterations.TabStop = false;
            this.groupBoxIterations.Text = "Iterations";
            // 
            // btnEstimate
            // 
            this.btnEstimate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstimate.Location = new System.Drawing.Point(568, 283);
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
            this.btnCancel.Location = new System.Drawing.Point(806, 283);
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
            this.btnOk.Location = new System.Drawing.Point(725, 283);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBoxEstimation
            // 
            this.groupBoxEstimation.Controls.Add(actionFunctionPointsLabel);
            this.groupBoxEstimation.Controls.Add(this.actionFunctionPointsTextBox);
            this.groupBoxEstimation.Controls.Add(this.fileFunctionPointsTextBox);
            this.groupBoxEstimation.Controls.Add(fileFunctionPointsLabel);
            this.groupBoxEstimation.Controls.Add(this.totalFunctionPointsTextBox);
            this.groupBoxEstimation.Controls.Add(totalFunctionPointsLabel);
            this.groupBoxEstimation.Location = new System.Drawing.Point(680, 12);
            this.groupBoxEstimation.Name = "groupBoxEstimation";
            this.groupBoxEstimation.Size = new System.Drawing.Size(218, 93);
            this.groupBoxEstimation.TabIndex = 14;
            this.groupBoxEstimation.TabStop = false;
            this.groupBoxEstimation.Text = "Estimation Values";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(nameLabel);
            this.groupBoxInfo.Controls.Add(this.nameTextBox);
            this.groupBoxInfo.Controls.Add(applyEstimationLabel);
            this.groupBoxInfo.Controls.Add(this.applyEstimationCheckBox);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(662, 93);
            this.groupBoxInfo.TabIndex = 15;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Phase Information";
            // 
            // PhaseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 318);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxEstimation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.groupBoxIterations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhaseEdit";
            this.TabText = "PhaseEdit";
            this.Text = "PhaseEdit";
            ((System.ComponentModel.ISupportInitialize)(this.uMLPhaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationBindingSource)).EndInit();
            this.groupBoxIterations.ResumeLayout(false);
            this.groupBoxEstimation.ResumeLayout(false);
            this.groupBoxEstimation.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxEstimation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedEffort;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAF;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedProductivity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn First;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Last;
        private System.Windows.Forms.GroupBox groupBoxInfo;
    }
}