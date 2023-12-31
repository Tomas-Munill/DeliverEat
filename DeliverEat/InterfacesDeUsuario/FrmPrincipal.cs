﻿using DeliverEat.Entidades;
using DeliverEat.Repositorios;
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
            CargarListadoPedidos();

            lblPrecioTotal.Text = CalcularTotal().ToString("c2");
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

        private double CalcularTotal()
        {
            List<DetallePedido> detalles = gestorPedido.CargarCarrito();
            double cantidad = 0;
            foreach (var detalle in detalles)
            {
                cantidad += detalle.CalcularPrecio();
            }
            return cantidad;

        }

        public void CargarListadoPedidos()
        {
            Pedido[] pedidos = gestorPedido.GetPedidos();
            lstPedidos.Items.Clear();
            foreach (var pedido in pedidos)
            {
                string fechaRecepcion;
                if (pedido.RecepcionLoAntesPosible)
                {
                    fechaRecepcion = "Lo antes posible";
                }
                else
                {
                    fechaRecepcion = pedido.FechaHoraRecepcion.ToString("dd/MM HH:mm");
                }

                var item = new ListViewItem(new string[] {pedido.Direccion.ToString(), pedido.MetodoPago.ToString(),
                pedido.CalcularTotal().ToString("c2"), fechaRecepcion});
                lstPedidos.Items.Add(item);
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

            lblPrecioTotal.Visible = true;
            lblPagar.Visible = true;
            lblPrecioTotal.Text = CalcularTotal().ToString("c2");

        }

        public void MostrarConfirmacion()
        {
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Tu pedido ha sido confirmado!", 2000);
            SnackBarMessage.Show(this);
        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            lstCarrito.Items.Clear();
            lblPrecioTotal.Visible = false;
            lblPagar.Visible = false;
        }

        private void btnCargarCarrito_Click(object sender, EventArgs e)
        {
            CargarCarrito();
        }
    }
}
