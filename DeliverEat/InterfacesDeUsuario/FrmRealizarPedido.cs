using DeliverEat.Entidades;
using DeliverEat.Servicios;
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
        public GestorPedido gestorPedido;


        public FrmRealizarPedido(GestorPedido gestor)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink100, Primary.Pink200, Primary.Indigo100, Accent.Indigo100, TextShade.BLACK);

            this.gestorPedido = gestor;
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
            Regex regex = new Regex("^[0-9\\p{L} ]+$");
            if (!regex.IsMatch(txtCalle.Text))
            {
                mensaje += "El campo calle y número debe contener solo caracteres alfanumericos.";
            }

            // Validar horario de fecha hora recepcion
            if (rdbFechaHoraRecepcion.Checked == true)
            {
                if (dtpFechaHoraRecepcion.Value.Hour < 7)
                {
                    mensaje += "\nLas horas válidas para planificar un envío son desde las 7:00 hasta las 23:59.";
                }
                if (dtpFechaHoraRecepcion.Value < DateTime.Now)
                {
                    mensaje += "\nNo se puede planificar un pedido para una hora menor a la actual";
                }
            }

            string numeroTarjeta = txtNumeroTarjeta.Text.Replace(" ", "");

            // Validar tarjeta visa
            if (tclMetodoPago.SelectedTab == tclMetodoPago.TabPages["tpTarjeta"])
            {
                //if (!numeroTarjeta.Contains(" "))
                if (numeroTarjeta.Length == 19)
                {
                    if (!ValidarTarjeta(numeroTarjeta))
                    {
                        mensaje += "\nLa tarjeta ingresada no es valida";
                    }
                }
                else
                {
                    mensaje += "\nDebe cargar todos los numeros de la Tarjeta";
                }

            }


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
                GuardarDatos();
            }





        }

        private bool ValidarTarjeta(string numero)
        {
            bool resultado = true;
            TarjetaCredito tarjeta = new TarjetaCredito();
            Regex expresion = new Regex("\\b4\\d{3}-\\d{4}-\\d{4}-\\d{4}\\b");
            if (!expresion.IsMatch(numero))
            {
                resultado = false;
            }
            return tarjeta.ValidarMetodo(numero) && resultado;

        }

        //private bool ValidarLuhn(string numero)
        //{
        //    int sum = 0;
        //    bool alternate = false;

        //    // Recorre los dígitos de derecha a izquierda
        //    for (int i = numero.Length - 1; i >= 0; i--)
        //    {
        //        if (numero[i] == '-')
        //            continue;

        //        int digit = int.Parse(numero[i].ToString());



        //        if (alternate)
        //        {
        //            // Duplica el dígito y ajusta si es mayor o igual a 10
        //            digit *= 2;
        //            if (digit >= 10)
        //            {
        //                digit -= 9;
        //            }
        //        }

        //        sum += digit;
        //        alternate = !alternate;
        //    }

        //    // El número es válido si la suma es un múltiplo de 10
        //    return sum % 10 == 0;
        //}

        private void GuardarDatos()
        {
            Ciudad ciudad = new Ciudad();
            ciudad.Nombre = cmbCiudades.Text;

            Direccion direccion = new Direccion();
            direccion.Calle = txtCalle.Text;
            direccion.ciudad = ciudad;
            direccion.Referencia = txtReferencia.Text;


            List<DetallePedido> listaDetalles = gestorPedido.CargarCarrito();

            Pedido pedido = new Pedido();

            if (tclMetodoPago.SelectedTab == tclMetodoPago.TabPages["tpEfectivo"])
            {
                Efectivo efectivo = new Efectivo();
                efectivo.MontoQueAbona = Convert.ToDouble(txtMontoAPagar.Text);
                pedido.MetodoPago = efectivo;
            }
            else
            {

                TarjetaCredito tarjeta = new TarjetaCredito();
                tarjeta.numero = txtNumeroTarjeta.Text;
                tarjeta.cvc = txtCvc.Text;
                tarjeta.fechaVencimiento = dtpFechaVencimiento.Value;
                tarjeta.nombreApellidoTitular = txtNombreTitular.Text;
                pedido.MetodoPago = tarjeta;

            }
            
            pedido.RecepcionLoAntesPosible = rdbLoAntesPosible.Checked;
            pedido.FechaHoraRecepcion = dtpFechaHoraRecepcion.Value;
            pedido.FechaHoraCreacion = DateTime.Now;
            pedido.Estado = "Confirmado";
            pedido.Direccion = direccion;
            pedido.DetallePedidos = listaDetalles;

            gestorPedido.GuardarPedido(pedido);


        }
    }
}
