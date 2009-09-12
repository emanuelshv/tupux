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

  #region ListValidationSummary
  [ToolboxBitmap(typeof(ListValidationSummary), "ListValidationSummary.ico")]
  public class ListValidationSummary : BaseValidationSummary
  {

    ValidationSummaryForm _dlg = null;
    BaseContainerValidator currentExtendee = null;

    protected override void Summarize(object sender, SummarizeEventArgs e)
    {

      // Close form if open and nothing invalid
      if (e.Validators.Count == 0)
      {
        if (_dlg != null)
        {
          _dlg.Close();
          _dlg = null;
          currentExtendee = null;
        }
        return;
      }

      BaseContainerValidator extendee = (BaseContainerValidator)sender;

      // If the ValidationSummaryForm is open, but refers to a different extendee
      // (BaseContainerValidator), get rid of it
      if ((_dlg != null) && (currentExtendee != null) && (extendee != currentExtendee))
      {
        _dlg.Close();
        _dlg = null;
        currentExtendee = extendee;
      }

      // Open ValidationSummaryForm if it hasn't been opened,
      // or has been closed since Summarize was last called
      if (_dlg == null)
      {
        _dlg = new ValidationSummaryForm();
        _dlg.ErrorCaption = GetErrorCaption(extendee);
        _dlg.ErrorMessage = GetErrorMessage(extendee);
        _dlg.Owner = extendee.HostingForm;

        // Register Disposed to handle clean up when user closes form
        _dlg.Disposed += new EventHandler(ValidationSummaryForm_Disposed);
      }

      // Get complete set of Validators under the jurisdiction
      // of the BaseContainerValidator
      _dlg.LoadValidators(Sort(extendee.GetValidators()));

      // Show dialog if not already visible
      if (!_dlg.Visible) _dlg.Show();
    }

    private void ValidationSummaryForm_Disposed(object sender, EventArgs e)
    {
      // Clean up if user closes form
      _dlg.Disposed -= new EventHandler(ValidationSummaryForm_Disposed);
      _dlg = null;
    }
  }
  #endregion

}
