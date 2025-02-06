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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphicsObj = this.CreateGraphics();
            Pen pen = new Pen(Color.Pink, 5);
            graphicsObj.DrawLine(pen, 50, 50, 100, 200);
            graphicsObj.DrawLine(pen, 300, 100, 100, 100);
        }
    }
}
