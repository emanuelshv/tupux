using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;
using System.Globalization;

namespace TUPUX.Forms
{
    public partial class FactorEdit : Form
    {
        #region Attributes and Properties
        UMLFactor _factor;

        public UMLFactor Factor
        {
            get { return _factor; }
        }

        #endregion

        public FactorEdit(UMLFactor factor)
        {
            InitializeComponent();
            LoadFactor(factor);
        }

        #region Events

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.frmValidator.Validate();
            if (this.frmValidator.IsValid)
            {
                SetFactorValues();
            }
        }

        #endregion

        #region Methods

        private void LoadFactor(UMLFactor factor)
        {
            if (factor == null)
            {
                _factor = new UMLFactor();
                _factor.Editable = true;
                this.txtN.Text = "1.00";
            }
            else
            {
                CultureInfo ci = new CultureInfo("en-US");

                _factor = factor;
                if (_factor.Values.ContainsKey("VL")) this.txtVL.Text = _factor.Values["VL"].ToString(ci);
                else if (!_factor.Editable) this.txtVL.ReadOnly = true;

                if (_factor.Values.ContainsKey("L")) this.txtL.Text = _factor.Values["L"].ToString(ci);
                else if (!_factor.Editable) this.txtL.ReadOnly = true;

                if (_factor.Values.ContainsKey("N")) this.txtN.Text = _factor.Values["N"].ToString(ci);
                else if (!_factor.Editable) this.txtN.ReadOnly = true;

                if (_factor.Values.ContainsKey("H")) this.txtH.Text = _factor.Values["H"].ToString(ci);
                else if (!_factor.Editable) this.txtH.ReadOnly = true;

                if (_factor.Values.ContainsKey("VH")) this.txtVH.Text = _factor.Values["VH"].ToString(ci);
                else if (!_factor.Editable) this.txtVH.ReadOnly = true;

                if (_factor.Values.ContainsKey("XH")) this.txtXH.Text = _factor.Values["XH"].ToString(ci);
                else if (!_factor.Editable) this.txtXH.ReadOnly = true;

            }

            uMLFactorBindingSource.DataSource = _factor;
        }
                
        private void SetFactorValues()
        {

            CultureInfo ci = new CultureInfo("en-US");
            if (_factor.Values.ContainsKey("VL"))
                _factor.Values["VL"] = Convert.ToDouble(this.txtVL.Text, ci);
            else if (_factor.Editable && !String.IsNullOrEmpty(this.txtVL.Text))
            {
                _factor.Values.Add("VL", Convert.ToDouble(this.txtVL.Text, ci));
            }

            if (_factor.Values.ContainsKey("L"))
                _factor.Values["L"] = Convert.ToDouble(this.txtL.Text, ci);
            else if (_factor.Editable && !String.IsNullOrEmpty(this.txtL.Text))
            {
                _factor.Values.Add("L", Convert.ToDouble(this.txtL.Text, ci));
            }

            if (_factor.Values.ContainsKey("N"))
                _factor.Values["N"] = Convert.ToDouble(this.txtN.Text, ci);
            else if (_factor.Editable && !String.IsNullOrEmpty(this.txtN.Text))
            {
                _factor.Values.Add("N", Convert.ToDouble(this.txtN.Text, ci));
            }

            if (_factor.Values.ContainsKey("H"))
                _factor.Values["H"] = Convert.ToDouble(this.txtH.Text, ci);
            else if (_factor.Editable && !String.IsNullOrEmpty(this.txtH.Text))
            {
                _factor.Values.Add("H", Convert.ToDouble(this.txtH.Text, ci));
            }

            if (_factor.Values.ContainsKey("VH"))
                _factor.Values["VH"] = Convert.ToDouble(this.txtVH.Text, ci);
            else if (_factor.Editable && !String.IsNullOrEmpty(this.txtVH.Text))
            {
                _factor.Values.Add("VH", Convert.ToDouble(this.txtVH.Text, ci));
            }

            if (_factor.Values.ContainsKey("XH"))
                _factor.Values["XH"] = Convert.ToDouble(this.txtXH.Text, ci);
            else if (_factor.Editable && !String.IsNullOrEmpty(this.txtXH.Text))
            {
                _factor.Values.Add("XH", Convert.ToDouble(this.txtXH.Text, ci));
            }
        }

        #endregion
    }
}