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

  #region BaseValidationSummary

  [ProvideProperty("ShowSummary", typeof(BaseContainerValidator))]
  [ProvideProperty("ErrorMessage", typeof(BaseContainerValidator))]
  [ProvideProperty("ErrorCaption", typeof(BaseContainerValidator))]
  public abstract class BaseValidationSummary : Component, IExtenderProvider
  {

    private Hashtable _showSummaries = new Hashtable();
    private Hashtable _errorMessages = new Hashtable();
    private Hashtable _errorCaptions = new Hashtable();

    #region IExtenderProvider
    bool IExtenderProvider.CanExtend(object extendee)
    {
      return true;
    }
    #endregion

    [Category("Validation Summary")]
    [Description("Sets or returns whether BaseContainerValidator uses the ValidationSummary component.")]
    [DefaultValue(false)]
    public bool GetShowSummary(BaseContainerValidator extendee)
    {
      if (_showSummaries.Contains(extendee))
      {
        return (bool)_showSummaries[extendee];
      }
      else
      {
        return false;
      }
    }
    public void SetShowSummary(BaseContainerValidator extendee, bool value)
    {
      if (value == true)
      {
        _showSummaries[extendee] = value;
        extendee.Summarize += new SummarizeEventHandler(Summarize);
      }
      else
      {
        _showSummaries.Remove(extendee);
      }
    }

    [Category("Validation Summary")]
    [Description("Sets or returns the message to display with the validation summary.")]
    [DefaultValue("")]
    public string GetErrorMessage(BaseContainerValidator extendee)
    {
      if (_errorMessages.Contains(extendee))
      {
        return (string)_errorMessages[extendee];
      }
      else
      {
        return "";
      }
    }
    public void SetErrorMessage(BaseContainerValidator extendee, string value)
    {
      if (value != null)
      {
        _errorMessages[extendee] = value;
      }
      else
      {
        _errorMessages.Remove(extendee);
      }
    }

    [Category("Validation Summary")]
    [Description("Sets or returns the caption to display with the validation summary.")]
    [DefaultValue("")]
    public string GetErrorCaption(BaseContainerValidator extendee)
    {
      if (_errorCaptions.Contains(extendee))
      {
        return (string)_errorCaptions[extendee];
      }
      else
      {
        return "";
      }
    }
    public void SetErrorCaption(BaseContainerValidator extendee, string value)
    {
      if (value != null)
      {
        _errorCaptions[extendee] = value;
      }
      else
      {
        _errorCaptions.Remove(extendee);
      }
    }


    protected abstract void Summarize(object sender, SummarizeEventArgs e);

    // Support validation in flattened tab index order
    protected ValidatorCollection Sort(ValidatorCollection validators)
    {

      // Sort validators into flattened tab index order
      // using the BaseValidatorComparer
      ArrayList sorted = new ArrayList();
      foreach (BaseValidator validator in validators)
      {
        sorted.Add(validator);
      }
      sorted.Sort(new BaseValidatorComparer());
      ValidatorCollection sortedValidators = new ValidatorCollection();
      foreach (BaseValidator validator in sorted)
      {
        sortedValidators.Add(validator);
      }

      return sortedValidators;
    }
  }

  #endregion

}
