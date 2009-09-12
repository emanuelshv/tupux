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

  #region ValidationSummary
  [ToolboxBitmap(typeof(ValidationSummary), "ValidationSummary.ico")]
  [ProvideProperty("DisplayMode", typeof(BaseContainerValidator))]
  public class ValidationSummary : BaseValidationSummary
  {

    private Hashtable _displayModes = new Hashtable();

    [Category("Validation Summary")]
    [Description("Sets or returns how the validation summary will be displayed.")]
    [DefaultValue(ValidationSummaryDisplayMode.Simple)]
    public ValidationSummaryDisplayMode GetDisplayMode(BaseContainerValidator extendee)
    {
      if (_displayModes.Contains(extendee))
      {
        return (ValidationSummaryDisplayMode)_displayModes[extendee];
      }
      else
      {
        return ValidationSummaryDisplayMode.Simple;
      }
    }
    public void SetDisplayMode(BaseContainerValidator extendee, ValidationSummaryDisplayMode value)
    {
      _displayModes[extendee] = value;
    }

    protected override void Summarize(object sender, SummarizeEventArgs e)
    {

      // Don’t validate if no validators were passed
      if (e.Validators.Count == 0)
      {
        return;
      }

      BaseContainerValidator extendee = (BaseContainerValidator)sender;
      ValidationSummaryDisplayMode displayMode = GetDisplayMode(extendee);
      ValidatorCollection validators = e.Validators;

      // Make sure there are validators
      if ((validators == null) || (validators.Count == 0)) return;

      string errorMessage = GetErrorMessage(extendee);
      string errorCaption = GetErrorCaption(extendee);

      // Get error text, if provided
      if (errorMessage == null)
      {
        errorMessage = "";
      }

      // Get error caption, if provided
      if (errorCaption == null)
      {
        errorCaption = "";
      }

      // Build summary message body
      string errors = "";
      if (displayMode == ValidationSummaryDisplayMode.Simple)
      {
        // Build Simple message
        errors = errorMessage;
      }
      else
      {
        // Build List, BulletList or SingleParagraph
        foreach (object validator in base.Sort(validators))
        {
          BaseValidator current = (BaseValidator)validator;
          if (!current.IsValid)
          {
            switch (displayMode)
            {
              case ValidationSummaryDisplayMode.List:
                errors += string.Format("{0}\n", current.ErrorMessage);
                break;
              case ValidationSummaryDisplayMode.BulletList:
                errors += string.Format("- {0}\n", current.ErrorMessage);
                break;
              case ValidationSummaryDisplayMode.SingleParagraph:
                errors += string.Format("{0}. ", current.ErrorMessage);
                break;
            }
          }
        }
        // Prepend error message, if provided
        if ((errors != "") && (errorMessage != ""))
        {
          errors = string.Format("{0}\n\n{1}", errorMessage.Trim(), errors);
        }
      }

      // Display summary message
      // "if( errors.Trim().Length > 0 )" thanks to John V. Barone and Jorge Matos
      if (errors.Trim().Length > 0)
      {
        MessageBox.Show(errors, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
  #endregion

}
