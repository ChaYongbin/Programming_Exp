using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * 이 게임은 NHN NEXT 프로그래밍 연습 수업에 진행한 mini project입니다.
 * 제작자 차용빈
 */

namespace HangmanGame
{
    public partial class Form1 : Form
    {
        string l = string.Empty; // 행맨 문제 출제
        Label[] test = new Label[50]; //레이블 제작에 초기화
        int score = 0; // score 변수 초기화
        bool suc; // 정답을 맞았는지 확인하는 변수
        int level = 1; // 레벨 초기화

        public Form1()
        {
            InitializeComponent();

            for (int idx = 0; idx < 50; idx++) // 레이블 생성
            {
                test[idx] = new Label();
                Controls.Add(test[idx]);
            }

            score = 400; // 초기 스코어

            suc = true;
        }

        // Level 별로 난이도를 다르게 한다. (Level 별 단어 길이 설정)

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
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\chayongbin\Documents\GitHub\pex2014\homework\mini Project\HangmanGame\HangmanGame\Resources\wordlist.txt");
            // wordlist text file

            Random r = new Random();
            l = lines[r.Next(0, 58110)];
            QBox(l);
            ScoreView();
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
                string[] tcw = label4.Text.Split(' ');

                if (l == string.Empty)
                {
                    MessageBox.Show("start 버튼을 눌러 시작 해주세요");
                    textBox1.Text = "";
                }
                 /* 버그 발생지점
                 * 스펠링이 두 개 겹치는 경우에 에러가 나면서 오류가 뜸.
                 * 문제 해결 방안. 
                 * TestCheckWord()를 추가 해서 발생한 오류이기 때문에 이 점을 해결해야한다. 
                 * 다른 오류는 없지만 이 문제가 해결되야지 점수 측정에 도움이 된다.
                 */
                else
                {
                    for (int j = 0; j < l.Length; j++)
                    {
                        if (textBox1.Text == l[j].ToString())
                        {
                            Qprint(j, textBox1.Text);
                            score += 50;
                            ScoreView();
                        }
                    }

                    for (int i = 0; i < tcw.Length; i++) // label4.Text.Length로 할 경우 빈 공백도 길이로 간주하기 떄문에 오류가 생긴다. tcw로 하는 것이 좋음. 
                    {
                        if (tcw[i] == textBox1.Text)
                        {
                            MessageBox.Show("사용한 스펠링입니다. 다시 한 번 확인해보세요.");
                            textBox1.Text = string.Empty;
                            break; 
                            // break 를 이용하여 버그 해결
                        }
                    }

                    // 사용한 스펠링을 알려주고 빈 공백이 생기는 버그를 해결. 
                    if (textBox1.Text != string.Empty) 
                    {
                        label4.Text += " " + textBox1.Text;
                        textBox1.Text = string.Empty;
                        score -= 50;
                        ScoreView();
                    }

                    QBox(l);
                }
            }
        }

        // 게임 스코어를 기록하는 메소드이다. 
        private void GameScore()
        {
            // 최종 답을 맞출 때 스코어 정산.
            if (suc == true)
            {
                score += 100;
                suc = false;
            }
            else
            {
                score -= 100;
                suc = true;
            }
            // 철자 입력할 때 스코어 정산.
        }

        // 게임 스코어를 화면에 보여주는 메소드
        private void ScoreView()
        {
            label6.Text = score.ToString();
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

        // 정답이 맞는지 아닌지 확인한다.
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text == l)
                {
                    MessageBox.Show("정답입니다. 좀 대단하군 ㅋㅋ");
                    suc = true;
                    GameScore();
                    ScoreView();
                    Reset();
                }
                else
                {
                    suc = false;
                    MessageBox.Show("으이그... 다시해라!!!");
                    GameScore();
                    ScoreView();
                }
            }
        }

        // 문제 박스를 지운다.
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

        // 리셋 버튼을 통해서 리셋을 진행을 한다.
        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // 리셋 메소드를 만드는데, 이때 철자 적는 칸과 답을 적는 칸, 단어 레이블을 초기화를 진행을 한다. 
        private void Reset()
        {
            BoxClear();
            worldclear();
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // 사용한 스펠링를 체크하는 메소드를 체크하는 테스트를 한다.
        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            QBox(l);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        // 점수가 0점 일 때 일어나는 이벤트
        private void GameOver()
        {
            if (score == 0)
            {
                MessageBox.Show("");
            }
        }
    }
}
