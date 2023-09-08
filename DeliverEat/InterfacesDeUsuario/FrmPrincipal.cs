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
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            gestorPedido.ConfirmarPedido();
        }

        public void MostrarConfirmacion()
        {
            Thread.Sleep(150);
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Tu pedido ha sido confirmado!", 2000);
            SnackBarMessage.Show(this);
        }
    }
}
