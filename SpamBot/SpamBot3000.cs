using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpamBot
{
    public partial class SpamBot3000 : Form
    {
        public SpamBot3000()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void SpamBot3000_Load(object sender, EventArgs e)
        {

        }
    }
}
