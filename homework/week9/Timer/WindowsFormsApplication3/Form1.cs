using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        bool t1 = false;
        bool t2 = false;
        bool t3 = false;
        int tSec = 0;
        int tSec2 = 1;
        int s, m, h = 0;

        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1;
            timer3.Interval = 100;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer3.Enabled = false;

            if (t1 == false)
            {
                timer1.Enabled = true;
                t1 = true;
            }
            else
            {
                timer1.Enabled = false;
                t1 = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = Convert.ToString(DateTime.Now.Hour);
            label2.Text = Convert.ToString(DateTime.Now.Minute);
            label3.Text = Convert.ToString(DateTime.Now.Second);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tSec += 1;
            label1.Text = Convert.ToString(tSec / 3600);
            label2.Text = Convert.ToString((tSec / 60) % 60);
            label3.Text = Convert.ToString(tSec % 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string l = textBox1.Text;
            string[] ll = l.Split();
            int[] arr = new int[ll.Length];

            for (int i = 0; i < ll.Length; i++)
                arr[i] = Convert.ToInt32(ll[i]);

            s = arr[2];
            m = arr[1];
            h = arr[0];

            tSec2 = s + (m * 60) + (h * 3600);


            if (radioButton2.Checked)
            {
                timer1.Enabled = false;
                timer3.Enabled = false;

                if (t2 == false)
                {
                    timer2.Enabled = true;
                    t2 = true;
                }
            }
            else if (radioButton3.Checked)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;

                if (t3 == false)
                {
                    timer3.Enabled = true;
                    t3 = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t2 == true)
            {
                timer2.Enabled = false;
                t2 = false;
            }
            else if (t3 == true)
            {
                timer3.Enabled = false;
                t3 = false;
                button2.Text = "Restart";
            }
            else if (t3 == false)
            {
                timer3.Enabled = true;
                t3 = true;
                button2.Text = "Stop";
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            tSec2 -= 1;

            label1.Text = Convert.ToString(tSec2 / 3600);
            label2.Text = Convert.ToString((tSec2 / 60) % 60);
            label3.Text = Convert.ToString(tSec2 % 60);
        }
    }
}
