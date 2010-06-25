namespace TUPUX.Forms
{
    partial class FactorsSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactorsSettings));
            this.uMLFactorCollectionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abbrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMLFactorCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveFactors = new System.Windows.Forms.Button();
            this.gbxFactors = new System.Windows.Forms.GroupBox();
            this.navFactors = new TUPUX.Controls.UMLNavigator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnModify = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorCollectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorCollectionBindingSource)).BeginInit();
            this.gbxFactors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navFactors)).BeginInit();
            this.navFactors.SuspendLayout();
            this.SuspendLayout();
            // 
            // uMLFactorCollectionDataGridView
            // 
            this.uMLFactorCollectionDataGridView.AllowUserToAddRows = false;
            this.uMLFactorCollectionDataGridView.AllowUserToDeleteRows = false;
            this.uMLFactorCollectionDataGridView.AutoGenerateColumns = false;
            this.uMLFactorCollectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uMLFactorCollectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Abbrev});
            this.uMLFactorCollectionDataGridView.DataSource = this.uMLFactorCollectionBindingSource;
            this.uMLFactorCollectionDataGridView.Location = new System.Drawing.Point(6, 44);
            this.uMLFactorCollectionDataGridView.MultiSelect = false;
            this.uMLFactorCollectionDataGridView.Name = "uMLFactorCollectionDataGridView";
            this.uMLFactorCollectionDataGridView.ReadOnly = true;
            this.uMLFactorCollectionDataGridView.RowHeadersWidth = 20;
            this.uMLFactorCollectionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.uMLFactorCollectionDataGridView.Size = new System.Drawing.Size(263, 442);
            this.uMLFactorCollectionDataGridView.TabIndex = 1;
            this.uMLFactorCollectionDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uMLFactorCollectionDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Abbrev
            // 
            this.Abbrev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abbrev.DataPropertyName = "Abbrev";
            this.Abbrev.HeaderText = "Abbrev";
            this.Abbrev.Name = "Abbrev";
            this.Abbrev.ReadOnly = true;
            // 
            // uMLFactorCollectionBindingSource
            // 
            this.uMLFactorCollectionBindingSource.DataSource = typeof(TUPUX.Entity.UMLFactorCollection);
            // 
            // btnSaveFactors
            // 
            this.btnSaveFactors.Location = new System.Drawing.Point(106, 514);
            this.btnSaveFactors.Name = "btnSaveFactors";
            this.btnSaveFactors.Size = new System.Drawing.Size(95, 23);
            this.btnSaveFactors.TabIndex = 2;
            this.btnSaveFactors.Text = "Save Factors";
            this.btnSaveFactors.UseVisualStyleBackColor = true;
            this.btnSaveFactors.Click += new System.EventHandler(this.btnSaveFactors_Click);
            // 
            // gbxFactors
            // 
            this.gbxFactors.Controls.Add(this.navFactors);
            this.gbxFactors.Controls.Add(this.uMLFactorCollectionDataGridView);
            this.gbxFactors.Location = new System.Drawing.Point(12, 12);
            this.gbxFactors.Name = "gbxFactors";
            this.gbxFactors.Size = new System.Drawing.Size(275, 496);
            this.gbxFactors.TabIndex = 5;
            this.gbxFactors.TabStop = false;
            this.gbxFactors.Text = "Factors";
            // 
            // navFactors
            // 
            this.navFactors.AddNewItem = null;
            this.navFactors.BindingSource = this.uMLFactorCollectionBindingSource;
            this.navFactors.CountItem = null;
            this.navFactors.DeleteItem = this.bindingNavigatorDeleteItem;
            this.navFactors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator1,
            this.toolStripBtnModify,
            this.bindingNavigatorRefreshItem});
            this.navFactors.Location = new System.Drawing.Point(3, 16);
            this.navFactors.MoveFirstItem = null;
            this.navFactors.MoveLastItem = null;
            this.navFactors.MoveNextItem = null;
            this.navFactors.MovePreviousItem = null;
            this.navFactors.Name = "navFactors";
            this.navFactors.PositionItem = null;
            this.navFactors.Size = new System.Drawing.Size(269, 25);
            this.navFactors.TabIndex = 6;
            this.navFactors.Text = "Factor Navigator ";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnModify
            // 
            this.toolStripBtnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnModify.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnModify.Image")));
            this.toolStripBtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnModify.Name = "toolStripBtnModify";
            this.toolStripBtnModify.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnModify.Text = "Modify";
            this.toolStripBtnModify.Click += new System.EventHandler(this.toolStripBtnModify_Click);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRefreshItem.Image")));
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorRefreshItem.Text = "Refresh";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 514);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Default";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(207, 514);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FactorsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(297, 547);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbxFactors);
            this.Controls.Add(this.btnSaveFactors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FactorsSettings";
            this.Text = "Factors Settings";
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorCollectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorCollectionBindingSource)).EndInit();
            this.gbxFactors.ResumeLayout(false);
            this.gbxFactors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navFactors)).EndInit();
            this.navFactors.ResumeLayout(false);
            this.navFactors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource uMLFactorCollectionBindingSource;
        private System.Windows.Forms.DataGridView uMLFactorCollectionDataGridView;
        private System.Windows.Forms.Button btnSaveFactors;
        private System.Windows.Forms.GroupBox gbxFactors;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private TUPUX.Controls.UMLNavigator navFactors;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.ToolStripButton toolStripBtnModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abbrev;
    }
}