using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke_Chatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.KeyDown += new KeyEventHandler(Enter_Touch);
        }

        private void Enter_Touch(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radioButton1.Checked)
                {
                    textBox1.Text = textBox1.Text + "\r\n" + "ME : " + textBox2.Text;
                    textBox2.Text = "";
                }
                else if (radioButton2.Checked)
                {
                    textBox1.Text = textBox1.Text + "\r\n" + "Steve.K : " + textBox2.Text;
                    textBox2.Text = "";
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
