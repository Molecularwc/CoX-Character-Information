namespace CoX_Character_Information
{
    partial class Form1
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
            System.Windows.Forms.Label toon_NameLabel;
            System.Windows.Forms.Label factionLabel;
            System.Windows.Forms.Label archtypeLabel;
            System.Windows.Forms.Label originLabel;
            System.Windows.Forms.Label primary_PowersetLabel;
            System.Windows.Forms.Label secondary_PowersetLabel;
            System.Windows.Forms.Label levelLabel;
            System.Windows.Forms.Label serverLabel;
            System.Windows.Forms.Label global_NameLabel;
            System.Windows.Forms.Label infLabel;
            System.Windows.Forms.Label sG_AffiliationLabel;
            System.Windows.Forms.Label sG_RankLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClose = new System.Windows.Forms.Button();
            this.characterTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.characterTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.characterTableDataGridView = new System.Windows.Forms.DataGridView();
            this.toon_NameTextBox = new System.Windows.Forms.TextBox();
            this.global_NameTextBox = new System.Windows.Forms.TextBox();
            this.infTextBox = new System.Windows.Forms.TextBox();
            this.sG_AffiliationTextBox = new System.Windows.Forms.TextBox();
            this.sG_RankTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.characterTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterDataSet = new CoX_Character_Information.characterDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterTableTableAdapter = new CoX_Character_Information.characterDataSetTableAdapters.characterTableTableAdapter();
            this.tableAdapterManager = new CoX_Character_Information.characterDataSetTableAdapters.TableAdapterManager();
            toon_NameLabel = new System.Windows.Forms.Label();
            factionLabel = new System.Windows.Forms.Label();
            archtypeLabel = new System.Windows.Forms.Label();
            originLabel = new System.Windows.Forms.Label();
            primary_PowersetLabel = new System.Windows.Forms.Label();
            secondary_PowersetLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            serverLabel = new System.Windows.Forms.Label();
            global_NameLabel = new System.Windows.Forms.Label();
            infLabel = new System.Windows.Forms.Label();
            sG_AffiliationLabel = new System.Windows.Forms.Label();
            sG_RankLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.characterTableBindingNavigator)).BeginInit();
            this.characterTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toon_NameLabel
            // 
            toon_NameLabel.AutoSize = true;
            toon_NameLabel.Location = new System.Drawing.Point(12, 39);
            toon_NameLabel.Name = "toon_NameLabel";
            toon_NameLabel.Size = new System.Drawing.Size(66, 13);
            toon_NameLabel.TabIndex = 3;
            toon_NameLabel.Text = "Toon Name:";
            // 
            // factionLabel
            // 
            factionLabel.AutoSize = true;
            factionLabel.Location = new System.Drawing.Point(232, 39);
            factionLabel.Name = "factionLabel";
            factionLabel.Size = new System.Drawing.Size(45, 13);
            factionLabel.TabIndex = 5;
            factionLabel.Text = "Faction:";
            // 
            // archtypeLabel
            // 
            archtypeLabel.AutoSize = true;
            archtypeLabel.Location = new System.Drawing.Point(452, 39);
            archtypeLabel.Name = "archtypeLabel";
            archtypeLabel.Size = new System.Drawing.Size(52, 13);
            archtypeLabel.TabIndex = 7;
            archtypeLabel.Text = "Archtype:";
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new System.Drawing.Point(672, 39);
            originLabel.Name = "originLabel";
            originLabel.Size = new System.Drawing.Size(37, 13);
            originLabel.TabIndex = 9;
            originLabel.Text = "Origin:";
            // 
            // primary_PowersetLabel
            // 
            primary_PowersetLabel.AutoSize = true;
            primary_PowersetLabel.Location = new System.Drawing.Point(12, 65);
            primary_PowersetLabel.Name = "primary_PowersetLabel";
            primary_PowersetLabel.Size = new System.Drawing.Size(91, 13);
            primary_PowersetLabel.TabIndex = 11;
            primary_PowersetLabel.Text = "Primary Powerset:";
            // 
            // secondary_PowersetLabel
            // 
            secondary_PowersetLabel.AutoSize = true;
            secondary_PowersetLabel.Location = new System.Drawing.Point(232, 65);
            secondary_PowersetLabel.Name = "secondary_PowersetLabel";
            secondary_PowersetLabel.Size = new System.Drawing.Size(108, 13);
            secondary_PowersetLabel.TabIndex = 13;
            secondary_PowersetLabel.Text = "Secondary Powerset:";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(452, 65);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(36, 13);
            levelLabel.TabIndex = 15;
            levelLabel.Text = "Level:";
            // 
            // serverLabel
            // 
            serverLabel.AutoSize = true;
            serverLabel.Location = new System.Drawing.Point(672, 65);
            serverLabel.Name = "serverLabel";
            serverLabel.Size = new System.Drawing.Size(41, 13);
            serverLabel.TabIndex = 17;
            serverLabel.Text = "Server:";
            // 
            // global_NameLabel
            // 
            global_NameLabel.AutoSize = true;
            global_NameLabel.Location = new System.Drawing.Point(12, 91);
            global_NameLabel.Name = "global_NameLabel";
            global_NameLabel.Size = new System.Drawing.Size(71, 13);
            global_NameLabel.TabIndex = 19;
            global_NameLabel.Text = "Global Name:";
            // 
            // infLabel
            // 
            infLabel.AutoSize = true;
            infLabel.Location = new System.Drawing.Point(232, 91);
            infLabel.Name = "infLabel";
            infLabel.Size = new System.Drawing.Size(22, 13);
            infLabel.TabIndex = 21;
            infLabel.Text = "Inf:";
            // 
            // sG_AffiliationLabel
            // 
            sG_AffiliationLabel.AutoSize = true;
            sG_AffiliationLabel.Location = new System.Drawing.Point(452, 91);
            sG_AffiliationLabel.Name = "sG_AffiliationLabel";
            sG_AffiliationLabel.Size = new System.Drawing.Size(70, 13);
            sG_AffiliationLabel.TabIndex = 23;
            sG_AffiliationLabel.Text = "SG Affiliation:";
            // 
            // sG_RankLabel
            // 
            sG_RankLabel.AutoSize = true;
            sG_RankLabel.Location = new System.Drawing.Point(672, 91);
            sG_RankLabel.Name = "sG_RankLabel";
            sG_RankLabel.Size = new System.Drawing.Size(54, 13);
            sG_RankLabel.TabIndex = 25;
            sG_RankLabel.Text = "SG Rank:";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClose.Location = new System.Drawing.Point(429, 565);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // characterTableBindingNavigator
            // 
            this.characterTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.characterTableBindingNavigator.BindingSource = this.characterTableBindingSource;
            this.characterTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.characterTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.characterTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.characterTableBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.characterTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.characterTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.characterTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.characterTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.characterTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.characterTableBindingNavigator.Name = "characterTableBindingNavigator";
            this.characterTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.characterTableBindingNavigator.Size = new System.Drawing.Size(943, 25);
            this.characterTableBindingNavigator.TabIndex = 1;
            this.characterTableBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // characterTableBindingNavigatorSaveItem
            // 
            this.characterTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.characterTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("characterTableBindingNavigatorSaveItem.Image")));
            this.characterTableBindingNavigatorSaveItem.Name = "characterTableBindingNavigatorSaveItem";
            this.characterTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.characterTableBindingNavigatorSaveItem.Text = "Save Data";
            this.characterTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.characterTableBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "&Help";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton2.Text = "&About";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton3.Text = "&Report";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // characterTableDataGridView
            // 
            this.characterTableDataGridView.AutoGenerateColumns = false;
            this.characterTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.characterTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.characterTableDataGridView.DataSource = this.characterTableBindingSource;
            this.characterTableDataGridView.Location = new System.Drawing.Point(12, 114);
            this.characterTableDataGridView.Name = "characterTableDataGridView";
            this.characterTableDataGridView.Size = new System.Drawing.Size(911, 445);
            this.characterTableDataGridView.TabIndex = 2;
            // 
            // toon_NameTextBox
            // 
            this.toon_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Toon Name", true));
            this.toon_NameTextBox.Location = new System.Drawing.Point(126, 36);
            this.toon_NameTextBox.Name = "toon_NameTextBox";
            this.toon_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.toon_NameTextBox.TabIndex = 0;
            // 
            // global_NameTextBox
            // 
            this.global_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Global Name", true));
            this.global_NameTextBox.Location = new System.Drawing.Point(126, 88);
            this.global_NameTextBox.Name = "global_NameTextBox";
            this.global_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.global_NameTextBox.TabIndex = 8;
            // 
            // infTextBox
            // 
            this.infTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Inf", true));
            this.infTextBox.Location = new System.Drawing.Point(346, 88);
            this.infTextBox.Name = "infTextBox";
            this.infTextBox.Size = new System.Drawing.Size(100, 20);
            this.infTextBox.TabIndex = 9;
            // 
            // sG_AffiliationTextBox
            // 
            this.sG_AffiliationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "SG Affiliation", true));
            this.sG_AffiliationTextBox.Location = new System.Drawing.Point(566, 88);
            this.sG_AffiliationTextBox.Name = "sG_AffiliationTextBox";
            this.sG_AffiliationTextBox.Size = new System.Drawing.Size(100, 20);
            this.sG_AffiliationTextBox.TabIndex = 10;
            // 
            // sG_RankTextBox
            // 
            this.sG_RankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "SG Rank", true));
            this.sG_RankTextBox.Location = new System.Drawing.Point(786, 88);
            this.sG_RankTextBox.Name = "sG_RankTextBox";
            this.sG_RankTextBox.Size = new System.Drawing.Size(100, 20);
            this.sG_RankTextBox.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Origin", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(786, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Server", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Champion",
            "Freedom",
            "Guardian",
            "Infinity",
            "Justice",
            "Liberty",
            "Pinnacle",
            "Protector",
            "Triumph",
            "Victory",
            "Virtrue"});
            this.comboBox2.Location = new System.Drawing.Point(786, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Archtype", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(566, 36);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Level", true));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.comboBox4.Location = new System.Drawing.Point(566, 62);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 21);
            this.comboBox4.TabIndex = 6;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Primary Powerset", true));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(126, 62);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 4;
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Secondary Powerset", true));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(346, 62);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(100, 21);
            this.comboBox6.TabIndex = 5;
            // 
            // comboBox7
            // 
            this.comboBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "Faction", true));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Hero",
            "Villain"});
            this.comboBox7.Location = new System.Drawing.Point(346, 36);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(100, 21);
            this.comboBox7.TabIndex = 1;
            this.comboBox7.SelectionChangeCommitted += new System.EventHandler(this.comboBox7_SelectionChangedCommited);
            // 
            // characterTableBindingSource
            // 
            this.characterTableBindingSource.DataMember = "characterTable";
            this.characterTableBindingSource.DataSource = this.characterDataSet;
            this.characterTableBindingSource.Sort = "";
            // 
            // characterDataSet
            // 
            this.characterDataSet.DataSetName = "characterDataSet";
            this.characterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Toon Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Toon Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Faction";
            this.dataGridViewTextBoxColumn2.HeaderText = "Faction";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Archtype";
            this.dataGridViewTextBoxColumn3.HeaderText = "Archtype";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Origin";
            this.dataGridViewTextBoxColumn4.HeaderText = "Origin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Primary Powerset";
            this.dataGridViewTextBoxColumn5.HeaderText = "Primary Powerset";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Secondary Powerset";
            this.dataGridViewTextBoxColumn6.HeaderText = "Secondary Powerset";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Level";
            this.dataGridViewTextBoxColumn7.HeaderText = "LvL";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 30;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Server";
            this.dataGridViewTextBoxColumn8.HeaderText = "Server";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Global Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Global Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Inf";
            this.dataGridViewTextBoxColumn10.HeaderText = "Inf";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SG Affiliation";
            this.dataGridViewTextBoxColumn11.HeaderText = "SG Affiliation";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SG Rank";
            this.dataGridViewTextBoxColumn12.HeaderText = "SG Rank";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 70;
            // 
            // characterTableTableAdapter
            // 
            this.characterTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.characterTableTableAdapter = this.characterTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CoX_Character_Information.characterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 600);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(toon_NameLabel);
            this.Controls.Add(this.toon_NameTextBox);
            this.Controls.Add(factionLabel);
            this.Controls.Add(archtypeLabel);
            this.Controls.Add(originLabel);
            this.Controls.Add(primary_PowersetLabel);
            this.Controls.Add(secondary_PowersetLabel);
            this.Controls.Add(levelLabel);
            this.Controls.Add(serverLabel);
            this.Controls.Add(global_NameLabel);
            this.Controls.Add(this.global_NameTextBox);
            this.Controls.Add(infLabel);
            this.Controls.Add(this.infTextBox);
            this.Controls.Add(sG_AffiliationLabel);
            this.Controls.Add(this.sG_AffiliationTextBox);
            this.Controls.Add(sG_RankLabel);
            this.Controls.Add(this.sG_RankTextBox);
            this.Controls.Add(this.characterTableDataGridView);
            this.Controls.Add(this.characterTableBindingNavigator);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoX Character Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterTableBindingNavigator)).EndInit();
            this.characterTableBindingNavigator.ResumeLayout(false);
            this.characterTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private characterDataSet characterDataSet;
        private System.Windows.Forms.BindingSource characterTableBindingSource;
        private CoX_Character_Information.characterDataSetTableAdapters.characterTableTableAdapter characterTableTableAdapter;
        private CoX_Character_Information.characterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator characterTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton characterTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView characterTableDataGridView;
        private System.Windows.Forms.TextBox toon_NameTextBox;
        private System.Windows.Forms.TextBox global_NameTextBox;
        private System.Windows.Forms.TextBox infTextBox;
        private System.Windows.Forms.TextBox sG_AffiliationTextBox;
        private System.Windows.Forms.TextBox sG_RankTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
    }
}

