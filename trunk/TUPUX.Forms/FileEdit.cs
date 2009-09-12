using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;

namespace TUPUX.Forms
{
    public partial class FileEdit : FormEdit
    {
        #region Attributes and Properties

        public UMLFile File
        {
            get
            {
                return _element as UMLFile; 
            }
            set 
            {
                _element = value;
                this.uMLFileBindingSource.DataSource = _element;
            }
        }

        private bool _changed = true;

        #endregion

        public FileEdit(UMLFile file)
        {            
            InitializeComponent();
            File = file;
        }

        #region Events

        private void btnOk_Click(object sender, EventArgs e)
        {
            DoSave();
            this._changed = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        protected override void DoSave()
        {
            //this.useCaseBindingSource.EndEdit();
            this.frmValidator.Validate();
            if (this.frmValidator.IsValid)
            {
                File.MarkModified();
                File.Save();
                
            }
        }

        protected override bool IsChanged()
        {
            _changed = this.File.State != TUPUX.ActiveRecord.RecordState.Loaded;
            return _changed;
        }

        #endregion
    }
}