namespace TUPUX.Forms
{
    partial class IterationEdit
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
            System.Windows.Forms.Label EAFLabel;
            System.Windows.Forms.Label estimatedEffortLabel;
            System.Windows.Forms.Label estimatedProductivityLlabel;
            System.Windows.Forms.Label previusProductivityLabel;
            System.Windows.Forms.Label prevEAF;
            System.Windows.Forms.Label realProductivity;
            System.Windows.Forms.Label label2;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.uMLIterationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applyEstimationCheckBox = new System.Windows.Forms.CheckBox();
            this.actionFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.fileFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.totalFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.useCasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useCasesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxUseCase = new System.Windows.Forms.GroupBox();
            this.btnUseCaseSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFactores = new System.Windows.Forms.Button();
            this.groupBoxEstimation = new System.Windows.Forms.GroupBox();
            this.EAFTextBox = new System.Windows.Forms.TextBox();
            this.estimatedProductivityTextBox = new System.Windows.Forms.TextBox();
            this.estimatedEffortTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.realEAFtextBox = new System.Windows.Forms.TextBox();
            this.realProductivitytextBox = new System.Windows.Forms.TextBox();
            this.prevEAFTextBox = new System.Windows.Forms.TextBox();
            this.prevProductivityTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            applyEstimationLabel = new System.Windows.Forms.Label();
            actionFunctionPointsLabel = new System.Windows.Forms.Label();
            fileFunctionPointsLabel = new System.Windows.Forms.Label();
            totalFunctionPointsLabel = new System.Windows.Forms.Label();
            EAFLabel = new System.Windows.Forms.Label();
            estimatedEffortLabel = new System.Windows.Forms.Label();
            estimatedProductivityLlabel = new System.Windows.Forms.Label();
            previusProductivityLabel = new System.Windows.Forms.Label();
            prevEAF = new System.Windows.Forms.Label();
            realProductivity = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useCasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useCasesDataGridView)).BeginInit();
            this.groupBoxUseCase.SuspendLayout();
            this.groupBoxEstimation.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
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
            // applyEstimationLabel
            // 
            applyEstimationLabel.AutoSize = true;
            applyEstimationLabel.Location = new System.Drawing.Point(6, 40);
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
            // EAFLabel
            // 
            EAFLabel.AutoSize = true;
            EAFLabel.Location = new System.Drawing.Point(225, 68);
            EAFLabel.Name = "EAFLabel";
            EAFLabel.Size = new System.Drawing.Size(30, 13);
            EAFLabel.TabIndex = 12;
            EAFLabel.Text = "EAF:";
            // 
            // estimatedEffortLabel
            // 
            estimatedEffortLabel.AutoSize = true;
            estimatedEffortLabel.Location = new System.Drawing.Point(225, 16);
            estimatedEffortLabel.Name = "estimatedEffortLabel";
            estimatedEffortLabel.Size = new System.Drawing.Size(84, 13);
            estimatedEffortLabel.TabIndex = 10;
            estimatedEffortLabel.Text = "Estimated Effort:";
            // 
            // estimatedProductivityLlabel
            // 
            estimatedProductivityLlabel.AutoSize = true;
            estimatedProductivityLlabel.Location = new System.Drawing.Point(225, 42);
            estimatedProductivityLlabel.Name = "estimatedProductivityLlabel";
            estimatedProductivityLlabel.Size = new System.Drawing.Size(114, 13);
            estimatedProductivityLlabel.TabIndex = 11;
            estimatedProductivityLlabel.Text = "Estimated Productivity:";
            // 
            // previusProductivityLabel
            // 
            previusProductivityLabel.AutoSize = true;
            previusProductivityLabel.Location = new System.Drawing.Point(6, 68);
            previusProductivityLabel.Name = "previusProductivityLabel";
            previusProductivityLabel.Size = new System.Drawing.Size(93, 13);
            previusProductivityLabel.TabIndex = 6;
            previusProductivityLabel.Text = "Prev. Productivity:";
            // 
            // prevEAF
            // 
            prevEAF.AutoSize = true;
            prevEAF.Location = new System.Drawing.Point(229, 68);
            prevEAF.Name = "prevEAF";
            prevEAF.Size = new System.Drawing.Size(58, 13);
            prevEAF.TabIndex = 7;
            prevEAF.Text = "Prev. EAF:";
            // 
            // realProductivity
            // 
            realProductivity.AutoSize = true;
            realProductivity.Location = new System.Drawing.Point(7, 97);
            realProductivity.Name = "realProductivity";
            realProductivity.Size = new System.Drawing.Size(90, 13);
            realProductivity.TabIndex = 8;
            realProductivity.Text = "Real Productivity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(229, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 13);
            label2.TabIndex = 11;
            label2.Text = "Real EAF:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(106, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(251, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // uMLIterationBindingSource
            // 
            this.uMLIterationBindingSource.DataSource = typeof(TUPUX.Entity.UMLIteration);
            // 
            // applyEstimationCheckBox
            // 
            this.applyEstimationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uMLIterationBindingSource, "ApplyEstimation", true));
            this.applyEstimationCheckBox.Location = new System.Drawing.Point(106, 35);
            this.applyEstimationCheckBox.Name = "applyEstimationCheckBox";
            this.applyEstimationCheckBox.Size = new System.Drawing.Size(104, 24);
            this.applyEstimationCheckBox.TabIndex = 3;
            // 
            // actionFunctionPointsTextBox
            // 
            this.actionFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "ActionFunctionPoints", true));
            this.actionFunctionPointsTextBox.Location = new System.Drawing.Point(126, 13);
            this.actionFunctionPointsTextBox.Name = "actionFunctionPointsTextBox";
            this.actionFunctionPointsTextBox.ReadOnly = true;
            this.actionFunctionPointsTextBox.Size = new System.Drawing.Size(75, 20);
            this.actionFunctionPointsTextBox.TabIndex = 5;
            this.actionFunctionPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileFunctionPointsTextBox
            // 
            this.fileFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "FileFunctionPoints", true));
            this.fileFunctionPointsTextBox.Location = new System.Drawing.Point(126, 39);
            this.fileFunctionPointsTextBox.Name = "fileFunctionPointsTextBox";
            this.fileFunctionPointsTextBox.ReadOnly = true;
            this.fileFunctionPointsTextBox.Size = new System.Drawing.Size(75, 20);
            this.fileFunctionPointsTextBox.TabIndex = 7;
            this.fileFunctionPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalFunctionPointsTextBox
            // 
            this.totalFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "TotalFunctionPoints", true));
            this.totalFunctionPointsTextBox.Location = new System.Drawing.Point(126, 65);
            this.totalFunctionPointsTextBox.Name = "totalFunctionPointsTextBox";
            this.totalFunctionPointsTextBox.ReadOnly = true;
            this.totalFunctionPointsTextBox.Size = new System.Drawing.Size(75, 20);
            this.totalFunctionPointsTextBox.TabIndex = 9;
            this.totalFunctionPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // useCasesBindingSource
            // 
            this.useCasesBindingSource.DataMember = "UseCases";
            this.useCasesBindingSource.DataSource = this.uMLIterationBindingSource;
            // 
            // useCasesDataGridView
            // 
            this.useCasesDataGridView.AllowUserToAddRows = false;
            this.useCasesDataGridView.AllowUserToDeleteRows = false;
            this.useCasesDataGridView.AutoGenerateColumns = false;
            this.useCasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.useCasesDataGridView.DataSource = this.useCasesBindingSource;
            this.useCasesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useCasesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.useCasesDataGridView.Name = "useCasesDataGridView";
            this.useCasesDataGridView.ReadOnly = true;
            this.useCasesDataGridView.Size = new System.Drawing.Size(787, 262);
            this.useCasesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Purpose";
            this.dataGridViewTextBoxColumn4.HeaderText = "Purpose";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Resume";
            this.dataGridViewTextBoxColumn5.HeaderText = "Resume";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBoxUseCase
            // 
            this.groupBoxUseCase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUseCase.Controls.Add(this.useCasesDataGridView);
            this.groupBoxUseCase.Location = new System.Drawing.Point(7, 141);
            this.groupBoxUseCase.Name = "groupBoxUseCase";
            this.groupBoxUseCase.Size = new System.Drawing.Size(793, 281);
            this.groupBoxUseCase.TabIndex = 11;
            this.groupBoxUseCase.TabStop = false;
            this.groupBoxUseCase.Text = "Use Cases";
            // 
            // btnUseCaseSelect
            // 
            this.btnUseCaseSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseCaseSelect.Location = new System.Drawing.Point(365, 428);
            this.btnUseCaseSelect.Name = "btnUseCaseSelect";
            this.btnUseCaseSelect.Size = new System.Drawing.Size(106, 23);
            this.btnUseCaseSelect.TabIndex = 1;
            this.btnUseCaseSelect.Text = "Select Use Case";
            this.btnUseCaseSelect.UseVisualStyleBackColor = true;
            this.btnUseCaseSelect.Click += new System.EventHandler(this.btnUseCaseSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(724, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(643, 428);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(113, 428);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next Iteration";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Location = new System.Drawing.Point(12, 428);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(95, 23);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "Prev Iteration";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFactores
            // 
            this.btnFactores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFactores.Location = new System.Drawing.Point(477, 428);
            this.btnFactores.Name = "btnFactores";
            this.btnFactores.Size = new System.Drawing.Size(160, 23);
            this.btnFactores.TabIndex = 10;
            this.btnFactores.Text = "Effort Adjustment Factor (EAF)";
            this.btnFactores.UseVisualStyleBackColor = true;
            this.btnFactores.Click += new System.EventHandler(this.btnFactores_Click);
            // 
            // groupBoxEstimation
            // 
            this.groupBoxEstimation.Controls.Add(this.EAFTextBox);
            this.groupBoxEstimation.Controls.Add(this.estimatedProductivityTextBox);
            this.groupBoxEstimation.Controls.Add(this.estimatedEffortTextBox);
            this.groupBoxEstimation.Controls.Add(EAFLabel);
            this.groupBoxEstimation.Controls.Add(estimatedEffortLabel);
            this.groupBoxEstimation.Controls.Add(estimatedProductivityLlabel);
            this.groupBoxEstimation.Controls.Add(totalFunctionPointsLabel);
            this.groupBoxEstimation.Controls.Add(this.actionFunctionPointsTextBox);
            this.groupBoxEstimation.Controls.Add(actionFunctionPointsLabel);
            this.groupBoxEstimation.Controls.Add(this.fileFunctionPointsTextBox);
            this.groupBoxEstimation.Controls.Add(fileFunctionPointsLabel);
            this.groupBoxEstimation.Controls.Add(this.totalFunctionPointsTextBox);
            this.groupBoxEstimation.Location = new System.Drawing.Point(376, 12);
            this.groupBoxEstimation.Name = "groupBoxEstimation";
            this.groupBoxEstimation.Size = new System.Drawing.Size(424, 123);
            this.groupBoxEstimation.TabIndex = 16;
            this.groupBoxEstimation.TabStop = false;
            this.groupBoxEstimation.Text = "Estimation Values";
            // 
            // EAFTextBox
            // 
            this.EAFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "EAF", true));
            this.EAFTextBox.Location = new System.Drawing.Point(342, 65);
            this.EAFTextBox.Name = "EAFTextBox";
            this.EAFTextBox.ReadOnly = true;
            this.EAFTextBox.Size = new System.Drawing.Size(75, 20);
            this.EAFTextBox.TabIndex = 15;
            this.EAFTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // estimatedProductivityTextBox
            // 
            this.estimatedProductivityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "EstimatedProductivity", true));
            this.estimatedProductivityTextBox.Location = new System.Drawing.Point(342, 39);
            this.estimatedProductivityTextBox.Name = "estimatedProductivityTextBox";
            this.estimatedProductivityTextBox.ReadOnly = true;
            this.estimatedProductivityTextBox.Size = new System.Drawing.Size(75, 20);
            this.estimatedProductivityTextBox.TabIndex = 14;
            this.estimatedProductivityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // estimatedEffortTextBox
            // 
            this.estimatedEffortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "EstimatedEffort", true));
            this.estimatedEffortTextBox.Location = new System.Drawing.Point(342, 13);
            this.estimatedEffortTextBox.Name = "estimatedEffortTextBox";
            this.estimatedEffortTextBox.ReadOnly = true;
            this.estimatedEffortTextBox.Size = new System.Drawing.Size(75, 20);
            this.estimatedEffortTextBox.TabIndex = 13;
            this.estimatedEffortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(label2);
            this.groupBoxInfo.Controls.Add(this.realEAFtextBox);
            this.groupBoxInfo.Controls.Add(this.realProductivitytextBox);
            this.groupBoxInfo.Controls.Add(realProductivity);
            this.groupBoxInfo.Controls.Add(prevEAF);
            this.groupBoxInfo.Controls.Add(previusProductivityLabel);
            this.groupBoxInfo.Controls.Add(this.prevEAFTextBox);
            this.groupBoxInfo.Controls.Add(this.prevProductivityTextBox);
            this.groupBoxInfo.Controls.Add(nameLabel);
            this.groupBoxInfo.Controls.Add(this.nameTextBox);
            this.groupBoxInfo.Controls.Add(this.applyEstimationCheckBox);
            this.groupBoxInfo.Controls.Add(applyEstimationLabel);
            this.groupBoxInfo.Location = new System.Drawing.Point(7, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(363, 123);
            this.groupBoxInfo.TabIndex = 17;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Iteration Information";
            // 
            // realEAFtextBox
            // 
            this.realEAFtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "RealEffort", true));
            this.realEAFtextBox.Location = new System.Drawing.Point(293, 91);
            this.realEAFtextBox.Name = "realEAFtextBox";
            this.realEAFtextBox.Size = new System.Drawing.Size(64, 20);
            this.realEAFtextBox.TabIndex = 10;
            // 
            // realProductivitytextBox
            // 
            this.realProductivitytextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "RealProductivity", true));
            this.realProductivitytextBox.Location = new System.Drawing.Point(106, 91);
            this.realProductivitytextBox.Name = "realProductivitytextBox";
            this.realProductivitytextBox.Size = new System.Drawing.Size(64, 20);
            this.realProductivitytextBox.TabIndex = 9;
            // 
            // prevEAFTextBox
            // 
            this.prevEAFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "EAFHistory", true));
            this.prevEAFTextBox.Enabled = false;
            this.prevEAFTextBox.Location = new System.Drawing.Point(293, 65);
            this.prevEAFTextBox.Name = "prevEAFTextBox";
            this.prevEAFTextBox.Size = new System.Drawing.Size(64, 20);
            this.prevEAFTextBox.TabIndex = 5;
            // 
            // prevProductivityTextBox
            // 
            this.prevProductivityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLIterationBindingSource, "ProductivityHistory", true));
            this.prevProductivityTextBox.Enabled = false;
            this.prevProductivityTextBox.Location = new System.Drawing.Point(106, 65);
            this.prevProductivityTextBox.Name = "prevProductivityTextBox";
            this.prevProductivityTextBox.Size = new System.Drawing.Size(64, 20);
            this.prevProductivityTextBox.TabIndex = 4;
            // 
            // IterationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 463);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnUseCaseSelect);
            this.Controls.Add(this.groupBoxEstimation);
            this.Controls.Add(this.btnFactores);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxUseCase);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IterationEdit";
            this.TabText = "IterationEdit";
            this.Text = "Iteration Edit";
            ((System.ComponentModel.ISupportInitialize)(this.uMLIterationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useCasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useCasesDataGridView)).EndInit();
            this.groupBoxUseCase.ResumeLayout(false);
            this.groupBoxEstimation.ResumeLayout(false);
            this.groupBoxEstimation.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource uMLIterationBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox applyEstimationCheckBox;
        private System.Windows.Forms.TextBox actionFunctionPointsTextBox;
        private System.Windows.Forms.TextBox fileFunctionPointsTextBox;
        private System.Windows.Forms.TextBox totalFunctionPointsTextBox;
        private System.Windows.Forms.BindingSource useCasesBindingSource;
        private System.Windows.Forms.DataGridView useCasesDataGridView;
        private System.Windows.Forms.GroupBox groupBoxUseCase;
        private System.Windows.Forms.Button btnUseCaseSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFactores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBoxEstimation;
        private System.Windows.Forms.TextBox EAFTextBox;
        private System.Windows.Forms.TextBox estimatedProductivityTextBox;
        private System.Windows.Forms.TextBox estimatedEffortTextBox;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox prevEAFTextBox;
        private System.Windows.Forms.TextBox prevProductivityTextBox;
        private System.Windows.Forms.TextBox realEAFtextBox;
        private System.Windows.Forms.TextBox realProductivitytextBox;
    }
}