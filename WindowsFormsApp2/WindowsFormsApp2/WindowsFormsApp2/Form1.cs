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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDraw fDraw = new FormDraw();
            fDraw.Show();
            fDraw.TopMost = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFill fFIll = new FormFill();
            fFIll.Show();
            fFIll.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormControls fControls = new FormControls();
            fControls.Show();
            fControls.TopMost = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
