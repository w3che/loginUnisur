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
        static string usuario = "Pancho";
        static string clave = "Barco100";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"..\..\lock.png");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //User = "Pancho"
            //Contraseña = "Barco100"
            string user = tbuser.Text;
            string contrasena = tbcontrasena.Text;
            if (user == usuario && contrasena == clave)
            {
                intentos = 3;
                pictureBox1.Image = new Bitmap(@"..\..\unlocked.png");
                MessageBox.Show("Bienvenido", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aviso.Text = "";
            }
            else if (intentos <= 3 && intentos > 0)
            {
                //Avisar cuantos intentos le quedan
                intentos--;
                aviso.Text = "Solo tienes " + Convert.ToString(intentos) + " intentos más";
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbuser.Focus();
            }
            
            if (intentos <= 0)
            {
                aviso.Text = "Ya no tienes más intentos";
                btnEntrar.Enabled = false;
                tbcontrasena.Enabled = false;
                tbuser.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
