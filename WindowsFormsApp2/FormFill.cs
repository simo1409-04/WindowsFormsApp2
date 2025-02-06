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
    public partial class FormFill : Form
    {
        public FormFill()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFillPie fFPie = new FormFillPie();
            fFPie.Show();
            fFPie.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFillEllipse fFillEllipse = new FormFillEllipse();
            fFillEllipse.Show();
            fFillEllipse.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFillRect fFillRect = new FormFillRect();
            fFillRect.Show();
            fFillRect.TopMost = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormFillClosedCurve fClosedCurve = new FormFillClosedCurve();
            fClosedCurve.Show();
            fClosedCurve.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormFillPolygon fFillPolygon = new FormFillPolygon();
            fFillPolygon.Show();
            fFillPolygon.TopMost = true;
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            FormFillTriangle fFillTriangle = new FormFillTriangle();
            fFillTriangle.Show();
            fFillTriangle.TopMost = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
