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
    public partial class FormSpiral : Form
    {
        public FormSpiral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;
            double radius = 1;
            double stepSize = 0.5;
            int angle = 0;
            GraphicsPath path = new GraphicsPath();
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Pen pen = new Pen(colorDialog.Color, 1);
                pictureBox1.Refresh();
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    path.StartFigure();

                    for (int i = 0; i < 500; i++)
                    {
                        double radians = angle * Math.PI / 180.0;
                        int x = (int)(centerX + radius * Math.Cos(radians));
                        int y = (int)(centerY + radius * Math.Sin(radians));
                        path.AddEllipse(x, y, 3, 3);
                        radius += stepSize;
                        angle += 4;
                    }
                    path.CloseFigure();
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}
