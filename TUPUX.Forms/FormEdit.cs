using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TUPUX.ActiveRecord;

namespace TUPUX.Forms
{
#if DEBUG
    public class FormEdit : WeifenLuo.WinFormsUI.Docking.DockContent
    {
#else
    public abstract class FormEdit : WeifenLuo.WinFormsUI.Docking.DockContent
    {
#endif
        #region Events
        public event EventHandler FormSaving;
        public event EventHandler FormSaved; 
        #endregion

        #region Attributes
        protected IUMLElement _element;
        #endregion

        #region Properties
        public IUMLElement Element
        {
            get { return _element; }
        } 
        #endregion

        public FormEdit() : base()
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormEdit_FormClosing);
        }

        void FormEdit_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (this.IsChanged())
            {
                DialogResult result = MessageBox.Show(this, "Save the changes?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Yes:
                        this.DoSave();
                        break;
                    default:
                        break;
                }
                
            }
        }

        public void Save()
        {
            if (FormSaving != null) FormSaving(this, new EventArgs());
            DoSave();
            if (FormSaved != null) FormSaved(this, new EventArgs());
        }
#if DEBUG
        protected virtual void DoSave()
        {
            throw new NotImplementedException();
        }
        protected virtual bool IsChanged()
        {
            throw new NotImplementedException();
        }
#else
        protected abstract void DoSave();
        protected abstract bool IsChanged();
#endif
    }
}
