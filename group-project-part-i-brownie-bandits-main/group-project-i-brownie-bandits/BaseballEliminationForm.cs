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
    public partial class BaseballEliminationForm : Form
    {
        public BaseballEliminationForm()
        {
            InitializeComponent();
        }

        private void BaseballEliminationForm_Load(object sender, EventArgs e)
        {
            mlbYearBox.Items.Add("2024");
        }

        private void mlbYearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mlbYearBox.SelectedIndex == 0)
            {
                al1.Text = "Detroit";
                al2.Text = "Houston";
                al3.Text = "Kansas City";
                al4.Text = "Baltimore";
                al5.Text = "Detroit";
                al6.Text = "Cleveland";
                al7.Text = "Kansas City";
                al8.Text = "NY Yankees";
                al9.Text = "Cleveland";
                al10.Text = "NY Yankees";
                nl1.Text = "NY Mets";
                nl2.Text = "Milwaukee";
                nl3.Text = "Atlanta";
                nl4.Text = "San Diego";
                nl5.Text = "NY Mets";
                nl6.Text = "Philadelphia";
                nl7.Text = "San Diego";
                nl8.Text = "Los Angeles";
                nl9.Text = "NY Mets";
                nl10.Text = "Los Angeles";
                alws.Text = "NY Yankees";
                nlws.Text = "Los Angeles";
            }
        }
    }
}
