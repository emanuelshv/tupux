using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;
using TUPUX.Controls;
using TUPUX.ActiveRecord;

namespace TUPUX.Forms
{
    public partial class UseCaseEdit : TUPUX.Forms.FormEdit
    {
        #region Properties
        public UMLUseCase UseCase
        {
            get { return _element as UMLUseCase; }
            set
            {
                _element = value;
                this.uMLUseCaseBindingSource.DataSource = value;
                this.uMLFlowCollectionBindingSource.DataSource = value.GetFlows();
                this.uMLRequerimentCollectionBindingSource.DataSource = value.GetRequeriments();
            }
        }
        #endregion

        #region Contructors
        public UseCaseEdit()
        {
            InitializeComponent();
        }

        public UseCaseEdit(UMLUseCase useCase)
        {
            InitializeComponent();

            this.DataBindings.Add(new System.Windows.Forms.Binding("Name", this.uMLUseCaseBindingSource, "PathName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "New Use Case"));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLUseCaseBindingSource, "PathName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "New Use Case"));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TabText", this.uMLUseCaseBindingSource, "PathName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "New Use Case"));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ToolTipText", this.uMLUseCaseBindingSource, "PathName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "New Use Case"));

            this.UseCase = useCase;
        }
        #endregion

        #region Form Events
        private void UseCaseEdit_Load(object sender, EventArgs e)
        {
            this.useCaseTypeComboBox.DataSource = Properties.Settings.Default.UseCaseType;
            this.flowTypeComboBox.DataSource = Properties.Settings.Default.FlowType;
            this.requerimentTypeComboBox.DataSource = Properties.Settings.Default.RequerimentType;
            this.dificultyComboBox.DataSource = Properties.Settings.Default.Dificulty;
            this.priorityComboBox.DataSource = Properties.Settings.Default.Priority;

            this.LockFlowControls(true);
        }
        #endregion

        #region FormEdit Methods
        protected override void DoSave()
        {
            this.UseCase.Save();
        }

        protected override bool IsChanged()
        {
            if (this.UseCase.State != RecordState.Loaded)
                return true;

            return false;
        }

        #endregion

        #region Button Methods
        private void newButton_Click(object sender, EventArgs e)
        {
            UMLFlow flow = new UMLFlow();
            flow.Owner = this.UseCase;
            this.uMLFlowBindingSource.DataSource = flow;

            this.LockFlowControls(false);
            this.uMLFlowCollectionDataGridView.Enabled = false;

            this.flowTypeComboBox.SelectedIndex = 0;

            this.editButton.Enabled = false;
            this.newButton.Enabled = false;
            this.cancelButton.Enabled = true;
            this.saveButton.Enabled = true;
            this.removeButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.uMLFlowBindingSource.Current != null)
            {
                this.uMLFlowBindingSource.EndEdit();


                UMLFlow flow = this.uMLFlowBindingSource.Current as UMLFlow;

                if (flow.State == RecordState.Created)
                {
                    this.uMLFlowCollectionBindingSource.Add(flow);
                    this.uMLFlowCollectionBindingSource.Position = this.uMLFlowCollectionBindingSource.IndexOf(flow);
                }

                flow.Save();

                this.LockFlowControls(true);
                this.uMLFlowCollectionDataGridView.Enabled = true;

                this.editButton.Enabled = true;
                this.newButton.Enabled = true;
                this.cancelButton.Enabled = false;
                this.saveButton.Enabled = false;
                this.removeButton.Enabled = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.uMLFlowBindingSource.Current != null)
            {
                this.LockFlowControls(false);
                this.uMLFlowCollectionDataGridView.Enabled = false;

                this.editButton.Enabled = false;
                this.newButton.Enabled = false;
                this.cancelButton.Enabled = true;
                this.saveButton.Enabled = true;
                this.removeButton.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.uMLFlowBindingSource.Current != null)
            {
                this.LockFlowControls(true);
                this.uMLFlowCollectionDataGridView.Enabled = true;

                UMLFlow flow = this.uMLFlowBindingSource.Current as UMLFlow;

                if (flow.State != RecordState.Created)
                {
                    this.uMLFlowBindingSource.CancelEdit();
                    this.uMLFlowCollectionBindingSource.ResetCurrentItem();
                }

                if (uMLFlowCollectionBindingSource.Count > 0)
                {
                    this.uMLFlowBindingSource.DataSource = this.uMLFlowCollectionBindingSource.Current;

                    this.editButton.Enabled = true;
                    this.newButton.Enabled = true;
                    this.cancelButton.Enabled = false;
                    this.saveButton.Enabled = false;
                    this.removeButton.Enabled = true;
                }
                else
                {
                    this.uMLFlowBindingSource.Clear();

                    this.editButton.Enabled = false;
                    this.newButton.Enabled = true;
                    this.cancelButton.Enabled = false;
                    this.saveButton.Enabled = false;
                    this.removeButton.Enabled = false;
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (this.uMLFlowBindingSource.Current != null)
            {
                UMLFlow item = uMLFlowCollectionBindingSource.Current as UMLFlow;

                if (item != null)
                {
                    DialogResult result = MessageBox.Show(this, "Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            item.Delete();
                            uMLFlowCollectionBindingSource.RemoveCurrent();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        #endregion

        #region uMLFlowCollectionBindingSource Events
        private void uMLFlowCollectionBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.uMLFlowCollectionBindingSource.Current != null)
            {
                this.uMLFlowBindingSource.DataSource = this.uMLFlowCollectionBindingSource.Current;

                this.editButton.Enabled = true;
                this.newButton.Enabled = true;
                this.cancelButton.Enabled = false;
                this.saveButton.Enabled = false;
                this.removeButton.Enabled = true;
            }
            else
            {
                this.uMLFlowBindingSource.Clear();

                this.editButton.Enabled = false;
                this.newButton.Enabled = true;
                this.cancelButton.Enabled = false;
                this.saveButton.Enabled = false;
                this.removeButton.Enabled = false;
            }
        }
        #endregion

        #region uMLFlowCollectionDataGridView Events
        private void uMLFlowCollectionDataGridView_DoubleClick(object sender, EventArgs e)
        {
            UMLFlow item = uMLFlowCollectionBindingSource.Current as UMLFlow;

            if (item != null)
            {
                FormEdit form = FormsFactory.GetFormEdit(item);

                if (form != null)
                {
                    form.FormClosed += new FormClosedEventHandler(form_FormClosed);
                    if (this.DockPanel != null)
                        form.Show(this.DockPanel);
                    else
                        form.Show();
                }
            }
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormEdit form = sender as FormEdit;
            FormsFactory.Remove(form.Element);
        }
        #endregion

        #region Utils
        private void LockFlowControls(bool locked)
        {
            Color backColor;

            if (locked)
                backColor = System.Drawing.SystemColors.InactiveCaptionText;
            else
                backColor = System.Drawing.SystemColors.Window;

            this.flowTypeComboBox.Enabled = !locked;
            this.flowTypeComboBox.BackColor = backColor;
            this.nameTextBox1.ReadOnly = locked;
            this.descriptionTextBox.ReadOnly = locked;
        }
        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            this.UseCase.GetFlows().SaveToExcel("");
        }

        private void btnSelectIteration_Click(object sender, EventArgs e)
        {
            UMLIterationCollection collection = new UMLIterationCollection();
            UMLIteration iteration = UseCase.GetIteration();
            if(iteration != null)
                collection.Add(iteration);
            ItemSelect<UMLIteration, UMLIterationCollection> iterationSelect = new ItemSelect<UMLIteration, UMLIterationCollection>(collection);
            iterationSelect.ShowDialog(this);
            if (iterationSelect.DialogResult == DialogResult.OK)
            {
                UseCase.IterationOld = UseCase.Iteration;
                UseCase.Iteration = iterationSelect.SelectedList[0];
            }
        }
    }
}

