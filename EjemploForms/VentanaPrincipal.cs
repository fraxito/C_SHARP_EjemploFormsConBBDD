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
        DataTable misClientes = new DataTable();

        public VentanaPrincipal()
        {
            InitializeComponent();
            misClientes = miConexion.getClientes();
        }
    }
}
