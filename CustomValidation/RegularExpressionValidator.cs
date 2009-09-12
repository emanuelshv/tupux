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

  #region RegularExpressionValidator
  [ToolboxBitmap(typeof(RegularExpressionValidator), "RegularExpressionValidator.ico")]
  public class RegularExpressionValidator : BaseValidator
  {

    private string _validationExpression = "";

    [Category("Behavior")]
    [Description("Sets or returns the regular expression that determines the pattern used to validate a field.")]
    [DefaultValue("")]
    public string ValidationExpression
    {
      get { return _validationExpression; }
      set { _validationExpression = value; }
    }

    protected override bool EvaluateIsValid()
    {
      // Don't validate if empty
      if (ControlToValidate.Text.Trim() == "") return true;
      // Successful if match matches the entire text of ControlToValidate
      string input = ControlToValidate.Text.Trim();
      return Regex.IsMatch(input, _validationExpression.Trim());
    }
  }
  #endregion

}
