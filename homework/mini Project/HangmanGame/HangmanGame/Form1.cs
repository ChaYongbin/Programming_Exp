using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 이 게임은 NHN NEXT 프로그래밍 연습 수업에 진행한 mini project입니다.
 * 제작자 차용빈
 */

namespace HangmanGame
{
    public partial class Form1 : Form
    {
        string l; // 행맨 문제 출제

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
  
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            
            string[] q20 = new string[] { "object", "desposit", "nuclear", "pollution", "convert", "trip", "motif", "remote", "victor", "enroll", "horror" };
            Random r = new Random();
            l = q20[r.Next(0, 10)];
            QBox();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                string oneword = textBox1.Text;

                for (int i = 0; i < l.Length; i++)
                {
                    if (oneword == l[i].ToString())
                    {
                        Qprint(i, textBox1.Text);
                        
                    }
                }
                label4.Text += " "  + textBox1.Text;
                textBox1.Text = "";
                QBox();
            }
        }
        public void Qprint(int w, string spe)
        {
            Label[] test = new Label[50];
            test[w] = new Label();
            Controls.Add(test[w]);
            test[w].Location = new System.Drawing.Point(51 + 50 * w, 101);
            test[w].Name = "word" + w.ToString();
            test[w].Size = new System.Drawing.Size(47, 49);
            test[w].Text = spe;
            test[w].Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            
        }
        public void QBox()
        {
            

            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black);

            for (int i = 0; i < l.Length; i++)  // 문제 출제 라벨 생성과 밑줄 ~~
            {
                g.DrawRectangle(blackPen, 50 + 50 * i, 100, 48, 50);
                //   Qprint(i, "   ");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text == l)
                {
                    MessageBox.Show("정답입니다. 좀 대단하군 ㅋㅋ");
                }
                else
                {
                    MessageBox.Show("으이그... 다시해라!!!");
                }
            }
        }
    }
}
