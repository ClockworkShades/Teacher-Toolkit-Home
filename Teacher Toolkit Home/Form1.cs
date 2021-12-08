using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Toolkit_Home
{
    public partial class Form1 : Form
    {
        //Global
        DateTime dt1 = DateTime.Now;
        textBox1.Text = dt1.ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dt1 = dt1.AddMilliseconds(timer1.Interval);
            textBox1.Text = dt1.ToString();
            TimeSpan ts = DateTime.Now.Subtract(dt1);

        }
    }
}
