using System;
using System.ComponentModel;
using System.Collections;
using System.ComponentModel.Design;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CustomValidation
{

    #region RequiredFieldValidator
    [ToolboxBitmap(typeof(RequiredFieldValidator), "RequiredFieldValidator.ico")]
    public class RequiredFieldValidator : BaseValidator
    {
        private string _initialValue = null;
        [Category("Behavior")]
        [DefaultValue(null)]
        [Description("Sets or returns the base value for the validator. The default value is null.")]
        public string InitialValue
        {
            get { return _initialValue; }
            set { _initialValue = value; }
        }

        protected override bool EvaluateIsValid()
        {
            string controlValue = ControlToValidate.Text.Trim();
            string initialValue;
            if (_initialValue == null) initialValue = "";
            else initialValue = _initialValue.Trim();
            return (controlValue != initialValue);
        }
    }
    #endregion

}
