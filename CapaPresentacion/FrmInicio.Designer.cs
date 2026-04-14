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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnproducto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnventafechas = new System.Windows.Forms.Button();
            this.btncomprafechas = new System.Windows.Forms.Button();
            this.mnuconsultas = new System.Windows.Forms.Panel();
            this.mnucompra = new System.Windows.Forms.Panel();
            this.btnproveedor = new System.Windows.Forms.Button();
            this.btngenerarcompra = new System.Windows.Forms.Button();
            this.mnuventa = new System.Windows.Forms.Panel();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btngenerarventas = new System.Windows.Forms.Button();
            this.btnstockminimo = new System.Windows.Forms.Button();
            this.mnuconfiguraciones = new System.Windows.Forms.Panel();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.mnureportes = new System.Windows.Forms.Panel();
            this.btnreportecliente = new System.Windows.Forms.Button();
            this.btnreporteproducto = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btnventas = new System.Windows.Forms.Button();
            this.btnconfiguraciones = new System.Windows.Forms.Button();
            this.btnconsultas = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnalmacen = new System.Windows.Forms.Button();
            this.btnreporteempleado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.mnuconsultas.SuspendLayout();
            this.mnucompra.SuspendLayout();
            this.mnuventa.SuspendLayout();
            this.mnuconfiguraciones.SuspendLayout();
            this.mnureportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.mnureportes);
            this.panel1.Controls.Add(this.mnuventa);
            this.panel1.Controls.Add(this.mnuconfiguraciones);
            this.panel1.Controls.Add(this.mnuconsultas);
            this.panel1.Controls.Add(this.mnucompra);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btncerrar);
            this.panel2.Controls.Add(this.btnmaximizar);
            this.panel2.Controls.Add(this.btnminimizar);
            this.panel2.Controls.Add(this.btnrestaurar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 46);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(194, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(225, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(575, 118);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.btnproducto);
            this.panel5.Controls.Add(this.btnalmacen);
            this.panel5.Location = new System.Drawing.Point(9, 156);
            this.panel5.MaximumSize = new System.Drawing.Size(214, 120);
            this.panel5.MinimumSize = new System.Drawing.Size(214, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 38);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnproducto
            // 
            this.btnproducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnproducto.FlatAppearance.BorderSize = 0;
            this.btnproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.ForeColor = System.Drawing.Color.White;
            this.btnproducto.Location = new System.Drawing.Point(63, 42);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(148, 33);
            this.btnproducto.TabIndex = 5;
            this.btnproducto.Text = "Producto";
            this.btnproducto.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(63, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Categoría";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnventafechas
            // 
            this.btnventafechas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnventafechas.FlatAppearance.BorderSize = 0;
            this.btnventafechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventafechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventafechas.ForeColor = System.Drawing.Color.White;
            this.btnventafechas.Location = new System.Drawing.Point(32, 44);
            this.btnventafechas.Name = "btnventafechas";
            this.btnventafechas.Size = new System.Drawing.Size(177, 33);
            this.btnventafechas.TabIndex = 5;
            this.btnventafechas.Text = "Ventas por fecha";
            this.btnventafechas.UseVisualStyleBackColor = false;
            // 
            // btncomprafechas
            // 
            this.btncomprafechas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncomprafechas.FlatAppearance.BorderSize = 0;
            this.btncomprafechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomprafechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomprafechas.ForeColor = System.Drawing.Color.White;
            this.btncomprafechas.Location = new System.Drawing.Point(34, 81);
            this.btncomprafechas.Name = "btncomprafechas";
            this.btncomprafechas.Size = new System.Drawing.Size(177, 33);
            this.btncomprafechas.TabIndex = 6;
            this.btncomprafechas.Text = "Compras por fechas";
            this.btncomprafechas.UseVisualStyleBackColor = false;
            // 
            // mnuconsultas
            // 
            this.mnuconsultas.Controls.Add(this.btnstockminimo);
            this.mnuconsultas.Controls.Add(this.btncomprafechas);
            this.mnuconsultas.Controls.Add(this.btnventafechas);
            this.mnuconsultas.Controls.Add(this.btnconsultas);
            this.mnuconsultas.Location = new System.Drawing.Point(9, 289);
            this.mnuconsultas.MaximumSize = new System.Drawing.Size(214, 160);
            this.mnuconsultas.MinimumSize = new System.Drawing.Size(214, 20);
            this.mnuconsultas.Name = "mnuconsultas";
            this.mnuconsultas.Size = new System.Drawing.Size(214, 44);
            this.mnuconsultas.TabIndex = 7;
            this.mnuconsultas.Paint += new System.Windows.Forms.PaintEventHandler(this.mnuconsultas_Paint);
            // 
            // mnucompra
            // 
            this.mnucompra.Controls.Add(this.btnproveedor);
            this.mnucompra.Controls.Add(this.btngenerarcompra);
            this.mnucompra.Controls.Add(this.btncompras);
            this.mnucompra.Location = new System.Drawing.Point(9, 197);
            this.mnucompra.MaximumSize = new System.Drawing.Size(214, 120);
            this.mnucompra.MinimumSize = new System.Drawing.Size(214, 37);
            this.mnucompra.Name = "mnucompra";
            this.mnucompra.Size = new System.Drawing.Size(214, 37);
            this.mnucompra.TabIndex = 8;
            this.mnucompra.Paint += new System.Windows.Forms.PaintEventHandler(this.mnucompra_Paint);
            // 
            // btnproveedor
            // 
            this.btnproveedor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnproveedor.FlatAppearance.BorderSize = 0;
            this.btnproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedor.ForeColor = System.Drawing.Color.White;
            this.btnproveedor.Location = new System.Drawing.Point(63, 81);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Size = new System.Drawing.Size(148, 33);
            this.btnproveedor.TabIndex = 6;
            this.btnproveedor.Text = "Proveedores";
            this.btnproveedor.UseVisualStyleBackColor = false;
            // 
            // btngenerarcompra
            // 
            this.btngenerarcompra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngenerarcompra.FlatAppearance.BorderSize = 0;
            this.btngenerarcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarcompra.ForeColor = System.Drawing.Color.White;
            this.btngenerarcompra.Location = new System.Drawing.Point(63, 42);
            this.btngenerarcompra.Name = "btngenerarcompra";
            this.btngenerarcompra.Size = new System.Drawing.Size(148, 33);
            this.btngenerarcompra.TabIndex = 5;
            this.btngenerarcompra.Text = "Generar Compra";
            this.btngenerarcompra.UseVisualStyleBackColor = false;
            // 
            // mnuventa
            // 
            this.mnuventa.Controls.Add(this.btnclientes);
            this.mnuventa.Controls.Add(this.btngenerarventas);
            this.mnuventa.Controls.Add(this.btnventas);
            this.mnuventa.Location = new System.Drawing.Point(9, 241);
            this.mnuventa.MaximumSize = new System.Drawing.Size(214, 120);
            this.mnuventa.MinimumSize = new System.Drawing.Size(214, 37);
            this.mnuventa.Name = "mnuventa";
            this.mnuventa.Size = new System.Drawing.Size(214, 42);
            this.mnuventa.TabIndex = 8;
            this.mnuventa.Paint += new System.Windows.Forms.PaintEventHandler(this.mnuventa_Paint);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Location = new System.Drawing.Point(63, 81);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(148, 33);
            this.btnclientes.TabIndex = 6;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = false;
            // 
            // btngenerarventas
            // 
            this.btngenerarventas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngenerarventas.FlatAppearance.BorderSize = 0;
            this.btngenerarventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarventas.ForeColor = System.Drawing.Color.White;
            this.btngenerarventas.Location = new System.Drawing.Point(63, 42);
            this.btngenerarventas.Name = "btngenerarventas";
            this.btngenerarventas.Size = new System.Drawing.Size(148, 33);
            this.btngenerarventas.TabIndex = 5;
            this.btngenerarventas.Text = "Generar Compra";
            this.btngenerarventas.UseVisualStyleBackColor = false;
            // 
            // btnstockminimo
            // 
            this.btnstockminimo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnstockminimo.FlatAppearance.BorderSize = 0;
            this.btnstockminimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstockminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockminimo.ForeColor = System.Drawing.Color.White;
            this.btnstockminimo.Location = new System.Drawing.Point(34, 120);
            this.btnstockminimo.Name = "btnstockminimo";
            this.btnstockminimo.Size = new System.Drawing.Size(177, 33);
            this.btnstockminimo.TabIndex = 7;
            this.btnstockminimo.Text = "Stock";
            this.btnstockminimo.UseVisualStyleBackColor = false;
            // 
            // mnuconfiguraciones
            // 
            this.mnuconfiguraciones.Controls.Add(this.btnusuarios);
            this.mnuconfiguraciones.Controls.Add(this.btnempleados);
            this.mnuconfiguraciones.Controls.Add(this.btnconfiguraciones);
            this.mnuconfiguraciones.Location = new System.Drawing.Point(9, 339);
            this.mnuconfiguraciones.MaximumSize = new System.Drawing.Size(214, 120);
            this.mnuconfiguraciones.MinimumSize = new System.Drawing.Size(214, 20);
            this.mnuconfiguraciones.Name = "mnuconfiguraciones";
            this.mnuconfiguraciones.Size = new System.Drawing.Size(214, 40);
            this.mnuconfiguraciones.TabIndex = 8;
            this.mnuconfiguraciones.Paint += new System.Windows.Forms.PaintEventHandler(this.mnuconfiguraciones_Paint);
            // 
            // btnusuarios
            // 
            this.btnusuarios.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnusuarios.FlatAppearance.BorderSize = 0;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.Color.White;
            this.btnusuarios.Location = new System.Drawing.Point(34, 81);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(177, 33);
            this.btnusuarios.TabIndex = 6;
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
            this.btnempleados.Location = new System.Drawing.Point(34, 42);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(177, 33);
            this.btnempleados.TabIndex = 5;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = false;
            // 
            // mnureportes
            // 
            this.mnureportes.Controls.Add(this.btnreporteempleado);
            this.mnureportes.Controls.Add(this.btnreportecliente);
            this.mnureportes.Controls.Add(this.btnreporteproducto);
            this.mnureportes.Controls.Add(this.btnreportes);
            this.mnureportes.Location = new System.Drawing.Point(9, 385);
            this.mnureportes.MaximumSize = new System.Drawing.Size(214, 160);
            this.mnureportes.MinimumSize = new System.Drawing.Size(214, 20);
            this.mnureportes.Name = "mnureportes";
            this.mnureportes.Size = new System.Drawing.Size(214, 40);
            this.mnureportes.TabIndex = 9;
            // 
            // btnreportecliente
            // 
            this.btnreportecliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreportecliente.FlatAppearance.BorderSize = 0;
            this.btnreportecliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportecliente.ForeColor = System.Drawing.Color.White;
            this.btnreportecliente.Location = new System.Drawing.Point(34, 81);
            this.btnreportecliente.Name = "btnreportecliente";
            this.btnreportecliente.Size = new System.Drawing.Size(177, 33);
            this.btnreportecliente.TabIndex = 6;
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
            this.btnreporteproducto.Location = new System.Drawing.Point(34, 42);
            this.btnreporteproducto.Name = "btnreporteproducto";
            this.btnreporteproducto.Size = new System.Drawing.Size(177, 33);
            this.btnreporteproducto.TabIndex = 5;
            this.btnreporteproducto.Text = "Productos";
            this.btnreporteproducto.UseVisualStyleBackColor = false;
            // 
            // btnreportes
            // 
            this.btnreportes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreportes.FlatAppearance.BorderSize = 0;
            this.btnreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportes.ForeColor = System.Drawing.Color.White;
            this.btnreportes.Image = global::CapaPresentacion.Properties.Resources.reportes;
            this.btnreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportes.Location = new System.Drawing.Point(3, 5);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(206, 33);
            this.btnreportes.TabIndex = 4;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.UseVisualStyleBackColor = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Location = new System.Drawing.Point(753, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 6;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Location = new System.Drawing.Point(720, 12);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 5;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Location = new System.Drawing.Point(687, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(25, 25);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 4;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Location = new System.Drawing.Point(720, 12);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 3;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.ForeColor = System.Drawing.Color.White;
            this.btnventas.Image = global::CapaPresentacion.Properties.Resources.ventas;
            this.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventas.Location = new System.Drawing.Point(3, 4);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(206, 33);
            this.btnventas.TabIndex = 4;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = false;
            // 
            // btnconfiguraciones
            // 
            this.btnconfiguraciones.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnconfiguraciones.FlatAppearance.BorderSize = 0;
            this.btnconfiguraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfiguraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfiguraciones.ForeColor = System.Drawing.Color.White;
            this.btnconfiguraciones.Image = global::CapaPresentacion.Properties.Resources.confi__;
            this.btnconfiguraciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconfiguraciones.Location = new System.Drawing.Point(3, 5);
            this.btnconfiguraciones.Name = "btnconfiguraciones";
            this.btnconfiguraciones.Size = new System.Drawing.Size(208, 33);
            this.btnconfiguraciones.TabIndex = 4;
            this.btnconfiguraciones.Text = "Configuraciones";
            this.btnconfiguraciones.UseVisualStyleBackColor = false;
            // 
            // btnconsultas
            // 
            this.btnconsultas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnconsultas.FlatAppearance.BorderSize = 0;
            this.btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultas.ForeColor = System.Drawing.Color.White;
            this.btnconsultas.Image = global::CapaPresentacion.Properties.Resources.consultas;
            this.btnconsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultas.Location = new System.Drawing.Point(3, 5);
            this.btnconsultas.Name = "btnconsultas";
            this.btnconsultas.Size = new System.Drawing.Size(206, 31);
            this.btnconsultas.TabIndex = 4;
            this.btnconsultas.Text = "Consultas";
            this.btnconsultas.UseVisualStyleBackColor = false;
            // 
            // btncompras
            // 
            this.btncompras.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncompras.FlatAppearance.BorderSize = 0;
            this.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.ForeColor = System.Drawing.Color.White;
            this.btncompras.Image = global::CapaPresentacion.Properties.Resources.compras;
            this.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompras.Location = new System.Drawing.Point(3, 5);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(206, 29);
            this.btncompras.TabIndex = 4;
            this.btncompras.Text = "Compras";
            this.btncompras.UseVisualStyleBackColor = false;
            this.btncompras.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.almacen11;
            this.pictureBox1.Location = new System.Drawing.Point(57, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnalmacen
            // 
            this.btnalmacen.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnalmacen.FlatAppearance.BorderSize = 0;
            this.btnalmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalmacen.ForeColor = System.Drawing.Color.White;
            this.btnalmacen.Image = global::CapaPresentacion.Properties.Resources.almacen3;
            this.btnalmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalmacen.Location = new System.Drawing.Point(3, 5);
            this.btnalmacen.Name = "btnalmacen";
            this.btnalmacen.Size = new System.Drawing.Size(206, 30);
            this.btnalmacen.TabIndex = 4;
            this.btnalmacen.Text = "Almacén";
            this.btnalmacen.UseVisualStyleBackColor = false;
            // 
            // btnreporteempleado
            // 
            this.btnreporteempleado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreporteempleado.FlatAppearance.BorderSize = 0;
            this.btnreporteempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporteempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporteempleado.ForeColor = System.Drawing.Color.White;
            this.btnreporteempleado.Location = new System.Drawing.Point(34, 121);
            this.btnreporteempleado.Name = "btnreporteempleado";
            this.btnreporteempleado.Size = new System.Drawing.Size(177, 33);
            this.btnreporteempleado.TabIndex = 7;
            this.btnreporteempleado.Text = "Empleados";
            this.btnreporteempleado.UseVisualStyleBackColor = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.mnuconsultas.ResumeLayout(false);
            this.mnucompra.ResumeLayout(false);
            this.mnuventa.ResumeLayout(false);
            this.mnuconfiguraciones.ResumeLayout(false);
            this.mnureportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnalmacen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Button btnconsultas;
        private System.Windows.Forms.Button btnventafechas;
        private System.Windows.Forms.Button btncomprafechas;
        private System.Windows.Forms.Panel mnuconsultas;
        private System.Windows.Forms.Panel mnucompra;
        private System.Windows.Forms.Button btnproveedor;
        private System.Windows.Forms.Button btngenerarcompra;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Panel mnuventa;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btngenerarventas;
        private System.Windows.Forms.Button btnventas;
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
    }
}