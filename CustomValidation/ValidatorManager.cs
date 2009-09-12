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

  #region ValidatorManager

  public class ValidatorManager
  {

    private static Hashtable _validators = new Hashtable();
    public static void Register(BaseValidator validator, Form hostingForm)
    {

      // Create form bucket if it doesn't exist
      if (_validators[hostingForm] == null)
      {
        _validators[hostingForm] = new ValidatorCollection();
      }

      // Add this validator to the list of registered validators
      ValidatorCollection validators =
        (ValidatorCollection)_validators[hostingForm];
      validators.Add(validator);
    }

    public static ValidatorCollection GetValidators(Form hostingForm)
    {
      return (ValidatorCollection)_validators[hostingForm];
    }

    public static ValidatorCollection GetValidators(Form hostingForm, Control container, ValidationDepth validationDepth)
    {

      ValidatorCollection validators = ValidatorManager.GetValidators(hostingForm);
      ValidatorCollection contained = new ValidatorCollection();
      foreach (BaseValidator validator in validators)
      {
        // Only validate BaseValidators hosted by the container I reference
        if (IsParent(container, validator.ControlToValidate, validationDepth))
        {
          contained.Add(validator);
        }
      }
      return contained;
    }

    public static void DeRegister(BaseValidator validator, Form hostingForm)
    {

      // Remove this validator from the list of registered validators
      ValidatorCollection validators = (ValidatorCollection)_validators[hostingForm];
      if (validators != null)
      {
        validators.Remove(validator);
        // Remove form bucket if all validators on the form are de-registered
        if (validators.Count == 0) _validators.Remove(hostingForm);
      }
    }

    private static bool IsParent(Control parent, Control child, ValidationDepth validationDepth)
    {
      if (validationDepth == ValidationDepth.ContainerOnly)
      {
        return (child.Parent == parent);
      }
      else
      {
        Control current = child;
        while (current != null)
        {
          if (current == parent) return true;

          current = current.Parent;
        }
        return false;
      }
    }
  }

  #endregion

}
