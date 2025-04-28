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
    public partial class SoccerPlayerForm : Form
    {
        public SoccerPlayerForm()
        {
            InitializeComponent();
        }

        private void allstarsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.allstarsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseballDBDataSet);

        }

        private void SoccerPlayerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseballDBDataSet.Allstars' table. You can move, or remove it, as needed.
            this.allstarsTableAdapter.Fill(this.baseballDBDataSet.Allstars);

        }

        private void btnSearchBy_Click(object sender, EventArgs e)
        {
            //playerID search
            if (rdbtnPlayerId.Checked)
            {
                this.allstarsTableAdapter.SearchPlayerID(this.baseballDBDataSet.Allstars, txtboxSearch.Text);
            }

            //teamID search
            else if (rdbtnTeamID.Checked)
            {
                this.allstarsTableAdapter.SearchTeamID(this.baseballDBDataSet.Allstars, txtboxSearch.Text);
            }

            //if no filter by selection made
            else
            {
                MessageBox.Show("Please select a field to search by.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
