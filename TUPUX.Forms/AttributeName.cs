using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TUPUX.Forms
{
    public partial class AttributeName : Form
    {
        public string NameAttribute
        {
            get
            {
                return this.txtName.Text.Trim();
            }
        }
        public AttributeName()
        {
            InitializeComponent();
        }

    }
}