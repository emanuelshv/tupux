using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;

namespace TUPUX.Forms
{
    public partial class FactorList : Form
    {
        #region Attributes and Properties

        private bool _change = false;
        private UMLFactorCollection _factors;
        private Double _total;

        public bool Change
        {
            get { return _change; }
        }

        public UMLFactorCollection Factors
        {
            get { return _factors; }
        }

        public Double Total
        {
            get { return _total; }
        }

        #endregion

        public FactorList(UMLFactorCollection factors)
        {
            InitializeComponent();
            _factors = factors.Clone();
            LoadFactors();
        }

        #region Events

        private void uMLFactorCollectionDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UMLFactor factor = (UMLFactor)uMLFactorCollectionDataGridView.Rows[e.RowIndex].DataBoundItem;
            DataGridViewComboBoxCell col = (DataGridViewComboBoxCell)uMLFactorCollectionDataGridView[e.ColumnIndex, e.RowIndex];

            factor.SelectedKey = (String)col.Value;
            if (_factors != null)
                GetTotal();
        }

        #endregion

        #region Methods

        private void LoadFactors()
        {
            
            this.uMLFactorCollectionBindingSource.DataSource = _factors;
            GetTotal();
        }

        private void GetTotal()
        {
            double total = 1;
            foreach (UMLFactor factor in _factors)
            {
                //CultureInfo ci = new CultureInfo("en-US");
                total *= factor.SelectedValue;
            }
            _total = Math.Round(total, 2);
            this.txtTotal.Text = _total.ToString();
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this._change = true;
            this.Close();
        }

        private void uMLFactorCollectionDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dgrv in uMLFactorCollectionDataGridView.Rows)
            {
                
                DataGridViewComboBoxCell col = (DataGridViewComboBoxCell)dgrv.Cells[1];

                UMLFactor factor = (UMLFactor)dgrv.DataBoundItem;

                col.DataSource = factor.ValuesKey;
                col.Value = factor.SelectedKey;
                
            }
            uMLFactorCollectionDataGridView.CellValueChanged += uMLFactorCollectionDataGridView_CellValueChanged;
        }
    }
}