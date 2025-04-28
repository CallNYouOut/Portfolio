namespace group_project_i_brownie_bandits
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.btnSoccerElm = new System.Windows.Forms.Button();
            this.btnSoccerTeam = new System.Windows.Forms.Button();
            this.btnSoccerPlayer = new System.Windows.Forms.Button();
            this.btnUserFav = new System.Windows.Forms.Button();
            this.btnNHLTeam = new System.Windows.Forms.Button();
            this.btnNHLPlayer = new System.Windows.Forms.Button();
            this.btnNHLElm = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitleLogo = new System.Windows.Forms.Label();
            this.lblNHLLogo = new System.Windows.Forms.Label();
            this.lblSoccerLogo = new System.Windows.Forms.Label();
            this.lblFavLogo = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTitle.Location = new System.Drawing.Point(400, 32);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(436, 48);
            this.lblHomeTitle.TabIndex = 0;
            this.lblHomeTitle.Text = "Bandit Sport Tracker";
            // 
            // btnSoccerElm
            // 
            this.btnSoccerElm.BackColor = System.Drawing.Color.Black;
            this.btnSoccerElm.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoccerElm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSoccerElm.Location = new System.Drawing.Point(464, 332);
            this.btnSoccerElm.Name = "btnSoccerElm";
            this.btnSoccerElm.Size = new System.Drawing.Size(259, 43);
            this.btnSoccerElm.TabIndex = 1;
            this.btnSoccerElm.Text = "MLB Elemination Bracket";
            this.btnSoccerElm.UseVisualStyleBackColor = false;
            this.btnSoccerElm.Click += new System.EventHandler(this.btnSoccerElm_Click);
            // 
            // btnSoccerTeam
            // 
            this.btnSoccerTeam.BackColor = System.Drawing.Color.Black;
            this.btnSoccerTeam.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoccerTeam.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSoccerTeam.Location = new System.Drawing.Point(498, 378);
            this.btnSoccerTeam.Name = "btnSoccerTeam";
            this.btnSoccerTeam.Size = new System.Drawing.Size(181, 43);
            this.btnSoccerTeam.TabIndex = 2;
            this.btnSoccerTeam.Text = "MLB Team List";
            this.btnSoccerTeam.UseVisualStyleBackColor = false;
            this.btnSoccerTeam.Click += new System.EventHandler(this.btnSoccerTeam_Click);
            // 
            // btnSoccerPlayer
            // 
            this.btnSoccerPlayer.BackColor = System.Drawing.Color.Black;
            this.btnSoccerPlayer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoccerPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSoccerPlayer.Location = new System.Drawing.Point(498, 423);
            this.btnSoccerPlayer.Name = "btnSoccerPlayer";
            this.btnSoccerPlayer.Size = new System.Drawing.Size(181, 43);
            this.btnSoccerPlayer.TabIndex = 3;
            this.btnSoccerPlayer.Text = "MLB Player Stats";
            this.btnSoccerPlayer.UseVisualStyleBackColor = false;
            this.btnSoccerPlayer.Click += new System.EventHandler(this.btnSoccerPlayer_Click);
            // 
            // btnUserFav
            // 
            this.btnUserFav.BackColor = System.Drawing.Color.Black;
            this.btnUserFav.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserFav.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUserFav.Location = new System.Drawing.Point(798, 332);
            this.btnUserFav.Name = "btnUserFav";
            this.btnUserFav.Size = new System.Drawing.Size(133, 43);
            this.btnUserFav.TabIndex = 4;
            this.btnUserFav.Text = "Favorites";
            this.btnUserFav.UseVisualStyleBackColor = false;
            this.btnUserFav.Click += new System.EventHandler(this.btnUserFav_Click);
            // 
            // btnNHLTeam
            // 
            this.btnNHLTeam.BackColor = System.Drawing.Color.Black;
            this.btnNHLTeam.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNHLTeam.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNHLTeam.Location = new System.Drawing.Point(207, 381);
            this.btnNHLTeam.Name = "btnNHLTeam";
            this.btnNHLTeam.Size = new System.Drawing.Size(164, 43);
            this.btnNHLTeam.TabIndex = 5;
            this.btnNHLTeam.Text = "NHL Team List";
            this.btnNHLTeam.UseVisualStyleBackColor = false;
            this.btnNHLTeam.Click += new System.EventHandler(this.btnNHLTeam_Click);
            // 
            // btnNHLPlayer
            // 
            this.btnNHLPlayer.BackColor = System.Drawing.Color.Black;
            this.btnNHLPlayer.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNHLPlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNHLPlayer.Location = new System.Drawing.Point(207, 430);
            this.btnNHLPlayer.Name = "btnNHLPlayer";
            this.btnNHLPlayer.Size = new System.Drawing.Size(164, 43);
            this.btnNHLPlayer.TabIndex = 6;
            this.btnNHLPlayer.Text = "NHL Player Stats";
            this.btnNHLPlayer.UseVisualStyleBackColor = false;
            this.btnNHLPlayer.Click += new System.EventHandler(this.btnNHLPlayer_Click);
            // 
            // btnNHLElm
            // 
            this.btnNHLElm.BackColor = System.Drawing.Color.Black;
            this.btnNHLElm.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNHLElm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNHLElm.Location = new System.Drawing.Point(177, 332);
            this.btnNHLElm.Name = "btnNHLElm";
            this.btnNHLElm.Size = new System.Drawing.Size(232, 43);
            this.btnNHLElm.TabIndex = 7;
            this.btnNHLElm.Text = "NHL Elemination Bracket";
            this.btnNHLElm.UseVisualStyleBackColor = false;
            this.btnNHLElm.Click += new System.EventHandler(this.btnNHLElm_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(932, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 48);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.Black;
            this.btnUserInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUserInfo.Location = new System.Drawing.Point(32, 481);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(133, 43);
            this.btnUserInfo.TabIndex = 9;
            this.btnUserInfo.Text = "User Settings";
            this.btnUserInfo.UseVisualStyleBackColor = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(932, 481);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 43);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close App";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitleLogo
            // 
            this.lblTitleLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblTitleLogo.Image")));
            this.lblTitleLogo.Location = new System.Drawing.Point(12, 9);
            this.lblTitleLogo.Name = "lblTitleLogo";
            this.lblTitleLogo.Size = new System.Drawing.Size(101, 99);
            this.lblTitleLogo.TabIndex = 11;
            // 
            // lblNHLLogo
            // 
            this.lblNHLLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNHLLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblNHLLogo.Image")));
            this.lblNHLLogo.Location = new System.Drawing.Point(191, 126);
            this.lblNHLLogo.Name = "lblNHLLogo";
            this.lblNHLLogo.Size = new System.Drawing.Size(196, 203);
            this.lblNHLLogo.TabIndex = 12;
            // 
            // lblSoccerLogo
            // 
            this.lblSoccerLogo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblSoccerLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoccerLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblSoccerLogo.Image")));
            this.lblSoccerLogo.Location = new System.Drawing.Point(492, 126);
            this.lblSoccerLogo.Name = "lblSoccerLogo";
            this.lblSoccerLogo.Size = new System.Drawing.Size(200, 203);
            this.lblSoccerLogo.TabIndex = 13;
            // 
            // lblFavLogo
            // 
            this.lblFavLogo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblFavLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFavLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblFavLogo.Image")));
            this.lblFavLogo.Location = new System.Drawing.Point(768, 133);
            this.lblFavLogo.Name = "lblFavLogo";
            this.lblFavLogo.Size = new System.Drawing.Size(186, 190);
            this.lblFavLogo.TabIndex = 14;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(728, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(139, 29);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1071, 542);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblFavLogo);
            this.Controls.Add(this.lblSoccerLogo);
            this.Controls.Add(this.lblNHLLogo);
            this.Controls.Add(this.lblTitleLogo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnNHLElm);
            this.Controls.Add(this.btnNHLPlayer);
            this.Controls.Add(this.btnNHLTeam);
            this.Controls.Add(this.btnUserFav);
            this.Controls.Add(this.btnSoccerPlayer);
            this.Controls.Add(this.btnSoccerTeam);
            this.Controls.Add(this.btnSoccerElm);
            this.Controls.Add(this.lblHomeTitle);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Button btnSoccerElm;
        private System.Windows.Forms.Button btnSoccerTeam;
        private System.Windows.Forms.Button btnSoccerPlayer;
        private System.Windows.Forms.Button btnUserFav;
        private System.Windows.Forms.Button btnNHLTeam;
        private System.Windows.Forms.Button btnNHLPlayer;
        private System.Windows.Forms.Button btnNHLElm;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitleLogo;
        private System.Windows.Forms.Label lblNHLLogo;
        private System.Windows.Forms.Label lblSoccerLogo;
        private System.Windows.Forms.Label lblFavLogo;
        private System.Windows.Forms.Label lblWelcome;
    }
}