using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeliverEat
{
    public partial class FrmRealizarPedido : Form
    {
        public FrmRealizarPedido()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEfectivo.Checked == true)
            {
                lblNumeroTarjeta.Visible = true;
                txtNumeroTarjeta.Visible = true;
                lblNombreTitular.Visible = true;
                txtNombreTitular.Visible = true;
                lblFechaVencimiento.Visible = true;
                txtFechaVencimiento.Visible = true;
                lblCvc.Visible = true;
                txtCvc.Visible = true;
            }
            else
            {
                lblNumeroTarjeta.Visible = false;
                txtNumeroTarjeta.Visible = false;
                lblNombreTitular.Visible = false;
                txtNombreTitular.Visible = false;
                lblFechaVencimiento.Visible = false;
                txtFechaVencimiento.Visible = false;
                lblCvc.Visible = false;
                txtCvc.Visible = false;
            }
        }

        private void rbnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnTarjeta.Checked == true)
            {
                lblMontoAPagar.Visible = true;
                txtMontoAPagar.Visible = true;
            }
            else
            {
                lblMontoAPagar.Visible = false;
                txtMontoAPagar.Visible = false;

            }
        }

        private void ClearAll()
        {
            txtCalle.Clear();
            txtNumeroCalle.Clear();
            // cmb
            txtReferencia.Clear();
            rbtEfectivo.Checked = true;
            rbnTarjeta.Checked = false;
            txtNumeroTarjeta.Clear();
            txtNombreTitular.Clear();
            txtFechaVencimiento.Clear();
            txtCvc.Clear();
        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            lblCantidadCaracteres.Text = txtReferencia.Text.Length + "/240"; // Mostrar la cantidad de caracteres ingresados
            if (txtReferencia.Text.Length > 240)
            {
                txtReferencia.Text = txtReferencia.Text.Substring(0, 240); // Limitar la longitud a 240 caracteres
                txtReferencia.SelectionStart = txtReferencia.Text.Length; // Colocar el cursor al final del texto
            }
        }
    }
}
