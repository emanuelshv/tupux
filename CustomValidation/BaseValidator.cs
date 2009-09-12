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


  #region BaseValidator


  public abstract class BaseValidator : Component, ISupportInitialize
  {

    private Control _controlToValidate = null;
    private string _errorMessage = "";
    private Icon _icon = new Icon(typeof(ErrorProvider), "Error.ico");
    private ErrorProvider _errorProvider = new ErrorProvider();
    private bool _isValid = false;
    private bool _validateOnLoad = false;
    private string _flattenedTabIndex = null;

    #region ISupportInitialize

    public void BeginInit() { }
    public void EndInit()
    {
      // Hook up ControlToValidate's parent form's Load and Closed events 
      // to register and unregister with the ValidationManager
      // ONLY if _controlToValidate exists at run-time and has a parent form
      // ie has been added to a Form's Controls collection
      // NOTE: if there is no form, we don't add this instance to the ValidatorManager
      // so it is not available for form-wide validation which makes sense
      // since there is no form and therefore no form scope.

      if (DesignMode) return;

      Control topMostParent = _controlToValidate;
      while (topMostParent.Parent != null)
      {
        topMostParent = topMostParent.Parent;
      }
      if (topMostParent is Form)
      {
        ((Form)topMostParent).Load += new EventHandler(Host_Load);
        return;
      }
      if (topMostParent is UserControl)
      {
        ((UserControl)topMostParent).Load += new EventHandler(Host_Load);
        return;
      }
      //      if( _controlToValidate.Parent is UserControl ) {
      //        UserControl userControl = _controlToValidate.Parent as UserControl;
      //        userControl.Load += new EventHandler(Form_Load);
      //        userControl.Disposed += new EventHandler(Form_Closed);
      //        return;
      //      }
      //
      //      Form host = _controlToValidate.FindForm();
      //      if( (_controlToValidate != null) && (!DesignMode) && (host != null) ) {
      //        host.Load += new EventHandler(Form_Load);
      //        host.Closed += new EventHandler(Form_Closed);
      //      }
    }

    #endregion

    [Category("Appearance")]
    [Description("Sets or returns the text for the error message.")]
    [DefaultValue("")]
    public string ErrorMessage
    {
      get { return _errorMessage; }
      set { _errorMessage = value; }
    }

    [Category("Appearance")]
    [Description("Sets or returns the Icon to display ErrorMessage.")]
    public Icon Icon
    {
      get { return _icon; }
      set { _icon = value; }
    }

    [Category("Behavior")]
    [Description("Sets or returns the input control to validate.")]
    [DefaultValue(null)]
    [TypeConverter(typeof(ValidatableControlConverter))]
    public Control ControlToValidate
    {
      get { return _controlToValidate; }
      set
      {
        _controlToValidate = value;

        // Hook up ControlToValidate’s Validating event at run-time ie not from VS.NET
        if ((_controlToValidate != null) && (!DesignMode))
        {
          _controlToValidate.Validating += new CancelEventHandler(ControlToValidate_Validating);
        }
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsValid
    {
      get { return _isValid; }
      set { _isValid = value; }
    }

    [Category("Behavior")]
    [Description("Sets or returns whether this validator will validate itself when its host form loads.")]
    [DefaultValue(false)]
    public bool ValidateOnLoad
    {
      get { return _validateOnLoad; }
      set { _validateOnLoad = value; }
    }

    public void Validate()
    {

      // Validate control
      _isValid = this.EvaluateIsValid();

      // Display an error if ControlToValidate is invalid
      string errorMessage = "";
      if (!_isValid)
      {
        errorMessage = _errorMessage;
        _errorProvider.Icon = _icon;
      }
      _errorProvider.SetError(_controlToValidate, errorMessage);

      OnValidated(new EventArgs());
    }

    public override string ToString()
    {
      return _errorMessage;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public decimal FlattenedTabIndex
    {
      get
      {

        // Globalization update thanks to Ondrej Psencik
        System.Globalization.NumberFormatInfo info = new System.Globalization.NumberFormatInfo();
        info.NumberDecimalSeparator = ".";

        // Generate unique tab index and store it if 
        // not already generated
        if (_flattenedTabIndex == null)
        {
          StringBuilder sb = new StringBuilder();
          Control current = _controlToValidate;
          while (current != null)
          {
            string tabIndex = current.TabIndex.ToString();
            sb.Insert(0, tabIndex);
            current = current.Parent;
          }
          sb.Insert(0, "0.");
          _flattenedTabIndex = sb.ToString();
        }

        // Return unique tab index
        return decimal.Parse(_flattenedTabIndex, System.Globalization.NumberStyles.Number, info);
      }
    }

    public event EventHandler Validated;
    protected void OnValidated(EventArgs e)
    {
      if (Validated != null)
      {
        Validated(this, e);
      }
    }

    protected abstract bool EvaluateIsValid();

    private void ControlToValidate_Validating(object sender, CancelEventArgs e)
    {
      // We don't cancel if invalid since we don't want to force
      // the focus to remain on ControlToValidate if invalid
      Validate();
    }

    private void Host_Load(object sender, EventArgs e)
    {
      // Register with ValidatorManager
      Form hostingForm = ((Control)sender).FindForm();
      ValidatorManager.Register(this, hostingForm);
      if (_validateOnLoad) this.Validate();
      hostingForm.Closed += new EventHandler(HostingForm_Closed);
      //hostingForm.Disposed += new EventHandler(hostingForm_Disposed);

    }

    void hostingForm_Disposed(object sender, EventArgs e)
    {
      ValidatorManager.DeRegister(this, (Form)sender);
    }
    private void HostingForm_Closed(object sender, EventArgs e)
    {
      // DeRegister from ValidatorCollection
      ValidatorManager.DeRegister(this, (Form)sender);
    }
  }

  #endregion



}
