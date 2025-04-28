using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace group_project_i_brownie_bandits
{
    
    public partial class HomeForm : Form
    {
        private User loggedInUser;

        public HomeForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            lblWelcome.Text += loggedInUser.Username;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNHLElm_Click(object sender, EventArgs e)
        {
            EliminationForm eliminationForm = new EliminationForm();
            eliminationForm.ShowDialog();
        }

        private void btnNHLTeam_Click(object sender, EventArgs e)
        {
            TeamListForm teamListForm = new TeamListForm();
            teamListForm.ShowDialog();
        }

        private void btnNHLPlayer_Click(object sender, EventArgs e)
        {
            PlayerStatsForm playerStatsForm = new PlayerStatsForm();
            playerStatsForm.ShowDialog();
        }

        private void btnSoccerElm_Click(object sender, EventArgs e)
        {
            SoccerEliminationForm eliminationForm= new SoccerEliminationForm();
            eliminationForm.ShowDialog();
        }

        private void btnSoccerTeam_Click(object sender, EventArgs e)
        {
            SoccerTeamForm soccerTeamForm = new SoccerTeamForm();
            soccerTeamForm.ShowDialog();
        }

        private void btnSoccerPlayer_Click(object sender, EventArgs e)
        {
            SoccerPlayerForm playerForm = new SoccerPlayerForm();
            playerForm.ShowDialog();
        }

        private void btnUserFav_Click(object sender, EventArgs e)
        {
            UserFavoritesForm favoritesForm = new UserFavoritesForm();
            favoritesForm.ShowDialog();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            // Open the settings form
            Settings settings = new Settings(this);
            settings.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Method to update the profile form (Called from the CusomizeForm)
        public void UpdateHome(Color bgColor, Font fontStyle)
        {
            this.BackColor = bgColor; // change background color
            lblHomeTitle.Font = fontStyle; // change font
            lblWelcome.Font = fontStyle;
            btnClose.Font = fontStyle;
            btnLogout.Font = fontStyle;
            btnNHLElm.Font = fontStyle;
            btnNHLPlayer.Font = fontStyle;
            btnNHLTeam.Font = fontStyle;
            btnSoccerElm.Font = fontStyle;
            btnSoccerPlayer.Font = fontStyle;
            btnSoccerTeam.Font = fontStyle;
            btnUserFav.Font = fontStyle;
            btnUserInfo.Font = fontStyle;
            this.Refresh();
        }
    }
}
