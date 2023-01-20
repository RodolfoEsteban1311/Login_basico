using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginBasico
{
    public partial class Form1 : Form
    {
        static int intentos = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string usuario = tbuser.Text;
            string password = tvcontrasena.Text;


            if (this.tbuser.Text == "rodolfo" && this.tvcontrasena.Text == "abcd1234")
            {
                intentos = 0;
                pictureBox1.Image = new Bitmap(@"C:\Users\52998\source\repos\LoginBasico\LoginBasico\candado.png");
                MessageBox.Show("Acceso concedido, Bienvenido");
            }
            else
            {
                intentos--;
                MessageBox.Show("Acceso Denegado. Usuario y/o clave incorrectos.");
                if (intentos == 0)
                {
                    MessageBox.Show("Ha llegado al número máximo de intentos.");
                    Application.Exit();
                }

            }
        }
    }
}
