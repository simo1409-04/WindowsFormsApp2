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
    public partial class FormRadioButton : Form
    {
        public FormRadioButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Червен");
                radioButton1.ForeColor = Color.Red;
                radioButton1.BackColor = Color.White;
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Син");
                radioButton2.ForeColor = Color.Blue;
                radioButton2.BackColor = Color.White;
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("Оранжев");
                radioButton3.ForeColor = Color.Orange;
                radioButton3.BackColor = Color.White;
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("Зелен");
                radioButton4.ForeColor = Color.Green;
                radioButton4.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Изберете опция");
            }
        }
    }
}
