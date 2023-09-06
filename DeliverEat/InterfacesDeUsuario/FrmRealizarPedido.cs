using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeliverEat
{
    public partial class FrmRealizarPedido : MaterialSkin.Controls.MaterialForm
    {
        public FrmRealizarPedido()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink100, Primary.Pink200, Primary.Indigo100, Accent.Indigo100, TextShade.BLACK);


        }

        private void FrmRealizarPedido_Load(object sender, EventArgs e)
        {
            var fechaActual = DateTime.Now;
            var fechaHasta = fechaActual.AddDays(6);

            dtpFechaHoraRecepcion.MinDate = fechaActual;
            dtpFechaHoraRecepcion.MaxDate = fechaHasta;

        }


        private void ClearAll()
        {

            
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

        private void rdbFechaHoraRecepcion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbFechaHoraRecepcion.Checked == true)
            {
                dtpFechaHoraRecepcion.Visible = true;
            }
            else
            {
                dtpFechaHoraRecepcion.Visible = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            // Validar que calle y numero sea alfanumerico
            Regex regex = new Regex("^[0-9a-zA-Z]+$");
            if (!regex.IsMatch(txtCalle.Text))
            {
                mensaje += "El campo calle y número debe contener solo caracteres alfanumericos.";
            }

            // Validar horario de fecha hora recepcion
            if (rdbFechaHoraRecepcion.Checked == true)
            {
                if (dtpFechaHoraRecepcion.Value.Hour < 7)
                {
                    mensaje += "Las horas válidas para planificar un envío son desde las 7:00 hasta las 23:59.";
                }
            }

            // Validar tarjeta visa

            // Validar monto en efectivo a abonar mayor al monto del pedido
            


            if (mensaje != "")
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "¡Error: datos inválidos!", mensaje, "OK", true, "Cancel");
                DialogResult result = materialDialog.ShowDialog(this);
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Tu pedido ha sido confirmado!", 2000);
                SnackBarMessage.Show(this);
            }
        }
    }
}
