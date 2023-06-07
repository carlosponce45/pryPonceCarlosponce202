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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text == "admin" && txtcontraseña.Text == "admin")
            {
               Frmmenucliente frmmenucliente = new Frmmenucliente();
                this.Hide();
                frmmenucliente.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuarioy la contraseña no son correcto", "Usuario/Contraseña Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
