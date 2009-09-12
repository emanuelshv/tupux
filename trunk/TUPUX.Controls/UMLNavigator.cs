using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.ActiveRecord;

namespace TUPUX.Controls
{
    [ToolboxBitmap(typeof(System.Windows.Forms.BindingNavigator))]
    public partial class UMLNavigator : System.Windows.Forms.BindingNavigator
    {
        public UMLNavigator()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
            
        }

        //private ToolStripItem _deleteItem;

        //public new virtual ToolStripItem DeleteItem
        //{
        //    get
        //    {
        //        if ((_deleteItem != null) && _deleteItem.IsDisposed)
        //            _deleteItem = null;
        //        return _deleteItem;
        //    }
        //    set
        //    {
        //        WireUpButton(ref _deleteItem, value, new System.EventHandler(OnDelete));
        //    }
        //}

        //private void WireUpButton(ref ToolStripItem oldButton, ToolStripItem newButton, System.EventHandler clickHandler)
        //{
        //    if (oldButton != newButton)
        //    {
        //        if (oldButton != null)
        //            oldButton.Click -= clickHandler;
        //        if (newButton != null)
        //            newButton.Click += clickHandler;
        //        oldButton = newButton;
        //    }
        //}

        public override void AddStandardItems()
        {
            ComponentResourceManager resources = new ComponentResourceManager(this.GetType());

            ToolStripItem bindingNavigatorSeparator = new ToolStripSeparator();
            ToolStripItem bindingNavigatorAddNewItem = new ToolStripButton();
            ToolStripItem bindingNavigatorDeleteItem = new ToolStripButton();
            ToolStripItem bindingNavigatorSeparator1 = new ToolStripSeparator();
            ToolStripItem bindingNavigatorRefreshItem = new ToolStripButton();

            // 
            // bindingNavigator
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            bindingNavigatorSeparator,
            bindingNavigatorAddNewItem,
            bindingNavigatorDeleteItem,
            bindingNavigatorSeparator1,
            bindingNavigatorRefreshItem});

            this.AddNewItem = bindingNavigatorAddNewItem;
            this.DeleteItem = bindingNavigatorDeleteItem;

            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            //
            // bindingNavigatorRefreshItem
            // 
            bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            bindingNavigatorRefreshItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 22);
            bindingNavigatorRefreshItem.Text = "Refresh";

            
        }

        //private void OnDelete(object sender, System.EventArgs e)
        //{
        //    if (this.Validate() && (this.BindingSource != null))
        //    {
        //        DialogResult result = MessageBox.Show(this, "Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        switch (result)
        //        {
        //            case DialogResult.No:
        //                break;
        //            case DialogResult.Yes:
        //                //this.BindingSource.RemoveCurrent();
        //                //((Equin.ApplicationFramework.ObjectView<IUMLElement>)this.BindingSource.Current).Object.MarkDeleted();
        //                if (this.BindingSource.Current is IUMLElement)
        //                {
        //                    (this.BindingSource.Current as IUMLElement).MarkDeleted();
        //                    (this.BindingSource.List as IBindingListView).Filter = this.BindingSource.Filter;
        //                    //this.BindingSource.CurrencyManager.Refresh();
        //                }
        //                //this.BindingSource.MoveNext();
        //                break;
        //            default:
        //                break;
        //        }

        //        //this.BindingSource.RemoveCurrent();
        //        //RefreshItemsInternal();
        //    }
        //}

        protected override void RefreshItemsCore()
        {
            base.RefreshItemsCore();

            if (!this.DesignMode)
            {
                if ((this.DeleteItem != null) && (this.BindingSource != null))
                    if (this.BindingSource.Count > 0)
                        this.DeleteItem.Enabled = true;
                    else this.DeleteItem.Enabled = false;
            }
        }

    }
}
