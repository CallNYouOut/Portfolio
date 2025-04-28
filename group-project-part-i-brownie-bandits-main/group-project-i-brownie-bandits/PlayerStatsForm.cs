using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group_project_i_brownie_bandits
{
    public partial class PlayerStatsForm : Form
    {
        public PlayerStatsForm()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.playerLitsDataSet);

        }

        private void PlayerStatsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'playerLitsDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.playerLitsDataSet.Players);

        }

        private void btnSearchBy_Click(object sender, EventArgs e)
        {
            //name search
            if (rdbtnPlayerName.Checked)
            {
                this.playersTableAdapter.SearchPlayerName(this.playerLitsDataSet.Players, txtboxSearch.Text);
            }
            //team search
            if (rdbtnTeamName.Checked)
            {
                this.playersTableAdapter.SearchTeamName(this.playerLitsDataSet.Players, txtboxSearch.Text);
            }
            //position search
            if (rdbtnPosition.Checked)
            {
                this.playersTableAdapter.SearchPosition(this.playerLitsDataSet.Players, txtboxSearch.Text);
            }
        }

        private void btnFilterBy_Click(object sender, EventArgs e)
        {
            //variable to parse string entered to int
            int filtval = 1;
            int.TryParse(txtboxFilter.Text, out filtval);
            //filter by games played
            if (rdbtnGamesPlayed.Checked)
            {
                if (rdbtnEquals.Checked)
                {
                    this.playersTableAdapter.FilterGPEqual(this.playerLitsDataSet.Players, filtval);
                }
                else if (rdbtnLessThan.Checked)
                {
                    this.playersTableAdapter.FilterGPlayedLess(this.playerLitsDataSet.Players, filtval);
                }
                else if (rdbtnGreaterThan.Checked)
                {
                    this.playersTableAdapter.FilterGPGreater(this.playerLitsDataSet.Players, filtval);
                }

            }

            //filter by goals
            else if (rdbtnGoals.Checked)
            {
                if (rdbtnEquals.Checked)
                {
                    this.playersTableAdapter.FilterGoalEqual(this.playerLitsDataSet.Players, filtval);
                }
                else if (rdbtnLessThan.Checked)
                {
                    this.playersTableAdapter.FilterGoalLess(this.playerLitsDataSet.Players, filtval);
                }
                else if (rdbtnGreaterThan.Checked)
                {
                    this.playersTableAdapter.FilterGoalGreater(this.playerLitsDataSet.Players, filtval);
                }

            }

            //filter by assists
            else if (rdBtnAssists.Checked)
            {
                if (rdbtnEquals.Checked)
                {
                    this.playersTableAdapter.FilterAssistsEqual(this.playerLitsDataSet.Players, filtval);
                }
                else if (rdbtnLessThan.Checked)
                {
                    this.playersTableAdapter.FilterAssistsLess(this.playerLitsDataSet.Players, filtval);
                }
                else if (rdbtnGreaterThan.Checked)
                {
                    this.playersTableAdapter.FilterAssistsGreater(this.playerLitsDataSet.Players, filtval);
                }

            }
            //filter by points
            else if (rdBtnPoints.Checked)
            {
                if (rdbtnEquals.Checked)
                {
                    this.playersTableAdapter.FilterPointsEqual(this.playerLitsDataSet.Players, filtval);
                }
                else if (rdbtnLessThan.Checked)
                {
                    this.playersTableAdapter.FilterPointsLess(this.playerLitsDataSet.Players, filtval);
                }
                else if (rdbtnGreaterThan.Checked)
                {
                    this.playersTableAdapter.FilterPointsGreater(this.playerLitsDataSet.Players, filtval);
                }

            }

            //if no filter by selection made
            else
            {
                MessageBox.Show("Please select a field to filter by.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
