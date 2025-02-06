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
    public partial class FormTimer : Form
    {
        
        public FormTimer()
        {
            InitializeComponent();
        }
        System.Diagnostics.Stopwatch StopWatch = new System.Diagnostics.Stopwatch();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.StopWatch.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = this.StopWatch.Elapsed;
            label1.Text = ($"Изминало реме: {Math.Floor(elapsed.TotalMilliseconds)} ms");
        }
    }
}
