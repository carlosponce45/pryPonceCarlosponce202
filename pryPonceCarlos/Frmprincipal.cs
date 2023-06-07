using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace pryPonceCarlos
{
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Clsbasededato clsBaseDeDatos = new Clsbasededato();
            clsBaseDeDatos.ListarClientes(dgvClientes, "NEPTUNO", "Clientes");
            mrcFiltros.Enabled = true;

        }

        private void Frmprincipal_Load(object sender, EventArgs e)
        {
            Clsbasededato clsBaseDeDatos = new Clsbasededato();
            clsBaseDeDatos.CargarPaisCiudad(cmbCiudad, cmbPais, "NEPTUNO", "Clientes");
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clsbasededato clsBaseDeDatos = new Clsbasededato();
            clsBaseDeDatos.ListarPais(dgvClientes, "NEPTUNO", "Clientes", cmbPais, cmbCiudad);
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clsbasededato clsBaseDeDatos = new Clsbasededato();
            clsBaseDeDatos.ListarCiudad(dgvClientes, "NEPTUNO", "Clientes", cmbCiudad, cmbPais);
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {

            Frmmenucliente frmmenucliente = new Frmmenucliente();
            this.Hide();
           frmmenucliente.ShowDialog();
            this.Close();
        }
    }
}
