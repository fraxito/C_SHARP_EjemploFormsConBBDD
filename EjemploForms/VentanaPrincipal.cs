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
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();

        public VentanaPrincipal()
        {
            InitializeComponent();
            misPokemons = miConexion.getPokemons();
            dataGridView1.DataSource = misPokemons;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPokemonPorNombre(textBox1.Text);
            label2.Text = misPokemons.Rows[0]["weight"].ToString();
        }


        //Método para cerrar la apliación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

    }
}
