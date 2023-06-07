using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonceCarlos
{
    public partial class Frmtablas : Form
    {
        public Frmtablas()
        {
            InitializeComponent();
        }
        Clsbasededato clsbasededato = new Clsbasededato();

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
           clsbasededato.MostrarTablas(cmbTablas, cadenaConexion, dgvTablas);
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
           clsbasededato.ListarTablas(cmbTablas, dgvTablas, txtBaseDatos);
            cadenaConexion = clsbasededato.cadenaConexion;
            if (cadenaConexion != "")
            {
                lblBaseDatos.Enabled = true;
                lblTabla.Enabled = true;
                cmbTablas.Enabled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Frmmenucliente frmmenucliente = new Frmmenucliente();
            this.Hide();
            frmmenucliente . ShowDialog();
            this.Close();
        }
    }
}
