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
    public partial class Frmmenucliente : Form
    {
        public Frmmenucliente()
        {
            InitializeComponent();
        }

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
           Frmprincipal frmprincipal = new Frmprincipal();
            this.Hide();
            frmprincipal.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTablas_Click(object sender, EventArgs e)
        {
            Frmtablas frmtablas = new Frmtablas();
            this.Hide();
            frmtablas.ShowDialog();
            this.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos frmPedidos = new frmPedidos();
            this.Hide();
            frmPedidos.ShowDialog();
            this.Close();
        }
    }
}
