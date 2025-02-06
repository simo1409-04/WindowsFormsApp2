﻿using System;
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
    public partial class FormFillEllipse : Form
    {
        public FormFillEllipse()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 150;
            numericUpDown2.Maximum = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            int radius1 = (int)numericUpDown1.Value;
            int radius2 = (int)numericUpDown2.Value;
            int x = (pictureBox1.Width - radius1 * 2) / 2;
            int y = (pictureBox1.Height - radius2 * 2) / 2;
            Rectangle rect = new Rectangle(x, y, radius1 * 2, radius2 * 2);
            pictureBox1.Refresh();
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Brush brush = new SolidBrush(colorDialog.Color);
                g.FillEllipse(brush, rect);
            }
        }
    }
}
