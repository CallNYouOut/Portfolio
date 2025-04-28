namespace group_project_i_brownie_bandits
{
    partial class TeamListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamListForm));
            this.teamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerLitsDataSet = new group_project_i_brownie_bandits.PlayerLitsDataSet();
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
            this.teamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.teamsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsTableAdapter = new group_project_i_brownie_bandits.PlayerLitsDataSetTableAdapters.TeamsTableAdapter();
            this.tableAdapterManager = new group_project_i_brownie_bandits.PlayerLitsDataSetTableAdapters.TableAdapterManager();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.rdbtnLocation = new System.Windows.Forms.RadioButton();
            this.rdbtnDivision = new System.Windows.Forms.RadioButton();
            this.rdbtnName = new System.Windows.Forms.RadioButton();
            this.btnNameAsc = new System.Windows.Forms.Button();
            this.btnDivisionAsc = new System.Windows.Forms.Button();
            this.btnLocationAsc = new System.Windows.Forms.Button();
            this.btnNameDec = new System.Windows.Forms.Button();
            this.btnDivisionDec = new System.Windows.Forms.Button();
            this.btnLocationDec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).BeginInit();
            this.teamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLitsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).BeginInit();
            this.grpBoxSearch.SuspendLayout();
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
            this.teamsBindingNavigator.Size = new System.Drawing.Size(1143, 33);
            this.teamsBindingNavigator.TabIndex = 0;
            this.teamsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.playerLitsDataSet;
            // 
            // playerLitsDataSet
            // 
            this.playerLitsDataSet.DataSetName = "PlayerLitsDataSet";
            this.playerLitsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // teamsBindingNavigatorSaveItem
            // 
            this.teamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teamsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teamsBindingNavigatorSaveItem.Image")));
            this.teamsBindingNavigatorSaveItem.Name = "teamsBindingNavigatorSaveItem";
            this.teamsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.teamsBindingNavigatorSaveItem.Text = "Save Data";
            this.teamsBindingNavigatorSaveItem.Click += new System.EventHandler(this.teamsBindingNavigatorSaveItem_Click);
            // 
            // teamsDataGridView
            // 
            this.teamsDataGridView.AutoGenerateColumns = false;
            this.teamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.teamsDataGridView.DataSource = this.teamsBindingSource;
            this.teamsDataGridView.Location = new System.Drawing.Point(543, 50);
            this.teamsDataGridView.Name = "teamsDataGridView";
            this.teamsDataGridView.RowHeadersWidth = 62;
            this.teamsDataGridView.RowTemplate.Height = 28;
            this.teamsDataGridView.Size = new System.Drawing.Size(588, 440);
            this.teamsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TeamName";
            this.dataGridViewTextBoxColumn1.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeamDvision";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeamDvision";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TeamLocation";
            this.dataGridViewTextBoxColumn3.HeaderText = "TeamLocation";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayersTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.UpdateOrder = group_project_i_brownie_bandits.PlayerLitsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(171, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Return to Home";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpBoxSearch
            // 
            this.grpBoxSearch.Controls.Add(this.btnSearch);
            this.grpBoxSearch.Controls.Add(this.txtboxSearch);
            this.grpBoxSearch.Controls.Add(this.rdbtnLocation);
            this.grpBoxSearch.Controls.Add(this.rdbtnDivision);
            this.grpBoxSearch.Controls.Add(this.rdbtnName);
            this.grpBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSearch.Location = new System.Drawing.Point(44, 127);
            this.grpBoxSearch.Name = "grpBoxSearch";
            this.grpBoxSearch.Size = new System.Drawing.Size(444, 142);
            this.grpBoxSearch.TabIndex = 3;
            this.grpBoxSearch.TabStop = false;
            this.grpBoxSearch.Text = "Search By:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(280, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(64, 83);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(197, 27);
            this.txtboxSearch.TabIndex = 3;
            // 
            // rdbtnLocation
            // 
            this.rdbtnLocation.AutoSize = true;
            this.rdbtnLocation.Location = new System.Drawing.Point(259, 39);
            this.rdbtnLocation.Name = "rdbtnLocation";
            this.rdbtnLocation.Size = new System.Drawing.Size(103, 23);
            this.rdbtnLocation.TabIndex = 2;
            this.rdbtnLocation.TabStop = true;
            this.rdbtnLocation.Text = "Location";
            this.rdbtnLocation.UseVisualStyleBackColor = true;
            // 
            // rdbtnDivision
            // 
            this.rdbtnDivision.AutoSize = true;
            this.rdbtnDivision.Location = new System.Drawing.Point(138, 39);
            this.rdbtnDivision.Name = "rdbtnDivision";
            this.rdbtnDivision.Size = new System.Drawing.Size(98, 23);
            this.rdbtnDivision.TabIndex = 1;
            this.rdbtnDivision.TabStop = true;
            this.rdbtnDivision.Text = "Division";
            this.rdbtnDivision.UseVisualStyleBackColor = true;
            // 
            // rdbtnName
            // 
            this.rdbtnName.AutoSize = true;
            this.rdbtnName.Location = new System.Drawing.Point(39, 39);
            this.rdbtnName.Name = "rdbtnName";
            this.rdbtnName.Size = new System.Drawing.Size(81, 23);
            this.rdbtnName.TabIndex = 0;
            this.rdbtnName.TabStop = true;
            this.rdbtnName.Text = "Name";
            this.rdbtnName.UseVisualStyleBackColor = true;
            // 
            // btnNameAsc
            // 
            this.btnNameAsc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNameAsc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameAsc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNameAsc.Location = new System.Drawing.Point(55, 303);
            this.btnNameAsc.Name = "btnNameAsc";
            this.btnNameAsc.Size = new System.Drawing.Size(109, 38);
            this.btnNameAsc.TabIndex = 4;
            this.btnNameAsc.Text = "Name Asc";
            this.btnNameAsc.UseVisualStyleBackColor = false;
            this.btnNameAsc.Click += new System.EventHandler(this.btnNameAsc_Click);
            // 
            // btnDivisionAsc
            // 
            this.btnDivisionAsc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDivisionAsc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisionAsc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDivisionAsc.Location = new System.Drawing.Point(192, 303);
            this.btnDivisionAsc.Name = "btnDivisionAsc";
            this.btnDivisionAsc.Size = new System.Drawing.Size(131, 38);
            this.btnDivisionAsc.TabIndex = 6;
            this.btnDivisionAsc.Text = "Division Asc";
            this.btnDivisionAsc.UseVisualStyleBackColor = false;
            this.btnDivisionAsc.Click += new System.EventHandler(this.btnDivisionAsc_Click);
            // 
            // btnLocationAsc
            // 
            this.btnLocationAsc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLocationAsc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationAsc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLocationAsc.Location = new System.Drawing.Point(349, 303);
            this.btnLocationAsc.Name = "btnLocationAsc";
            this.btnLocationAsc.Size = new System.Drawing.Size(128, 38);
            this.btnLocationAsc.TabIndex = 7;
            this.btnLocationAsc.Text = "Location Asc";
            this.btnLocationAsc.UseVisualStyleBackColor = false;
            this.btnLocationAsc.Click += new System.EventHandler(this.btnLocationAsc_Click);
            // 
            // btnNameDec
            // 
            this.btnNameDec.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNameDec.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameDec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNameDec.Location = new System.Drawing.Point(55, 356);
            this.btnNameDec.Name = "btnNameDec";
            this.btnNameDec.Size = new System.Drawing.Size(109, 38);
            this.btnNameDec.TabIndex = 5;
            this.btnNameDec.Text = "Name Dec";
            this.btnNameDec.UseVisualStyleBackColor = false;
            this.btnNameDec.Click += new System.EventHandler(this.btnNameDec_Click);
            // 
            // btnDivisionDec
            // 
            this.btnDivisionDec.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDivisionDec.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisionDec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDivisionDec.Location = new System.Drawing.Point(192, 356);
            this.btnDivisionDec.Name = "btnDivisionDec";
            this.btnDivisionDec.Size = new System.Drawing.Size(131, 38);
            this.btnDivisionDec.TabIndex = 8;
            this.btnDivisionDec.Text = "Division Dec";
            this.btnDivisionDec.UseVisualStyleBackColor = false;
            this.btnDivisionDec.Click += new System.EventHandler(this.btnDivisionDec_Click);
            // 
            // btnLocationDec
            // 
            this.btnLocationDec.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLocationDec.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationDec.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLocationDec.Location = new System.Drawing.Point(349, 356);
            this.btnLocationDec.Name = "btnLocationDec";
            this.btnLocationDec.Size = new System.Drawing.Size(128, 38);
            this.btnLocationDec.TabIndex = 9;
            this.btnLocationDec.Text = "Location Dec";
            this.btnLocationDec.UseVisualStyleBackColor = false;
            this.btnLocationDec.Click += new System.EventHandler(this.btnLocationDec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Team List:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 48);
            this.label2.TabIndex = 11;
            // 
            // TeamListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1143, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocationDec);
            this.Controls.Add(this.btnDivisionDec);
            this.Controls.Add(this.btnLocationAsc);
            this.Controls.Add(this.btnDivisionAsc);
            this.Controls.Add(this.btnNameDec);
            this.Controls.Add(this.btnNameAsc);
            this.Controls.Add(this.grpBoxSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.teamsDataGridView);
            this.Controls.Add(this.teamsBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TeamListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamListForm";
            this.Load += new System.EventHandler(this.TeamListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingNavigator)).EndInit();
            this.teamsBindingNavigator.ResumeLayout(false);
            this.teamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLitsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).EndInit();
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlayerLitsDataSet playerLitsDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private PlayerLitsDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private PlayerLitsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.RadioButton rdbtnName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.RadioButton rdbtnLocation;
        private System.Windows.Forms.RadioButton rdbtnDivision;
        private System.Windows.Forms.Button btnNameAsc;
        private System.Windows.Forms.Button btnDivisionAsc;
        private System.Windows.Forms.Button btnLocationAsc;
        private System.Windows.Forms.Button btnNameDec;
        private System.Windows.Forms.Button btnDivisionDec;
        private System.Windows.Forms.Button btnLocationDec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}