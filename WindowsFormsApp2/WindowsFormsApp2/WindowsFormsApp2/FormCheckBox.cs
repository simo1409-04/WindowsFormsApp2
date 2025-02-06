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
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkbox1;
            string checkbox2;
            string checkbox3;
            string checkbox4;
            string check= "Избрани опции:";
            if (checkBox1.Checked)
            {
                check+=checkbox1 = " А";
            }
            if (checkBox2.Checked)
            {
                check+=checkbox2 = " Б";
            }
            if (checkBox3.Checked)
            {
                check += checkbox3 = " В";
            }
            if (checkBox4.Checked)
            {
                check+=checkbox4 = " Г";
            }
            MessageBox.Show(check);
        }
    }
}
