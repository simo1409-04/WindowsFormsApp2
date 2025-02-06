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
    public partial class FormFillClosedCurve : Form
    {
        public FormFillClosedCurve()
        {
            InitializeComponent();
            startPX.Maximum = ctrlP1X.Maximum = ctrlP2X.Maximum = endPX.Maximum = 510;
            startPY.Maximum = ctrlP1Y.Maximum = ctrlP2Y.Maximum = endPY.Maximum = 350;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point startPoint = new Point((int)startPX.Value, (int)startPY.Value);
            Point controlP1 = new Point((int)ctrlP1X.Value, (int)ctrlP1Y.Value);
            Point controlP2 = new Point((int)ctrlP2X.Value, (int)ctrlP2Y.Value);
            Point endPoint = new Point((int)endPX.Value, (int)endPY.Value);
            Point[] points = { startPoint, controlP1, controlP2, endPoint };
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Brush brush = new SolidBrush(colorDialog.Color);

                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.FillClosedCurve(brush, points);
                }
            }
        }
    }
}
