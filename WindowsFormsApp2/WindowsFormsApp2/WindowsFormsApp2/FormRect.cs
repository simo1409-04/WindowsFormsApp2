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
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           Graphics graphicsObj = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);
            graphicsObj.DrawRectangle(pen, 50, 50, 100, 200);
        }
    }
}
