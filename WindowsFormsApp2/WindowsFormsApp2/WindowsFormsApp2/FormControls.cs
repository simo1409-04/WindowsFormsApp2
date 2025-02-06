using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormControls : Form
    {
        public FormControls()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRadioButton fRadioButton = new FormRadioButton();
            fRadioButton.Show();
            fRadioButton.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCheckBox fCheckBox = new FormCheckBox();
            fCheckBox.Show();
            fCheckBox.TopMost = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormTimer fTimer = new FormTimer();
            fTimer.Show();
            fTimer.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormButtons fButtons = new FormButtons();
            fButtons.Show();
            fButtons.TopMost = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormLabel fLabel = new FormLabel();
            fLabel.Show();
            fLabel.TopMost = true;
        }
    }
}
