using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace TUPUX.Controls
{
    public class CustomComboBox : ComboBox
    {
        public CustomComboBox():base()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void Load(StringCollection items)
        {
            this.Items.Clear();
            this.Items.Add("[Select One]");
            foreach (string item in items)
            {
                this.Items.Add(item);
            }
            this.SelectedIndex = 0;
        }
    }
}
