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
    public partial class SoccerEliminationForm : Form
    {
        public SoccerEliminationForm()
        {
            InitializeComponent();
        }

        private void SoccerEliminationForm_Load(object sender, EventArgs e)
        {
            yearBox.Items.Add("2024");
            WC1.Text = "Detroit";
            WC2.Text = "Houston";
            WC3.Text = "Detroit";
            WC4.Text = "Cleveland";
            WC5.Text = "Kansas City";
            WC6.Text = "NY Yankees";
            WC7.Text = "Kansas City";
            WC8.Text = "Baltimore";
            WC13.Text = "Cleveland";
            WC14.Text = "NY Yankees";
            EC1.Text = "NY Mets";
            EC2.Text = "Milwaukee";
            EC13.Text = "Atlanta";
            EC14.Text = "NY Mets";
            EC5.Text = "Los Angeles";
            EC6.Text = "Philadelphia";
            EC7.Text = "San Diego";
            EC8.Text = "Atlanta";
            EC9.Text = "San Diego";
            EC10.Text = "Los Angeles"; 
            SC1.Text = "NY Yankees";
            SC2.Text = "Los Angeles";

        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearBox.SelectedIndex == 0)
            {
                /*
                WC1.Text = "Detroit";
                WC2.Text = "Houston";
                WC3.Text = "Kansas City";
                WC4.Text = "Baltimore";
                WC5.Text = "Detroit";
                WC6.Text = "Cleveland";
                WC7.Text = "Kansas City";
                WC8.Text = "NY Yankees";
                WC9.Text = "Cleveland";
                WC10.Text = "NY Yankees";
                EC1.Text = "NY Mets";
                EC2.Text = "Milwaukee";
                EC3.Text = "Atlanta";
                EC4.Text = "San Diego";
                EC5.Text = "NY Mets";
                EC6.Text = "Philadelphia";
                EC7.Text = "San Diego";
                EC8.Text = "Los Angeles";
                EC9.Text = "NY Mets";
                EC10.Text = "Los Angeles";
                SC1.Text = "NY Yankees";
                SC2.Text = "Los Angeles";
                */
            }
        }

        private void bracketCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
