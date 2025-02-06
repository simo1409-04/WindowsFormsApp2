using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormPolygon : Form
    {
        List<Point> points = new List<Point>();
        int numPoints;
        public FormPolygon()
        {
            InitializeComponent();
            startPX.Maximum = 500;
            startPY.Maximum = 340;
            numericUpDown1.Minimum = 3;
        }
        
        private void button1_Click(object sender, EventArgs g)
        {
            int numPoints = (int)numericUpDown1.Value;
            int x = (int)startPX.Value;
            int y = (int)startPY.Value;
            points.Add(new Point(x, y));

            startPX.Value = 0;
            startPY.Value = 0;

            if (points.Count == numPoints)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            ColorDialog colorDialog = new ColorDialog();
            Graphics g = pictureBox1.CreateGraphics();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Pen pen = new Pen(colorDialog.Color, 2);
                g.DrawPolygon(pen, points.ToArray());
            }
        }
    }
}
