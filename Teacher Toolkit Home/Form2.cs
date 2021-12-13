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
    public partial class Form2 : Form
    {
        //GLOBAL
        float timer = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += timer1.Interval * 0.001f;
            label1.Text = timer.ToString("0.0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button3.Show();
            button1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Show();
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer = 0;
            label1.Text = timer.ToString();
        }
    }
}
