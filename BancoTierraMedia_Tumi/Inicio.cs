using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoTierraMedia_Tumi
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnSolicitarPrestamo.Enabled = false;
        }

        private void controlBotones()
        {
            if (txtNombre.Text.Trim() != string.Empty && txtNombre.Text.All(Char.IsLetter))
            {
                btnSolicitarPrestamo.Enabled = true;
                errorProvider1.SetError(txtNombre, "");
            }
            else
            {
                if (!(txtNombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtNombre, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtNombre, "Debe introducir su nombre");
                }
                btnSolicitarPrestamo.Enabled = false;
                txtNombre.Focus();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
