using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TUPUX.Entity;
using TUPUX.Forms.Util;

namespace TUPUX.Forms
{
    public partial class CollaborationEdit : FormEdit
    {
        #region Attributes and Properties

        private bool _load = false;

        private bool _changed = true;
        
        private UMLFile fileAux;
        
        private UMLFlowCollection flows;
        
        private UMLStepFlowCollection flowSteps;

        private UMLFlow selectedFlow;

        public UMLCollaboration Collaboration
        {
            get { return _element as UMLCollaboration; }
            set
            {
                _element = value;
                this.uMLCollaborationBindingSource.DataSource = value;
            }
        }

        #endregion
        
        public CollaborationEdit(UMLCollaboration collaboration)
        {

            InitializeComponent();
            
            Collaboration = collaboration;

            LoadCollaboration();


            int selectIndex = -1;
            typeCombobox.Items.Add(new ComboboxItem("External input", "EI"));
            if ("EI" == collaboration.Type) selectIndex = 0;
            typeCombobox.Items.Add(new ComboboxItem("External output", "EO"));
            if ("EO" == collaboration.Type) selectIndex = 1;
            typeCombobox.Items.Add(new ComboboxItem("External inquery", "EQ"));
            if ("EQ" == collaboration.Type) selectIndex = 2;

            typeCombobox.SelectedIndex = selectIndex;

            tabCollection.TabPages.RemoveAt(1);
            _load = true;
        }

        #region Methods Load

        private void LoadCollaboration()
        {
            Collaboration.LoadCollections();
            this.uMLCollaborationBindingSource.DataSource = Collaboration;
            LoadTreeViewFiles();
            LoadTreeViewAux();
            LoadFlows();
        }

        private void LoadFlows()
        {
            if (Collaboration.Owner is UMLUseCase)
            {
                flows = (Collaboration.Owner as UMLUseCase).GetFlows();
                this.uMLFlowCollectionBindingSource.DataSource = flows;

                if (Collaboration.Steps.Count > 0)
                {
                    UMLStepFlow stepCollaboration = Collaboration.Steps[0];
                    foreach (UMLFlow flow in flows)
                    {
                        UMLStepFlowCollection stepsFlow = flow.GetStepFlows();
                        bool find = false;
                        if (stepsFlow.Count > 0)
                        {
                            foreach (UMLStepFlow s in stepsFlow)
                            {
                                if (s.Guid == stepCollaboration.Guid)
                                {
                                    flowSteps = stepsFlow;
                                    find = true;
                                    this.ddlFLows.SelectedItem = selectedFlow = flow;
                                    break;
                                }
                            }
                        }
                        if (find) break;
                    }


                    if (flowSteps != null)
                    {
                        if (flowSteps.Count > 0 && Collaboration.Steps.Count > 0)
                        {
                            foreach (UMLStepFlow s in flowSteps)
                            {
                                bool find = false;
                                foreach (UMLStepFlow step in Collaboration.Steps)
                                {
                                    if (step.Guid == s.Guid)
                                    {
                                        find = true;
                                        break;
                                    }
                                }
                                TreeNode nodeStep = new TreeNode();
                                nodeStep.Tag = s;
                                nodeStep.Checked = find;
                                nodeStep.Text = s.Name;
                                treeViewFlows.Nodes.Add(nodeStep);
                            }
                            treeViewFlows.ExpandAll();
                        }
                    }
                }

            }

        }

        #endregion

        #region LoadTreeView

        private void LoadTreeViewFiles()
        {
            foreach (UMLFile file in Collaboration.Files)
            {
                TreeNode node = new TreeNode();
                node.Text = file.Name;
                node.Tag = file;
                LoadTreeViewAttributes(node);
                treeViewFiles.Nodes.Add(node);
            }
            treeViewFiles.ExpandAll();
        }

        public void LoadTreeViewAttributes(TreeNode fileNode)
        {
            UMLFile file = (UMLFile)fileNode.Tag;
            bool checkFile = false;
            file.LoadCollections();
            UMLAttributeCollection attributes = file.Attributes;

            foreach (UMLAttribute fileAttribute in attributes)
            {
                TreeNode node = new TreeNode();                
                node.Text = fileAttribute.Name;
                node.Tag = fileAttribute;

                foreach (UMLAttribute collaborationAttribute in Collaboration.Dets)
                {
                    if (collaborationAttribute.Guid == fileAttribute.Guid)
                    {
                        node.Checked = true;
                        checkFile = true;
                        break;
                    }
                }
                                
                fileNode.Nodes.Add(node);
            }
            fileNode.Checked = checkFile;
        }

