using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            panel2.Hide();
            btnsi.TabStop = false;//no permite usar la tecla tab en entre el botón
            btnNo.TabStop = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void Moverboton()
        {
            Random rmd = new Random();
            int x = rmd.Next(0,this.Width - btnNo.Width); //lo ancho
            int y = rmd.Next(0, this.Height - btnNo.Height); //lo alto
            btnNo.Location = new Point(x, y);
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            Moverboton();
            //para que el botón no quede sobrepuesto sobre otro
            if(btnNo.Location==btnsi.Location||btnNo.Location==label1.Location )
            {
                Moverboton();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void btnsi_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }
    }
}
