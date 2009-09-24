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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowEdit));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.uMLFlowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeCustomComboBox = new TUPUX.Controls.CustomComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uMLStepFlowCollectionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMLStepFlowCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uMLStepFlowCollectionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uMLStepFlowCollectionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionBindingNavigator)).BeginInit();
            this.uMLStepFlowCollectionBindingNavigator.SuspendLayout();
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
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.uMLStepFlowCollectionDataGridView);
            this.tabPage2.Controls.Add(this.uMLStepFlowCollectionBindingNavigator);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Steps";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uMLStepFlowCollectionDataGridView
            // 
            this.uMLStepFlowCollectionDataGridView.AllowUserToOrderColumns = true;
            this.uMLStepFlowCollectionDataGridView.AutoGenerateColumns = false;
            this.uMLStepFlowCollectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.uMLStepFlowCollectionDataGridView.DataSource = this.uMLStepFlowCollectionBindingSource;
            this.uMLStepFlowCollectionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uMLStepFlowCollectionDataGridView.Location = new System.Drawing.Point(3, 28);
            this.uMLStepFlowCollectionDataGridView.Name = "uMLStepFlowCollectionDataGridView";
            this.uMLStepFlowCollectionDataGridView.Size = new System.Drawing.Size(581, 357);
            this.uMLStepFlowCollectionDataGridView.TabIndex = 3;
            this.uMLStepFlowCollectionDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.uMLStepFlowCollectionDataGridView_UserDeletingRow);
            this.uMLStepFlowCollectionDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.uMLStepFlowCollectionDataGridView_RowsAdded);
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
            this.uMLStepFlowCollectionBindingSource.CurrentChanged += new System.EventHandler(this.uMLStepFlowCollectionBindingSource_CurrentChanged);
            this.uMLStepFlowCollectionBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.uMLStepFlowCollectionBindingSource_AddingNew);
            this.uMLStepFlowCollectionBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.uMLStepFlowCollectionBindingSource_ListChanged);
            // 
            // uMLStepFlowCollectionBindingNavigator
            // 
            this.uMLStepFlowCollectionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uMLStepFlowCollectionBindingNavigator.AllowItemReorder = true;
            this.uMLStepFlowCollectionBindingNavigator.BindingSource = this.uMLStepFlowCollectionBindingSource;
            this.uMLStepFlowCollectionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uMLStepFlowCollectionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uMLStepFlowCollectionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uMLStepFlowCollectionBindingNavigatorSaveItem});
            this.uMLStepFlowCollectionBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.uMLStepFlowCollectionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uMLStepFlowCollectionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uMLStepFlowCollectionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uMLStepFlowCollectionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uMLStepFlowCollectionBindingNavigator.Name = "uMLStepFlowCollectionBindingNavigator";
            this.uMLStepFlowCollectionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uMLStepFlowCollectionBindingNavigator.Size = new System.Drawing.Size(581, 25);
            this.uMLStepFlowCollectionBindingNavigator.TabIndex = 2;
            this.uMLStepFlowCollectionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uMLStepFlowCollectionBindingNavigatorSaveItem
            // 
            this.uMLStepFlowCollectionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uMLStepFlowCollectionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uMLStepFlowCollectionBindingNavigatorSaveItem.Image")));
            this.uMLStepFlowCollectionBindingNavigatorSaveItem.Name = "uMLStepFlowCollectionBindingNavigatorSaveItem";
            this.uMLStepFlowCollectionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uMLStepFlowCollectionBindingNavigatorSaveItem.Text = "Save Data";
            this.uMLStepFlowCollectionBindingNavigatorSaveItem.Click += new System.EventHandler(this.uMLStepFlowCollectionBindingNavigatorSaveItem_Click);
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
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLStepFlowCollectionBindingNavigator)).EndInit();
            this.uMLStepFlowCollectionBindingNavigator.ResumeLayout(false);
            this.uMLStepFlowCollectionBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.DataGridView uMLStepFlowCollectionDataGridView;
        private System.Windows.Forms.BindingSource uMLStepFlowCollectionBindingSource;
        private System.Windows.Forms.BindingNavigator uMLStepFlowCollectionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uMLStepFlowCollectionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    }
}
