using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginUnisur
{
    public partial class Form1 : Form
    {
        static int intentos = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //User = "Pancho"
            //Contraseña = "Barco100"
            string usuario = txtUsuario.Text;
            string password = txtClave.Text;
            if (usuario == "Pancho" && password == "Barco100")
            {
                intentos = 3;
                pictureBox1.Image = new Bitmap(@"C:\Users\JC\source\repos\loginUnisur\loginUnisur\unlocked.png");
                MessageBox.Show("Bienvenido");
            }
            else if (intentos <= 3 && intentos > 0)
            {
                //Avisar cuantos intentos le quedan
                intentos--;
                lblAviso.Text = "Solo tienes " + Convert.ToString(intentos) + " intentos más";
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            
            if (intentos == 0)
            {
                btnEntrar.Enabled = false;
                txtClave.Enabled = false;
                txtUsuario.Enabled = false;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            pictureBox1.Image = new Bitmap(@"C:\Users\JC\source\repos\loginUnisur\loginUnisur\lock.png");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
