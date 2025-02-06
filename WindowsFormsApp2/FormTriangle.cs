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
    public partial class FormTriangle : Form
    {
        public FormTriangle()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 200;
            numericUpDown2.Maximum = 200;
            numericUpDown3.Maximum = 200;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            int c = (int)numericUpDown3.Value;

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("Въведените стойности не образуват триъгълник.");
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
                return;
            }
            
            float angleA = (float)Math.Acos((b * b + c * c - a * a) / (2 * b * c));
            float angleB = (float)Math.Acos((a * a + c * c - b * b) / (2 * a * c));
            float angleC = (float)Math.Acos((a * a + b * b - c * c) / (2 * a * b));
            pictureBox1.Refresh();
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Pen pen = new Pen(colorDialog.Color, 2);

                PointF[] trianglePoints = new PointF[3];
                trianglePoints[0] = new PointF((pictureBox1.Width - c) / 2, (pictureBox1.Height - (float)(b * Math.Sin(angleA))) / 2);
                trianglePoints[1] = new PointF(trianglePoints[0].X + c, trianglePoints[0].Y);
                trianglePoints[2] = new PointF((float)(trianglePoints[0].X + b * Math.Cos(angleA)), (float)(trianglePoints[0].Y + b * Math.Sin(angleA)));
                g.DrawPolygon(pen, trianglePoints);
            }
        }
    }
}
