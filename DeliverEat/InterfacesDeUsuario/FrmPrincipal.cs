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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverEat.InterfacesDeUsuario
{
    public partial class FrmPrincipal : MaterialForm
    {   
        GestorPedido gestorPedido;
        public FrmPrincipal(GestorPedido gestor)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink100, Primary.Pink200, Primary.Indigo100, Accent.Indigo100, TextShade.BLACK);

            this.gestorPedido = gestor;
            CargarCarrito();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (lstCarrito.Items.Count != 0)
                gestorPedido.ConfirmarPedido();
            else
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "¡Error!", "No se puede confirmar un pedido con el carrito vacio", "OK", true, "Cancelar");
                DialogResult result = materialDialog.ShowDialog(this);
            }
        }

        private void CargarCarrito()
        {
            List<DetallePedido> carrito = gestorPedido.CargarCarrito();
            lstCarrito.Items.Clear();
            foreach (var detalle in carrito)
            {
                var item = new ListViewItem(new string[] {detalle.producto.Nombre, detalle.cantidad.ToString(),
                detalle.producto.Precio.ToString("C2"), detalle.CalcularPrecio().ToString("c2")});
                lstCarrito.Items.Add(item);
            }

        }

        public void MostrarConfirmacion()
        {
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Tu pedido ha sido confirmado!", 2000);
            SnackBarMessage.Show(this);
        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            lstCarrito.Items.Clear();
        }

        private void btnCargarCarrito_Click(object sender, EventArgs e)
        {
            CargarCarrito();
        }
    }
}
