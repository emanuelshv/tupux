namespace TUPUX.Forms
{
    partial class FactorList
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
            this.uMLFactorCollectionDataGridView = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbxFactors = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.uMLFactorCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DefinitionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedKey = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SelectedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorCollectionDataGridView)).BeginInit();
            this.gbxFactors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uMLFactorCollectionDataGridView
            // 
            this.uMLFactorCollectionDataGridView.AllowUserToAddRows = false;
            this.uMLFactorCollectionDataGridView.AllowUserToDeleteRows = false;
            this.uMLFactorCollectionDataGridView.AllowUserToResizeColumns = false;
            this.uMLFactorCollectionDataGridView.AllowUserToResizeRows = false;
            this.uMLFactorCollectionDataGridView.AutoGenerateColumns = false;
            this.uMLFactorCollectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uMLFactorCollectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DefinitionName,
            this.SelectedKey,
            this.SelectedValue});
            this.uMLFactorCollectionDataGridView.DataSource = this.uMLFactorCollectionBindingSource;
            this.uMLFactorCollectionDataGridView.Location = new System.Drawing.Point(6, 19);
            this.uMLFactorCollectionDataGridView.MultiSelect = false;
            this.uMLFactorCollectionDataGridView.Name = "uMLFactorCollectionDataGridView";
            this.uMLFactorCollectionDataGridView.RowHeadersWidth = 30;
            this.uMLFactorCollectionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.uMLFactorCollectionDataGridView.Size = new System.Drawing.Size(433, 413);
            this.uMLFactorCollectionDataGridView.TabIndex = 1;
            this.uMLFactorCollectionDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.uMLFactorCollectionDataGridView_DataBindingComplete);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(160, 443);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Effort Adjustment Factor (EAF)";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(339, 440);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbxFactors
            // 
            this.gbxFactors.Controls.Add(this.uMLFactorCollectionDataGridView);
            this.gbxFactors.Controls.Add(this.lblTotal);
            this.gbxFactors.Controls.Add(this.txtTotal);
            this.gbxFactors.Location = new System.Drawing.Point(12, 12);
            this.gbxFactors.Name = "gbxFactors";
            this.gbxFactors.Size = new System.Drawing.Size(445, 470);
            this.gbxFactors.TabIndex = 4;
            this.gbxFactors.TabStop = false;
            this.gbxFactors.Text = "Factors";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(382, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(301, 488);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // uMLFactorCollectionBindingSource
            // 
            this.uMLFactorCollectionBindingSource.DataSource = typeof(TUPUX.Entity.UMLFactorCollection);
            // 
            // DefinitionName
            // 
            this.DefinitionName.DataPropertyName = "DefinitionName";
            this.DefinitionName.HeaderText = "Name";
            this.DefinitionName.Name = "DefinitionName";
            this.DefinitionName.ReadOnly = true;
            this.DefinitionName.Width = 200;
            // 
            // SelectedKey
            // 
            this.SelectedKey.HeaderText = "Select";
            this.SelectedKey.Name = "SelectedKey";
            this.SelectedKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SelectedValue
            // 
            this.SelectedValue.DataPropertyName = "SelectedValue";
            this.SelectedValue.HeaderText = "Value";
            this.SelectedValue.Name = "SelectedValue";
            this.SelectedValue.ReadOnly = true;
            // 
            // FactorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 528);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbxFactors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FactorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FactorList";
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorCollectionDataGridView)).EndInit();
            this.gbxFactors.ResumeLayout(false);
            this.gbxFactors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFactorCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource uMLFactorCollectionBindingSource;
        private System.Windows.Forms.DataGridView uMLFactorCollectionDataGridView;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gbxFactors;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefinitionName;
        private System.Windows.Forms.DataGridViewComboBoxColumn SelectedKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedValue;
    }
}