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
            this.dtpFechaHoraRecepcion = new System.Windows.Forms.DateTimePicker();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tpEfectivo = new MaterialSkin.Controls.MaterialTabControl();
            this.tpTarjeta = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMaskedTextBox2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dtpFechaVencimiento = new DeliverEat.ControlesPersonalizados.RJDatePicker();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.panel1.SuspendLayout();
            this.tpEfectivo.SuspendLayout();
            this.tpTarjeta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.dtpFechaHoraRecepcion);
            this.panel1.Controls.Add(this.materialTabSelector1);
            this.panel1.Controls.Add(this.tpEfectivo);
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
            this.materialTabSelector1.BaseTabControl = this.tpEfectivo;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(16, 268);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(400, 48);
            this.materialTabSelector1.TabIndex = 53;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tpEfectivo
            // 
            this.tpEfectivo.Controls.Add(this.tpTarjeta);
            this.tpEfectivo.Controls.Add(this.tabPage2);
            this.tpEfectivo.Depth = 0;
            this.tpEfectivo.Location = new System.Drawing.Point(16, 322);
            this.tpEfectivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpEfectivo.Multiline = true;
            this.tpEfectivo.Name = "tpEfectivo";
            this.tpEfectivo.SelectedIndex = 0;
            this.tpEfectivo.Size = new System.Drawing.Size(400, 160);
            this.tpEfectivo.TabIndex = 52;
            // 
            // tpTarjeta
            // 
            this.tpTarjeta.Controls.Add(this.materialLabel3);
            this.tpTarjeta.Controls.Add(this.materialMaskedTextBox2);
            this.tpTarjeta.Controls.Add(this.dtpFechaVencimiento);
            this.tpTarjeta.Controls.Add(this.materialTextBox2);
            this.tpTarjeta.Controls.Add(this.materialTextBox1);
            this.tpTarjeta.Location = new System.Drawing.Point(4, 22);
            this.tpTarjeta.Name = "tpTarjeta";
            this.tpTarjeta.Padding = new System.Windows.Forms.Padding(3);
            this.tpTarjeta.Size = new System.Drawing.Size(392, 134);
            this.tpTarjeta.TabIndex = 0;
            this.tpTarjeta.Text = "Tarjeta";
            this.tpTarjeta.UseVisualStyleBackColor = true;
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
            // materialMaskedTextBox2
            // 
            this.materialMaskedTextBox2.AllowPromptAsInput = true;
            this.materialMaskedTextBox2.AnimateReadOnly = false;
            this.materialMaskedTextBox2.AsciiOnly = false;
            this.materialMaskedTextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox2.BeepOnError = false;
            this.materialMaskedTextBox2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox2.Depth = 0;
            this.materialMaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox2.HidePromptOnLeave = false;
            this.materialMaskedTextBox2.HideSelection = true;
            this.materialMaskedTextBox2.Hint = "CVC";
            this.materialMaskedTextBox2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox2.LeadingIcon = null;
            this.materialMaskedTextBox2.Location = new System.Drawing.Point(273, 8);
            this.materialMaskedTextBox2.Mask = "000 ";
            this.materialMaskedTextBox2.MaxLength = 32767;
            this.materialMaskedTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            this.materialMaskedTextBox2.PasswordChar = '\0';
            this.materialMaskedTextBox2.PrefixSuffixText = null;
            this.materialMaskedTextBox2.PromptChar = '_';
            this.materialMaskedTextBox2.ReadOnly = false;
            this.materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox2.ResetOnPrompt = true;
            this.materialMaskedTextBox2.ResetOnSpace = true;
            this.materialMaskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox2.SelectedText = "";
            this.materialMaskedTextBox2.SelectionLength = 0;
            this.materialMaskedTextBox2.SelectionStart = 0;
            this.materialMaskedTextBox2.ShortcutsEnabled = true;
            this.materialMaskedTextBox2.Size = new System.Drawing.Size(93, 48);
            this.materialMaskedTextBox2.SkipLiterals = true;
            this.materialMaskedTextBox2.TabIndex = 56;
            this.materialMaskedTextBox2.TabStop = false;
            this.materialMaskedTextBox2.Text = "    ";
            this.materialMaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox2.TrailingIcon = null;
            this.materialMaskedTextBox2.UseSystemPasswordChar = false;
            this.materialMaskedTextBox2.ValidatingType = null;
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
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Nombre Apellido del Titular";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(14, 64);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(238, 50);
            this.materialTextBox2.TabIndex = 3;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Número tarjeta";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(14, 8);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(238, 50);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblConCuantoVasAPagar);
            this.tabPage2.Controls.Add(this.txtMontoAPagar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Efectivo";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.lblCantidadCaracteres.Location = new System.Drawing.Point(265, 210);
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
            this.txtReferencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReferencia.Hint = "Referencia (opcional)";
            this.txtReferencia.LeadingIcon = null;
            this.txtReferencia.Location = new System.Drawing.Point(14, 157);
            this.txtReferencia.MaxLength = 240;
            this.txtReferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReferencia.Multiline = false;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(295, 50);
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
            this.cmbCiudades.Size = new System.Drawing.Size(295, 49);
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
            this.txtCalle.Size = new System.Drawing.Size(295, 48);
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
            this.tpEfectivo.ResumeLayout(false);
            this.tpTarjeta.ResumeLayout(false);
            this.tpTarjeta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel lblConCuantoVasAPagar;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tpEfectivo;
        private System.Windows.Forms.TabPage tpTarjeta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraRecepcion;
        private ControlesPersonalizados.RJDatePicker dtpFechaVencimiento;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}

