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
    public partial class FlowEdit : TUPUX.Forms.FormEdit
    {
        #region Properties
        public UMLFlow Flow
        {
            get { return _element as UMLFlow; }
            set
            {
                _element = value;
                this.uMLFlowBindingSource.DataSource = value;
                this.uMLStepFlowCollectionBindingSource.DataSource = value.GetStepFlows();
            }
        }
        #endregion

        #region Contructors
        public FlowEdit()
        {
            InitializeComponent();
        }

        public FlowEdit(UMLFlow flow)
        {
            InitializeComponent();

            this.DataBindings.Add(new System.Windows.Forms.Binding("Name", this.uMLFlowBindingSource, "PathName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "New Use Case"));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLFlowBindingSource, "PathName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "New Use Case"));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TabText", this.uMLFlowBindingSource, "PathName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "New Use Case"));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ToolTipText", this.uMLFlowBindingSource, "PathName", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "New Use Case"));

            this.Flow = flow;
        }
        #endregion

        #region Form Events
        private void FlowEdit_Load(object sender, EventArgs e)
        {
            this.typeCustomComboBox.DataSource = Properties.Settings.Default.FlowType;
            //this.typeCustomComboBox1.DataSource = Properties.Settings.Default.StepFlowType;

            //this.LockStepFlowControls(true);
        }
        #endregion

        #region FormEdit Methods
        protected override void DoSave()
        {
            this.Flow.Save();
        }

        protected override bool IsChanged()
        {
            if (this.Flow.State != RecordState.Loaded)
                return true;

            return false;
        }

        #endregion

        private void uMLStepFlowCollectionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void uMLStepFlowCollectionDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void uMLStepFlowCollectionDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            UMLStepFlow item = e.Row.DataBoundItem as UMLStepFlow;
            //if (item != null)
            //{
                //UMLStepFlow item = uMLStepFlowCollectionBindingSource.Current as UMLStepFlow;

                if (item != null)
                {
                    DialogResult result = MessageBox.Show(this, "Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            item.Delete();
                            //uMLStepFlowCollectionBindingSource.RemoveCurrent();
                            break;
                        default:
                            e.Cancel = true;
                            break;
                    }
                }
            //}
        }

        private void uMLStepFlowCollectionBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            UMLStepFlow stepFlow = new UMLStepFlow();
            stepFlow.Owner = this.Flow;
            stepFlow.Name = "";
            stepFlow.Type = "User";
            e.NewObject = stepFlow;
        }

        private void uMLStepFlowCollectionBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemChanged)
            {
                UMLStepFlow stepFlow = this.uMLStepFlowCollectionBindingSource[e.NewIndex] as UMLStepFlow;
                stepFlow.Save();
            }

        }

        private void uMLStepFlowCollectionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            /*
            UMLStepFlow stepFlow = this.uMLStepFlowCollectionBindingSource.Current as UMLStepFlow;

            if (stepFlow != null)
            {
                stepFlow.Save();
            }
            */ 
        }

        private void uMLStepFlowCollectionDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        #region Button Methods
        /*
        private void newButton_Click(object sender, EventArgs e)
        {
            UMLStepFlow stepFlow = new UMLStepFlow();
            stepFlow.Owner = this.Flow;
            this.uMLStepFlowBindingSource.DataSource = stepFlow;

            this.LockStepFlowControls(false);
            this.uMLStepFlowCollectionDataGridView.Enabled = false;

            this.typeCustomComboBox1.SelectedIndex = 0;

            this.editButton.Enabled = false;
            this.newButton.Enabled = false;
            this.cancelButton.Enabled = true;
            this.saveButton.Enabled = true;
            this.removeButton.Enabled = false;
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.uMLStepFlowBindingSource.Current != null)
            {
                this.uMLStepFlowBindingSource.EndEdit();


                UMLStepFlow stepFlow = this.uMLStepFlowBindingSource.Current as UMLStepFlow;

                if (stepFlow.State == RecordState.Created)
                {
                    this.uMLStepFlowCollectionBindingSource.Add(stepFlow);
                    this.uMLStepFlowCollectionBindingSource.Position = this.uMLStepFlowCollectionBindingSource.IndexOf(stepFlow);
                }

                stepFlow.Save();

                this.LockStepFlowControls(true);
                this.uMLStepFlowCollectionDataGridView.Enabled = true;

                this.editButton.Enabled = true;
                this.newButton.Enabled = true;
                this.cancelButton.Enabled = false;
                this.saveButton.Enabled = false;
                this.removeButton.Enabled = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.uMLStepFlowBindingSource.Current != null)
            {
                this.LockStepFlowControls(false);
                this.uMLStepFlowCollectionDataGridView.Enabled = false;

                this.editButton.Enabled = false;
                this.newButton.Enabled = false;
                this.cancelButton.Enabled = true;
                this.saveButton.Enabled = true;
                this.removeButton.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.uMLStepFlowBindingSource.Current != null)
            {
                this.LockStepFlowControls(true);
                this.uMLStepFlowCollectionDataGridView.Enabled = true;

                UMLStepFlow stepFlow = this.uMLStepFlowBindingSource.Current as UMLStepFlow;

                if (stepFlow.State != RecordState.Created)
                {
                    this.uMLStepFlowBindingSource.CancelEdit();
                    this.uMLStepFlowCollectionBindingSource.ResetCurrentItem();
                }

                if (this.uMLStepFlowCollectionBindingSource.Count > 0)
                {
                    this.uMLStepFlowBindingSource.DataSource = this.uMLStepFlowCollectionBindingSource.Current;

                    this.editButton.Enabled = true;
                    this.newButton.Enabled = true;
                    this.cancelButton.Enabled = false;
                    this.saveButton.Enabled = false;
                    this.removeButton.Enabled = true;
                }
                else
                {
                    this.uMLStepFlowBindingSource.Clear();

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
            if (this.uMLStepFlowBindingSource.Current != null)
            {
                UMLStepFlow item = uMLStepFlowCollectionBindingSource.Current as UMLStepFlow;

                if (item != null)
                {
                    DialogResult result = MessageBox.Show(this, "Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            item.Delete();
                            uMLStepFlowCollectionBindingSource.RemoveCurrent();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        */
        #endregion

        #region uMLStepFlowCollectionBindingSource Events
        /*
        private void uMLStepFlowCollectionBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.uMLStepFlowCollectionBindingSource.Current != null)
            {
                this.uMLStepFlowBindingSource.DataSource = this.uMLStepFlowCollectionBindingSource.Current;

                this.editButton.Enabled = true;
                this.newButton.Enabled = true;
                this.cancelButton.Enabled = false;
                this.saveButton.Enabled = false;
                this.removeButton.Enabled = true;
            }
            else
            {
                this.uMLStepFlowBindingSource.Clear();

                this.editButton.Enabled = false;
                this.newButton.Enabled = true;
                this.cancelButton.Enabled = false;
                this.saveButton.Enabled = false;
                this.removeButton.Enabled = false;
            }
        }
        */
        #endregion

        #region Utils
        /*
        private void LockStepFlowControls(bool locked)
        {
            Color backColor;

            if (locked)
                backColor = System.Drawing.SystemColors.InactiveCaptionText;
            else
                backColor = System.Drawing.SystemColors.Window;

            this.typeCustomComboBox1.Enabled = !locked;
            this.typeCustomComboBox1.BackColor = backColor;
            this.nameTextBox1.ReadOnly = locked;
            //this.descriptionTextBox.ReadOnly = locked;
        }
        */
        #endregion
    }
}

