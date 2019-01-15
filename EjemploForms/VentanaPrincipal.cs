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
    }
}
