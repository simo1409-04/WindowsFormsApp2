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
            //Отваряне на форма за изчертаване на правоъгълник
            FormRect fRect = new FormRect();
            fRect.Show();
            fRect.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Отваряне на форма за изчертаване на линия
            FormLine fLine = new FormLine();
            fLine.Show();
            fLine.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Отваряне на форма за изчертаване на елипса
            FormEllipse fEllipse = new FormEllipse();
            fEllipse.Show();
            fEllipse.TopMost = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Отваряне на форма за изчертаване на пай
            FormPie fPie = new FormPie();
            fPie.Show();
            fPie.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Отваряне на форма за изчертаване на полигон
            FormPolygon fPolygon = new FormPolygon();
            fPolygon.Show();
            fPolygon.TopMost = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Отваряне на форма за изчертаване на спирала
            FormSpiral fSpiral = new FormSpiral();
            fSpiral.Show();
            fSpiral.TopMost = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Отваряне на форма за изчертаване на криви, затворени криви и криви на Безие
            FormDrawBezier fDrawBezier = new FormDrawBezier();
            fDrawBezier.Show();
            fDrawBezier.TopMost = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Отваряне на форма за изчертаване на триъгълник
            FormTriangle fTriangle = new FormTriangle();
            fTriangle.Show();
            fTriangle.TopMost = true;
        }
    }
}
