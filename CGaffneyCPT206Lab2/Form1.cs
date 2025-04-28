using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGaffneyCPT206Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet1.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter1.Fill(this.cityDBDataSet1.City);
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void btnPopSortAsc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter1.FillByOrderPopAsc(this.cityDBDataSet1.City);
        }

        private void btnPopSortDesc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter1.FillByOrderPopDesc(this.cityDBDataSet1.City);
        }

        private void btnSortCity_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter1.FillByOrderByCity(this.cityDBDataSet1.City);
        }

        private void btnHighestPopulation_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter1.MaxPop(this.cityDBDataSet1.City);
        }

        private void btnLowestPopulation_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter1.MinPop(this.cityDBDataSet1.City);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter1.Fill(this.cityDBDataSet1.City);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The sum of the populations: " + this.cityTableAdapter1.TotalPop());
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The average of the populations: " + this.cityTableAdapter1.AveragePop());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
