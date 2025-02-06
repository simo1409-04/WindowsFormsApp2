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
            //Отваряне на форма FormDraw
            FormDraw fDraw = new FormDraw();
            fDraw.Show();
            fDraw.TopMost = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Отваряне на форма FormFIll
            FormFill fFIll = new FormFill();
            fFIll.Show();
            fFIll.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Отваряне на форма FormTools
            FormTools fTools = new FormTools();
            fTools.Show();
            fTools.TopMost = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            label3.AutoSize = false;
        }
    }
}
