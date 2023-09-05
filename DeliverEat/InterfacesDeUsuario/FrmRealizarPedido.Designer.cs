namespace DeliverEat
{
    partial class FrmRealizarPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.placeholderTextBox3 = new DeliverEat.ControlesPersonalizados.PlaceholderTextBox();
            this.placeholderTextBox1 = new DeliverEat.ControlesPersonalizados.PlaceholderTextBox();
            this.placeholderTextBox2 = new DeliverEat.ControlesPersonalizados.PlaceholderTextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblCompletaDireccion = new System.Windows.Forms.Label();
            this.lblDeliverEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxFormaPago = new System.Windows.Forms.GroupBox();
            this.rbnTarjeta = new System.Windows.Forms.RadioButton();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCantidadCaracteres = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txtMontoAPagar = new System.Windows.Forms.TextBox();
            this.lblMontoAPagar = new System.Windows.Forms.Label();
            this.lblCuandoRebirlo = new System.Windows.Forms.Label();
            this.txtCvc = new System.Windows.Forms.TextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.cmbCiudades = new System.Windows.Forms.ComboBox();
            this.txtNumeroCalle = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCvc = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblCiudades = new System.Windows.Forms.Label();
            this.lblNumeroCalle = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gboxFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.placeholderTextBox3);
            this.panel1.Controls.Add(this.placeholderTextBox1);
            this.panel1.Controls.Add(this.placeholderTextBox2);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.lblCompletaDireccion);
            this.panel1.Controls.Add(this.lblDeliverEat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gboxFormaPago);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.lblCantidadCaracteres);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.txtMontoAPagar);
            this.panel1.Controls.Add(this.lblMontoAPagar);
            this.panel1.Controls.Add(this.lblCuandoRebirlo);
            this.panel1.Controls.Add(this.txtCvc);
            this.panel1.Controls.Add(this.txtFechaVencimiento);
            this.panel1.Controls.Add(this.txtNombreTitular);
            this.panel1.Controls.Add(this.txtNumeroTarjeta);
            this.panel1.Controls.Add(this.cmbCiudades);
            this.panel1.Controls.Add(this.txtNumeroCalle);
            this.panel1.Controls.Add(this.txtCalle);
            this.panel1.Controls.Add(this.lblCvc);
            this.panel1.Controls.Add(this.lblFechaVencimiento);
            this.panel1.Controls.Add(this.lblNombreTitular);
            this.panel1.Controls.Add(this.lblNumeroTarjeta);
            this.panel1.Controls.Add(this.lblReferencia);
            this.panel1.Controls.Add(this.lblCiudades);
            this.panel1.Controls.Add(this.lblNumeroCalle);
            this.panel1.Controls.Add(this.lblCalle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 701);
            this.panel1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(59, 673);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 37;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(190, 528);
            this.maskedTextBox1.Mask = "9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBox1.TabIndex = 35;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // placeholderTextBox3
            // 
            this.placeholderTextBox3.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox3.Location = new System.Drawing.Point(182, 324);
            this.placeholderTextBox3.Name = "placeholderTextBox3";
            this.placeholderTextBox3.PlaceholderText = "Referencia (opcional)";
            this.placeholderTextBox3.Size = new System.Drawing.Size(130, 20);
            this.placeholderTextBox3.TabIndex = 34;
            this.placeholderTextBox3.Text = "Referencia (opcional)";
            // 
            // placeholderTextBox1
            // 
            this.placeholderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox1.Location = new System.Drawing.Point(190, 287);
            this.placeholderTextBox1.Name = "placeholderTextBox1";
            this.placeholderTextBox1.PlaceholderText = "Calle";
            this.placeholderTextBox1.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox1.TabIndex = 33;
            this.placeholderTextBox1.Text = "Calle";
            // 
            // placeholderTextBox2
            // 
            this.placeholderTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.placeholderTextBox2.Location = new System.Drawing.Point(182, 255);
            this.placeholderTextBox2.Name = "placeholderTextBox2";
            this.placeholderTextBox2.PlaceholderText = "Número";
            this.placeholderTextBox2.Size = new System.Drawing.Size(100, 20);
            this.placeholderTextBox2.TabIndex = 32;
            this.placeholderTextBox2.Text = "Número";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(25, 213);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(229, 20);
            this.txtReferencia.TabIndex = 14;
            this.txtReferencia.TextChanged += new System.EventHandler(this.txtReferencia_TextChanged);
            // 
            // lblCompletaDireccion
            // 
            this.lblCompletaDireccion.AutoSize = true;
            this.lblCompletaDireccion.Font = new System.Drawing.Font("Yu Gothic UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletaDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.lblCompletaDireccion.Location = new System.Drawing.Point(8, 64);
            this.lblCompletaDireccion.Name = "lblCompletaDireccion";
            this.lblCompletaDireccion.Size = new System.Drawing.Size(243, 31);
            this.lblCompletaDireccion.TabIndex = 30;
            this.lblCompletaDireccion.Text = "Completá tu dirección";
            // 
            // lblDeliverEat
            // 
            this.lblDeliverEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(190)))), ((int)(((byte)(221)))));
            this.lblDeliverEat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeliverEat.Font = new System.Drawing.Font("Yu Gothic UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliverEat.Location = new System.Drawing.Point(0, 0);
            this.lblDeliverEat.Name = "lblDeliverEat";
            this.lblDeliverEat.Size = new System.Drawing.Size(327, 51);
            this.lblDeliverEat.TabIndex = 29;
            this.lblDeliverEat.Text = "DeliverEat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Forma de pago:";
            // 
            // gboxFormaPago
            // 
            this.gboxFormaPago.Controls.Add(this.rbnTarjeta);
            this.gboxFormaPago.Controls.Add(this.rbtEfectivo);
            this.gboxFormaPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gboxFormaPago.Location = new System.Drawing.Point(38, 307);
            this.gboxFormaPago.Name = "gboxFormaPago";
            this.gboxFormaPago.Size = new System.Drawing.Size(142, 68);
            this.gboxFormaPago.TabIndex = 28;
            this.gboxFormaPago.TabStop = false;
            // 
            // rbnTarjeta
            // 
            this.rbnTarjeta.AutoSize = true;
            this.rbnTarjeta.Location = new System.Drawing.Point(9, 42);
            this.rbnTarjeta.Name = "rbnTarjeta";
            this.rbnTarjeta.Size = new System.Drawing.Size(130, 17);
            this.rbnTarjeta.TabIndex = 6;
            this.rbnTarjeta.TabStop = true;
            this.rbnTarjeta.Text = "Tarjeta Credito/Debito";
            this.rbnTarjeta.UseVisualStyleBackColor = true;
            this.rbnTarjeta.CheckedChanged += new System.EventHandler(this.rbnTarjeta_CheckedChanged);
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(9, 19);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbtEfectivo.TabIndex = 5;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            this.rbtEfectivo.CheckedChanged += new System.EventHandler(this.rbtEfectivo_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(166)))), ((int)(((byte)(202)))));
            this.btnConfirmar.Location = new System.Drawing.Point(182, 699);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(87, 31);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // lblCantidadCaracteres
            // 
            this.lblCantidadCaracteres.AutoSize = true;
            this.lblCantidadCaracteres.Location = new System.Drawing.Point(253, 220);
            this.lblCantidadCaracteres.Name = "lblCantidadCaracteres";
            this.lblCantidadCaracteres.Size = new System.Drawing.Size(36, 13);
            this.lblCantidadCaracteres.TabIndex = 26;
            this.lblCantidadCaracteres.Text = "0/100\r\n";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(182, 651);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 25;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(44, 628);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(184, 17);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ingresar fecha/hora de recepción";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(44, 605);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(102, 17);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Lo antes posible";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // txtMontoAPagar
            // 
            this.txtMontoAPagar.Location = new System.Drawing.Point(195, 405);
            this.txtMontoAPagar.Name = "txtMontoAPagar";
            this.txtMontoAPagar.Size = new System.Drawing.Size(100, 20);
            this.txtMontoAPagar.TabIndex = 22;
            // 
            // lblMontoAPagar
            // 
            this.lblMontoAPagar.AutoSize = true;
            this.lblMontoAPagar.Location = new System.Drawing.Point(192, 389);
            this.lblMontoAPagar.Name = "lblMontoAPagar";
            this.lblMontoAPagar.Size = new System.Drawing.Size(133, 13);
            this.lblMontoAPagar.TabIndex = 21;
            this.lblMontoAPagar.Text = "¿Con cuánto vas a pagar?";
            // 
            // lblCuandoRebirlo
            // 
            this.lblCuandoRebirlo.AutoSize = true;
            this.lblCuandoRebirlo.Font = new System.Drawing.Font("Yu Gothic UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuandoRebirlo.Location = new System.Drawing.Point(8, 554);
            this.lblCuandoRebirlo.Name = "lblCuandoRebirlo";
            this.lblCuandoRebirlo.Size = new System.Drawing.Size(283, 31);
            this.lblCuandoRebirlo.TabIndex = 20;
            this.lblCuandoRebirlo.Text = "¿Cuando queres recibirlo?";
            // 
            // txtCvc
            // 
            this.txtCvc.Location = new System.Drawing.Point(47, 528);
            this.txtCvc.Name = "txtCvc";
            this.txtCvc.Size = new System.Drawing.Size(100, 20);
            this.txtCvc.TabIndex = 19;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(47, 489);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVencimiento.TabIndex = 18;
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.Location = new System.Drawing.Point(47, 447);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTitular.TabIndex = 17;
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(47, 405);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroTarjeta.TabIndex = 16;
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Location = new System.Drawing.Point(25, 160);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudades.TabIndex = 15;
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.Location = new System.Drawing.Point(182, 121);
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCalle.TabIndex = 13;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(25, 121);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 12;
            // 
            // lblCvc
            // 
            this.lblCvc.AutoSize = true;
            this.lblCvc.Location = new System.Drawing.Point(44, 512);
            this.lblCvc.Name = "lblCvc";
            this.lblCvc.Size = new System.Drawing.Size(148, 13);
            this.lblCvc.TabIndex = 11;
            this.lblCvc.Text = "CVC  (Card Verification Code):";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(44, 470);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(115, 13);
            this.lblFechaVencimiento.TabIndex = 10;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.Location = new System.Drawing.Point(44, 431);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(136, 13);
            this.lblNombreTitular.TabIndex = 9;
            this.lblNombreTitular.Text = "Nombre y apellido del titual:";
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(44, 389);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(94, 13);
            this.lblNumeroTarjeta.TabIndex = 8;
            this.lblNumeroTarjeta.Text = "Numero de tarjeta:";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(22, 197);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(111, 13);
            this.lblReferencia.TabIndex = 4;
            this.lblReferencia.Text = "Referencia (opcional):";
            // 
            // lblCiudades
            // 
            this.lblCiudades.AutoSize = true;
            this.lblCiudades.Location = new System.Drawing.Point(22, 144);
            this.lblCiudades.Name = "lblCiudades";
            this.lblCiudades.Size = new System.Drawing.Size(43, 13);
            this.lblCiudades.TabIndex = 3;
            this.lblCiudades.Text = "Ciudad:";
            // 
            // lblNumeroCalle
            // 
            this.lblNumeroCalle.AutoSize = true;
            this.lblNumeroCalle.Location = new System.Drawing.Point(179, 103);
            this.lblNumeroCalle.Name = "lblNumeroCalle";
            this.lblNumeroCalle.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroCalle.TabIndex = 2;
            this.lblNumeroCalle.Text = "Numero:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(22, 103);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(35, 15);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "Calle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 855);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FrmRealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(344, 701);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRealizarPedido";
            this.Text = "Realizar Pedido ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gboxFormaPago.ResumeLayout(false);
            this.gboxFormaPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCvc;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblNombreTitular;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbnTarjeta;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblCiudades;
        private System.Windows.Forms.Label lblNumeroCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtCvc;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtNombreTitular;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.ComboBox cmbCiudades;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtNumeroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtMontoAPagar;
        private System.Windows.Forms.Label lblMontoAPagar;
        private System.Windows.Forms.Label lblCuandoRebirlo;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblCantidadCaracteres;
        private System.Windows.Forms.GroupBox gboxFormaPago;
        private System.Windows.Forms.Label lblDeliverEat;
        private System.Windows.Forms.Label lblCompletaDireccion;
        private ControlesPersonalizados.PlaceholderTextBox placeholderTextBox2;
        private ControlesPersonalizados.PlaceholderTextBox placeholderTextBox3;
        private ControlesPersonalizados.PlaceholderTextBox placeholderTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}

