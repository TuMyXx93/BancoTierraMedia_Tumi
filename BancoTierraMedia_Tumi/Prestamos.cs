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
    public partial class Prestamos : Form
    {
        string nombreCliente;
        string[] razasDisponibles = { "Balrog", "Drúedain", "Enano", "Elfo", "Ent", "Goblin", "Hobbit", "Hombre", "Istari (Mago)", "Orco", "Troll", "Uruk-hai" };
        int[] cuotasDisponibles = { 12, 24, 36, 60, 120, 180, 240 };
        string[] lugaresDisponibles;
        Dictionary<int, double> interesesBase;

        public Prestamos(string nombre)
        {
            InitializeComponent();
            nombreCliente = nombre;

            string listadoCiudades = Properties.Resources.lugares.ToString();
            lugaresDisponibles = listadoCiudades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            interesesBase = new Dictionary<int, double>();
            int i;
            double interes;
            for (i = 0, interes = 3.0; i < cuotasDisponibles.Length; i++, interes += 0.5)
            {
                interesesBase[cuotasDisponibles[i]] = interes;
            }
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            popularCuotas();
            popularRazas();
            popularCiudades();
            lblSaludo.Text += nombreCliente;
        }

        void popularCuotas()
        {
            for(int i = 0; i < cuotasDisponibles.Length; i++)
            {
                cbxCuotas.Items.Add(cuotasDisponibles[i]);
            }
        }

        void popularRazas()
        {
            for(int i = 0; i < razasDisponibles.Length; i++)
            {
                cbxRazas.Items.Add(razasDisponibles[i]);
            }
        }

        void popularCiudades()
        {
            for(int i = 0; i < lugaresDisponibles.Length; i++)
            {
                cbxLugares.Items.Add(lugaresDisponibles[i]);
            }
        }

        private void bntVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularInteres()
        {
            int cuotasPedidas = (int)cbxCuotas.SelectedItem;
            string razaSeleccionada = cbxRazas.SelectedItem.ToString().ToLower();
            string lugarSeleccionado = cbxLugares.SelectedItem.ToString().ToLower();
            double interes = interesesBase[cuotasPedidas];
            if (new[] { "orco", "uruk-hai", "goblin", "troll", "balrog" }.Contains(razaSeleccionada))
            {
                interes += 0.3;
            }
            if (new[] { "rivendell", "tirion", "valinor", "hobbiton", "bree", "gondor" }.Contains(lugarSeleccionado))
            {
                interes -= 0.3;
            }
            return interes;
        }

        private void btnConfirmarSolicitud_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(pnlDatosPersonales, "");
                        errorProvider1.SetError(pnlDatosPrestamo, "");
                        double interesMensual = calcularInteres();
                        double montoPedido = double.Parse(txtMonto.Text);
                        int cuotasPedidas = (int)cbxCuotas.SelectedItem;
                        double interesTotal = montoPedido * (interesMensual / 100) * cuotasPedidas;
                        double montoAPagar = montoPedido + interesTotal;
                        string mensaje = "Su préstamo por " + montoPedido + " en " + cuotasPedidas + " cuotas se concederá con un interés del " + interesMensual + "% mensual.\nEl monto final asciende a: " + montoAPagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Cálculo de intereses", buttons);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(pnlDatosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(pnlDatosPrestamo, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(pnlDatosPrestamo, "Debe ingresar un monto numérico y una cantidad de cuotas");
                        errorProvider1.SetError(pnlDatosPersonales, "");
                        break;
                    }
            }
        }

        int validaciones()
        {
            if ((cbxRazas.SelectedIndex <= -1) || (cbxLugares.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(txtMonto.Text.All(Char.IsDigit)) || (txtMonto.Text == "") || (cbxCuotas.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
