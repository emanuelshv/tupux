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

  #region SummarizeEventArgs
  public class SummarizeEventArgs
  {
    public ValidatorCollection Validators;
    public Form HostingForm;
    public SummarizeEventArgs(ValidatorCollection validators, Form hostingForm)
    {
      Validators = validators;
      HostingForm = hostingForm;
    }
  }
  #endregion

}
