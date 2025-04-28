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
    public partial class SoccerTeamForm : Form
    {
        public SoccerTeamForm()
        {
            InitializeComponent();
        }

        private void teamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseballDBDataSet);

        }

        private void SoccerTeamForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseballDBDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.baseballDBDataSet.Teams);

        }

        private void btnSearchBy_Click(object sender, EventArgs e)
        {
            //team search
            if (rdbtnTeam.Checked)
            {
                this.teamsTableAdapter.SearchTeamID(this.baseballDBDataSet.Teams, txtboxSearch.Text);
            }

            //name search
            if (rdbtnName.Checked)
            {
                this.teamsTableAdapter.SearchName(this.baseballDBDataSet.Teams, txtboxSearch.Text);
            }
            //park search
            if (rdbtnPark.Checked)
            {
                this.teamsTableAdapter.SearchPark(this.baseballDBDataSet.Teams, txtboxSearch.Text);
            }
        }

        private void btnFilterBy_Click(object sender, EventArgs e)
        {
            //variable to parse string entered to int
            int filtval = 1;
            int.TryParse(txtboxFilter.Text, out filtval);

            //filter by wins
            if (rdbtnWins.Checked)
            {
                if (rdbtnEquals.Checked)
                {
                    this.teamsTableAdapter.FilterWinsEqual(this.baseballDBDataSet.Teams, filtval);
                }
                else if (rdbtnLessThan.Checked)
                {
                    this.teamsTableAdapter.FilterWinsLess(this.baseballDBDataSet.Teams, filtval);
                }
                else if (rdbtnGreaterThan.Checked)
                {
                    this.teamsTableAdapter.FilterWinsGreater(this.baseballDBDataSet.Teams, filtval);
                }

            }
            
            //filter by losses
            else if (rdbtnLosses.Checked)
            {
                if (rdbtnEquals.Checked)
                {
                    this.teamsTableAdapter.FilterLossEqual(this.baseballDBDataSet.Teams, filtval);
                }
                else if (rdbtnLessThan.Checked)
                {
                    this.teamsTableAdapter.FilterLossLess(this.baseballDBDataSet.Teams, filtval);
                }
                else if (rdbtnGreaterThan.Checked)
                {
                    this.teamsTableAdapter.FilterLossGreater(this.baseballDBDataSet.Teams, filtval);
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
