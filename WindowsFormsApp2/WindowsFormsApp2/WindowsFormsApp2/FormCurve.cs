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
    public partial class FormCurve : Form
    {
        public FormCurve()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphicsObj = CreateGraphics();
            Pen penBlue = new Pen(Color.Blue, 2);
            Point[] points = new Point[]
               {
        new Point(50, 50),
        new Point(100, 100),
        new Point(150, 75),
        new Point(200, 125),
        new Point(250, 50)
               };
            float tension = 0.4f;                                
            graphicsObj.DrawCurve(penBlue, points,tension);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphicsObj = CreateGraphics();
            Pen pen = new Pen(Color.Green, 2);
            Point pt1 = new Point(50, 50);
            Point pt2 = new Point(100, 100);
            Point pt3 = new Point(150, 75);
            Point pt4 = new Point(200, 125);
            graphicsObj.DrawBezier(pen, pt1, pt2, pt3,pt4);
        }
    }
}
