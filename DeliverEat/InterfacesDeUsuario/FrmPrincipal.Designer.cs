namespace DeliverEat.InterfacesDeUsuario
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tpInicio = new System.Windows.Forms.TabPage();
            this.tpCarrito = new System.Windows.Forms.TabPage();
            this.btnCargarCarrito = new MaterialSkin.Controls.MaterialButton();
            this.lstCarrito = new MaterialSkin.Controls.MaterialListView();
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precioUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLimpiarCarrito = new MaterialSkin.Controls.MaterialButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblPrecioTotal = new MaterialSkin.Controls.MaterialLabel();
            this.lblPagar = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tpCarrito.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tpInicio);
            this.materialTabControl1.Controls.Add(this.tpCarrito);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(442, 721);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tpInicio
            // 
            this.tpInicio.BackColor = System.Drawing.Color.White;
            this.tpInicio.ImageKey = "home24.png";
            this.tpInicio.Location = new System.Drawing.Point(4, 31);
            this.tpInicio.Name = "tpInicio";
            this.tpInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tpInicio.Size = new System.Drawing.Size(434, 686);
            this.tpInicio.TabIndex = 0;
            this.tpInicio.Text = "Inicio";
            // 
            // tpCarrito
            // 
            this.tpCarrito.BackColor = System.Drawing.Color.White;
            this.tpCarrito.Controls.Add(this.lblPrecioTotal);
            this.tpCarrito.Controls.Add(this.lblPagar);
            this.tpCarrito.Controls.Add(this.btnCargarCarrito);
            this.tpCarrito.Controls.Add(this.lstCarrito);
            this.tpCarrito.Controls.Add(this.btnLimpiarCarrito);
            this.tpCarrito.Controls.Add(this.btnConfirmar);
            this.tpCarrito.ImageKey = "shoppingcart24.png";
            this.tpCarrito.Location = new System.Drawing.Point(4, 31);
            this.tpCarrito.Name = "tpCarrito";
            this.tpCarrito.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarrito.Size = new System.Drawing.Size(434, 686);
            this.tpCarrito.TabIndex = 1;
            this.tpCarrito.Text = "Carrito";
            // 
            // btnCargarCarrito
            // 
            this.btnCargarCarrito.AutoSize = false;
            this.btnCargarCarrito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCargarCarrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCargarCarrito.Depth = 0;
            this.btnCargarCarrito.HighEmphasis = false;
            this.btnCargarCarrito.Icon = null;
            this.btnCargarCarrito.Location = new System.Drawing.Point(25, 633);
            this.btnCargarCarrito.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCargarCarrito.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargarCarrito.Name = "btnCargarCarrito";
            this.btnCargarCarrito.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCargarCarrito.Size = new System.Drawing.Size(316, 36);
            this.btnCargarCarrito.TabIndex = 62;
            this.btnCargarCarrito.Text = "Cargar Carrito";
            this.btnCargarCarrito.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCargarCarrito.UseAccentColor = false;
            this.btnCargarCarrito.UseVisualStyleBackColor = true;
            this.btnCargarCarrito.Click += new System.EventHandler(this.btnCargarCarrito_Click);
            // 
            // lstCarrito
            // 
            this.lstCarrito.AutoSizeTable = true;
            this.lstCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.producto,
            this.cantidad,
            this.precioUnitario,
            this.subtotal});
            this.lstCarrito.Depth = 0;
            this.lstCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarrito.FullRowSelect = true;
            this.lstCarrito.HideSelection = false;
            this.lstCarrito.Location = new System.Drawing.Point(6, 35);
            this.lstCarrito.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstCarrito.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstCarrito.MouseState = MaterialSkin.MouseState.OUT;
            this.lstCarrito.Name = "lstCarrito";
            this.lstCarrito.OwnerDraw = true;
            this.lstCarrito.Scrollable = false;
            this.lstCarrito.Size = new System.Drawing.Size(370, 100);
            this.lstCarrito.TabIndex = 61;
            this.lstCarrito.UseCompatibleStateImageBehavior = false;
            this.lstCarrito.View = System.Windows.Forms.View.Details;
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.Width = 100;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cant";
            this.cantidad.Width = 70;
            // 
            // precioUnitario
            // 
            this.precioUnitario.Text = "$ un";
            this.precioUnitario.Width = 100;
            // 
            // subtotal
            // 
            this.subtotal.Text = "Subtotal";
            this.subtotal.Width = 100;
            // 
            // btnLimpiarCarrito
            // 
            this.btnLimpiarCarrito.AutoSize = false;
            this.btnLimpiarCarrito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiarCarrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiarCarrito.Depth = 0;
            this.btnLimpiarCarrito.HighEmphasis = false;
            this.btnLimpiarCarrito.Icon = null;
            this.btnLimpiarCarrito.Location = new System.Drawing.Point(25, 588);
            this.btnLimpiarCarrito.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiarCarrito.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiarCarrito.Name = "btnLimpiarCarrito";
            this.btnLimpiarCarrito.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiarCarrito.Size = new System.Drawing.Size(316, 36);
            this.btnLimpiarCarrito.TabIndex = 60;
            this.btnLimpiarCarrito.Text = "Limpiar Carrito";
            this.btnLimpiarCarrito.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLimpiarCarrito.UseAccentColor = false;
            this.btnLimpiarCarrito.UseVisualStyleBackColor = true;
            this.btnLimpiarCarrito.Click += new System.EventHandler(this.btnLimpiarCarrito_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = false;
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.HighEmphasis = true;
            this.btnConfirmar.Icon = null;
            this.btnConfirmar.Location = new System.Drawing.Point(25, 540);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Size = new System.Drawing.Size(316, 36);
            this.btnConfirmar.TabIndex = 59;
            this.btnConfirmar.Text = "Confirmar Pedido";
            this.btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmar.UseAccentColor = false;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home24.png");
            this.imageList1.Images.SetKeyName(1, "shoppingcart24.png");
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Depth = 0;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecioTotal.Location = new System.Drawing.Point(299, 500);
            this.lblPrecioTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(46, 19);
            this.lblPrecioTotal.TabIndex = 64;
            this.lblPrecioTotal.Text = "$$$$$";
            this.lblPrecioTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPagar
            // 
            this.lblPagar.AutoSize = true;
            this.lblPagar.Depth = 0;
            this.lblPagar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPagar.Location = new System.Drawing.Point(16, 501);
            this.lblPagar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(297, 19);
            this.lblPagar.TabIndex = 63;
            this.lblPagar.Text = "Total a Pagar .................................................";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 788);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 788);
            this.MinimumSize = new System.Drawing.Size(448, 788);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliverEat";
            this.materialTabControl1.ResumeLayout(false);
            this.tpCarrito.ResumeLayout(false);
            this.tpCarrito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tpInicio;
        private System.Windows.Forms.TabPage tpCarrito;
        public System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btnLimpiarCarrito;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private MaterialSkin.Controls.MaterialListView lstCarrito;
        private System.Windows.Forms.ColumnHeader producto;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.ColumnHeader precioUnitario;
        private System.Windows.Forms.ColumnHeader subtotal;
        private MaterialSkin.Controls.MaterialButton btnCargarCarrito;
        private MaterialSkin.Controls.MaterialLabel lblPrecioTotal;
        private MaterialSkin.Controls.MaterialLabel lblPagar;
    }
}