namespace group_project_i_brownie_bandits
{
    partial class SoccerTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoccerTeamForm));
            this.teamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.teamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teamsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxFilter = new System.Windows.Forms.GroupBox();
            this.grpBoxOperators = new System.Windows.Forms.GroupBox();
            this.rdbtnGreaterThan = new System.Windows.Forms.RadioButton();
            this.rdbtnLessThan = new System.Windows.Forms.RadioButton();
            this.rdbtnEquals = new System.Windows.Forms.RadioButton();
            this.grpBoxField = new System.Windows.Forms.GroupBox();
            this.rdbtnLosses = new System.Windows.Forms.RadioButton();
            this.rdbtnWins = new System.Windows.Forms.RadioButton();
            this.btnFilterBy = new System.Windows.Forms.Button();
            this.txtboxFilter = new System.Windows.Forms.TextBox();
            this.lblMLBTeamTitle = new System.Windows.Forms.Label();
            this.grpboxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchBy = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.rdbtnPark = new System.Windows.Forms.RadioButton();
            this.rdbtnName = new System.Windows.Forms.RadioButton();
            this.rdbtnTeam = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseballDBDataSet = new group_project_i_brownie_bandits.BaseballDBDataSet();
            this.teamsTableAdapter = new group_project_i_brownie_bandits.BaseballDBDataSetTableAdapters.TeamsTableAdapter();
            this.tableAdapterManager = new group_project_i_brownie_bandits.BaseballDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).BeginInit();
            this.teamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).BeginInit();
            this.grpBoxFilter.SuspendLayout();
            this.grpBoxOperators.SuspendLayout();
            this.grpBoxField.SuspendLayout();
            this.grpboxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // teamsBindingNavigator
            // 
            this.teamsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teamsBindingNavigator.BindingSource = this.teamsBindingSource;
            this.teamsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teamsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teamsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.teamsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.teamsBindingNavigatorSaveItem});
            this.teamsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teamsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teamsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teamsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teamsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teamsBindingNavigator.Name = "teamsBindingNavigator";
            this.teamsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teamsBindingNavigator.Size = new System.Drawing.Size(1198, 38);
            this.teamsBindingNavigator.TabIndex = 0;
            this.teamsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // teamsBindingNavigatorSaveItem
            // 
            this.teamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teamsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teamsBindingNavigatorSaveItem.Image")));
            this.teamsBindingNavigatorSaveItem.Name = "teamsBindingNavigatorSaveItem";
            this.teamsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.teamsBindingNavigatorSaveItem.Text = "Save Data";
            this.teamsBindingNavigatorSaveItem.Click += new System.EventHandler(this.teamsBindingNavigatorSaveItem_Click);
            // 
            // teamsDataGridView
            // 
            this.teamsDataGridView.AutoGenerateColumns = false;
            this.teamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.teamsDataGridView.DataSource = this.teamsBindingSource;
            this.teamsDataGridView.Location = new System.Drawing.Point(487, 36);
            this.teamsDataGridView.Name = "teamsDataGridView";
            this.teamsDataGridView.RowHeadersWidth = 62;
            this.teamsDataGridView.RowTemplate.Height = 28;
            this.teamsDataGridView.Size = new System.Drawing.Size(699, 535);
            this.teamsDataGridView.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 48);
            this.label2.TabIndex = 25;
            // 
            // grpBoxFilter
            // 
            this.grpBoxFilter.Controls.Add(this.grpBoxOperators);
            this.grpBoxFilter.Controls.Add(this.grpBoxField);
            this.grpBoxFilter.Controls.Add(this.btnFilterBy);
            this.grpBoxFilter.Controls.Add(this.txtboxFilter);
            this.grpBoxFilter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFilter.Location = new System.Drawing.Point(19, 293);
            this.grpBoxFilter.Name = "grpBoxFilter";
            this.grpBoxFilter.Size = new System.Drawing.Size(446, 193);
            this.grpBoxFilter.TabIndex = 24;
            this.grpBoxFilter.TabStop = false;
            this.grpBoxFilter.Text = "Filter By:";
            // 
            // grpBoxOperators
            // 
            this.grpBoxOperators.Controls.Add(this.rdbtnGreaterThan);
            this.grpBoxOperators.Controls.Add(this.rdbtnLessThan);
            this.grpBoxOperators.Controls.Add(this.rdbtnEquals);
            this.grpBoxOperators.Location = new System.Drawing.Point(4, 77);
            this.grpBoxOperators.Name = "grpBoxOperators";
            this.grpBoxOperators.Size = new System.Drawing.Size(428, 56);
            this.grpBoxOperators.TabIndex = 7;
            this.grpBoxOperators.TabStop = false;
            this.grpBoxOperators.Text = "Operators";
            // 
            // rdbtnGreaterThan
            // 
            this.rdbtnGreaterThan.AutoSize = true;
            this.rdbtnGreaterThan.Location = new System.Drawing.Point(253, 27);
            this.rdbtnGreaterThan.Name = "rdbtnGreaterThan";
            this.rdbtnGreaterThan.Size = new System.Drawing.Size(170, 23);
            this.rdbtnGreaterThan.TabIndex = 2;
            this.rdbtnGreaterThan.TabStop = true;
            this.rdbtnGreaterThan.Text = "Greater Than(>)";
            this.rdbtnGreaterThan.UseVisualStyleBackColor = true;
            // 
            // rdbtnLessThan
            // 
            this.rdbtnLessThan.AutoSize = true;
            this.rdbtnLessThan.Location = new System.Drawing.Point(115, 27);
            this.rdbtnLessThan.Name = "rdbtnLessThan";
            this.rdbtnLessThan.Size = new System.Drawing.Size(142, 23);
            this.rdbtnLessThan.TabIndex = 1;
            this.rdbtnLessThan.TabStop = true;
            this.rdbtnLessThan.Text = "Less Than(<)";
            this.rdbtnLessThan.UseVisualStyleBackColor = true;
            // 
            // rdbtnEquals
            // 
            this.rdbtnEquals.AutoSize = true;
            this.rdbtnEquals.Location = new System.Drawing.Point(6, 26);
            this.rdbtnEquals.Name = "rdbtnEquals";
            this.rdbtnEquals.Size = new System.Drawing.Size(114, 23);
            this.rdbtnEquals.TabIndex = 0;
            this.rdbtnEquals.TabStop = true;
            this.rdbtnEquals.Text = "Equals(=)";
            this.rdbtnEquals.UseVisualStyleBackColor = true;
            // 
            // grpBoxField
            // 
            this.grpBoxField.Controls.Add(this.rdbtnLosses);
            this.grpBoxField.Controls.Add(this.rdbtnWins);
            this.grpBoxField.Location = new System.Drawing.Point(4, 22);
            this.grpBoxField.Name = "grpBoxField";
            this.grpBoxField.Size = new System.Drawing.Size(423, 49);
            this.grpBoxField.TabIndex = 6;
            this.grpBoxField.TabStop = false;
            this.grpBoxField.Text = "Field";
            // 
            // rdbtnLosses
            // 
            this.rdbtnLosses.AutoSize = true;
            this.rdbtnLosses.Location = new System.Drawing.Point(211, 20);
            this.rdbtnLosses.Name = "rdbtnLosses";
            this.rdbtnLosses.Size = new System.Drawing.Size(87, 23);
            this.rdbtnLosses.TabIndex = 1;
            this.rdbtnLosses.TabStop = true;
            this.rdbtnLosses.Text = "Losses";
            this.rdbtnLosses.UseVisualStyleBackColor = true;
            // 
            // rdbtnWins
            // 
            this.rdbtnWins.AutoSize = true;
            this.rdbtnWins.Location = new System.Drawing.Point(115, 20);
            this.rdbtnWins.Name = "rdbtnWins";
            this.rdbtnWins.Size = new System.Drawing.Size(73, 23);
            this.rdbtnWins.TabIndex = 0;
            this.rdbtnWins.TabStop = true;
            this.rdbtnWins.Text = "Wins";
            this.rdbtnWins.UseVisualStyleBackColor = true;
            // 
            // btnFilterBy
            // 
            this.btnFilterBy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFilterBy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFilterBy.Location = new System.Drawing.Point(245, 150);
            this.btnFilterBy.Name = "btnFilterBy";
            this.btnFilterBy.Size = new System.Drawing.Size(90, 32);
            this.btnFilterBy.TabIndex = 5;
            this.btnFilterBy.Text = "Filter";
            this.btnFilterBy.UseVisualStyleBackColor = false;
            this.btnFilterBy.Click += new System.EventHandler(this.btnFilterBy_Click);
            // 
            // txtboxFilter
            // 
            this.txtboxFilter.Location = new System.Drawing.Point(61, 152);
            this.txtboxFilter.Name = "txtboxFilter";
            this.txtboxFilter.Size = new System.Drawing.Size(163, 27);
            this.txtboxFilter.TabIndex = 4;
            // 
            // lblMLBTeamTitle
            // 
            this.lblMLBTeamTitle.AutoSize = true;
            this.lblMLBTeamTitle.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMLBTeamTitle.Location = new System.Drawing.Point(171, 62);
            this.lblMLBTeamTitle.Name = "lblMLBTeamTitle";
            this.lblMLBTeamTitle.Size = new System.Drawing.Size(229, 34);
            this.lblMLBTeamTitle.TabIndex = 23;
            this.lblMLBTeamTitle.Text = "MLB Team List:";
            // 
            // grpboxSearch
            // 
            this.grpboxSearch.Controls.Add(this.btnSearchBy);
            this.grpboxSearch.Controls.Add(this.txtboxSearch);
            this.grpboxSearch.Controls.Add(this.rdbtnPark);
            this.grpboxSearch.Controls.Add(this.rdbtnName);
            this.grpboxSearch.Controls.Add(this.rdbtnTeam);
            this.grpboxSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxSearch.Location = new System.Drawing.Point(19, 117);
            this.grpboxSearch.Name = "grpboxSearch";
            this.grpboxSearch.Size = new System.Drawing.Size(446, 141);
            this.grpboxSearch.TabIndex = 22;
            this.grpboxSearch.TabStop = false;
            this.grpboxSearch.Text = "Search By:";
            // 
            // btnSearchBy
            // 
            this.btnSearchBy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchBy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchBy.Location = new System.Drawing.Point(285, 80);
            this.btnSearchBy.Name = "btnSearchBy";
            this.btnSearchBy.Size = new System.Drawing.Size(90, 34);
            this.btnSearchBy.TabIndex = 4;
            this.btnSearchBy.Text = "Search";
            this.btnSearchBy.UseVisualStyleBackColor = false;
            this.btnSearchBy.Click += new System.EventHandler(this.btnSearchBy_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(87, 85);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(177, 27);
            this.txtboxSearch.TabIndex = 3;
            // 
            // rdbtnPark
            // 
            this.rdbtnPark.AutoSize = true;
            this.rdbtnPark.Location = new System.Drawing.Point(285, 36);
            this.rdbtnPark.Name = "rdbtnPark";
            this.rdbtnPark.Size = new System.Drawing.Size(72, 23);
            this.rdbtnPark.TabIndex = 2;
            this.rdbtnPark.TabStop = true;
            this.rdbtnPark.Text = "Park";
            this.rdbtnPark.UseVisualStyleBackColor = true;
            // 
            // rdbtnName
            // 
            this.rdbtnName.AutoSize = true;
            this.rdbtnName.Location = new System.Drawing.Point(183, 36);
            this.rdbtnName.Name = "rdbtnName";
            this.rdbtnName.Size = new System.Drawing.Size(81, 23);
            this.rdbtnName.TabIndex = 1;
            this.rdbtnName.TabStop = true;
            this.rdbtnName.Text = "Name";
            this.rdbtnName.UseVisualStyleBackColor = true;
            // 
            // rdbtnTeam
            // 
            this.rdbtnTeam.AutoSize = true;
            this.rdbtnTeam.Location = new System.Drawing.Point(61, 36);
            this.rdbtnTeam.Name = "rdbtnTeam";
            this.rdbtnTeam.Size = new System.Drawing.Size(99, 23);
            this.rdbtnTeam.TabIndex = 0;
            this.rdbtnTeam.TabStop = true;
            this.rdbtnTeam.Text = "TeamID";
            this.rdbtnTeam.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(113, 492);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 41);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Return to Home";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "teamID";
            this.dataGridViewTextBoxColumn3.HeaderText = "teamID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn39.HeaderText = "name";
            this.dataGridViewTextBoxColumn39.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Width = 150;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "park";
            this.dataGridViewTextBoxColumn40.HeaderText = "park";
            this.dataGridViewTextBoxColumn40.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "W";
            this.dataGridViewTextBoxColumn9.HeaderText = "W";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "L";
            this.dataGridViewTextBoxColumn10.HeaderText = "L";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.baseballDBDataSet;
            // 
            // baseballDBDataSet
            // 
            this.baseballDBDataSet.DataSetName = "BaseballDBDataSet";
            this.baseballDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AllstarsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SeriesPostTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.UpdateOrder = group_project_i_brownie_bandits.BaseballDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SoccerTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1198, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBoxFilter);
            this.Controls.Add(this.lblMLBTeamTitle);
            this.Controls.Add(this.grpboxSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.teamsDataGridView);
            this.Controls.Add(this.teamsBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SoccerTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseballTeamForm";
            this.Load += new System.EventHandler(this.SoccerTeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).EndInit();
            this.teamsBindingNavigator.ResumeLayout(false);
            this.teamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).EndInit();
            this.grpBoxFilter.ResumeLayout(false);
            this.grpBoxFilter.PerformLayout();
            this.grpBoxOperators.ResumeLayout(false);
            this.grpBoxOperators.PerformLayout();
            this.grpBoxField.ResumeLayout(false);
            this.grpBoxField.PerformLayout();
            this.grpboxSearch.ResumeLayout(false);
            this.grpboxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseballDBDataSet baseballDBDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private BaseballDBDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private BaseballDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teamsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton teamsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView teamsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoxFilter;
        private System.Windows.Forms.GroupBox grpBoxOperators;
        private System.Windows.Forms.RadioButton rdbtnGreaterThan;
        private System.Windows.Forms.RadioButton rdbtnLessThan;
        private System.Windows.Forms.RadioButton rdbtnEquals;
        private System.Windows.Forms.GroupBox grpBoxField;
        private System.Windows.Forms.RadioButton rdbtnLosses;
        private System.Windows.Forms.RadioButton rdbtnWins;
        private System.Windows.Forms.Button btnFilterBy;
        private System.Windows.Forms.TextBox txtboxFilter;
        private System.Windows.Forms.Label lblMLBTeamTitle;
        private System.Windows.Forms.GroupBox grpboxSearch;
        private System.Windows.Forms.Button btnSearchBy;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.RadioButton rdbtnPark;
        private System.Windows.Forms.RadioButton rdbtnName;
        private System.Windows.Forms.RadioButton rdbtnTeam;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}