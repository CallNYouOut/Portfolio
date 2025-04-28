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
    public partial class Settings : Form
    {
        private HomeForm homeForm;
        private Color selectedColor;
        private Font selectedFont;
        public Settings(HomeForm form)
        {
            InitializeComponent();
            this.homeForm = form;
            // initialize defaults
            selectedColor = homeForm.BackColor;
            selectedFont = homeForm.Font;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            // get user selected font
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFont = fontDialog.Font;
                lblCustomize.Font = fontDialog.Font; // show font on label
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Open color picker
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                pnlColor.BackColor = selectedColor; // Show preview in a panel
            }
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            // apply changes to the profile form
            homeForm.UpdateHome(selectedColor, selectedFont);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
