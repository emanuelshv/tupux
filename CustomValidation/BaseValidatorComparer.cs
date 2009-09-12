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
  #region BaseValidatorComparer
  public class BaseValidatorComparer : IComparer
  {
    public int Compare(object x, object y)
    {
      BaseValidator xBaseValidator = (BaseValidator)x;
      BaseValidator yBaseValidator = (BaseValidator)y;
      if (xBaseValidator.FlattenedTabIndex < yBaseValidator.FlattenedTabIndex) return -1;
      if (xBaseValidator.FlattenedTabIndex > yBaseValidator.FlattenedTabIndex) return 1;
      return 0;
    }
  }

  #endregion
}
