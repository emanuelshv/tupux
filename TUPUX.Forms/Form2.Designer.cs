namespace TUPUX.Forms
{
    partial class frmFileGenerator
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
            this.pbrMain = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTask1 = new System.Windows.Forms.Label();
            this.lblTask2 = new System.Windows.Forms.Label();
            this.lblTask3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbrMain
            // 
            this.pbrMain.Location = new System.Drawing.Point(12, 113);
            this.pbrMain.Name = "pbrMain";
            this.pbrMain.Size = new System.Drawing.Size(345, 25);
            this.pbrMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTask3);
            this.groupBox1.Controls.Add(this.lblTask2);
            this.groupBox1.Controls.Add(this.lblTask1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial clean-up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "File pre-processing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "File finalization";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(147, 144);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTask1
            // 
            this.lblTask1.AutoSize = true;
            this.lblTask1.Location = new System.Drawing.Point(295, 16);
            this.lblTask1.Name = "lblTask1";
            this.lblTask1.Padding = new System.Windows.Forms.Padding(5);
            this.lblTask1.Size = new System.Drawing.Size(44, 23);
            this.lblTask1.TabIndex = 3;
            this.lblTask1.Text = "[ OK ]";
            this.lblTask1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTask1.Visible = false;
            // 
            // lblTask2
            // 
            this.lblTask2.AutoSize = true;
            this.lblTask2.Location = new System.Drawing.Point(295, 39);
            this.lblTask2.Name = "lblTask2";
            this.lblTask2.Padding = new System.Windows.Forms.Padding(5);
            this.lblTask2.Size = new System.Drawing.Size(44, 23);
            this.lblTask2.TabIndex = 6;
            this.lblTask2.Text = "[ OK ]";
            this.lblTask2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTask2.Visible = false;
            // 
            // lblTask3
            // 
            this.lblTask3.AutoSize = true;
            this.lblTask3.Location = new System.Drawing.Point(295, 62);
            this.lblTask3.Name = "lblTask3";
            this.lblTask3.Padding = new System.Windows.Forms.Padding(5);
            this.lblTask3.Size = new System.Drawing.Size(44, 23);
            this.lblTask3.TabIndex = 7;
            this.lblTask3.Text = "[ OK ]";
            this.lblTask3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTask3.Visible = false;
            // 
            // frmFileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 179);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbrMain);
            this.Name = "frmFileGenerator";
            this.Text = "File Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbrMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTask3;
        private System.Windows.Forms.Label lblTask2;
        private System.Windows.Forms.Label lblTask1;

    }
}