        private void LoadTreeViewAux()
        {
            fileAux = Collaboration.GetFileAux();
            TreeNode node = new TreeNode();
            node.Text = fileAux.Name;
            node.Tag = fileAux;
            LoadTreeViewAttributes(node);
            treeViewAux.Nodes.Add(node);

            treeViewAux.ExpandAll();
        }
                
        #endregion

        #region Events
        
        private void treeViewFiles_AfterCheck(object sender, TreeViewEventArgs e)
        {
            ChangeDet(e);
        }
        
        private void treeViewFlows_AfterCheck(object sender, TreeViewEventArgs e)
        {
            ChangeStep(e);
        }
        
        private void treeViewAux_AfterCheck(object sender, TreeViewEventArgs e)
        {
            ChangeDet(e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (treeViewAux.Nodes.Count > 0)
            {
                AttributeName getName = new AttributeName();
                if (getName.ShowDialog() == DialogResult.OK)
                {
                    TreeNode fileNode = treeViewAux.Nodes[0];
                    UMLFile file = (UMLFile)fileNode.Tag;

                    UMLAttribute attribute = new UMLAttribute();
                    attribute.Owner = file;
                    attribute.Name = getName.NameAttribute;
                    file.Attributes.Add(attribute);
                    TreeNode newNode = new TreeNode();
                    newNode.Tag = attribute;
                    newNode.Text = getName.NameAttribute;
                    fileNode.Nodes.Add(newNode);
                    fileNode.ExpandAll();
                }
            }
        }

        private void ddlFLows_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlFLows.SelectedItem != null && ddlFLows.SelectedItem != selectedFlow)
            {
                if (StepsChecked())
                {

                    if (MessageBox.Show("The steps selected will be removed. Do you want continue?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        ddlFLows.SelectedItem = selectedFlow;
                        return;
                    }
                    Collaboration.Steps.Clear();
                    LoadSelectedFlow();
                }
                else
                {
                    Collaboration.Steps.Clear();
                    LoadSelectedFlow();
                }
            }

        }
        
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

        private void ChangeDet(TreeViewEventArgs e)
        {
            if (e.Node.Tag is UMLAttribute)
            {
                if (e.Node.Checked)
                {
                    Collaboration.AddDet((UMLAttribute)e.Node.Tag);
                }
                else
                {
                    Collaboration.RemoveDet((UMLAttribute)e.Node.Tag);
                }
            }
            else if (e.Node.Tag is UMLFile)
            {
                foreach (TreeNode nod in e.Node.Nodes)
                {
                    nod.Checked = e.Node.Checked;
                    if (e.Node.Checked)
                    {
                        Collaboration.AddDet((UMLAttribute)nod.Tag);
                    }
                    else
                    {
                        Collaboration.RemoveDet((UMLAttribute)nod.Tag);
                    }
                }

            }
        }

        private void LoadSelectedFlow()
        {
            selectedFlow = (UMLFlow)ddlFLows.SelectedItem;
            if (selectedFlow != null)
            {
                treeViewFlows.Nodes.Clear();
                foreach (UMLStepFlow step in selectedFlow.GetStepFlows())
                {
                    TreeNode nodeStep = new TreeNode();
                    nodeStep.Tag = step;
                    nodeStep.Text = step.Name;
                    treeViewFlows.Nodes.Add(nodeStep);
                }
                treeViewFlows.ExpandAll();
            }
        }

        private bool StepsChecked()
        {
            foreach (TreeNode node in treeViewFlows.Nodes)
            {
                if (node.Checked)
                {
                    return true;
                }
            }

            return false;
        }
        
        private void ChangeStep(TreeViewEventArgs e)
        {
            if (e.Node.Tag is UMLStepFlow)
            {
                if (e.Node.Checked)
                {
                    Collaboration.AddStep((UMLStepFlow)e.Node.Tag);
                }
                else
                {
                    Collaboration.RemoveStep((UMLStepFlow)e.Node.Tag);
                }
            }
        }

        protected override void DoSave()
        {
            //this.useCaseBindingSource.EndEdit();
            this.Collaboration.MarkModified();
            if (fileAux != null)
            {
                fileAux.MarkModified();
                fileAux.SaveImport();
            }
            this.Collaboration.SaveEdit();
        }

        protected override bool IsChanged()
        {
            _changed = this.Collaboration.State != TUPUX.ActiveRecord.RecordState.Loaded;
            return _changed;
        }

        #endregion

        private void typeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_load)
            {
                this.Collaboration.Type = ((ComboboxItem)typeCombobox.SelectedItem).Value.ToString();
            }
        }
    }
}