using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGaffney206Lab3
{
    public partial class frmStateDetails : Form
    {
        // Fields
        int position;
        frmMain menu;
        public frmStateDetails(int position, frmMain menu)
        {
            InitializeComponent();
            // Assigning fields
            this.position = position;
            this.menu = menu;
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDataSet);

        }

        private void frmStateDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.statesDataSet.States);

            // This sets the table 'details' to the position of the selected item in the listbox
            statesBindingSource.Position = position;
        }
        
        private void btnReturn_Click(object sender, EventArgs e) // Button to close form and show the main menu
        {
            this.Close();
            menu.Show();
        }

        private void frmStateDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}
