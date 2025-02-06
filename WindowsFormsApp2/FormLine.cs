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
    public partial class FormLine : Form
    {
        public FormLine()
        {
            InitializeComponent();
            //Задаване на максимални стойности на numericupdown за създаване на точките на линията
            numericUpDown1.Maximum = 499;
            numericUpDown2.Maximum = 299;
            numericUpDown3.Maximum = 499;
            numericUpDown4.Maximum = 299;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics graphicsObj = pictureBox1.CreateGraphics();
            ColorDialog colorDialog = new ColorDialog();
            //Избор на цвят на писалка за изчертаване на линия
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                //Въвеждне на координати на две точки
                int p1x, p1y, p2x, p2y;
                Pen pen1 = new Pen(colorDialog.Color,3);
                p1x = Convert.ToInt32(numericUpDown1.Value);
                p1y = Convert.ToInt32(numericUpDown2.Value);
                p2x = Convert.ToInt32(numericUpDown3.Value);
                p2y = Convert.ToInt32(numericUpDown4.Value);
                //Изчертаване
                graphicsObj.DrawLine(pen1, p1x, p1y, p2x, p2y);
            }                                   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
