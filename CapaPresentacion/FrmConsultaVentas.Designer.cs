namespace CapaPresentacion
{
    partial class FrmConsultaVentas
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
            this.datetimeinicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.datetimefin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnanular = new System.Windows.Forms.Button();
            this.btndetalle = new System.Windows.Forms.Button();
            this.grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimeinicio
            // 
            this.datetimeinicio.CustomFormat = "dd/mm/aaaa";
            this.datetimeinicio.Location = new System.Drawing.Point(19, 49);
            this.datetimeinicio.Name = "datetimeinicio";
            this.datetimeinicio.Size = new System.Drawing.Size(200, 22);
            this.datetimeinicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas por Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.btnsalir);
            this.grpbox.Controls.Add(this.btnreporte);
            this.grpbox.Controls.Add(this.btnbuscar);
            this.grpbox.Controls.Add(this.label3);
            this.grpbox.Controls.Add(this.datetimefin);
            this.grpbox.Controls.Add(this.label2);
            this.grpbox.Controls.Add(this.datetimeinicio);
            this.grpbox.Location = new System.Drawing.Point(57, 83);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(914, 100);
            this.grpbox.TabIndex = 2;
            this.grpbox.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(774, 34);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(118, 33);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnreporte.FlatAppearance.BorderSize = 0;
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.Location = new System.Drawing.Point(633, 34);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(119, 33);
            this.btnreporte.TabIndex = 11;
            this.btnreporte.Text = "REPORTE";
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(491, 38);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(120, 33);
            this.btnbuscar.TabIndex = 10;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "FECHA FIN";
            // 
            // datetimefin
            // 
            this.datetimefin.CustomFormat = "dd/mm/aaaa";
            this.datetimefin.Location = new System.Drawing.Point(268, 45);
            this.datetimefin.Name = "datetimefin";
            this.datetimefin.Size = new System.Drawing.Size(200, 22);
            this.datetimefin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA INICIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idventa,
            this.cliente,
            this.fecha,
            this.empleado,
            this.tipo_documento,
            this.serie,
            this.num_documento,
            this.total,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(57, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 262);
            this.dataGridView1.TabIndex = 3;
            // 
            // idventa
            // 
            this.idventa.DataPropertyName = "idventa";
            this.idventa.HeaderText = "ID";
            this.idventa.MinimumWidth = 6;
            this.idventa.Name = "idventa";
            this.idventa.Width = 50;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.Width = 125;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 125;
            // 
            // empleado
            // 
            this.empleado.DataPropertyName = "empleado";
            this.empleado.HeaderText = "Empleado";
            this.empleado.MinimumWidth = 6;
            this.empleado.Name = "empleado";
            this.empleado.Width = 125;
            // 
            // tipo_documento
            // 
            this.tipo_documento.DataPropertyName = "tipo_documento";
            this.tipo_documento.HeaderText = "Tipo Documento";
            this.tipo_documento.MinimumWidth = 6;
            this.tipo_documento.Name = "tipo_documento";
            this.tipo_documento.Width = 125;
            // 
            // serie
            // 
            this.serie.DataPropertyName = "serie";
            this.serie.HeaderText = "Serie";
            this.serie.MinimumWidth = 6;
            this.serie.Name = "serie";
            this.serie.Width = 125;
            // 
            // num_documento
            // 
            this.num_documento.DataPropertyName = "num_documento";
            this.num_documento.HeaderText = "Numero Documento";
            this.num_documento.MinimumWidth = 6;
            this.num_documento.Name = "num_documento";
            this.num_documento.Width = 125;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // btnanular
            // 
            this.btnanular.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnanular.FlatAppearance.BorderSize = 0;
            this.btnanular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanular.ForeColor = System.Drawing.Color.White;
            this.btnanular.Location = new System.Drawing.Point(847, 532);
            this.btnanular.Name = "btnanular";
            this.btnanular.Size = new System.Drawing.Size(124, 33);
            this.btnanular.TabIndex = 13;
            this.btnanular.Text = "ANULAR";
            this.btnanular.UseVisualStyleBackColor = false;
            this.btnanular.Click += new System.EventHandler(this.btnanular_Click);
            // 
            // btndetalle
            // 
            this.btndetalle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btndetalle.FlatAppearance.BorderSize = 0;
            this.btndetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetalle.ForeColor = System.Drawing.Color.White;
            this.btndetalle.Location = new System.Drawing.Point(664, 532);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(145, 33);
            this.btndetalle.TabIndex = 13;
            this.btndetalle.Text = "VER DETALLE";
            this.btndetalle.UseVisualStyleBackColor = false;
            this.btndetalle.Click += new System.EventHandler(this.btndetalle_Click);
            // 
            // FrmConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 577);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.btnanular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaVentas";
            this.Text = "FrmConsultaVentas";
            this.Load += new System.EventHandler(this.FrmConsultaVentas_Load);
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimeinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetimefin;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnanular;
        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}