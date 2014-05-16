using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool t1check = false;
        bool t2check = false;
        bool t3check = false;
        int ms1 = 0;
        int ms2 = 1;
        int h, m, s;

        public Form1()
        {
            InitializeComponent();
            label4.Text = "초";
            label5.Text = "분";
            label6.Text = "시";
            timer1.Interval = 100;
            timer2.Interval = 1;
            timer3.Interval = 10;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(DateTime.Now.Second);
            label2.Text = Convert.ToString(DateTime.Now.Minute);
            label3.Text = Convert.ToString(DateTime.Now.Hour);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 현재 시각 표시 
            if (radioButton1.Checked)
            {

                timer2.Enabled = false;
                timer3.Enabled = false;
                label1.Text = "00";
                label2.Text = "00";
                label3.Text = "00";

                label4.Text = "초";
                label5.Text = "분";
                label6.Text = "시";

                if (t1check == false)
                {
                    timer1.Enabled = true;
                    t1check = true;
                }
                else
                {
                    timer1.Enabled = false;
                    t1check = false;
                }
            }

            // 스톱워치 표시
            if (radioButton2.Checked)
            {
                timer1.Enabled = false;
                timer3.Enabled = false;

                label4.Text = "";
                label5.Text = "초";
                label6.Text = "분";


                if (t2check == false)
                {
                    timer2.Enabled = true;
                    t2check = true;
                }
                else
                {
                    timer2.Enabled = false;
                    t2check = false;
                }
            }

            // 타이머 표시
            if (radioButton3.Checked)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;


                label4.Text = "초";
                label5.Text = "분";
                label6.Text = "시";


                string line = textBox1.Text;
                string[] words = line.Split('/');
                int[] array = new int[words.Length];

                for (int i = 0; i < words.Length; i++)
                {
                    array[i] = Convert.ToInt32(words[i]);
                }

                h = array[0];
                m = array[1]; s = array[2];
                ms2 = s + (m * 60) + (h * 3600);

                if (t3check == false)
                {
                    timer3.Enabled = true;
                    t3check = true;
                }
                else
                {
                    timer3.Enabled = false;
                    t3check = false;
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ms1 = ms1 + 1;
            label1.Text = Convert.ToString(ms1 % 100);
            label2.Text = Convert.ToString((ms1 / 100) % (60));
            label3.Text = Convert.ToString(ms1 / 6000);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (ms2 != 0)
            {
                ms2 = ms2 - 1;
                label1.Text = Convert.ToString(ms2 % 60);
                label2.Text = Convert.ToString((ms2 / 60) % (60));
                label3.Text = Convert.ToString(ms2 / 3600);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // 스톱워치 표시
            if (radioButton2.Checked)
            {
                label1.Text = "00";
                label2.Text = "00";
                label3.Text = "00";
                label4.Text = "";
                label5.Text = "초";
                label6.Text = "분";
                ms1 = 0;
            }

            // 타이머 표시
            if (radioButton3.Checked)
            {
                label1.Text = "00";
                label2.Text = "00";
                label3.Text = "00";
                label4.Text = "";
                label5.Text = "초";
                label6.Text = "분";
                ms2 = 0;
            }
        }
    }
}
