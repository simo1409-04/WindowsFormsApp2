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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphicsObj = this.CreateGraphics();
            const int height = 10;
            const int width = 100;
            Pen redPen = Pens.Red;
            Brush orangeBrush = Brushes.Orange;
            Pen ellipse_pen = new Pen(Color.Blue);
                ellipse_pen.DashPattern = new float[] { 5, 5 };

                Rectangle rect =
                    new Rectangle(height + 30, 10, width, width);
                graphicsObj.DrawEllipse(ellipse_pen, rect);
                graphicsObj.FillPie(orangeBrush, rect, 300, 30);
                graphicsObj.DrawPie(redPen, rect, 300, 30);

                rect.X += width + height;
                graphicsObj.DrawEllipse(ellipse_pen, rect);
                graphicsObj.FillPie(orangeBrush, rect, 300, -330);
                graphicsObj.DrawPie(redPen, rect, 300, -330);

                rect.Y += width + height;
                rect.X = height + 30;
                graphicsObj.DrawEllipse(ellipse_pen, rect);
                graphicsObj.FillPie(orangeBrush, rect, 315, 90);
                graphicsObj.DrawPie(redPen, rect, 315, 90);

                rect.X += width + height;
                graphicsObj.DrawEllipse(ellipse_pen, rect);
                graphicsObj.FillPie(orangeBrush, rect, 315, -270);
                graphicsObj.DrawPie(redPen, rect, 315, -270);

                rect.Y += width + height;
                rect.X = height + 30;
                graphicsObj.DrawEllipse(ellipse_pen, rect);
                graphicsObj.FillPie(orangeBrush, rect, 180, 90);
                graphicsObj.DrawPie(redPen, rect, 180, 90);
               
                rect.X += width + height;
                graphicsObj.DrawEllipse(ellipse_pen, rect);
                graphicsObj.FillPie(orangeBrush, rect, 180, -270);
                graphicsObj.DrawPie(redPen, rect, 180, -270);
        }
    }
}
