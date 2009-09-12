namespace TUPUX.Forms
{
    partial class FlowEdit
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label typeLabel1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.uMLFlowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeCustomComboBox = new TUPUX.Controls.CustomComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.uMLStepFlowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.uMLStepFlowCollectionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMLStepFlowCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeCustomComboBox1 = new TUPUX.Controls.CustomComboBox();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            typeLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 53);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 27);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(3, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "Type:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(3, 27);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 15;
            nameLabel1.Text = "Name:";
            // 
            // typeLabel1
            // 
            typeLabel1.AutoSize = true;
            typeLabel1.Location = new System.Drawing.Point(3, 0);
            typeLabel1.Name = "typeLabel1";
            typeLabel1.Size = new System.Drawing.Size(34, 13);
            typeLabel1.TabIndex = 16;
            typeLabel1.Text = "Type:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(typeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(descriptionLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(nameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.typeCustomComboBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 382);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.descriptionTextBox, 3);
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLFlowBindingSource, "Description", true));
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(73, 56);
            this.descriptionTextBox.MaximumSize = new System.Drawing.Size(0, 100);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(505, 100);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // uMLFlowBindingSource
            // 
            this.uMLFlowBindingSource.DataSource = typeof(TUPUX.Entity.UMLFlow);
            // 
            // nameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nameTextBox, 3);
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLFlowBindingSource, "Name", true));
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(73, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(505, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // typeCustomComboBox
            // 
            this.typeCustomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.uMLFlowBindingSource, "Type", true));
            this.typeCustomComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCustomComboBox.FormattingEnabled = true;
            this.typeCustomComboBox.Location = new System.Drawing.Point(73, 3);
            this.typeCustomComboBox.Name = "typeCustomComboBox";
            this.typeCustomComboBox.Size = new System.Drawing.Size(214, 21);
            this.typeCustomComboBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Steps";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(typeLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(nameLabel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nameTextBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.uMLStepFlowCollectionDataGridView, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.typeCustomComboBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(581, 382);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // nameTextBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.nameTextBox1, 3);
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLStepFlowBindingSource, "Name", true));
            this.nameTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox1.Location = new System.Drawing.Point(73, 30);
            this.nameTextBox1.Multiline = true;
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(505, 100);
            this.nameTextBox1.TabIndex = 1;
            // 
            // uMLStepFlowBindingSource
            // 
            this.uMLStepFlowBindingSource.DataSource = typeof(TUPUX.Entity.UMLStepFlow);
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
            this.panel1.Location = new System.Drawing.Point(3, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 30);
            this.panel1.TabIndex = 14;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Enabled = false;
            this.removeButton.Image = global::TUPUX.Forms.Properties.Resources.delete;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(497, 3);
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
            this.editButton.Location = new System.Drawing.Point(173, 3);
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
            this.cancelButton.Location = new System.Drawing.Point(416, 3);
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
            this.newButton.Location = new System.Drawing.Point(254, 3);
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
            this.saveButton.Location = new System.Drawing.Point(335, 3);
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
            // uMLStepFlowCollectionDataGridView
            // 
            this.uMLStepFlowCollectionDataGridView.AllowUserToAddRows = false;
            this.uMLStepFlowCollectionDataGridView.AllowUserToResizeRows = false;
            this.uMLStepFlowCollectionDataGridView.AutoGenerateColumns = false;
            this.uMLStepFlowCollectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.tableLayoutPanel2.SetColumnSpan(this.uMLStepFlowCollectionDataGridView, 4);
            this.uMLStepFlowCollectionDataGridView.DataSource = this.uMLStepFlowCollectionBindingSource;
            this.uMLStepFlowCollectionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uMLStepFlowCollectionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uMLStepFlowCollectionDataGridView.Location = new System.Drawing.Point(3, 172);
            this.uMLStepFlowCollectionDataGridView.Name = "uMLStepFlowCollectionDataGridView";
            this.uMLStepFlowCollectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uMLStepFlowCollectionDataGridView.Size = new System.Drawing.Size(575, 207);
            this.uMLStepFlowCollectionDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // uMLStepFlowCollectionBindingSource
            // 
            this.uMLStepFlowCollectionBindingSource.DataSource = typeof(TUPUX.Entity.UMLStepFlowCollection);
            this.uMLStepFlowCollectionBindingSource.PositionChanged += new System.EventHandler(this.uMLStepFlowCollectionBindingSource_PositionChanged);
            // 
            // typeCustomComboBox1
            // 
            this.typeCustomComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.uMLStepFlowBindingSource, "Type", true));
            this.typeCustomComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeCustomComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCustomComboBox1.FormattingEnabled = true;
            this.typeCustomComboBox1.Location = new System.Drawing.Point(73, 3);
            this.typeCustomComboBox1.Name = "typeCustomComboBox1";
            this.typeCustomComboBox1.Size = new System.Drawing.Size(214, 21);
            this.typeCustomComboBox1.TabIndex = 0;
            // 
            // FlowEdit
            // 
            this.ClientSize = new System.Drawing.Size(595, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "FlowEdit";
            this.Load += new System.EventHandler(this.FlowEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TUPUX.Controls.CustomComboBox typeCustomComboBox;
        private System.Windows.Forms.BindingSource uMLFlowBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.BindingSource uMLStepFlowBindingSource;
        private System.Windows.Forms.DataGridView uMLStepFlowCollectionDataGridView;
        private System.Windows.Forms.BindingSource uMLStepFlowCollectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TUPUX.Controls.CustomComboBox typeCustomComboBox1;

    }
}
