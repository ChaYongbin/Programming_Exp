using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GameTest
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        int w = 400;
        bool left;
        List<Bitmap> smurf = new List<Bitmap>();
        Bitmap actor;
        List<Bitmap> smurfLeft = new List<Bitmap>();


        public Form1()
        {
            InitializeComponent();
            wmp.URL = @"Resources\mario.mp3";
            wmp.controls.stop();
            timer1.Interval = 33;
            timer1.Enabled = true;
            wmp.controls.play();
            Bitmap x = Properties.Resources.smurf;
            for (int i = 0; i < 64 * 8; i += 64)
            {
                Rectangle r = new Rectangle(i, 0, 64, 64);
                Bitmap s = x.Clone(r, x.PixelFormat);
                Bitmap l = x.Clone(r, x.PixelFormat);
                smurf.Add(s);
                smurfLeft.Add(l);

            }
            actor = smurfLeft[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wmp.controls.play();
            Graphics g = this.CreateGraphics();
            Bitmap b1 = Properties.Resources.back1;
            Bitmap b2 = Properties.Resources.back2;
            Rectangle r1 = new Rectangle(w, 0, 800, 480);
            Bitmap b3 = b2.Clone(r1, b2.PixelFormat);
            g.DrawImage(b1, 0, 0);
            g.DrawImage(b2, -400, 0);
            g.DrawImage(b3, 400, 0);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }
        private void draw()
        {
            Bitmap screen = new Bitmap(800, 480);
            Graphics g4 = Graphics.FromImage(screen);

            Graphics g = this.CreateGraphics();
            Bitmap b1 = Properties.Resources.back1;
            Bitmap b2 = Properties.Resources.back2;
            Rectangle r1 = new Rectangle(w, 0, 800, 480);
            Bitmap b3 = b2.Clone(r1, b2.PixelFormat);
            g4.DrawImage(b1, 0, 0);
            g4.DrawImage(b3, 0, 0);
            g4.DrawImage(actor, 368, 328);
            DateTime t = DateTime.Now;
            string str = string.Format("{0:hh시mm분ss초ffff}", t);
            g4.DrawString(str, new Font("나눔고딕", 20, GraphicsUnit.Pixel), Brushes.Red, 10, 10);

            g.DrawImage(screen, 0, 0);

            g4.Dispose();
            g.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameUpdate();
            draw();
        }
        
        private void GameUpdate()
        {
            if (MouseButtons == MouseButtons.Left)
            {
                if (left)
                    w = w - 7;
                else
                    w = w + 7;
            }
            if (w < 0) w = 0;
            else if (w > 800) w = 800;


            if (left)
            {
                actor = smurfLeft[(w / 5) % 8];
            }
            else
            {
                actor = smurfLeft[(w / 5) % 8];
            }
            
           

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            left = (e.X < 400);
            
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
