using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace WindowsFormsApp2
{
    public partial class FormBrush : Form
    {
        public FormBrush()
        {
            InitializeComponent();
        }
        //Създаване на правоъгълник
        Rectangle rect = new Rectangle(50, 150, 200, 150);
        private void button1_Click(object sender, EventArgs e)
        {
            //Изчертава се правоъгълник с плътен цвят, като цветът се избира чрез colorDialog
            Graphics g = pictureBox1.CreateGraphics();
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Brush solidBrush = new SolidBrush(colorDialog.Color);
                g.FillRectangle(solidBrush, rect);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Изчертава се правоъгълник с преливащи цветове, като цветътовете се избират чрез два последователни colorDialog
            Graphics g = pictureBox1.CreateGraphics();
            ColorDialog colorDialog = new ColorDialog();
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {              
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    Brush linearBrush = new LinearGradientBrush(new Point(0, 0), new Point(100, 0), colorDialog.Color, colorDialog1.Color);
                    g.FillRectangle(linearBrush, rect);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Изчертава се правоъгълник с щрихована четка
            Graphics g = pictureBox1.CreateGraphics();
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                HatchBrush hatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, colorDialog.Color);
                g.FillRectangle(hatchBrush, rect);
            }
        }
    }
}
