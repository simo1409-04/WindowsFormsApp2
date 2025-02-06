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
    public partial class FormDraw : Form
    {
        public FormDraw()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRect fRect = new FormRect();
            fRect.Show();
            fRect.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLine fLine = new FormLine();
            fLine.Show();
            fLine.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEllipse fEllipse = new FormEllipse();
            fEllipse.Show();
            fEllipse.TopMost = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormPie fPie = new FormPie();
            fPie.Show();
            fPie.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCurve fCurve = new FormCurve();
            fCurve.Show();
            fCurve.TopMost = true;
            fCurve.TopMost = true;
            fCurve.TopMost = true;
        }
    }
}
