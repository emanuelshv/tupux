namespace TUPUX.Forms
{
    partial class ucFlowEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label typeLabel1;
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.flowTypeComboBox = new TUPUX.Controls.CustomComboBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uMLFlowCollectionDataGridView = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.uMLFlowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uMLFlowCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stereotypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            typeLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowCollectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 53);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(3, 27);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 3;
            nameLabel1.Text = "Name:";
            // 
            // typeLabel1
            // 
            typeLabel1.AutoSize = true;
            typeLabel1.Location = new System.Drawing.Point(319, 0);
            typeLabel1.Name = "typeLabel1";
            typeLabel1.Size = new System.Drawing.Size(34, 13);
            typeLabel1.TabIndex = 12;
            typeLabel1.Text = "Type:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.descriptionTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(descriptionLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(nameLabel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowTypeComboBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(typeLabel1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.uMLFlowCollectionDataGridView, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(633, 486);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.descriptionTextBox, 3);
            this.descriptionTextBox.Location = new System.Drawing.Point(73, 56);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(557, 100);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // flowTypeComboBox
            // 
            this.flowTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.uMLFlowBindingSource, "Type", true));
            this.flowTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowTypeComboBox.Enabled = false;
            this.flowTypeComboBox.FormattingEnabled = true;
            this.flowTypeComboBox.Location = new System.Drawing.Point(389, 3);
            this.flowTypeComboBox.Name = "flowTypeComboBox";
            this.flowTypeComboBox.Size = new System.Drawing.Size(241, 21);
            this.flowTypeComboBox.TabIndex = 0;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.nameTextBox1, 3);
            this.nameTextBox1.Location = new System.Drawing.Point(73, 30);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(557, 20);
            this.nameTextBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 30);
            this.panel1.TabIndex = 14;
            // 
            // uMLFlowCollectionDataGridView
            // 
            this.uMLFlowCollectionDataGridView.AllowUserToAddRows = false;
            this.uMLFlowCollectionDataGridView.AllowUserToResizeRows = false;
            this.uMLFlowCollectionDataGridView.AutoGenerateColumns = false;
            this.uMLFlowCollectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.guidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pathNameDataGridViewTextBoxColumn,
            this.stereotypeDataGridViewTextBoxColumn,
            this.documentationDataGridViewTextBoxColumn,
            this.visibilityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.tableLayoutPanel2.SetColumnSpan(this.uMLFlowCollectionDataGridView, 4);
            this.uMLFlowCollectionDataGridView.DataSource = this.uMLFlowCollectionBindingSource;
            this.uMLFlowCollectionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uMLFlowCollectionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uMLFlowCollectionDataGridView.Location = new System.Drawing.Point(3, 198);
            this.uMLFlowCollectionDataGridView.MultiSelect = false;
            this.uMLFlowCollectionDataGridView.Name = "uMLFlowCollectionDataGridView";
            this.uMLFlowCollectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uMLFlowCollectionDataGridView.Size = new System.Drawing.Size(627, 285);
            this.uMLFlowCollectionDataGridView.TabIndex = 3;
            this.uMLFlowCollectionDataGridView.DoubleClick += new System.EventHandler(this.uMLFlowCollectionDataGridView_DoubleClick);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Enabled = false;
            this.removeButton.Image = global::TUPUX.Forms.Properties.Resources.delete;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(549, 3);
            this.removeButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.removeButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Enabled = false;
            this.editButton.Image = global::TUPUX.Forms.Properties.Resources.edit_2;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(225, 3);
            this.editButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.editButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Tag = "2";
            this.editButton.Text = "Edit";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Enabled = false;
            this.cancelButton.Image = global::TUPUX.Forms.Properties.Resources.cancel;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(468, 3);
            this.cancelButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.cancelButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // newButton
            // 
            this.newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newButton.Image = global::TUPUX.Forms.Properties.Resources.file_new;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(306, 3);
            this.newButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.newButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Image = global::TUPUX.Forms.Properties.Resources.save;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(387, 3);
            this.saveButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.saveButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // uMLFlowBindingSource
            // 
            this.uMLFlowBindingSource.DataSource = typeof(TUPUX.Entity.UMLFlow);
            // 
            // uMLFlowCollectionBindingSource
            // 
            this.uMLFlowCollectionBindingSource.DataSource = typeof(TUPUX.Entity.UMLFlowCollection);
            this.uMLFlowCollectionBindingSource.PositionChanged += new System.EventHandler(this.uMLFlowCollectionBindingSource_PositionChanged);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            // 
            // guidDataGridViewTextBoxColumn
            // 
            this.guidDataGridViewTextBoxColumn.DataPropertyName = "Guid";
            this.guidDataGridViewTextBoxColumn.HeaderText = "Guid";
            this.guidDataGridViewTextBoxColumn.Name = "guidDataGridViewTextBoxColumn";
            this.guidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // pathNameDataGridViewTextBoxColumn
            // 
            this.pathNameDataGridViewTextBoxColumn.DataPropertyName = "PathName";
            this.pathNameDataGridViewTextBoxColumn.HeaderText = "PathName";
            this.pathNameDataGridViewTextBoxColumn.Name = "pathNameDataGridViewTextBoxColumn";
            // 
            // stereotypeDataGridViewTextBoxColumn
            // 
            this.stereotypeDataGridViewTextBoxColumn.DataPropertyName = "Stereotype";
            this.stereotypeDataGridViewTextBoxColumn.HeaderText = "Stereotype";
            this.stereotypeDataGridViewTextBoxColumn.Name = "stereotypeDataGridViewTextBoxColumn";
            // 
            // documentationDataGridViewTextBoxColumn
            // 
            this.documentationDataGridViewTextBoxColumn.DataPropertyName = "Documentation";
            this.documentationDataGridViewTextBoxColumn.HeaderText = "Documentation";
            this.documentationDataGridViewTextBoxColumn.Name = "documentationDataGridViewTextBoxColumn";
            // 
            // visibilityDataGridViewTextBoxColumn
            // 
            this.visibilityDataGridViewTextBoxColumn.DataPropertyName = "Visibility";
            this.visibilityDataGridViewTextBoxColumn.HeaderText = "Visibility";
            this.visibilityDataGridViewTextBoxColumn.Name = "visibilityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucFlowEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucFlowEdit";
            this.Size = new System.Drawing.Size(633, 486);
            this.Load += new System.EventHandler(this.ucFlowEdit_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowCollectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private TUPUX.Controls.CustomComboBox flowTypeComboBox;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView uMLFlowCollectionDataGridView;
        public System.Windows.Forms.BindingSource uMLFlowBindingSource;
        public System.Windows.Forms.BindingSource uMLFlowCollectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stereotypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}
