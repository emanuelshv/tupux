namespace TUPUX.Forms
{
    partial class ucRequerimentEdit
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
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label dificultyLabel;
            System.Windows.Forms.Label typeLabel2;
            System.Windows.Forms.Label nameLabel2;
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.priorityComboBox = new TUPUX.Controls.CustomComboBox();
            this.dificultyComboBox = new TUPUX.Controls.CustomComboBox();
            this.requerimentTypeComboBox = new TUPUX.Controls.CustomComboBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.uMLRequerimentCollectionDataGridView = new System.Windows.Forms.DataGridView();
            this.uMLRequerimentCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uMLRequerimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descriptionLabel1 = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            dificultyLabel = new System.Windows.Forms.Label();
            typeLabel2 = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLRequerimentCollectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLRequerimentCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLRequerimentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(3, 80);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(63, 13);
            descriptionLabel1.TabIndex = 20;
            descriptionLabel1.Text = "Description:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(3, 53);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(41, 13);
            priorityLabel.TabIndex = 19;
            priorityLabel.Text = "Priority:";
            // 
            // dificultyLabel
            // 
            dificultyLabel.AutoSize = true;
            dificultyLabel.Location = new System.Drawing.Point(304, 26);
            dificultyLabel.Name = "dificultyLabel";
            dificultyLabel.Size = new System.Drawing.Size(47, 13);
            dificultyLabel.TabIndex = 18;
            dificultyLabel.Text = "Dificulty:";
            // 
            // typeLabel2
            // 
            typeLabel2.AutoSize = true;
            typeLabel2.Location = new System.Drawing.Point(3, 26);
            typeLabel2.Name = "typeLabel2";
            typeLabel2.Size = new System.Drawing.Size(34, 13);
            typeLabel2.TabIndex = 17;
            typeLabel2.Text = "Type:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(3, 0);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(38, 13);
            nameLabel2.TabIndex = 16;
            nameLabel2.Text = "Name:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(descriptionLabel1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.descriptionTextBox1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(priorityLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.priorityComboBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dificultyComboBox, 3, 1);
            this.tableLayoutPanel3.Controls.Add(typeLabel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.requerimentTypeComboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(nameLabel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.nameTextBox2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.uMLRequerimentCollectionDataGridView, 0, 5);
            this.tableLayoutPanel3.Controls.Add(dificultyLabel, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(603, 465);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // descriptionTextBox1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.descriptionTextBox1, 3);
            this.descriptionTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox1.Location = new System.Drawing.Point(73, 83);
            this.descriptionTextBox1.Multiline = true;
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(527, 100);
            this.descriptionTextBox1.TabIndex = 21;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Location = new System.Drawing.Point(73, 56);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(225, 21);
            this.priorityComboBox.TabIndex = 20;
            // 
            // dificultyComboBox
            // 
            this.dificultyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dificultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dificultyComboBox.FormattingEnabled = true;
            this.dificultyComboBox.Location = new System.Drawing.Point(374, 29);
            this.dificultyComboBox.Name = "dificultyComboBox";
            this.dificultyComboBox.Size = new System.Drawing.Size(226, 21);
            this.dificultyComboBox.TabIndex = 19;
            // 
            // requerimentTypeComboBox
            // 
            this.requerimentTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requerimentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requerimentTypeComboBox.FormattingEnabled = true;
            this.requerimentTypeComboBox.Location = new System.Drawing.Point(73, 29);
            this.requerimentTypeComboBox.Name = "requerimentTypeComboBox";
            this.requerimentTypeComboBox.Size = new System.Drawing.Size(225, 21);
            this.requerimentTypeComboBox.TabIndex = 18;
            // 
            // nameTextBox2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.nameTextBox2, 3);
            this.nameTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox2.Location = new System.Drawing.Point(73, 3);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(527, 20);
            this.nameTextBox2.TabIndex = 17;
            // 
            // panel2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel2, 4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 30);
            this.panel2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Image = global::TUPUX.Forms.Properties.Resources.delete;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(519, 3);
            this.button1.MaximumSize = new System.Drawing.Size(75, 23);
            this.button1.MinimumSize = new System.Drawing.Size(75, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Image = global::TUPUX.Forms.Properties.Resources.edit_2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(195, 3);
            this.button2.MaximumSize = new System.Drawing.Size(75, 23);
            this.button2.MinimumSize = new System.Drawing.Size(75, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Tag = "2";
            this.button2.Text = "Edit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Image = global::TUPUX.Forms.Properties.Resources.cancel;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(438, 3);
            this.button3.MaximumSize = new System.Drawing.Size(75, 23);
            this.button3.MinimumSize = new System.Drawing.Size(75, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancel";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = global::TUPUX.Forms.Properties.Resources.file_new;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(276, 3);
            this.button4.MaximumSize = new System.Drawing.Size(75, 23);
            this.button4.MinimumSize = new System.Drawing.Size(75, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "New";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Enabled = false;
            this.button5.Image = global::TUPUX.Forms.Properties.Resources.save;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(357, 3);
            this.button5.MaximumSize = new System.Drawing.Size(75, 23);
            this.button5.MinimumSize = new System.Drawing.Size(75, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Save";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // uMLRequerimentCollectionDataGridView
            // 
            this.uMLRequerimentCollectionDataGridView.AllowUserToAddRows = false;
            this.uMLRequerimentCollectionDataGridView.AllowUserToResizeRows = false;
            this.tableLayoutPanel3.SetColumnSpan(this.uMLRequerimentCollectionDataGridView, 4);
            this.uMLRequerimentCollectionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uMLRequerimentCollectionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uMLRequerimentCollectionDataGridView.Location = new System.Drawing.Point(3, 225);
            this.uMLRequerimentCollectionDataGridView.Name = "uMLRequerimentCollectionDataGridView";
            this.uMLRequerimentCollectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uMLRequerimentCollectionDataGridView.Size = new System.Drawing.Size(597, 237);
            this.uMLRequerimentCollectionDataGridView.TabIndex = 0;
            // 
            // uMLRequerimentCollectionBindingSource
            // 
            this.uMLRequerimentCollectionBindingSource.DataSource = typeof(TUPUX.Entity.UMLRequerimentCollection);
            // 
            // uMLRequerimentBindingSource
            // 
            this.uMLRequerimentBindingSource.DataSource = typeof(TUPUX.Entity.UMLRequeriment);
            // 
            // ucRequerimentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "ucRequerimentEdit";
            this.Size = new System.Drawing.Size(603, 465);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uMLRequerimentCollectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLRequerimentCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMLRequerimentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private TUPUX.Controls.CustomComboBox priorityComboBox;
        private TUPUX.Controls.CustomComboBox dificultyComboBox;
        private TUPUX.Controls.CustomComboBox requerimentTypeComboBox;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView uMLRequerimentCollectionDataGridView;
        private System.Windows.Forms.BindingSource uMLRequerimentCollectionBindingSource;
        private System.Windows.Forms.BindingSource uMLRequerimentBindingSource;
    }
}
