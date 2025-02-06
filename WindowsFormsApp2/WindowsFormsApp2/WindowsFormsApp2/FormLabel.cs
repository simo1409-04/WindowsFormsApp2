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
    public partial class FormLabel : Form
    {
        Font SmallFont = new Font("Arial", 10);
        Font LargeFont = new Font("Arial", 20);
        public FormLabel()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Font = LargeFont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Font = SmallFont;
            
        }
    }
}
