using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkClient
{
    public partial class Form1 : Form
    {
        Client client = new Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = textBox2.Text;
            int port = (int) numericUpDown1.Value;
            string result = client.Connect(address, port);
            label1.Text = result;
            if(result == "success")
            {
                labeldebug.Text = "Connected";
            }
            else
            {
                labeldebug.Text = "연결 오류 발생";
                textBox1.Text = result;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labeldebug_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Close();
            labeldebug.Text = "접속 종료";
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                labeldebug.Text = "엔터 눌림";
                string msg = client.Send(textBox3.Text);
                textBox1.Text += msg + "\r\n";
                textBox3.Text = "";
                textBox3.Focus();
            }
        }
    }
}
