namespace group_project_i_brownie_bandits
{
    partial class SoccerPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoccerPlayerForm));
            this.baseballDBDataSet = new group_project_i_brownie_bandits.BaseballDBDataSet();
            this.allstarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allstarsTableAdapter = new group_project_i_brownie_bandits.BaseballDBDataSetTableAdapters.AllstarsTableAdapter();
            this.tableAdapterManager = new group_project_i_brownie_bandits.BaseballDBDataSetTableAdapters.TableAdapterManager();
            this.allstarsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.allstarsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.allstarsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMLBTeamTitle = new System.Windows.Forms.Label();
            this.grpboxSearch = new System.Windows.Forms.GroupBox();
            this.rdbtnPlayerId = new System.Windows.Forms.RadioButton();
            this.btnSearchBy = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.rdbtnGP = new System.Windows.Forms.RadioButton();
            this.rdbtnGName = new System.Windows.Forms.RadioButton();
            this.rdbtnTeamID = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allstarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allstarsBindingNavigator)).BeginInit();
            this.allstarsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allstarsDataGridView)).BeginInit();
            this.grpboxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseballDBDataSet
            // 
            this.baseballDBDataSet.DataSetName = "BaseballDBDataSet";
            this.baseballDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allstarsBindingSource
            // 
            this.allstarsBindingSource.DataMember = "Allstars";
            this.allstarsBindingSource.DataSource = this.baseballDBDataSet;
            // 
            // allstarsTableAdapter
            // 
            this.allstarsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AllstarsTableAdapter = this.allstarsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SeriesPostTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = group_project_i_brownie_bandits.BaseballDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // allstarsBindingNavigator
            // 
            this.allstarsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.allstarsBindingNavigator.BindingSource = this.allstarsBindingSource;
            this.allstarsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.allstarsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.allstarsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.allstarsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.allstarsBindingNavigatorSaveItem});
            this.allstarsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.allstarsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.allstarsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.allstarsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.allstarsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.allstarsBindingNavigator.Name = "allstarsBindingNavigator";
            this.allstarsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.allstarsBindingNavigator.Size = new System.Drawing.Size(1190, 33);
            this.allstarsBindingNavigator.TabIndex = 0;
            this.allstarsBindingNavigator.Text = "bindingNavigator1";
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
            // allstarsBindingNavigatorSaveItem
            // 
            this.allstarsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.allstarsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("allstarsBindingNavigatorSaveItem.Image")));
            this.allstarsBindingNavigatorSaveItem.Name = "allstarsBindingNavigatorSaveItem";
            this.allstarsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.allstarsBindingNavigatorSaveItem.Text = "Save Data";
            this.allstarsBindingNavigatorSaveItem.Click += new System.EventHandler(this.allstarsBindingNavigatorSaveItem_Click);
            // 
            // allstarsDataGridView
            // 
            this.allstarsDataGridView.AutoGenerateColumns = false;
            this.allstarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allstarsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.allstarsDataGridView.DataSource = this.allstarsBindingSource;
            this.allstarsDataGridView.Location = new System.Drawing.Point(549, 52);
            this.allstarsDataGridView.Name = "allstarsDataGridView";
            this.allstarsDataGridView.RowHeadersWidth = 62;
            this.allstarsDataGridView.RowTemplate.Height = 28;
            this.allstarsDataGridView.Size = new System.Drawing.Size(629, 502);
            this.allstarsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "playerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "playerID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "yearID";
            this.dataGridViewTextBoxColumn2.HeaderText = "yearID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "gameNum";
            this.dataGridViewTextBoxColumn3.HeaderText = "gameNum";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gameID";
            this.dataGridViewTextBoxColumn4.HeaderText = "gameID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "teamID";
            this.dataGridViewTextBoxColumn5.HeaderText = "teamID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "lgID";
            this.dataGridViewTextBoxColumn6.HeaderText = "lgID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "GP";
            this.dataGridViewCheckBoxColumn1.HeaderText = "GP";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "startingPos";
            this.dataGridViewTextBoxColumn7.HeaderText = "startingPos";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(62, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 48);
            this.label2.TabIndex = 28;
            // 
            // lblMLBTeamTitle
            // 
            this.lblMLBTeamTitle.AutoSize = true;
            this.lblMLBTeamTitle.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMLBTeamTitle.Location = new System.Drawing.Point(208, 63);
            this.lblMLBTeamTitle.Name = "lblMLBTeamTitle";
            this.lblMLBTeamTitle.Size = new System.Drawing.Size(252, 34);
            this.lblMLBTeamTitle.TabIndex = 27;
            this.lblMLBTeamTitle.Text = "MLB Player Stats";
            // 
            // grpboxSearch
            // 
            this.grpboxSearch.Controls.Add(this.rdbtnPlayerId);
            this.grpboxSearch.Controls.Add(this.btnSearchBy);
            this.grpboxSearch.Controls.Add(this.txtboxSearch);
            this.grpboxSearch.Controls.Add(this.rdbtnGP);
            this.grpboxSearch.Controls.Add(this.rdbtnGName);
            this.grpboxSearch.Controls.Add(this.rdbtnTeamID);
            this.grpboxSearch.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxSearch.Location = new System.Drawing.Point(62, 159);
            this.grpboxSearch.Name = "grpboxSearch";
            this.grpboxSearch.Size = new System.Drawing.Size(446, 223);
            this.grpboxSearch.TabIndex = 26;
            this.grpboxSearch.TabStop = false;
            this.grpboxSearch.Text = "Search By:";
            // 
            // rdbtnPlayerId
            // 
            this.rdbtnPlayerId.AutoSize = true;
            this.rdbtnPlayerId.Location = new System.Drawing.Point(97, 38);
            this.rdbtnPlayerId.Name = "rdbtnPlayerId";
            this.rdbtnPlayerId.Size = new System.Drawing.Size(110, 23);
            this.rdbtnPlayerId.TabIndex = 5;
            this.rdbtnPlayerId.TabStop = true;
            this.rdbtnPlayerId.Text = "Player ID";
            this.rdbtnPlayerId.UseVisualStyleBackColor = true;
            // 
            // btnSearchBy
            // 
            this.btnSearchBy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchBy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchBy.Location = new System.Drawing.Point(270, 139);
            this.btnSearchBy.Name = "btnSearchBy";
            this.btnSearchBy.Size = new System.Drawing.Size(90, 34);
            this.btnSearchBy.TabIndex = 4;
            this.btnSearchBy.Text = "Search";
            this.btnSearchBy.UseVisualStyleBackColor = false;
            this.btnSearchBy.Click += new System.EventHandler(this.btnSearchBy_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(72, 144);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(177, 27);
            this.txtboxSearch.TabIndex = 3;
            // 
            // rdbtnGP
            // 
            this.rdbtnGP.AutoSize = true;
            this.rdbtnGP.Location = new System.Drawing.Point(219, 88);
            this.rdbtnGP.Name = "rdbtnGP";
            this.rdbtnGP.Size = new System.Drawing.Size(57, 23);
            this.rdbtnGP.TabIndex = 2;
            this.rdbtnGP.TabStop = true;
            this.rdbtnGP.Text = "GP";
            this.rdbtnGP.UseVisualStyleBackColor = true;
            // 
            // rdbtnGName
            // 
            this.rdbtnGName.AutoSize = true;
            this.rdbtnGName.Location = new System.Drawing.Point(219, 38);
            this.rdbtnGName.Name = "rdbtnGName";
            this.rdbtnGName.Size = new System.Drawing.Size(123, 23);
            this.rdbtnGName.TabIndex = 1;
            this.rdbtnGName.TabStop = true;
            this.rdbtnGName.Text = "Game Num";
            this.rdbtnGName.UseVisualStyleBackColor = true;
            // 
            // rdbtnTeamID
            // 
            this.rdbtnTeamID.AutoSize = true;
            this.rdbtnTeamID.Location = new System.Drawing.Point(97, 88);
            this.rdbtnTeamID.Name = "rdbtnTeamID";
            this.rdbtnTeamID.Size = new System.Drawing.Size(99, 23);
            this.rdbtnTeamID.TabIndex = 0;
            this.rdbtnTeamID.TabStop = true;
            this.rdbtnTeamID.Text = "TeamID";
            this.rdbtnTeamID.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(159, 445);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 41);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Return to Home";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SoccerPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1190, 566);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMLBTeamTitle);
            this.Controls.Add(this.grpboxSearch);
            this.Controls.Add(this.allstarsDataGridView);
            this.Controls.Add(this.allstarsBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SoccerPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseballPlayerForm";
            this.Load += new System.EventHandler(this.SoccerPlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseballDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allstarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allstarsBindingNavigator)).EndInit();
            this.allstarsBindingNavigator.ResumeLayout(false);
            this.allstarsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allstarsDataGridView)).EndInit();
            this.grpboxSearch.ResumeLayout(false);
            this.grpboxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseballDBDataSet baseballDBDataSet;
        private System.Windows.Forms.BindingSource allstarsBindingSource;
        private BaseballDBDataSetTableAdapters.AllstarsTableAdapter allstarsTableAdapter;
        private BaseballDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator allstarsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton allstarsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView allstarsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMLBTeamTitle;
        private System.Windows.Forms.GroupBox grpboxSearch;
        private System.Windows.Forms.Button btnSearchBy;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.RadioButton rdbtnGP;
        private System.Windows.Forms.RadioButton rdbtnGName;
        private System.Windows.Forms.RadioButton rdbtnTeamID;
        private System.Windows.Forms.RadioButton rdbtnPlayerId;
        private System.Windows.Forms.Button btnClose;
    }
}