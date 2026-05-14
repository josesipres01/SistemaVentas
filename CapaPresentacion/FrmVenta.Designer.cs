namespace CapaPresentacion
{
    partial class FrmVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtimefecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbcajero = new System.Windows.Forms.ComboBox();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.grplistado = new System.Windows.Forms.GroupBox();
            this.dlistadocompra = new System.Windows.Forms.DataGridView();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbdocumento = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnrealizarventa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tboxtotal = new System.Windows.Forms.TextBox();
            this.tboxsubtotal = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tboxiva = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.grplistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistadocompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 69;
            this.label1.Text = "Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(39, 88);
            this.materialLabel2.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 19);
            this.materialLabel2.TabIndex = 71;
            this.materialLabel2.Text = "Fecha:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // dtimefecha
            // 
            this.dtimefecha.Enabled = false;
            this.dtimefecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimefecha.Location = new System.Drawing.Point(120, 85);
            this.dtimefecha.MinimumSize = new System.Drawing.Size(10, 20);
            this.dtimefecha.Name = "dtimefecha";
            this.dtimefecha.Size = new System.Drawing.Size(115, 22);
            this.dtimefecha.TabIndex = 72;
            this.dtimefecha.ValueChanged += new System.EventHandler(this.dtimefecha_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(308, 85);
            this.materialLabel1.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 73;
            this.materialLabel1.Text = "Cajero:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // cbcajero
            // 
            this.cbcajero.FormattingEnabled = true;
            this.cbcajero.Location = new System.Drawing.Point(369, 85);
            this.cbcajero.MinimumSize = new System.Drawing.Size(10, 0);
            this.cbcajero.Name = "cbcajero";
            this.cbcajero.Size = new System.Drawing.Size(191, 24);
            this.cbcajero.TabIndex = 74;
            this.cbcajero.SelectedIndexChanged += new System.EventHandler(this.cbcajero_SelectedIndexChanged);
            // 
            // cbcliente
            // 
            this.cbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(42, 178);
            this.cbcliente.MinimumSize = new System.Drawing.Size(10, 0);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(191, 24);
            this.cbcliente.TabIndex = 76;
            this.cbcliente.SelectedIndexChanged += new System.EventHandler(this.cbcliente_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(39, 146);
            this.materialLabel3.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 75;
            this.materialLabel3.Text = "Cliente:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // grplistado
            // 
            this.grplistado.Controls.Add(this.dlistadocompra);
            this.grplistado.Location = new System.Drawing.Point(42, 259);
            this.grplistado.Name = "grplistado";
            this.grplistado.Size = new System.Drawing.Size(726, 193);
            this.grplistado.TabIndex = 78;
            this.grplistado.TabStop = false;
            this.grplistado.Text = "Listado de Compra";
            this.grplistado.Enter += new System.EventHandler(this.grplistado_Enter);
            // 
            // dlistadocompra
            // 
            this.dlistadocompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistadocompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.nombre,
            this.cantidad,
            this.precio_unit});
            this.dlistadocompra.Location = new System.Drawing.Point(6, 21);
            this.dlistadocompra.Name = "dlistadocompra";
            this.dlistadocompra.RowHeadersWidth = 51;
            this.dlistadocompra.RowTemplate.Height = 24;
            this.dlistadocompra.Size = new System.Drawing.Size(712, 156);
            this.dlistadocompra.TabIndex = 4;
            this.dlistadocompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dlistadocompra_CellContentClick);
            // 
            // idproducto
            // 
            this.idproducto.DataPropertyName = "idproducto";
            this.idproducto.HeaderText = "ID";
            this.idproducto.MinimumWidth = 6;
            this.idproducto.Name = "idproducto";
            this.idproducto.Visible = false;
            this.idproducto.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Producto";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // precio_unit
            // 
            this.precio_unit.DataPropertyName = "precio_unit";
            this.precio_unit.HeaderText = "Precio Unit";
            this.precio_unit.MinimumWidth = 6;
            this.precio_unit.Name = "precio_unit";
            this.precio_unit.ReadOnly = true;
            this.precio_unit.Width = 125;
            // 
            // cbdocumento
            // 
            this.cbdocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbdocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbdocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdocumento.FormattingEnabled = true;
            this.cbdocumento.Items.AddRange(new object[] {
            "Ticket",
            "Factura",
            "Nota"});
            this.cbdocumento.Location = new System.Drawing.Point(311, 178);
            this.cbdocumento.MinimumSize = new System.Drawing.Size(10, 0);
            this.cbdocumento.Name = "cbdocumento";
            this.cbdocumento.Size = new System.Drawing.Size(161, 24);
            this.cbdocumento.TabIndex = 82;
            this.cbdocumento.SelectedIndexChanged += new System.EventHandler(this.cbmetodopago_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(308, 146);
            this.materialLabel4.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(155, 20);
            this.materialLabel4.TabIndex = 81;
            this.materialLabel4.Text = "Tipo de Documento:\r\n";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // btnrealizarventa
            // 
            this.btnrealizarventa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizarventa.Location = new System.Drawing.Point(612, 540);
            this.btnrealizarventa.Name = "btnrealizarventa";
            this.btnrealizarventa.Size = new System.Drawing.Size(132, 33);
            this.btnrealizarventa.TabIndex = 86;
            this.btnrealizarventa.Text = "&Realizar Venta";
            this.btnrealizarventa.UseVisualStyleBackColor = true;
            this.btnrealizarventa.Click += new System.EventHandler(this.btnrealizarventa_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(670, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 33);
            this.button2.TabIndex = 87;
            this.button2.Text = "&Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(537, 220);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(90, 33);
            this.btnagregar.TabIndex = 88;
            this.btnagregar.Text = "&Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(71, 548);
            this.materialLabel5.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(42, 19);
            this.materialLabel5.TabIndex = 89;
            this.materialLabel5.Text = "Total:";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // tboxtotal
            // 
            this.tboxtotal.Location = new System.Drawing.Point(137, 548);
            this.tboxtotal.Name = "tboxtotal";
            this.tboxtotal.ReadOnly = true;
            this.tboxtotal.Size = new System.Drawing.Size(140, 22);
            this.tboxtotal.TabIndex = 90;
            this.tboxtotal.TextChanged += new System.EventHandler(this.tboxtotal_TextChanged);
            // 
            // tboxsubtotal
            // 
            this.tboxsubtotal.Location = new System.Drawing.Point(137, 466);
            this.tboxsubtotal.Name = "tboxsubtotal";
            this.tboxsubtotal.ReadOnly = true;
            this.tboxsubtotal.Size = new System.Drawing.Size(140, 22);
            this.tboxsubtotal.TabIndex = 92;
            this.tboxsubtotal.TextChanged += new System.EventHandler(this.tboxsubtotal_TextChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(41, 469);
            this.materialLabel6.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(65, 19);
            this.materialLabel6.TabIndex = 91;
            this.materialLabel6.Text = "Subtotal:";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // tboxiva
            // 
            this.tboxiva.Location = new System.Drawing.Point(137, 507);
            this.tboxiva.Name = "tboxiva";
            this.tboxiva.ReadOnly = true;
            this.tboxiva.Size = new System.Drawing.Size(140, 22);
            this.tboxiva.TabIndex = 94;
            this.tboxiva.TextChanged += new System.EventHandler(this.tboxiva_TextChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(39, 503);
            this.materialLabel7.MinimumSize = new System.Drawing.Size(10, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(74, 19);
            this.materialLabel7.TabIndex = 93;
            this.materialLabel7.Text = "IVA (16%):";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 615);
            this.Controls.Add(this.tboxiva);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.tboxsubtotal);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.tboxtotal);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnrealizarventa);
            this.Controls.Add(this.cbdocumento);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.grplistado);
            this.Controls.Add(this.cbcliente);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cbcajero);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtimefecha);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.grplistado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dlistadocompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtimefecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cbcajero;
        private System.Windows.Forms.ComboBox cbcliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.GroupBox grplistado;
        private System.Windows.Forms.DataGridView dlistadocompra;
        private System.Windows.Forms.ComboBox cbdocumento;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Button btnrealizarventa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnagregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox tboxtotal;
        private System.Windows.Forms.TextBox tboxsubtotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox tboxiva;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unit;
    }
}