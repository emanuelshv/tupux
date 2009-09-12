using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace TUPUX.Forms
{
    public partial class MainForm : Form
    {
        private ModelExplorerTool modelExplorerTool = new ModelExplorerTool();

        public MainForm()
        {
            InitializeComponent();

            this.modelExplorerTool.Show(this.dockPanel);
            //this.dockPanel.ActiveContent
        }

        private void dockPanel_ActiveContentChanged(object sender, EventArgs e)
        {
            if (this.dockPanel.ActiveContent is FormEdit)
            {
                this.toolBarButtonSave.Enabled = true;
            }
            else
            {
                this.toolBarButtonSave.Enabled = false;
            }
        }

        private void toolBarButtonSave_Click(object sender, EventArgs e)
        {
            if (this.dockPanel.ActiveContent is FormEdit)
            {
                FormEdit form = dockPanel.ActiveContent as FormEdit;
                form.Save();
            }

        }

        private void toolBarButtonSaveAll_Click(object sender, EventArgs e)
        {
            foreach (DockContent content in this.dockPanel.Contents)
            {
                if (content is FormEdit)
                {
                    FormEdit form = dockPanel.ActiveContent as FormEdit;
                    form.Save();
                }
            }
        }
    }
}
