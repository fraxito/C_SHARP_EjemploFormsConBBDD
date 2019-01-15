using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = textBox1.Text;
            String pass = textBox2.Text;

            if (usuario == "a")
            {
                //oculto esta ventana
                this.Hide();
                //
                VentanaPrincipal ventana = new VentanaPrincipal();
                ventana.Show();
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error al iniciar Sesión");
            }

        }
    }
}
