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
        Label[] test = new Label[50];
        public Form1()
        {
            InitializeComponent();
            
            for (int idx = 0; idx < 50; idx++)
            {
                test[idx] = new Label();
                Controls.Add(test[idx]);
            }
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

        // 버튼을 클릭을 하면, 램덤으로 문제를 생성하고, Box를 그려준다.
        private void button27_Click(object sender, EventArgs e) // StartButton
        {
            string[] q10 = new string[] { 
                "object", "desposit", "nuclear", "pollution", "convert", 
                "trip", "motif", "remote", "victor", "enroll", 
                "horror", "accident", "advice", "aisle", "alphabet",
                "double","excite","experiment","explain","kindergarten",
                "production","performance","semester","somewhere","volunteer",
                "wisdom","wonder","temple","production","int"};
            Random r = new Random();
            l = q10[r.Next(0, 29)];
            QBox(l);
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
        
        // 원하는 철자를 입력하여 엔터키를 누르면 문제와 같은 철자가 있는지 확인하고 입력한다.
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
                QBox(l);
            }
        }

        // 리셋시 입력한 모든 글자를 지운다. 
        private void worldclear()
        {
            for (int idx = 0; idx < l.Length; idx++)
            {
                test[idx].Name = "word" + idx.ToString();
                test[idx].Location = new System.Drawing.Point(51 + 50 * idx, 101);
                test[idx].Size = new System.Drawing.Size(47, 49);
                test[idx].Text = "";
            }
        }
        
        // x번째 라벨의 글자를 넣는다.
        public void Qprint(int idx, string spe)
        {
            
            test[idx].Name = "word" + idx.ToString();
            test[idx].Location = new System.Drawing.Point(51 + 50 * idx, 101);
            test[idx].Size = new System.Drawing.Size(47, 49);
            test[idx].Text = spe;
            test[idx].Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        }
        
        // 램덤으로 정해진 글자의 수에 맞게 사각형을 그려준다.
        public void QBox(string l)
        {
            Graphics g = this.CreateGraphics(); 
            Pen blackPen = new Pen(Color.Black);
            for (int i = 0; i < l.Length; i++)  // 글자 수를 알려주는 사각형 그리기
                g.DrawRectangle(blackPen, 50 + 50 * i, 100, 48, 50);
            g.Dispose();
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
        public void BoxClear()
        {
            Graphics g = this.CreateGraphics();
            Brush back = Brushes.LavenderBlush;
            g.FillRectangle(back, 50, 100, 700, 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoxClear();
            worldclear();
            label4.Text = "";
            textBox2.Text = "";
        }
    }
}
