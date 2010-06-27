namespace TUPUX.Forms
{
    partial class CollaborationEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label generateActionLabel;
            System.Windows.Forms.Label actionFunctionPointsLabel;
            System.Windows.Forms.Label sendMessageLabel;
            System.Windows.Forms.Label totalFunctionPointsLabel;
            System.Windows.Forms.Label filesFunctionPointsLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollaborationEdit));
            this.generateActionCheckBox = new System.Windows.Forms.CheckBox();
            this.uMLCollaborationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.totalFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.filesFunctionPointsTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tabCollection = new System.Windows.Forms.TabControl();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.groupBoxAux = new System.Windows.Forms.GroupBox();
            this.navigationAuxFile = new TUPUX.Controls.UMLNavigator();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.treeViewAux = new System.Windows.Forms.TreeView();
            this.tabSteps = new System.Windows.Forms.TabPage();
            this.gbxFlows = new System.Windows.Forms.GroupBox();
            this.gbxSteps = new System.Windows.Forms.GroupBox();
            this.treeViewFlows = new System.Windows.Forms.TreeView();
            this.ddlFLows = new System.Windows.Forms.ComboBox();
            this.uMLFlowCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFlows = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.rfvName = new CustomValidation.RequiredFieldValidator();
            this.validationSummary = new CustomValidation.ValidationSummary();
            this.frmValidator = new CustomValidation.FormValidator();
            this.rfvType = new CustomValidation.RequiredFieldValidator();
            this.groupBoxEstimation = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            generateActionLabel = new System.Windows.Forms.Label();
            actionFunctionPointsLabel = new System.Windows.Forms.Label();
            sendMessageLabel = new System.Windows.Forms.Label();
            totalFunctionPointsLabel = new System.Windows.Forms.Label();
            filesFunctionPointsLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uMLCollaborationBindingSource)).BeginInit();
            this.tabCollection.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.groupBoxAux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationAuxFile)).BeginInit();
            this.navigationAuxFile.SuspendLayout();
            this.tabSteps.SuspendLayout();
            this.gbxFlows.SuspendLayout();
            this.gbxSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvType)).BeginInit();
            this.groupBoxEstimation.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateActionLabel
            // 
            generateActionLabel.AutoSize = true;
            generateActionLabel.Location = new System.Drawing.Point(6, 68);
            generateActionLabel.Name = "generateActionLabel";
            generateActionLabel.Size = new System.Drawing.Size(87, 13);
            generateActionLabel.TabIndex = 4;
            generateActionLabel.Text = "Generate Action:";
            // 
            // actionFunctionPointsLabel
            // 
            actionFunctionPointsLabel.AutoSize = true;
            actionFunctionPointsLabel.Location = new System.Drawing.Point(6, 16);
            actionFunctionPointsLabel.Name = "actionFunctionPointsLabel";
            actionFunctionPointsLabel.Size = new System.Drawing.Size(90, 13);
            actionFunctionPointsLabel.TabIndex = 8;
            actionFunctionPointsLabel.Text = "Transaction UFP:";
            // 
            // sendMessageLabel
            // 
            sendMessageLabel.AutoSize = true;
            sendMessageLabel.Location = new System.Drawing.Point(6, 91);
            sendMessageLabel.Name = "sendMessageLabel";
            sendMessageLabel.Size = new System.Drawing.Size(81, 13);
            sendMessageLabel.TabIndex = 6;
            sendMessageLabel.Text = "Send Message:";
            // 
            // totalFunctionPointsLabel
            // 
            totalFunctionPointsLabel.AutoSize = true;
            totalFunctionPointsLabel.Location = new System.Drawing.Point(6, 68);
            totalFunctionPointsLabel.Name = "totalFunctionPointsLabel";
            totalFunctionPointsLabel.Size = new System.Drawing.Size(58, 13);
            totalFunctionPointsLabel.TabIndex = 12;
            totalFunctionPointsLabel.Text = "Total UFP:";
            // 
            // filesFunctionPointsLabel
            // 
            filesFunctionPointsLabel.AutoSize = true;
            filesFunctionPointsLabel.Location = new System.Drawing.Point(6, 42);
            filesFunctionPointsLabel.Name = "filesFunctionPointsLabel";
            filesFunctionPointsLabel.Size = new System.Drawing.Size(55, 13);
            filesFunctionPointsLabel.TabIndex = 10;
            filesFunctionPointsLabel.Text = "Files UFP:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(6, 42);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 2;
            typeLabel.Text = "Type:";
            // 
            // generateActionCheckBox
            // 
            this.generateActionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uMLCollaborationBindingSource, "GenerateAction", true));
            this.generateActionCheckBox.Location = new System.Drawing.Point(117, 63);
            this.generateActionCheckBox.Name = "generateActionCheckBox";
            this.generateActionCheckBox.Size = new System.Drawing.Size(104, 24);
            this.generateActionCheckBox.TabIndex = 5;
            // 
            // uMLCollaborationBindingSource
            // 
            this.uMLCollaborationBindingSource.DataSource = typeof(TUPUX.Entity.UMLCollaboration);
            // 
            // actionFunctionPointsTextBox
            // 
            this.actionFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLCollaborationBindingSource, "ActionFunctionPoints", true));
            this.actionFunctionPointsTextBox.Location = new System.Drawing.Point(128, 13);
            this.actionFunctionPointsTextBox.Name = "actionFunctionPointsTextBox";
            this.actionFunctionPointsTextBox.ReadOnly = true;
            this.actionFunctionPointsTextBox.Size = new System.Drawing.Size(75, 20);
            this.actionFunctionPointsTextBox.TabIndex = 9;
            this.actionFunctionPointsTextBox.TabStop = false;
            // 
            // sendMessageCheckBox
            // 
            this.sendMessageCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uMLCollaborationBindingSource, "SendMessage", true));
            this.sendMessageCheckBox.Location = new System.Drawing.Point(117, 86);
            this.sendMessageCheckBox.Name = "sendMessageCheckBox";
            this.sendMessageCheckBox.Size = new System.Drawing.Size(104, 24);
            this.sendMessageCheckBox.TabIndex = 7;
            // 
            // totalFunctionPointsTextBox
            // 
            this.totalFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLCollaborationBindingSource, "TotalFunctionPoints", true));
            this.totalFunctionPointsTextBox.Location = new System.Drawing.Point(128, 65);
            this.totalFunctionPointsTextBox.Name = "totalFunctionPointsTextBox";
            this.totalFunctionPointsTextBox.ReadOnly = true;
            this.totalFunctionPointsTextBox.Size = new System.Drawing.Size(75, 20);
            this.totalFunctionPointsTextBox.TabIndex = 13;
            this.totalFunctionPointsTextBox.TabStop = false;
            // 
            // filesFunctionPointsTextBox
            // 
            this.filesFunctionPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLCollaborationBindingSource, "FilesFunctionPoints", true));
            this.filesFunctionPointsTextBox.Location = new System.Drawing.Point(128, 39);
            this.filesFunctionPointsTextBox.Name = "filesFunctionPointsTextBox";
            this.filesFunctionPointsTextBox.ReadOnly = true;
            this.filesFunctionPointsTextBox.Size = new System.Drawing.Size(75, 20);
            this.filesFunctionPointsTextBox.TabIndex = 11;
            this.filesFunctionPointsTextBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLCollaborationBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(117, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(195, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // tabCollection
            // 
            this.tabCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCollection.Controls.Add(this.tabFiles);
            this.tabCollection.Controls.Add(this.tabSteps);
            this.tabCollection.Location = new System.Drawing.Point(15, 135);
            this.tabCollection.Name = "tabCollection";
            this.tabCollection.SelectedIndex = 0;
            this.tabCollection.Size = new System.Drawing.Size(562, 441);
            this.tabCollection.TabIndex = 14;
            // 
            // tabFiles
            // 
            this.tabFiles.Controls.Add(this.splitContainer);
            this.tabFiles.Location = new System.Drawing.Point(4, 22);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiles.Size = new System.Drawing.Size(554, 415);
            this.tabFiles.TabIndex = 0;
            this.tabFiles.Text = "Associated Files";
            this.tabFiles.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(6, 6);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBoxFiles);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBoxAux);
            this.splitContainer.Size = new System.Drawing.Size(542, 402);
            this.splitContainer.SplitterDistance = 182;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 1;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiles.Controls.Add(this.treeViewFiles);
            this.groupBoxFiles.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(536, 176);
            this.groupBoxFiles.TabIndex = 1;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewFiles.CheckBoxes = true;
            this.treeViewFiles.Location = new System.Drawing.Point(6, 19);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(524, 149);
            this.treeViewFiles.TabIndex = 0;
            this.treeViewFiles.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterCheck);
            // 
            // groupBoxAux
            // 
            this.groupBoxAux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAux.Controls.Add(this.navigationAuxFile);
            this.groupBoxAux.Controls.Add(this.treeViewAux);
            this.groupBoxAux.Location = new System.Drawing.Point(9, 12);
            this.groupBoxAux.Name = "groupBoxAux";
            this.groupBoxAux.Size = new System.Drawing.Size(524, 185);
            this.groupBoxAux.TabIndex = 2;
            this.groupBoxAux.TabStop = false;
            this.groupBoxAux.Text = "Additional DETs";
            // 
            // navigationAuxFile
            // 
            this.navigationAuxFile.AddNewItem = null;
            this.navigationAuxFile.CountItem = null;
            this.navigationAuxFile.DeleteItem = null;
            this.navigationAuxFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator1});
            this.navigationAuxFile.Location = new System.Drawing.Point(3, 16);
            this.navigationAuxFile.MoveFirstItem = null;
            this.navigationAuxFile.MoveLastItem = null;
            this.navigationAuxFile.MoveNextItem = null;
            this.navigationAuxFile.MovePreviousItem = null;
            this.navigationAuxFile.Name = "navigationAuxFile";
            this.navigationAuxFile.PositionItem = null;
            this.navigationAuxFile.Size = new System.Drawing.Size(518, 25);
            this.navigationAuxFile.TabIndex = 1;
            this.navigationAuxFile.Text = "umlNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // treeViewAux
            // 
            this.treeViewAux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewAux.CheckBoxes = true;
            this.treeViewAux.Location = new System.Drawing.Point(6, 44);
            this.treeViewAux.Name = "treeViewAux";
            this.treeViewAux.Size = new System.Drawing.Size(512, 135);
            this.treeViewAux.TabIndex = 0;
            this.treeViewAux.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAux_AfterCheck);
            // 
            // tabSteps
            // 
            this.tabSteps.Controls.Add(this.gbxFlows);
            this.tabSteps.Location = new System.Drawing.Point(4, 22);
            this.tabSteps.Name = "tabSteps";
            this.tabSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tabSteps.Size = new System.Drawing.Size(554, 415);
            this.tabSteps.TabIndex = 1;
            this.tabSteps.Text = "Steps";
            this.tabSteps.UseVisualStyleBackColor = true;
            // 
            // gbxFlows
            // 
            this.gbxFlows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFlows.Controls.Add(this.gbxSteps);
            this.gbxFlows.Controls.Add(this.ddlFLows);
            this.gbxFlows.Controls.Add(this.lblFlows);
            this.gbxFlows.Location = new System.Drawing.Point(6, 6);
            this.gbxFlows.Name = "gbxFlows";
            this.gbxFlows.Size = new System.Drawing.Size(542, 386);
            this.gbxFlows.TabIndex = 0;
            this.gbxFlows.TabStop = false;
            this.gbxFlows.Text = "Flows";
            // 
            // gbxSteps
            // 
            this.gbxSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSteps.Controls.Add(this.treeViewFlows);
            this.gbxSteps.Location = new System.Drawing.Point(10, 44);
            this.gbxSteps.Name = "gbxSteps";
            this.gbxSteps.Size = new System.Drawing.Size(526, 336);
            this.gbxSteps.TabIndex = 3;
            this.gbxSteps.TabStop = false;
            this.gbxSteps.Text = "Steps";
            // 
            // treeViewFlows
            // 
            this.treeViewFlows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewFlows.CheckBoxes = true;
            this.treeViewFlows.Location = new System.Drawing.Point(6, 19);
            this.treeViewFlows.Name = "treeViewFlows";
            this.treeViewFlows.Size = new System.Drawing.Size(510, 311);
            this.treeViewFlows.TabIndex = 2;
            this.treeViewFlows.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFlows_AfterCheck);
            // 
            // ddlFLows
            // 
            this.ddlFLows.DataSource = this.uMLFlowCollectionBindingSource;
            this.ddlFLows.DisplayMember = "Name";
            this.ddlFLows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFLows.FormattingEnabled = true;
            this.ddlFLows.Location = new System.Drawing.Point(98, 17);
            this.ddlFLows.Name = "ddlFLows";
            this.ddlFLows.Size = new System.Drawing.Size(206, 21);
            this.ddlFLows.TabIndex = 1;
            this.ddlFLows.SelectedIndexChanged += new System.EventHandler(this.ddlFLows_SelectedIndexChanged);
            // 
            // uMLFlowCollectionBindingSource
            // 
            this.uMLFlowCollectionBindingSource.DataSource = typeof(TUPUX.Entity.UMLFlowCollection);
            // 
            // lblFlows
            // 
            this.lblFlows.AutoSize = true;
            this.lblFlows.Location = new System.Drawing.Point(13, 20);
            this.lblFlows.Name = "lblFlows";
            this.lblFlows.Size = new System.Drawing.Size(34, 13);
            this.lblFlows.TabIndex = 0;
            this.lblFlows.Text = "Flows";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(417, 582);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(498, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // typeCombobox
            // 
            this.typeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Location = new System.Drawing.Point(117, 39);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(195, 21);
            this.typeCombobox.TabIndex = 3;
            this.typeCombobox.SelectedIndexChanged += new System.EventHandler(this.typeCombobox_SelectedIndexChanged);
            // 
            // rfvName
            // 
            this.rfvName.ControlToValidate = this.nameTextBox;
            this.rfvName.ErrorMessage = "Name is empty";
            this.rfvName.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvName.Icon")));
            // 
            // frmValidator
            // 
            this.frmValidator.HostingForm = this;
            this.validationSummary.SetShowSummary(this.frmValidator, true);
            // 
            // rfvType
            // 
            this.rfvType.ControlToValidate = this.typeCombobox;
            this.rfvType.ErrorMessage = "Type is empty";
            this.rfvType.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvType.Icon")));
            // 
            // groupBoxEstimation
            // 
            this.groupBoxEstimation.Controls.Add(totalFunctionPointsLabel);
            this.groupBoxEstimation.Controls.Add(this.totalFunctionPointsTextBox);
            this.groupBoxEstimation.Controls.Add(filesFunctionPointsLabel);
            this.groupBoxEstimation.Controls.Add(this.filesFunctionPointsTextBox);
            this.groupBoxEstimation.Controls.Add(actionFunctionPointsLabel);
            this.groupBoxEstimation.Controls.Add(this.actionFunctionPointsTextBox);
            this.groupBoxEstimation.Location = new System.Drawing.Point(351, 13);
            this.groupBoxEstimation.Name = "groupBoxEstimation";
            this.groupBoxEstimation.Size = new System.Drawing.Size(218, 116);
            this.groupBoxEstimation.TabIndex = 17;
            this.groupBoxEstimation.TabStop = false;
            this.groupBoxEstimation.Text = "Estimation Values";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.txtType);
            this.groupBoxInfo.Controls.Add(nameLabel);
            this.groupBoxInfo.Controls.Add(this.generateActionCheckBox);
            this.groupBoxInfo.Controls.Add(this.typeCombobox);
            this.groupBoxInfo.Controls.Add(generateActionLabel);
            this.groupBoxInfo.Controls.Add(typeLabel);
            this.groupBoxInfo.Controls.Add(this.sendMessageCheckBox);
            this.groupBoxInfo.Controls.Add(sendMessageLabel);
            this.groupBoxInfo.Controls.Add(this.nameTextBox);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 13);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(333, 116);
            this.groupBoxInfo.TabIndex = 18;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Collaboration Information";
            // 
            // txtType
            // 
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uMLCollaborationBindingSource, "Type", true));
            this.txtType.Location = new System.Drawing.Point(138, 65);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 8;
            this.txtType.Visible = false;
            // 
            // CollaborationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 617);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxEstimation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabCollection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollaborationEdit";
            this.TabText = "Transaction Edit";
            this.Text = "Transaction Edit";
            ((System.ComponentModel.ISupportInitialize)(this.uMLCollaborationBindingSource)).EndInit();
            this.tabCollection.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxAux.ResumeLayout(false);
            this.groupBoxAux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationAuxFile)).EndInit();
            this.navigationAuxFile.ResumeLayout(false);
            this.navigationAuxFile.PerformLayout();
            this.tabSteps.ResumeLayout(false);
            this.gbxFlows.ResumeLayout(false);
            this.gbxFlows.PerformLayout();
            this.gbxSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uMLFlowCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvType)).EndInit();
            this.groupBoxEstimation.ResumeLayout(false);
            this.groupBoxEstimation.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource uMLCollaborationBindingSource;
        private System.Windows.Forms.CheckBox generateActionCheckBox;
        private System.Windows.Forms.TextBox actionFunctionPointsTextBox;
        private System.Windows.Forms.CheckBox sendMessageCheckBox;
        private System.Windows.Forms.TextBox totalFunctionPointsTextBox;
        private System.Windows.Forms.TextBox filesFunctionPointsTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TabControl tabCollection;
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.TreeView treeViewFiles;
        private System.Windows.Forms.TabPage tabSteps;
        private System.Windows.Forms.GroupBox groupBoxAux;
        private System.Windows.Forms.TreeView treeViewAux;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox typeCombobox;
        private TUPUX.Controls.UMLNavigator navigationAuxFile;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.GroupBox gbxFlows;
        private System.Windows.Forms.Label lblFlows;
        private System.Windows.Forms.ComboBox ddlFLows;
        private System.Windows.Forms.BindingSource uMLFlowCollectionBindingSource;
        private System.Windows.Forms.TreeView treeViewFlows;
        private System.Windows.Forms.GroupBox gbxSteps;
        private CustomValidation.RequiredFieldValidator rfvName;
        private CustomValidation.ValidationSummary validationSummary;
        private CustomValidation.FormValidator frmValidator;
        private CustomValidation.RequiredFieldValidator rfvType;
        private System.Windows.Forms.GroupBox groupBoxEstimation;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtType;
    }
}