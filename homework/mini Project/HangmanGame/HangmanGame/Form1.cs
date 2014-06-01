using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HangmanGame
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Label label;

        public Form1()
        {
            InitializeComponent();
            string l = "STRUCTURES"; // 행맨 문제 출제
            string[] ll = l.Split(); // 행맨 문제를 한 단어로 나누기
            int l_num = ll.Length; // l_num 에 ll 행렬 길이 넣기 -> 라벨을 만들기 위해서
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            string s = ((System.Windows.Forms.Label)sender).Name.ToString();
            
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            int i = 1;
            TextBox[] test = new TextBox[100];
            test[i] = new TextBox();
            Controls.Add(test[i]);
            test[i].Location = new System.Drawing.Point(100, 100);
            test[i].Name = "Testing";
            test[i].Size = new System.Drawing.Size(38,12);
            test[i].Text = "Label12";
            
        }
    }
}
