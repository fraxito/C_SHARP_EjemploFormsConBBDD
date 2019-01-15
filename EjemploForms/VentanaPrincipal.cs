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
            textBox2.Text = misPokemons.Rows[0]["weight"].ToString();
            textBox3.Text = misPokemons.Rows[0]["height"].ToString();
            textBox4.Text = misPokemons.Rows[0]["habitat"].ToString();
            label6.Text = misPokemons.Rows[0]["id"].ToString();
        }


        //Método para cerrar la apliación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miConexion.ActualizaPokemon(label6.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            //refresca el dataGridView
            dataGridView1.DataSource = miConexion.getPokemons();
        }
    }
}
