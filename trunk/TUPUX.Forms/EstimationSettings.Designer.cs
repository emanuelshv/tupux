namespace TUPUX.Forms
{
    partial class EstimationSettings
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
            this.uMLPhaseCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uMLPhaseCollectionDataGridView = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbxPhases = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uMLPhaseCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLPhaseCollectionDataGridView)).BeginInit();
            this.gbxPhases.SuspendLayout();
            this.SuspendLayout();
            // 
            // uMLPhaseCollectionBindingSource
            // 
            this.uMLPhaseCollectionBindingSource.DataSource = typeof(TUPUX.Entity.UMLPhaseCollection);
            // 
            // uMLPhaseCollectionDataGridView
            // 
            this.uMLPhaseCollectionDataGridView.AllowUserToAddRows = false;
            this.uMLPhaseCollectionDataGridView.AllowUserToDeleteRows = false;
            this.uMLPhaseCollectionDataGridView.AutoGenerateColumns = false;
            this.uMLPhaseCollectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.uMLPhaseCollectionDataGridView.DataSource = this.uMLPhaseCollectionBindingSource;
            this.uMLPhaseCollectionDataGridView.Location = new System.Drawing.Point(6, 19);
            this.uMLPhaseCollectionDataGridView.Name = "uMLPhaseCollectionDataGridView";
            this.uMLPhaseCollectionDataGridView.ReadOnly = true;
            this.uMLPhaseCollectionDataGridView.Size = new System.Drawing.Size(451, 220);
            this.uMLPhaseCollectionDataGridView.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(266, 263);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(122, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Estimation";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gbxPhases
            // 
            this.gbxPhases.Controls.Add(this.uMLPhaseCollectionDataGridView);
            this.gbxPhases.Location = new System.Drawing.Point(12, 12);
            this.gbxPhases.Name = "gbxPhases";
            this.gbxPhases.Size = new System.Drawing.Size(463, 245);
            this.gbxPhases.TabIndex = 3;
            this.gbxPhases.TabStop = false;
            this.gbxPhases.Text = "Phases List";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(394, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Phase Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FileFunctionPoints";
            this.dataGridViewTextBoxColumn2.HeaderText = "File UFP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ActionFunctionPoints";
            this.dataGridViewTextBoxColumn3.HeaderText = "Transaction UFP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TotalFunctionPoints";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total UFP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // EstimationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 297);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxPhases);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstimationSettings";
            this.Text = "Generate Phase Estimation";
            ((System.ComponentModel.ISupportInitialize)(this.uMLPhaseCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLPhaseCollectionDataGridView)).EndInit();
            this.gbxPhases.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource uMLPhaseCollectionBindingSource;
        private System.Windows.Forms.DataGridView uMLPhaseCollectionDataGridView;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox gbxPhases;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}