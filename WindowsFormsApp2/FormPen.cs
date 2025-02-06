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
    public partial class FormPen : Form
    {
        public FormPen()
        {
            InitializeComponent();
            //Задава се максимална стойност на дебелината 5
            numericUpDown1.Maximum = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Изчертава се линия, със стандартен стил на писалката, с избран цвят от Colordialog
            Graphics g = pictureBox1.CreateGraphics();
            int width = (int)numericUpDown1.Value;
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Pen pen1 = new Pen(colorDialog.Color, width);
                g.DrawLine(pen1,50, 50, 200, 50);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Изчертава се линия, със пунктиран стил на писалката, с избран цвят от ColorDialog
            Graphics g = pictureBox1.CreateGraphics();
            int width = (int)numericUpDown1.Value;
                Pen pen2 = new Pen(Color.Red,width);
                pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(pen2, 50, 70, 200, 70);           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Изчертава се линия, със точков стил на писаклака, с избран цвят от ColorDialog
            Graphics g = pictureBox1.CreateGraphics();
            int width = (int)numericUpDown1.Value;
                Pen pen3 = new Pen(Color.Purple, width);
                pen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawLine(pen3, 50, 80, 200, 80);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Изчертава се линия, със стил на писаклака тип тире-точка, с избран цвят от ColorDialog
            Graphics g = pictureBox1.CreateGraphics();
            int width = (int)numericUpDown1.Value;

            Pen pen3 = new Pen(Color.Purple, width);
            pen3.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawLine(pen3, 50, 90, 200, 90);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Изчертава се линия, със стил на писаклака тип тире-точка-точка, с избран цвят от ColorDialog
            Graphics g = pictureBox1.CreateGraphics();
            int width = (int)numericUpDown1.Value;

            Pen pen3 = new Pen(Color.Violet, width);
            pen3.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            g.DrawLine(pen3, 50, 120, 200, 120);
        }
    }
}
