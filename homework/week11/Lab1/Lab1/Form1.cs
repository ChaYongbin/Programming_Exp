using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brushes myCol = (Brush)myColor;
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            //Brush b = Color.MyColor;
            //Brush y = Brushes.PapayaWhip;
            //g.DrawLine(p, 100, 100, 500, 50);
            //g.DrawRectangle(p2, 50, 25, 500, 100);
            //g.FillEllipse(b, 300, 75, 50, 30);
            //g.DrawEllipse(p, 300, 75, 50, 30);

            g.DrawEllipse(p, 200, 100, 400, 370);
            //g.FillEllipse(b, 230, 80, 100, 100);
            //g.FillEllipse(b, 470, 80, 100, 100);
            //g.FillEllipse(y, 355, 320, 90, 100);

            p.Dispose();
            g.Dispose();
        }
    }
}
