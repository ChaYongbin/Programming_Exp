using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal1
{
    public partial class Form2 : Form
    {
        Form1 frm1;


        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
                frm1.textBox1.Text = "00";
                
        }
    }
}
