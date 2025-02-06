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
    public partial class FormEllipse : Form
    {
        public FormEllipse()
        {
            //Задаване на максимални стойности на Numericupdown
            InitializeComponent();
            numericUpDown1.Maximum = 150;
            numericUpDown2.Maximum = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            //Въвеждане на стойности на радиус1 и радиус2 за ширина и височина на елипсата
            int radius1 = (int)numericUpDown1.Value;
            int radius2 = (int)numericUpDown2.Value;
            int x = (pictureBox1.Width - radius1 * 2) / 2;
            int y = (pictureBox1.Height - radius2 * 2) / 2;
            Rectangle rect = new Rectangle(x, y, radius1 * 2, radius2 * 2);
            pictureBox1.Refresh();
            //Изчертаване на елипс чрез избор на цвят
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Pen pen = new Pen(colorDialog.Color, 2);
                g.DrawEllipse(pen, rect);
                }
        }
    }
}
