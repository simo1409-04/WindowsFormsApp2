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
    public partial class FormRect : Form
    {
        public FormRect()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 450;
            numericUpDown2.Maximum = 350;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int width = (int)numericUpDown1.Value;
            int height = (int)numericUpDown2.Value;

            int x = (pictureBox1.Width - width) / 2;
            int y = (pictureBox1.Height - height) / 2;

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Pen pen = new Pen(colorDialog.Color,2);

                pictureBox1.Refresh();
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawRectangle(pen, x, y, width, height);
                }
            }
        }
    }
}
