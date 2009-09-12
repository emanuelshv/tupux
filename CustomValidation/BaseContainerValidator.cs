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

  #region BaseContainerValidator

  public abstract class BaseContainerValidator : Component
  {

    private Form _hostingForm = null;

    [Browsable(false)]
    [DefaultValue(null)]
    public Form HostingForm
    {
      get
      {
        if ((_hostingForm == null) && DesignMode)
        {
          // See if we're being hosted in VS.NET (or something similar)
          // Cheers Ian Griffiths/Chris Sells for this code
          IDesignerHost designer = this.GetService(typeof(IDesignerHost)) as IDesignerHost;
          if (designer != null) _hostingForm = designer.RootComponent as Form;
        }
        return _hostingForm;
      }
      set
      {
        if (!DesignMode)
        {
          // Only allow this property to be set if:
          //    a) it is being set for the first time
          //    b) it is the same Form as the original form
          if ((_hostingForm != null) && (_hostingForm != value))
          {
            throw new Exception("Can't change HostingForm at runtime.");
          }
          else _hostingForm = value;
        }
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsValid
    {
      get
      {
        foreach (BaseValidator validator in GetValidators())
        {
          if (!validator.IsValid) return false;
        }
        return true;
      }
    }

    public void Validate()
    {
      // Validate
      BaseValidator firstInTabOrder = null;
      foreach (BaseValidator validator in GetValidators())
      {

        // Validate control
        validator.Validate();

        // Set focus on the control it its invalid and the earliest invalid
        // control in the tab order
        if (!validator.IsValid)
        {
          if ((firstInTabOrder == null) ||
            (firstInTabOrder.FlattenedTabIndex > validator.FlattenedTabIndex))
          {
            firstInTabOrder = validator;
          }
        }
      }

      OnSummarize(new SummarizeEventArgs(GetValidators(), HostingForm));

      // Select first invalid control in tab order, if any
      if (firstInTabOrder != null)
      {
        firstInTabOrder.ControlToValidate.Focus();
      }
    }

    public abstract ValidatorCollection GetValidators();

    public event SummarizeEventHandler Summarize;
    protected void OnSummarize(SummarizeEventArgs e)
    {
      if (Summarize != null)
      {
        Summarize(this, e);
      }
    }

  }

  #endregion

}
