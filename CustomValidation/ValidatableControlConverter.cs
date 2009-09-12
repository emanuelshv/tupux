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

  #region ValidatableControlConverter
  //public class ValidatableControlConverter : ReferenceConverter
  //{
  //  public ValidatableControlConverter(Type type) : base(type) { }
  //  //protected override bool IsValueAllowed(ITypeDescriptorContext context, object value)
  //  //{
  //  //  return ((value is TextBox) ||
  //  //          (value is ListBox) ||
  //  //          (value is System.Windows.Forms.ComboBox) ||
  //  //          (value is UserControl) || 
  //  //          (value is DevExpress.XtraEditors.TextEdit)
  //  //          );

  //  //}

  //}
  public class ValidatableControlConverter : ReferenceConverter
  {
    public ValidatableControlConverter(Type type) : base(type) { }
    protected override bool IsValueAllowed(ITypeDescriptorContext context, object value)
    {
      return ((value is TextBox) ||
              (value is ListBox) ||
              (value is ComboBox) ||
              (value is UserControl)
              );
    }
  }
  #endregion

}
