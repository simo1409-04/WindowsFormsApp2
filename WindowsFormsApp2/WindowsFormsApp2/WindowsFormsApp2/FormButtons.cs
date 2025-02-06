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
    public partial class FormButtons : Form
    {
        public FormButtons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
            button3.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изберете цвят");
        }
    }
}
