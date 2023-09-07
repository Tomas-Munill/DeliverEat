﻿namespace DeliverEat
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
            this.dtpFechaHoraRecepcion = new System.Windows.Forms.DateTimePicker();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tclMetodoPago = new MaterialSkin.Controls.MaterialTabControl();
            this.tpTarjeta = new System.Windows.Forms.TabPage();
            this.txtNumeroTarjeta = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCvc = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtNombreTitular = new MaterialSkin.Controls.MaterialTextBox();
            this.tpEfectivo = new System.Windows.Forms.TabPage();
            this.lblConCuantoVasAPagar = new MaterialSkin.Controls.MaterialLabel();
            this.txtMontoAPagar = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.rdbFechaHoraRecepcion = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbLoAntesPosible = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCompletaDireccion = new MaterialSkin.Controls.MaterialLabel();
            this.lblCantidadCaracteres = new MaterialSkin.Controls.MaterialLabel();
            this.txtReferencia = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbCiudades = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCalle = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaVencimiento = new DeliverEat.ControlesPersonalizados.RJDatePicker();
            this.panel1.SuspendLayout();
            this.tclMetodoPago.SuspendLayout();
            this.tpTarjeta.SuspendLayout();
            this.tpEfectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.dtpFechaHoraRecepcion);
            this.panel1.Controls.Add(this.materialTabSelector1);
            this.panel1.Controls.Add(this.tclMetodoPago);
            this.panel1.Controls.Add(this.rdbFechaHoraRecepcion);
            this.panel1.Controls.Add(this.rdbLoAntesPosible);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.lblCompletaDireccion);
            this.panel1.Controls.Add(this.lblCantidadCaracteres);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.cmbCiudades);
            this.panel1.Controls.Add(this.txtCalle);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 721);
            this.panel1.TabIndex = 0;
            // 
            // dtpFechaHoraRecepcion
            // 
            this.dtpFechaHoraRecepcion.CustomFormat = "dd/MM HH:mm";
            this.dtpFechaHoraRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHoraRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraRecepcion.Location = new System.Drawing.Point(20, 612);
            this.dtpFechaHoraRecepcion.Name = "dtpFechaHoraRecepcion";
            this.dtpFechaHoraRecepcion.Size = new System.Drawing.Size(205, 29);
            this.dtpFechaHoraRecepcion.TabIndex = 55;
            this.dtpFechaHoraRecepcion.Visible = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tclMetodoPago;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(16, 268);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(396, 48);
            this.materialTabSelector1.TabIndex = 53;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tclMetodoPago
            // 
            this.tclMetodoPago.Controls.Add(this.tpTarjeta);
            this.tclMetodoPago.Controls.Add(this.tpEfectivo);
            this.tclMetodoPago.Depth = 0;
            this.tclMetodoPago.Location = new System.Drawing.Point(16, 322);
            this.tclMetodoPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.tclMetodoPago.Multiline = true;
            this.tclMetodoPago.Name = "tclMetodoPago";
            this.tclMetodoPago.SelectedIndex = 0;
            this.tclMetodoPago.Size = new System.Drawing.Size(400, 160);
            this.tclMetodoPago.TabIndex = 52;
            // 
            // tpTarjeta
            // 
            this.tpTarjeta.Controls.Add(this.txtNumeroTarjeta);
            this.tpTarjeta.Controls.Add(this.materialLabel3);
            this.tpTarjeta.Controls.Add(this.txtCvc);
            this.tpTarjeta.Controls.Add(this.dtpFechaVencimiento);
            this.tpTarjeta.Controls.Add(this.txtNombreTitular);
            this.tpTarjeta.Location = new System.Drawing.Point(4, 22);
            this.tpTarjeta.Name = "tpTarjeta";
            this.tpTarjeta.Padding = new System.Windows.Forms.Padding(3);
            this.tpTarjeta.Size = new System.Drawing.Size(392, 134);
            this.tpTarjeta.TabIndex = 0;
            this.tpTarjeta.Text = "Tarjeta";
            this.tpTarjeta.UseVisualStyleBackColor = true;
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.AllowPromptAsInput = true;
            this.txtNumeroTarjeta.AnimateReadOnly = false;
            this.txtNumeroTarjeta.AsciiOnly = false;
            this.txtNumeroTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNumeroTarjeta.BeepOnError = false;
            this.txtNumeroTarjeta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNumeroTarjeta.Depth = 0;
            this.txtNumeroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroTarjeta.HidePromptOnLeave = false;
            this.txtNumeroTarjeta.HideSelection = true;
            this.txtNumeroTarjeta.Hint = "Número Tarjeta";
            this.txtNumeroTarjeta.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNumeroTarjeta.LeadingIcon = null;
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(17, 10);
            this.txtNumeroTarjeta.Mask = "0000-0000-0000-0000";
            this.txtNumeroTarjeta.MaxLength = 32767;
            this.txtNumeroTarjeta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.PasswordChar = '\0';
            this.txtNumeroTarjeta.PrefixSuffixText = null;
            this.txtNumeroTarjeta.PromptChar = '_';
            this.txtNumeroTarjeta.ReadOnly = false;
            this.txtNumeroTarjeta.RejectInputOnFirstFailure = false;
            this.txtNumeroTarjeta.ResetOnPrompt = true;
            this.txtNumeroTarjeta.ResetOnSpace = true;
            this.txtNumeroTarjeta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumeroTarjeta.SelectedText = "";
            this.txtNumeroTarjeta.SelectionLength = 0;
            this.txtNumeroTarjeta.SelectionStart = 0;
            this.txtNumeroTarjeta.ShortcutsEnabled = true;
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(235, 48);
            this.txtNumeroTarjeta.SkipLiterals = true;
            this.txtNumeroTarjeta.TabIndex = 56;
            this.txtNumeroTarjeta.TabStop = false;
            this.txtNumeroTarjeta.Text = "    -    -    -";
            this.txtNumeroTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumeroTarjeta.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNumeroTarjeta.TrailingIcon = null;
            this.txtNumeroTarjeta.UseSystemPasswordChar = false;
            this.txtNumeroTarjeta.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel3.Location = new System.Drawing.Point(270, 64);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 14);
            this.materialLabel3.TabIndex = 57;
            this.materialLabel3.Text = "Fecha de vencimiento";
            // 
            // txtCvc
            // 
            this.txtCvc.AllowPromptAsInput = true;
            this.txtCvc.AnimateReadOnly = false;
            this.txtCvc.AsciiOnly = false;
            this.txtCvc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCvc.BeepOnError = false;
            this.txtCvc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCvc.Depth = 0;
            this.txtCvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCvc.HidePromptOnLeave = false;
            this.txtCvc.HideSelection = true;
            this.txtCvc.Hint = "CVC";
            this.txtCvc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCvc.LeadingIcon = null;
            this.txtCvc.Location = new System.Drawing.Point(273, 8);
            this.txtCvc.Mask = "000 ";
            this.txtCvc.MaxLength = 32767;
            this.txtCvc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCvc.Name = "txtCvc";
            this.txtCvc.PasswordChar = '\0';
            this.txtCvc.PrefixSuffixText = null;
            this.txtCvc.PromptChar = '_';
            this.txtCvc.ReadOnly = false;
            this.txtCvc.RejectInputOnFirstFailure = false;
            this.txtCvc.ResetOnPrompt = true;
            this.txtCvc.ResetOnSpace = true;
            this.txtCvc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCvc.SelectedText = "";
            this.txtCvc.SelectionLength = 0;
            this.txtCvc.SelectionStart = 0;
            this.txtCvc.ShortcutsEnabled = true;
            this.txtCvc.Size = new System.Drawing.Size(93, 48);
            this.txtCvc.SkipLiterals = true;
            this.txtCvc.TabIndex = 56;
            this.txtCvc.TabStop = false;
            this.txtCvc.Text = "    ";
            this.txtCvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCvc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCvc.TrailingIcon = null;
            this.txtCvc.UseSystemPasswordChar = false;
            this.txtCvc.ValidatingType = null;
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.AnimateReadOnly = false;
            this.txtNombreTitular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreTitular.Depth = 0;
            this.txtNombreTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreTitular.Hint = "Nombre Apellido del Titular";
            this.txtNombreTitular.LeadingIcon = null;
            this.txtNombreTitular.Location = new System.Drawing.Point(14, 64);
            this.txtNombreTitular.MaxLength = 50;
            this.txtNombreTitular.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreTitular.Multiline = false;
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(238, 50);
            this.txtNombreTitular.TabIndex = 3;
            this.txtNombreTitular.Text = "";
            this.txtNombreTitular.TrailingIcon = null;
            // 
            // tpEfectivo
            // 
            this.tpEfectivo.Controls.Add(this.lblConCuantoVasAPagar);
            this.tpEfectivo.Controls.Add(this.txtMontoAPagar);
            this.tpEfectivo.Location = new System.Drawing.Point(4, 22);
            this.tpEfectivo.Name = "tpEfectivo";
            this.tpEfectivo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEfectivo.Size = new System.Drawing.Size(392, 134);
            this.tpEfectivo.TabIndex = 1;
            this.tpEfectivo.Text = "Efectivo";
            this.tpEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblConCuantoVasAPagar
            // 
            this.lblConCuantoVasAPagar.AutoSize = true;
            this.lblConCuantoVasAPagar.BackColor = System.Drawing.Color.White;
            this.lblConCuantoVasAPagar.Depth = 0;
            this.lblConCuantoVasAPagar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConCuantoVasAPagar.Location = new System.Drawing.Point(17, 23);
            this.lblConCuantoVasAPagar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConCuantoVasAPagar.Name = "lblConCuantoVasAPagar";
            this.lblConCuantoVasAPagar.Size = new System.Drawing.Size(185, 19);
            this.lblConCuantoVasAPagar.TabIndex = 51;
            this.lblConCuantoVasAPagar.Text = "¿Con cuánto vas a pagar?";
            // 
            // txtMontoAPagar
            // 
            this.txtMontoAPagar.AllowPromptAsInput = true;
            this.txtMontoAPagar.AnimateReadOnly = false;
            this.txtMontoAPagar.AsciiOnly = false;
            this.txtMontoAPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMontoAPagar.BeepOnError = false;
            this.txtMontoAPagar.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMontoAPagar.Depth = 0;
            this.txtMontoAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontoAPagar.HidePromptOnLeave = false;
            this.txtMontoAPagar.HideSelection = true;
            this.txtMontoAPagar.Hint = "Monto";
            this.txtMontoAPagar.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMontoAPagar.LeadingIcon = null;
            this.txtMontoAPagar.Location = new System.Drawing.Point(20, 61);
            this.txtMontoAPagar.Mask = "00,000.00";
            this.txtMontoAPagar.MaxLength = 32767;
            this.txtMontoAPagar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMontoAPagar.Name = "txtMontoAPagar";
            this.txtMontoAPagar.PasswordChar = '\0';
            this.txtMontoAPagar.PrefixSuffixText = null;
            this.txtMontoAPagar.PromptChar = '_';
            this.txtMontoAPagar.ReadOnly = false;
            this.txtMontoAPagar.RejectInputOnFirstFailure = false;
            this.txtMontoAPagar.ResetOnPrompt = true;
            this.txtMontoAPagar.ResetOnSpace = true;
            this.txtMontoAPagar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMontoAPagar.SelectedText = "";
            this.txtMontoAPagar.SelectionLength = 0;
            this.txtMontoAPagar.SelectionStart = 0;
            this.txtMontoAPagar.ShortcutsEnabled = true;
            this.txtMontoAPagar.Size = new System.Drawing.Size(193, 48);
            this.txtMontoAPagar.SkipLiterals = true;
            this.txtMontoAPagar.TabIndex = 50;
            this.txtMontoAPagar.TabStop = false;
            this.txtMontoAPagar.Text = "  .   ,";
            this.txtMontoAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMontoAPagar.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMontoAPagar.TrailingIcon = null;
            this.txtMontoAPagar.UseSystemPasswordChar = false;
            this.txtMontoAPagar.ValidatingType = null;
            // 
            // rdbFechaHoraRecepcion
            // 
            this.rdbFechaHoraRecepcion.AutoSize = true;
            this.rdbFechaHoraRecepcion.Depth = 0;
            this.rdbFechaHoraRecepcion.Location = new System.Drawing.Point(14, 572);
            this.rdbFechaHoraRecepcion.Margin = new System.Windows.Forms.Padding(0);
            this.rdbFechaHoraRecepcion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbFechaHoraRecepcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbFechaHoraRecepcion.Name = "rdbFechaHoraRecepcion";
            this.rdbFechaHoraRecepcion.Ripple = true;
            this.rdbFechaHoraRecepcion.Size = new System.Drawing.Size(268, 37);
            this.rdbFechaHoraRecepcion.TabIndex = 48;
            this.rdbFechaHoraRecepcion.TabStop = true;
            this.rdbFechaHoraRecepcion.Text = "Ingresar fecha/hora de recepción";
            this.rdbFechaHoraRecepcion.UseVisualStyleBackColor = true;
            this.rdbFechaHoraRecepcion.CheckedChanged += new System.EventHandler(this.rdbFechaHoraRecepcion_CheckedChanged);
            // 
            // rdbLoAntesPosible
            // 
            this.rdbLoAntesPosible.AutoSize = true;
            this.rdbLoAntesPosible.Checked = true;
            this.rdbLoAntesPosible.Depth = 0;
            this.rdbLoAntesPosible.Location = new System.Drawing.Point(14, 535);
            this.rdbLoAntesPosible.Margin = new System.Windows.Forms.Padding(0);
            this.rdbLoAntesPosible.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbLoAntesPosible.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbLoAntesPosible.Name = "rdbLoAntesPosible";
            this.rdbLoAntesPosible.Ripple = true;
            this.rdbLoAntesPosible.Size = new System.Drawing.Size(151, 37);
            this.rdbLoAntesPosible.TabIndex = 47;
            this.rdbLoAntesPosible.TabStop = true;
            this.rdbLoAntesPosible.Text = "Lo antes posible";
            this.rdbLoAntesPosible.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(10, 232);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(216, 24);
            this.materialLabel1.TabIndex = 45;
            this.materialLabel1.Text = "Elegí tu método de pago";
            // 
            // lblCompletaDireccion
            // 
            this.lblCompletaDireccion.AutoSize = true;
            this.lblCompletaDireccion.Depth = 0;
            this.lblCompletaDireccion.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCompletaDireccion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCompletaDireccion.Location = new System.Drawing.Point(10, 12);
            this.lblCompletaDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCompletaDireccion.Name = "lblCompletaDireccion";
            this.lblCompletaDireccion.Size = new System.Drawing.Size(196, 24);
            this.lblCompletaDireccion.TabIndex = 44;
            this.lblCompletaDireccion.Text = "Completá tu dirección";
            // 
            // lblCantidadCaracteres
            // 
            this.lblCantidadCaracteres.AutoSize = true;
            this.lblCantidadCaracteres.Depth = 0;
            this.lblCantidadCaracteres.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCantidadCaracteres.Location = new System.Drawing.Point(368, 210);
            this.lblCantidadCaracteres.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidadCaracteres.Name = "lblCantidadCaracteres";
            this.lblCantidadCaracteres.Size = new System.Drawing.Size(44, 19);
            this.lblCantidadCaracteres.TabIndex = 43;
            this.lblCantidadCaracteres.Text = "0/240";
            // 
            // txtReferencia
            // 
            this.txtReferencia.AnimateReadOnly = false;
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferencia.Depth = 0;
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReferencia.Hint = "Referencia (opcional)";
            this.txtReferencia.LeadingIcon = null;
            this.txtReferencia.Location = new System.Drawing.Point(14, 157);
            this.txtReferencia.MaxLength = 240;
            this.txtReferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReferencia.Multiline = false;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(398, 50);
            this.txtReferencia.TabIndex = 42;
            this.txtReferencia.Text = "";
            this.txtReferencia.TrailingIcon = null;
            this.txtReferencia.TextChanged += new System.EventHandler(this.txtReferencia_TextChanged);
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.AutoResize = false;
            this.cmbCiudades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCiudades.Depth = 0;
            this.cmbCiudades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCiudades.DropDownHeight = 174;
            this.cmbCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudades.DropDownWidth = 121;
            this.cmbCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCiudades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Hint = "Ciudad";
            this.cmbCiudades.IntegralHeight = false;
            this.cmbCiudades.ItemHeight = 43;
            this.cmbCiudades.Items.AddRange(new object[] {
            "Carlos Paz",
            "Córdoba"});
            this.cmbCiudades.Location = new System.Drawing.Point(14, 102);
            this.cmbCiudades.MaxDropDownItems = 4;
            this.cmbCiudades.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(398, 49);
            this.cmbCiudades.StartIndex = 0;
            this.cmbCiudades.TabIndex = 41;
            // 
            // txtCalle
            // 
            this.txtCalle.AllowPromptAsInput = true;
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.AsciiOnly = false;
            this.txtCalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCalle.BeepOnError = false;
            this.txtCalle.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCalle.Depth = 0;
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalle.HidePromptOnLeave = false;
            this.txtCalle.HideSelection = true;
            this.txtCalle.Hint = "Calle y número";
            this.txtCalle.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(14, 48);
            this.txtCalle.Mask = "";
            this.txtCalle.MaxLength = 32767;
            this.txtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '\0';
            this.txtCalle.PrefixSuffixText = null;
            this.txtCalle.PromptChar = '_';
            this.txtCalle.ReadOnly = false;
            this.txtCalle.RejectInputOnFirstFailure = false;
            this.txtCalle.ResetOnPrompt = true;
            this.txtCalle.ResetOnSpace = true;
            this.txtCalle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCalle.SelectedText = "";
            this.txtCalle.SelectionLength = 0;
            this.txtCalle.SelectionStart = 0;
            this.txtCalle.ShortcutsEnabled = true;
            this.txtCalle.Size = new System.Drawing.Size(398, 48);
            this.txtCalle.SkipLiterals = true;
            this.txtCalle.TabIndex = 40;
            this.txtCalle.TabStop = false;
            this.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalle.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCalle.TrailingIcon = null;
            this.txtCalle.UseSystemPasswordChar = false;
            this.txtCalle.ValidatingType = null;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.HighEmphasis = true;
            this.btnConfirmar.Icon = null;
            this.btnConfirmar.Location = new System.Drawing.Point(472, 572);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Size = new System.Drawing.Size(105, 36);
            this.btnConfirmar.TabIndex = 39;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmar.UseAccentColor = false;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 740);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(16, 511);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(232, 24);
            this.materialLabel2.TabIndex = 49;
            this.materialLabel2.Text = "¿Cuando queres recibirlo?";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.dtpFechaVencimiento.BorderSize = 1;
            this.dtpFechaVencimiento.CustomFormat = "MM/yyyy";
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(271, 79);
            this.dtpFechaVencimiento.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(115, 35);
            this.dtpFechaVencimiento.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dtpFechaVencimiento.TabIndex = 5;
            this.dtpFechaVencimiento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            // 
            // FrmRealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRealizarPedido";
            this.Text = "DeliverEat - Realizar Pedido ";
            this.Load += new System.EventHandler(this.FrmRealizarPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tclMetodoPago.ResumeLayout(false);
            this.tpTarjeta.ResumeLayout(false);
            this.tpTarjeta.PerformLayout();
            this.tpEfectivo.ResumeLayout(false);
            this.tpEfectivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCalle;
        private MaterialSkin.Controls.MaterialComboBox cmbCiudades;
        private MaterialSkin.Controls.MaterialLabel lblCantidadCaracteres;
        private MaterialSkin.Controls.MaterialTextBox txtReferencia;
        private MaterialSkin.Controls.MaterialLabel lblCompletaDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton rdbFechaHoraRecepcion;
        private MaterialSkin.Controls.MaterialRadioButton rdbLoAntesPosible;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMontoAPagar;
        private MaterialSkin.Controls.MaterialTextBox txtNombreTitular;
        private MaterialSkin.Controls.MaterialLabel lblConCuantoVasAPagar;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tclMetodoPago;
        private System.Windows.Forms.TabPage tpTarjeta;
        private System.Windows.Forms.TabPage tpEfectivo;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraRecepcion;
        private ControlesPersonalizados.RJDatePicker dtpFechaVencimiento;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCvc;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNumeroTarjeta;
    }
}

