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
    public partial class FormPie : Form
    {
        public FormPie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphicsObj = this.CreateGraphics();
            Pen penGreen = new Pen(Color.Orange,2);
            Rectangle rect = new Rectangle(10, 10, 100, 100);
            float startAngle = 0.0F;
            float sweepAngle = 90.0F;
            graphicsObj.DrawPie(penGreen, rect, startAngle, sweepAngle);
        }
    }
}
