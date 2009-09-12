using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using TUPUX.Entity;
using TUPUX.ActiveRecord;

namespace TUPUX.Forms
{
    public partial class ModelExplorerTool : ToolWindow
    {
        #region Attributes
        private TreeNode _selectedNode;
        private Dictionary<string, TreeNode> _treeNodes = new Dictionary<string, TreeNode>();

        #endregion

        #region Methods
        public ModelExplorerTool()
        {
            InitializeComponent();

            UMLProject prj = UMLProject.GetInstance();
            this.LoadTreeView(this.treeView1.Nodes, prj);
            this.treeView1.ExpandAll();
        }

        private void LoadTreeView(TreeNodeCollection nodes, IUMLElement root)
        {
            List<IUMLElement> list = root.GetOwnedElements();

            foreach (IUMLElement element in list)
            {
                TreeNode node;
                if (element is UMLUseCase)
                {
                    node = nodes.Add(element.Guid, element.Name, "useCase", "useCase");
                }
                else if (element is UMLPhase)
                {
                    node = nodes.Add(element.Guid, element.Name, "phase", "phase");
                }
                else if (element is UMLIteration)
                {
                    node = nodes.Add(element.Guid, element.Name, "iteration", "iteration");
                }
                else if (element is UMLFile)
                {
                    node = nodes.Add(element.Guid, element.Name, "file", "file");
                }
                else if ((element is UMLModel) || (element is UMLPackage) || (element is UMLSubsystem))
                {
                    node = nodes.Add(element.Guid, element.Name);
                    node.ContextMenuStrip = this.contextMenuStrip1;
                }
                else
                {
                    node = nodes.Add(element.Guid, element.Name);
                }
                node.Tag = element;
                _treeNodes.Add(element.Guid, node);

                this.LoadTreeView(node.Nodes, element);
            }
        }
        
        #endregion
        
        #region Events
        private void newUseCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UMLUseCase useCase = new UMLUseCase();
            NewFormEdit(useCase);
        }


        private void newCollaborationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UMLCollaboration collaboraion = new UMLCollaboration();
            NewFormEdit(collaboraion);
        }

        private void NewFormEdit(IUMLElement element)
        {
            element.Owner = (IUMLElement)_selectedNode.Tag;

            FormEdit form = FormsFactory.GetFormEdit(element);
            form.FormSaved += new EventHandler(form_FormSaved);

            form.Show(this.DockPanel);
        }
                
        //private TreeNode FindNode(TreeNodeCollection nodes, string key)
        //{
        //    TreeNode result = nodes[key];

        //    if (result == null)
        //    {
        //        foreach (TreeNode node in nodes)
        //        {
        //            result = FindNode(node.Nodes, key);
        //            if (result != null) return result;
        //        }
        //    }
        //    return result;
        //}
                
        #endregion

        #region Events Treeview
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            try
            {
                //StarUML.IUMLClassifier objNode = (StarUML.IUMLClassifier)e.Node.Tag;
                //objNode.Name = e.Label;
            }
            catch (Exception)
            {
                e.CancelEdit = true;
                MessageBox.Show(this, "Name Conflict", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FormEdit form = FormsFactory.GetFormEdit(e.Node.Tag as IUMLElement);
            if (form != null)
            {
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
                form.Show(this.DockPanel);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this._selectedNode = e.Node;
            if(e.Node.Tag is UMLUseCase)
            {
                this.contextMenuStrip1.Items[0].Enabled = true;
                this.contextMenuStrip1.Items[1].Enabled = true;
            }
        } 

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormEdit form = sender as FormEdit;
            FormsFactory.Remove(form.Element);
        }

        private void form_FormSaved(object sender, EventArgs e)
        {
            UseCaseEdit usecaseForm = sender as UseCaseEdit;
            //TreeNode ownerNode = FindNode(this.treeView1.Nodes, usecaseForm.UseCase.Owner.Guid);
            //TreeNode node = ownerNode.Nodes[usecaseForm.UseCase.Guid];
            TreeNode node = _treeNodes[usecaseForm.UseCase.Guid];
            
            if (node == null)
            {
                TreeNode ownerNode = _treeNodes[usecaseForm.UseCase.Owner.Guid];
                node = ownerNode.Nodes.Add(usecaseForm.UseCase.Guid, usecaseForm.UseCase.Name, "useCase", "useCase");
                node.Tag = usecaseForm.UseCase;
                _treeNodes.Add(usecaseForm.UseCase.Guid, node);
            }

            treeView1.SelectedNode = node;
        }

        #endregion

    }
}