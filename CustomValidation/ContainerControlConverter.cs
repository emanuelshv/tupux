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

  #region ContainerControlConverter

  public class ContainerControlConverter : ReferenceConverter
  {

    public ContainerControlConverter(Type type) : base(type) { }

    protected override bool IsValueAllowed(ITypeDescriptorContext context, object value)
    {
      return ((value is GroupBox) ||
              (value is TabControl) ||
              (value is Panel) ||
              (value is TabPage) ||
              (value is Form) ||
              (value is UserControl));
    }
  }
  #endregion


}
