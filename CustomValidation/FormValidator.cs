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

  #region FormValidator
  [ToolboxBitmap(typeof(FormValidator), "FormValidator.ico")]
  public class FormValidator : BaseContainerValidator, ISupportInitialize
  {

    private bool _validateOnAccept = true;

    #region ISupportInitialize

    public void BeginInit() { }

    public void EndInit()
    {
      // Handle AcceptButton click if requested
      // IButtonControl check to support 3rd party buttons a la
      // DevExpress' SimpleButton control, thanks to John V. Barone
      if ((HostingForm != null) && _validateOnAccept)
      {
        IButtonControl iBtn = (IButtonControl)HostingForm.AcceptButton;
        if (iBtn != null)
        {
          Control acceptButton = (Control)iBtn;
          acceptButton.Click += new EventHandler(AcceptButton_Click);
        }
      }
    }

    #endregion

    [Category("Behavior")]
    [Description("If the host form's AcceptButton property is set, automatically validate when it is clicked. The AcceptButton's DialogResult property must be set to 'OK'.")]
    [DefaultValue(true)]
    public bool ValidateOnAccept
    {
      get { return _validateOnAccept; }
      set { _validateOnAccept = value; }
    }

    public override ValidatorCollection GetValidators()
    {
      return ValidatorManager.GetValidators(HostingForm);
    }

    private void AcceptButton_Click(object sender, System.EventArgs e)
    {
      // If DialogResult is OK, that means we need to return None
      if (HostingForm.DialogResult == DialogResult.OK)
      {
        Validate();
        if (!IsValid)
        {
          HostingForm.DialogResult = DialogResult.None;
        }
      }
    }
  }
  #endregion

}
