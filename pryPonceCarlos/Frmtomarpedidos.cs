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
    public partial class Frmtomarpedidos : Form
    {
        public Frmtomarpedidos()
        {
            InitializeComponent();
        }
        Clsbasededato objBaseDeDatos = new Clsbasededato();
        private void Form1_Load(object sender, EventArgs e)
        {
            objBaseDeDatos.CargarPedidos(cmbPedido, "NEPTUNO", "Pedidos");
        }

        private void cmbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            objBaseDeDatos.ListarPedidos(dgvPedidos, "NEPTUNO", "Detalles de pedidos", cmbPedido);
        }
    }
}
