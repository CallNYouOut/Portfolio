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
    public partial class TeamListForm : Form
    {
        public TeamListForm()
        {
            InitializeComponent();
        }

        private void teamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.playerLitsDataSet);

        }

        private void TeamListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'playerLitsDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.playerLitsDataSet.Teams);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ResetDataGridView();
            //name search
            if (rdbtnName.Checked)
            {
                this.teamsTableAdapter.SearchTeamName(this.playerLitsDataSet.Teams, txtboxSearch.Text);
            }
            //division search
            if (rdbtnDivision.Checked)
            {
                this.teamsTableAdapter.SearchTeamDivision(this.playerLitsDataSet.Teams, txtboxSearch.Text);
            }
            //location search
            if (rdbtnLocation.Checked)
            {
                this.teamsTableAdapter.SearchTeamLocation(this.playerLitsDataSet.Teams, txtboxSearch.Text);
            }
        }

        private void btnNameAsc_Click(object sender, EventArgs e)
        {
            this.teamsTableAdapter.FillByNameAsc(this.playerLitsDataSet.Teams);
        }

        private void btnNameDec_Click(object sender, EventArgs e)
        {
            this.teamsTableAdapter.FillByNameDesc(this.playerLitsDataSet.Teams);
        }

        private void btnDivisionAsc_Click(object sender, EventArgs e)
        {
            this.teamsTableAdapter.FillByDivisionAsc(this.playerLitsDataSet.Teams);
        }

        private void btnDivisionDec_Click(object sender, EventArgs e)
        {
            this.teamsTableAdapter.FillByDivisionDesc(this.playerLitsDataSet.Teams);
        }

        private void btnLocationAsc_Click(object sender, EventArgs e)
        {
            this.teamsTableAdapter.FillByLocationAsc(this.playerLitsDataSet.Teams);
        }

        private void btnLocationDec_Click(object sender, EventArgs e)
        {
            this.teamsTableAdapter.FillByLocationDesc(this.playerLitsDataSet.Teams);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
