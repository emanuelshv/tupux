using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.ActiveRecord;
using TUPUX.Entity;

namespace TUPUX.Forms
{
    public partial class ItemSelect<Item,List>: Form      
        where Item : ActiveRecord<Item>, new()
        where List : ActiveList<Item, List>, new()
    {
        #region Attributes and Properties

        private List _selectedList;
        
        private List _aux;

        public List SelectedList
        {
            get
            {
                if (_selectedList == null)
                    _selectedList = new List();
                return _selectedList; 
            }
            set 
            {
                _selectedList = value; 
            }
        }

        #endregion

        public ItemSelect(List listLoad)
        {
            InitializeComponent();
            _aux = listLoad;
            LoadTreeView(listLoad);
        }

        #region Events

        private void btnOk_Click(object sender, EventArgs e)
        {
            getSelectedNodes();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedList = _aux;
            DialogResult = DialogResult.None;
            this.Close();
        }

        #endregion

        #region Methods

        private void LoadTreeView(List listLoad) 
        {
            List list = UMLProject.GetInstance().GetUMLElements<Item,List>();
            foreach (Item i in list)
            {
                TreeNode node = new TreeNode();
                IUMLElement model = (IUMLElement)i;
                node.Text = model.Name;
                node.Tag = i;                
                
                if (listLoad != null)
                {
                    foreach (Item iLoad in listLoad)
                    {
                        if (i.Guid == iLoad.Guid) 
                        {
                            node.Checked = true;
                            //listLoad.Remove(iLoad);
                            break;
                        }
                    }
                }

                treeViewItems.Nodes.Add(node);
            }            
            treeViewItems.ExpandAll();
        }

        private void getSelectedNodes()
        {
            foreach (TreeNode node in treeViewItems.Nodes)
            {
                if (node.Checked)
                {
                    SelectedList.Add((Item)node.Tag);
                }
            }
        }

        #endregion
    }
}