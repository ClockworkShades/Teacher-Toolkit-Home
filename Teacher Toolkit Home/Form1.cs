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
        // int fx;
        // int fy;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.StartPosition = FormStartPosition.Manual;
           // fx = this.Width; //store initial size/dementions
           // fy = this.Height;
           // this.Location = new Point(100, 100);
        }
        // resize code
        private void button1_Click(object sender, EventArgs e)
        {
           // this.Width = this.Width + 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this.Width = fx;
            // this.Width = fy;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //current font as default
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle;

            // Bold
            newFontStyle = FontStyle.Bold;
            currentFont = new Font(currentFont.Name, 18);
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            richTextBox1.BackColor = Color.FromArgb(255, 255, 128);

            // Text box coloured text
            richTextBox1.BackColor = Color.FromArgb(255, 255, 128);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText("Test Black");
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText("\r\nTest Blue");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Gray;
            
        }
    }
}
