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
    public partial class FormFillPie : Form
    {
        public FormFillPie()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 150;
            numericUpDown2.Maximum = 360;
            numericUpDown3.Maximum = 360;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;
            int radius = (int)numericUpDown1.Value;
            int startAngle = (int)numericUpDown2.Value;
            int endAngle = (int)numericUpDown3.Value;

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                    Brush brush = new SolidBrush(colorDialog.Color);
                    Pen pen1 = new Pen(Color.Gray, 2);
                    pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    pictureBox1.Refresh();
                    using (Graphics g = pictureBox1.CreateGraphics())
                    {
                        g.FillPie(brush, centerX - radius, centerY - radius, radius * 2, radius * 2, startAngle, endAngle - startAngle);
                        g.DrawEllipse(pen1, centerX - radius, centerY - radius, radius * 2, radius * 2);
                    }         
            }
        }
    }
}
