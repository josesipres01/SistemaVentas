namespace CapaPresentacion
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnualmacen = new System.Windows.Forms.Panel();
            this.btncategoria = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.btnalmacen = new System.Windows.Forms.Button();
            this.mnucompra = new System.Windows.Forms.Panel();
            this.btnproveedor = new System.Windows.Forms.Button();
            this.btngenerarcompra = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.mnuventa = new System.Windows.Forms.Panel();
            this.btnventas = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btngenerarventa = new System.Windows.Forms.Button();
            this.mnuconsultas = new System.Windows.Forms.Panel();
            this.btnconsultas = new System.Windows.Forms.Button();
            this.btnstockminimo = new System.Windows.Forms.Button();
            this.btncomprafechas = new System.Windows.Forms.Button();
            this.btnventafechas = new System.Windows.Forms.Button();
            this.mnuconfiguraciones = new System.Windows.Forms.Panel();
            this.btnconfiguraciones = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.mnureportes = new System.Windows.Forms.Panel();
            this.btnreportes = new System.Windows.Forms.Button();
            this.btnreporteempleado = new System.Windows.Forms.Button();
            this.btnreportecliente = new System.Windows.Forms.Button();
            this.btnreporteproducto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tmrsubmenu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnualmacen.SuspendLayout();
            this.mnucompra.SuspendLayout();
            this.mnuventa.SuspendLayout();
            this.mnuconsultas.SuspendLayout();
            this.mnuconfiguraciones.SuspendLayout();
            this.mnureportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.btnmaximizar);
            this.panel1.Controls.Add(this.btnrestaurar);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(670, 21);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(25, 25);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 3;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(705, 21);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 2;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaurar.Image")));
            this.btnrestaurar.Location = new System.Drawing.Point(705, 21);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 1;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(740, 21);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.mnualmacen);
            this.flowLayoutPanel1.Controls.Add(this.mnucompra);
            this.flowLayoutPanel1.Controls.Add(this.mnuventa);
            this.flowLayoutPanel1.Controls.Add(this.mnuconfiguraciones);
            this.flowLayoutPanel1.Controls.Add(this.mnureportes);
            this.flowLayoutPanel1.Controls.Add(this.mnuconsultas);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(222, 514);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mnualmacen
            // 
            this.mnualmacen.Controls.Add(this.btncategoria);
            this.mnualmacen.Controls.Add(this.btnproducto);
            this.mnualmacen.Controls.Add(this.btnalmacen);
            this.mnualmacen.Location = new System.Drawing.Point(3, 106);
            this.mnualmacen.MaximumSize = new System.Drawing.Size(214, 120);
            this.mnualmacen.MinimumSize = new System.Drawing.Size(214, 37);
            this.mnualmacen.Name = "mnualmacen";
            this.mnualmacen.Size = new System.Drawing.Size(214, 46);
            this.mnualmacen.TabIndex = 4;
            // 
            // btncategoria
            // 
            this.btncategoria.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncategoria.FlatAppearance.BorderSize = 0;
            this.btncategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategoria.ForeColor = System.Drawing.Color.White;
            this.btncategoria.Location = new System.Drawing.Point(85, 84);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Size = new System.Drawing.Size(126, 30);
            this.btncategoria.TabIndex = 2;
            this.btncategoria.Text = "Categoría";
            this.btncategoria.UseVisualStyleBackColor = false;
            // 
            // btnproducto
            // 
            this.btnproducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnproducto.FlatAppearance.BorderSize = 0;
            this.btnproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.ForeColor = System.Drawing.Color.White;
            this.btnproducto.Location = new System.Drawing.Point(85, 49);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(126, 30);
            this.btnproducto.TabIndex = 1;
            this.btnproducto.Text = "Producto";
            this.btnproducto.UseVisualStyleBackColor = false;
            // 
            // btnalmacen
            // 
            this.btnalmacen.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnalmacen.FlatAppearance.BorderSize = 0;
            this.btnalmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalmacen.ForeColor = System.Drawing.Color.White;
            this.btnalmacen.Image = global::CapaPresentacion.Properties.Resources.almacen4;
            this.btnalmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalmacen.Location = new System.Drawing.Point(3, 3);
            this.btnalmacen.Name = "btnalmacen";
            this.btnalmacen.Size = new System.Drawing.Size(208, 40);
            this.btnalmacen.TabIndex = 0;
            this.btnalmacen.Text = "Almacén";
            this.btnalmacen.UseVisualStyleBackColor = false;
            this.btnalmacen.Click += new System.EventHandler(this.btnalmacen_Click);
            // 
            // mnucompra
            // 
            this.mnucompra.Controls.Add(this.btnproveedor);
            this.mnucompra.Controls.Add(this.btngenerarcompra);
            this.mnucompra.Controls.Add(this.btncompras);
            this.mnucompra.Location = new System.Drawing.Point(3, 158);
            this.mnucompra.MaximumSize = new System.Drawing.Size(214, 120);
            this.mnucompra.MinimumSize = new System.Drawing.Size(214, 37);
            this.mnucompra.Name = "mnucompra";
            this.mnucompra.Size = new System.Drawing.Size(214, 46);
            this.mnucompra.TabIndex = 5;
            // 
            // btnproveedor
            // 
            this.btnproveedor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnproveedor.FlatAppearance.BorderSize = 0;
            this.btnproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedor.ForeColor = System.Drawing.Color.White;
            this.btnproveedor.Location = new System.Drawing.Point(85, 84);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Size = new System.Drawing.Size(126, 30);
            this.btnproveedor.TabIndex = 2;
            this.btnproveedor.Text = "Proveedores";
            this.btnproveedor.UseVisualStyleBackColor = false;
            // 
            // btngenerarcompra
            // 
            this.btngenerarcompra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngenerarcompra.FlatAppearance.BorderSize = 0;
            this.btngenerarcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarcompra.ForeColor = System.Drawing.Color.White;
            this.btngenerarcompra.Location = new System.Drawing.Point(85, 49);
            this.btngenerarcompra.Name = "btngenerarcompra";
            this.btngenerarcompra.Size = new System.Drawing.Size(126, 30);
            this.btngenerarcompra.TabIndex = 1;
            this.btngenerarcompra.Text = "Generar Compra";
            this.btngenerarcompra.UseVisualStyleBackColor = false;
            // 
            // btncompras
            // 
            this.btncompras.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncompras.FlatAppearance.BorderSize = 0;
            this.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.ForeColor = System.Drawing.Color.White;
            this.btncompras.Image = global::CapaPresentacion.Properties.Resources.compras1;
            this.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompras.Location = new System.Drawing.Point(3, 3);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(208, 40);
            this.btncompras.TabIndex = 0;
            this.btncompras.Text = "Compras";
            this.btncompras.UseVisualStyleBackColor = false;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // mnuventa
            // 
            this.mnuventa.Controls.Add(this.btnventas);
            this.mnuventa.Controls.Add(this.btnclientes);
            this.mnuventa.Controls.Add(this.btngenerarventa);
            this.mnuventa.Location = new System.Drawing.Point(3, 210);
            this.mnuventa.MaximumSize = new System.Drawing.Size(214, 120);
            this.mnuventa.MinimumSize = new System.Drawing.Size(214, 37);
            this.mnuventa.Name = "mnuventa";
            this.mnuventa.Size = new System.Drawing.Size(214, 46);
            this.mnuventa.TabIndex = 6;
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.ForeColor = System.Drawing.Color.White;
            this.btnventas.Image = global::CapaPresentacion.Properties.Resources.ventas1;
            this.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventas.Location = new System.Drawing.Point(3, 3);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(208, 40);
            this.btnventas.TabIndex = 0;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Location = new System.Drawing.Point(85, 84);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(126, 30);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = false;
            // 
            // btngenerarventa
            // 
            this.btngenerarventa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngenerarventa.FlatAppearance.BorderSize = 0;
            this.btngenerarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarventa.ForeColor = System.Drawing.Color.White;
            this.btngenerarventa.Location = new System.Drawing.Point(85, 49);
            this.btngenerarventa.Name = "btngenerarventa";
            this.btngenerarventa.Size = new System.Drawing.Size(126, 30);
            this.btngenerarventa.TabIndex = 1;
            this.btngenerarventa.Text = "Generar Venta";
            this.btngenerarventa.UseVisualStyleBackColor = false;
            // 
            // mnuconsultas
            // 
            this.mnuconsultas.Controls.Add(this.btnconsultas);
            this.mnuconsultas.Controls.Add(this.btnstockminimo);
            this.mnuconsultas.Controls.Add(this.btncomprafechas);
            this.mnuconsultas.Controls.Add(this.btnventafechas);
            this.mnuconsultas.Location = new System.Drawing.Point(3, 366);
            this.mnuconsultas.MaximumSize = new System.Drawing.Size(214, 160);
            this.mnuconsultas.MinimumSize = new System.Drawing.Size(214, 37);
            this.mnuconsultas.Name = "mnuconsultas";
            this.mnuconsultas.Size = new System.Drawing.Size(214, 47);
            this.mnuconsultas.TabIndex = 7;
            // 
            // btnconsultas
            // 
            this.btnconsultas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnconsultas.FlatAppearance.BorderSize = 0;
            this.btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultas.ForeColor = System.Drawing.Color.White;
            this.btnconsultas.Image = global::CapaPresentacion.Properties.Resources.consultas1;
            this.btnconsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultas.Location = new System.Drawing.Point(3, 3);
            this.btnconsultas.Name = "btnconsultas";
            this.btnconsultas.Size = new System.Drawing.Size(208, 40);
            this.btnconsultas.TabIndex = 0;
            this.btnconsultas.Text = "Consultas";
            this.btnconsultas.UseVisualStyleBackColor = false;
            this.btnconsultas.Click += new System.EventHandler(this.btnconsultas_Click);
            // 
            // btnstockminimo
            // 
            this.btnstockminimo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnstockminimo.FlatAppearance.BorderSize = 0;
            this.btnstockminimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstockminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockminimo.ForeColor = System.Drawing.Color.White;
            this.btnstockminimo.Location = new System.Drawing.Point(64, 120);
            this.btnstockminimo.Name = "btnstockminimo";
            this.btnstockminimo.Size = new System.Drawing.Size(147, 30);
            this.btnstockminimo.TabIndex = 3;
            this.btnstockminimo.Text = "Stock mínimo";
            this.btnstockminimo.UseVisualStyleBackColor = false;
            // 
            // btncomprafechas
            // 
            this.btncomprafechas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncomprafechas.FlatAppearance.BorderSize = 0;
            this.btncomprafechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomprafechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomprafechas.ForeColor = System.Drawing.Color.White;
            this.btncomprafechas.Location = new System.Drawing.Point(64, 84);
            this.btncomprafechas.Name = "btncomprafechas";
            this.btncomprafechas.Size = new System.Drawing.Size(147, 30);
            this.btncomprafechas.TabIndex = 2;
            this.btncomprafechas.Text = "Compras por fecha";
            this.btncomprafechas.UseVisualStyleBackColor = false;
            // 
            // btnventafechas
            // 
            this.btnventafechas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnventafechas.FlatAppearance.BorderSize = 0;
            this.btnventafechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventafechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventafechas.ForeColor = System.Drawing.Color.White;
            this.btnventafechas.Location = new System.Drawing.Point(64, 49);
            this.btnventafechas.Name = "btnventafechas";
            this.btnventafechas.Size = new System.Drawing.Size(147, 30);
            this.btnventafechas.TabIndex = 1;
            this.btnventafechas.Text = "Ventas por fecha";
            this.btnventafechas.UseVisualStyleBackColor = false;
            // 
            // mnuconfiguraciones
            // 
            this.mnuconfiguraciones.Controls.Add(this.btnconfiguraciones);
            this.mnuconfiguraciones.Controls.Add(this.btnusuarios);
            this.mnuconfiguraciones.Controls.Add(this.btnempleados);
            this.mnuconfiguraciones.Location = new System.Drawing.Point(3, 262);
            this.mnuconfiguraciones.MaximumSize = new System.Drawing.Size(214, 120);
            this.mnuconfiguraciones.MinimumSize = new System.Drawing.Size(214, 37);
            this.mnuconfiguraciones.Name = "mnuconfiguraciones";
            this.mnuconfiguraciones.Size = new System.Drawing.Size(214, 46);
            this.mnuconfiguraciones.TabIndex = 8;
            // 
            // btnconfiguraciones
            // 
            this.btnconfiguraciones.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnconfiguraciones.FlatAppearance.BorderSize = 0;
            this.btnconfiguraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfiguraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfiguraciones.ForeColor = System.Drawing.Color.White;
            this.btnconfiguraciones.Image = global::CapaPresentacion.Properties.Resources.confi_1;
            this.btnconfiguraciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconfiguraciones.Location = new System.Drawing.Point(3, 3);
            this.btnconfiguraciones.Name = "btnconfiguraciones";
            this.btnconfiguraciones.Size = new System.Drawing.Size(208, 40);
            this.btnconfiguraciones.TabIndex = 0;
            this.btnconfiguraciones.Text = "Configuraciones";
            this.btnconfiguraciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconfiguraciones.UseVisualStyleBackColor = false;
            this.btnconfiguraciones.Click += new System.EventHandler(this.btnconfiguraciones_Click);
            // 
            // btnusuarios
            // 
            this.btnusuarios.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnusuarios.FlatAppearance.BorderSize = 0;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.Color.White;
            this.btnusuarios.Location = new System.Drawing.Point(75, 84);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(136, 30);
            this.btnusuarios.TabIndex = 2;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.UseVisualStyleBackColor = false;
            // 
            // btnempleados
            // 
            this.btnempleados.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.Color.White;
            this.btnempleados.Location = new System.Drawing.Point(75, 49);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(136, 30);
            this.btnempleados.TabIndex = 1;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = false;
            // 
            // mnureportes
            // 
            this.mnureportes.Controls.Add(this.btnreportes);
            this.mnureportes.Controls.Add(this.btnreporteempleado);
            this.mnureportes.Controls.Add(this.btnreportecliente);
            this.mnureportes.Controls.Add(this.btnreporteproducto);
            this.mnureportes.Location = new System.Drawing.Point(3, 314);
            this.mnureportes.MaximumSize = new System.Drawing.Size(214, 160);
            this.mnureportes.MinimumSize = new System.Drawing.Size(214, 37);
            this.mnureportes.Name = "mnureportes";
            this.mnureportes.Size = new System.Drawing.Size(214, 46);
            this.mnureportes.TabIndex = 9;
            // 
            // btnreportes
            // 
            this.btnreportes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreportes.FlatAppearance.BorderSize = 0;
            this.btnreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportes.ForeColor = System.Drawing.Color.White;
            this.btnreportes.Image = global::CapaPresentacion.Properties.Resources.reportes1;
            this.btnreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportes.Location = new System.Drawing.Point(3, 3);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(208, 40);
            this.btnreportes.TabIndex = 0;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.UseVisualStyleBackColor = false;
            this.btnreportes.Click += new System.EventHandler(this.btnreportes_Click);
            // 
            // btnreporteempleado
            // 
            this.btnreporteempleado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreporteempleado.FlatAppearance.BorderSize = 0;
            this.btnreporteempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporteempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporteempleado.ForeColor = System.Drawing.Color.White;
            this.btnreporteempleado.Location = new System.Drawing.Point(75, 120);
            this.btnreporteempleado.Name = "btnreporteempleado";
            this.btnreporteempleado.Size = new System.Drawing.Size(136, 30);
            this.btnreporteempleado.TabIndex = 3;
            this.btnreporteempleado.Text = "Empleados";
            this.btnreporteempleado.UseVisualStyleBackColor = false;
            // 
            // btnreportecliente
            // 
            this.btnreportecliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreportecliente.FlatAppearance.BorderSize = 0;
            this.btnreportecliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportecliente.ForeColor = System.Drawing.Color.White;
            this.btnreportecliente.Location = new System.Drawing.Point(75, 84);
            this.btnreportecliente.Name = "btnreportecliente";
            this.btnreportecliente.Size = new System.Drawing.Size(136, 30);
            this.btnreportecliente.TabIndex = 2;
            this.btnreportecliente.Text = "Clientes";
            this.btnreportecliente.UseVisualStyleBackColor = false;
            // 
            // btnreporteproducto
            // 
            this.btnreporteproducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreporteproducto.FlatAppearance.BorderSize = 0;
            this.btnreporteproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporteproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporteproducto.ForeColor = System.Drawing.Color.White;
            this.btnreporteproducto.Location = new System.Drawing.Point(75, 49);
            this.btnreporteproducto.Name = "btnreporteproducto";
            this.btnreporteproducto.Size = new System.Drawing.Size(136, 30);
            this.btnreporteproducto.TabIndex = 1;
            this.btnreporteproducto.Text = "Productos";
            this.btnreporteproducto.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(222, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 100);
            this.panel2.TabIndex = 2;
            // 
            // tmrsubmenu
            // 
            this.tmrsubmenu.Interval = 10;
            this.tmrsubmenu.Tick += new System.EventHandler(this.tmrsubmenu_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnualmacen.ResumeLayout(false);
            this.mnucompra.ResumeLayout(false);
            this.mnuventa.ResumeLayout(false);
            this.mnuconsultas.ResumeLayout(false);
            this.mnuconfiguraciones.ResumeLayout(false);
            this.mnureportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mnualmacen;
        private System.Windows.Forms.Button btnalmacen;
        private System.Windows.Forms.Button btncategoria;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Panel mnucompra;
        private System.Windows.Forms.Button btnproveedor;
        private System.Windows.Forms.Button btngenerarcompra;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Panel mnuventa;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btngenerarventa;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Panel mnuconsultas;
        private System.Windows.Forms.Button btncomprafechas;
        private System.Windows.Forms.Button btnventafechas;
        private System.Windows.Forms.Button btnconsultas;
        private System.Windows.Forms.Button btnstockminimo;
        private System.Windows.Forms.Panel mnuconfiguraciones;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btnconfiguraciones;
        private System.Windows.Forms.Panel mnureportes;
        private System.Windows.Forms.Button btnreportecliente;
        private System.Windows.Forms.Button btnreporteproducto;
        private System.Windows.Forms.Button btnreportes;
        private System.Windows.Forms.Button btnreporteempleado;
        private System.Windows.Forms.Timer tmrsubmenu;
    }
}