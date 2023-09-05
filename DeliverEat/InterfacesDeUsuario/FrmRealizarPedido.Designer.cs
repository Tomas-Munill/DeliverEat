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
            this.lblCantidadCaracteres = new MaterialSkin.Controls.MaterialLabel();
            this.txtReferencia = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbCiudades = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCalle = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gboxFormaPago = new System.Windows.Forms.GroupBox();
            this.lblMontoAPagar = new System.Windows.Forms.Label();
            this.txtCvc = new System.Windows.Forms.TextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.lblCvc = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompletaDireccion = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rbtEfectivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.rbnTarjeta = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMontoAPagar = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.gboxFormaPago.SuspendLayout();
            this.materialExpansionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.txtMontoAPagar);
            this.panel1.Controls.Add(this.materialExpansionPanel1);
            this.panel1.Controls.Add(this.materialRadioButton2);
            this.panel1.Controls.Add(this.materialRadioButton1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.lblCompletaDireccion);
            this.panel1.Controls.Add(this.lblCantidadCaracteres);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.cmbCiudades);
            this.panel1.Controls.Add(this.txtCalle);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.gboxFormaPago);
            this.panel1.Controls.Add(this.lblMontoAPagar);
            this.panel1.Controls.Add(this.txtCvc);
            this.panel1.Controls.Add(this.txtFechaVencimiento);
            this.panel1.Controls.Add(this.txtNombreTitular);
            this.panel1.Controls.Add(this.txtNumeroTarjeta);
            this.panel1.Controls.Add(this.lblCvc);
            this.panel1.Controls.Add(this.lblFechaVencimiento);
            this.panel1.Controls.Add(this.lblNombreTitular);
            this.panel1.Controls.Add(this.lblNumeroTarjeta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 634);
            this.panel1.TabIndex = 0;
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
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.btnConfirmar.Location = new System.Drawing.Point(190, 826);
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
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(177, 605);
            this.maskedTextBox1.Mask = "9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBox1.TabIndex = 35;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // gboxFormaPago
            // 
            this.gboxFormaPago.Controls.Add(this.rbnTarjeta);
            this.gboxFormaPago.Controls.Add(this.rbtEfectivo);
            this.gboxFormaPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gboxFormaPago.Location = new System.Drawing.Point(20, 270);
            this.gboxFormaPago.Name = "gboxFormaPago";
            this.gboxFormaPago.Size = new System.Drawing.Size(275, 92);
            this.gboxFormaPago.TabIndex = 28;
            this.gboxFormaPago.TabStop = false;
            // 
            // lblMontoAPagar
            // 
            this.lblMontoAPagar.AutoSize = true;
            this.lblMontoAPagar.Location = new System.Drawing.Point(8, 634);
            this.lblMontoAPagar.Name = "lblMontoAPagar";
            this.lblMontoAPagar.Size = new System.Drawing.Size(133, 13);
            this.lblMontoAPagar.TabIndex = 21;
            this.lblMontoAPagar.Text = "¿Con cuánto vas a pagar?";
            // 
            // txtCvc
            // 
            this.txtCvc.Location = new System.Drawing.Point(34, 605);
            this.txtCvc.Name = "txtCvc";
            this.txtCvc.Size = new System.Drawing.Size(100, 20);
            this.txtCvc.TabIndex = 19;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(34, 566);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVencimiento.TabIndex = 18;
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.Location = new System.Drawing.Point(34, 524);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTitular.TabIndex = 17;
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(34, 482);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroTarjeta.TabIndex = 16;
            // 
            // lblCvc
            // 
            this.lblCvc.AutoSize = true;
            this.lblCvc.Location = new System.Drawing.Point(31, 589);
            this.lblCvc.Name = "lblCvc";
            this.lblCvc.Size = new System.Drawing.Size(148, 13);
            this.lblCvc.TabIndex = 11;
            this.lblCvc.Text = "CVC  (Card Verification Code):";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(31, 547);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(115, 13);
            this.lblFechaVencimiento.TabIndex = 10;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.Location = new System.Drawing.Point(31, 508);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(136, 13);
            this.lblNombreTitular.TabIndex = 9;
            this.lblNombreTitular.Text = "Nombre y apellido del titual:";
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(31, 467);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(94, 13);
            this.lblNumeroTarjeta.TabIndex = 8;
            this.lblNumeroTarjeta.Text = "Numero de tarjeta:";
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(10, 232);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(221, 24);
            this.materialLabel1.TabIndex = 45;
            this.materialLabel1.Text = "Elegí tu método de pago:";
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Depth = 0;
            this.rbtEfectivo.Location = new System.Drawing.Point(3, 13);
            this.rbtEfectivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbtEfectivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtEfectivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Ripple = true;
            this.rbtEfectivo.Size = new System.Drawing.Size(92, 37);
            this.rbtEfectivo.TabIndex = 46;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.Controls.Add(this.materialTextBox3);
            this.materialExpansionPanel1.Controls.Add(this.materialTextBox2);
            this.materialExpansionPanel1.Controls.Add(this.materialTextBox1);
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.ExpandHeight = 410;
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(34, 385);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(16);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel1.Size = new System.Drawing.Size(271, 410);
            this.materialExpansionPanel1.TabIndex = 46;
            this.materialExpansionPanel1.Title = "Tarjeta";
            // 
            // rbnTarjeta
            // 
            this.rbnTarjeta.AutoSize = true;
            this.rbnTarjeta.Depth = 0;
            this.rbnTarjeta.Location = new System.Drawing.Point(3, 50);
            this.rbnTarjeta.Margin = new System.Windows.Forms.Padding(0);
            this.rbnTarjeta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbnTarjeta.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbnTarjeta.Name = "rbnTarjeta";
            this.rbnTarjeta.Ripple = true;
            this.rbnTarjeta.Size = new System.Drawing.Size(221, 37);
            this.rbnTarjeta.TabIndex = 47;
            this.rbnTarjeta.TabStop = true;
            this.rbnTarjeta.Text = "Tarjeta de Crédito / Debito";
            this.rbnTarjeta.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(14, 746);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(151, 37);
            this.materialRadioButton1.TabIndex = 47;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Lo antes posible";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Location = new System.Drawing.Point(11, 783);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(268, 37);
            this.materialRadioButton2.TabIndex = 48;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Ingresar fecha/hora de recepción";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(12, 722);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(232, 24);
            this.materialLabel2.TabIndex = 49;
            this.materialLabel2.Text = "¿Cuando queres recibirlo?";
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
            this.txtMontoAPagar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontoAPagar.HidePromptOnLeave = false;
            this.txtMontoAPagar.HideSelection = true;
            this.txtMontoAPagar.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtMontoAPagar.LeadingIcon = null;
            this.txtMontoAPagar.Location = new System.Drawing.Point(16, 814);
            this.txtMontoAPagar.Mask = "9999,99";
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
            this.txtMontoAPagar.Size = new System.Drawing.Size(72, 48);
            this.txtMontoAPagar.SkipLiterals = true;
            this.txtMontoAPagar.TabIndex = 50;
            this.txtMontoAPagar.TabStop = false;
            this.txtMontoAPagar.Text = "    .";
            this.txtMontoAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMontoAPagar.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtMontoAPagar.TrailingIcon = null;
            this.txtMontoAPagar.UseSystemPasswordChar = false;
            this.txtMontoAPagar.ValidatingType = null;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Número tarjeta";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(17, 67);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(238, 50);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Nombre Apellido del Titular";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(16, 128);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(238, 50);
            this.materialTextBox2.TabIndex = 3;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "CVC";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(17, 184);
            this.materialTextBox3.MaxLength = 4;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(238, 50);
            this.materialTextBox3.TabIndex = 4;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // FrmRealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(344, 701);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRealizarPedido";
            this.Text = "DeliverEat - Realizar Pedido ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gboxFormaPago.ResumeLayout(false);
            this.gboxFormaPago.PerformLayout();
            this.materialExpansionPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCvc;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblNombreTitular;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.TextBox txtCvc;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtNombreTitular;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label lblMontoAPagar;
        private System.Windows.Forms.GroupBox gboxFormaPago;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCalle;
        private MaterialSkin.Controls.MaterialComboBox cmbCiudades;
        private MaterialSkin.Controls.MaterialLabel lblCantidadCaracteres;
        private MaterialSkin.Controls.MaterialTextBox txtReferencia;
        private MaterialSkin.Controls.MaterialLabel lblCompletaDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton rbtEfectivo;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialRadioButton rbnTarjeta;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtMontoAPagar;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}

