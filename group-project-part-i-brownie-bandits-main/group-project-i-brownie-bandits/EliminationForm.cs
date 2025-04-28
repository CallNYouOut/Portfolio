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
    public partial class EliminationForm : Form
    {
        public EliminationForm()
        {
            InitializeComponent();
            yearBox.Items.Add("2024");
        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearBox.SelectedIndex == 0)
            {
                if (yearBox.SelectedIndex == 0)
                {
                    WC1.Text = "Dallas";
                    WC2.Text = "Las Vegas";
                    WC3.Text = "Winnipeg";
                    WC4.Text = "Colorado";
                    WC5.Text = "Vancouver";
                    WC6.Text = "Nashville";
                    WC7.Text = "Edmonton";
                    WC8.Text = "Los Angeles";
                    WC9.Text = "Dallas";
                    WC10.Text = "Colorado";
                    WC11.Text = "Vancouver";
                    WC12.Text = "Edmonton";
                    WC13.Text = "Dallas";
                    WC14.Text = "Edmonton";
                    EC1.Text = "Florida";
                    EC2.Text = "Tampa Bay";
                    EC3.Text = "Boston";
                    EC4.Text = "Toronto";
                    EC5.Text = "NY Rangers";
                    EC6.Text = "Washington (DC)";
                    EC7.Text = "Carolina";
                    EC8.Text = "NY Islanders";
                    EC9.Text = "Florida";
                    EC10.Text = "Boston";
                    EC11.Text = "NY Rangers";
                    EC12.Text = "Carolina";
                    EC13.Text = "Florida";
                    EC14.Text = "NY Rangers";
                    SC1.Text = "Florida";
                    SC2.Text = "Edmonton";
                }
            }
        }

        private void bracketCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
