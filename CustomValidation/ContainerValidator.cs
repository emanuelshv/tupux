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

  #region ContainerValidator
  [ToolboxBitmap(typeof(ContainerValidator), "ContainerValidator.ico")]
  public class ContainerValidator : BaseContainerValidator
  {

    private Control _containerToValidate = null;
    private ValidationDepth _validationDepth = ValidationDepth.All;

    [Category("Behavior")]
    [Description("Sets or returns the input control to validate.")]
    [DefaultValue(null)]
    [TypeConverter(typeof(ContainerControlConverter))]
    public Control ContainerToValidate
    {
      get { return _containerToValidate; }
      set { _containerToValidate = value; }
    }

    [Category("Behavior")]
    [DefaultValue(ValidationDepth.All)]
    [Description(@"Sets or returns the level of validation applied to ContainerToValidate using the ValidationDepth enumeration.")]
    public ValidationDepth ValidationDepth
    {
      get { return _validationDepth; }
      set { _validationDepth = value; }
    }

    public override ValidatorCollection GetValidators()
    {
      return ValidatorManager.GetValidators(HostingForm, _containerToValidate, _validationDepth);
    }

  }
  #endregion

}
