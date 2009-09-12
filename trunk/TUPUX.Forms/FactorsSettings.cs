using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;
using TUPUX.Controls;
using System.IO;

namespace TUPUX.Forms
{
    public partial class FactorsSettings : Form
    {
        #region Attributes and Properties

        UMLFactorCollection _factors;

        #endregion

        public FactorsSettings()
        {
            InitializeComponent();
            LoadFactors();
        }

        #region Events
        
        private void view_RemovingItem(object sender, RemoveEventArgs<UMLFactor> e)
        {
            UMLFactor factor = (UMLFactor)e.Item;
            if (factor.Editable)
            {
                _factors.Remove(factor);
                uMLFactorCollectionBindingSource.ResetBindings(false);
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("This factor can't be deleted");
                e.Cancel = true;
            }
        }

        private void btnSaveFactors_Click(object sender, EventArgs e)
        {            
            HelperEstimation.WriteFactorsInProfile(_factors);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            FactorEdit factorEdit = new FactorEdit(null);
            DialogResult result = factorEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                _factors.Add(factorEdit.Factor);
                uMLFactorCollectionBindingSource.ResetBindings(false);
            }
        }

        private void toolStripBtnModify_Click(object sender, EventArgs e)
        {
            ModifyFactor();
        }

        private void uMLFactorCollectionDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifyFactor();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want rest the factors", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                HelperEstimation.ResetProfile();

                _factors = UMLFactorCollection.GetFactors(true);

                BindingListView<UMLFactor> view = new BindingListView<UMLFactor>(_factors);
                this.uMLFactorCollectionBindingSource.DataSource = view;
                view.RemovingItem += new RemoveEventHandler<UMLFactor>(view_RemovingItem);
            }
        }                

        #endregion

        #region Methods

        private void LoadFactors()
        {
            _factors = UMLFactorCollection.GetFactors(false);
            BindingListView<UMLFactor> view = new BindingListView<UMLFactor>(_factors);
            this.uMLFactorCollectionBindingSource.DataSource = view;            
            view.RemovingItem += new RemoveEventHandler<UMLFactor>(view_RemovingItem);
        }
        
        private void ModifyFactor()
        {
            if (uMLFactorCollectionDataGridView.SelectedRows.Count == 1)
            {
                FactorEdit factorEdit = new FactorEdit((UMLFactor)uMLFactorCollectionDataGridView.SelectedRows[0].DataBoundItem);
                factorEdit.ShowDialog();

            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}