using System;
using System.Collections.Generic;
using System.Text;

namespace TUPUX.Forms.Util
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboboxItem(string Text, object value)
        {
            this.Text = Text;
            this.Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
