namespace CapaPresentacion
{
    partial class FrmRegistrarEmpleado
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
            this.btncancerlar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtninactivo = new System.Windows.Forms.RadioButton();
            this.rbtnactivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancerlar
            // 
            this.btncancerlar.Location = new System.Drawing.Point(675, 397);
            this.btncancerlar.Name = "btncancerlar";
            this.btncancerlar.Size = new System.Drawing.Size(75, 23);
            this.btncancerlar.TabIndex = 33;
            this.btncancerlar.Text = "&Cancelar";
            this.btncancerlar.UseVisualStyleBackColor = true;
            this.btncancerlar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(551, 397);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 32;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(198, 75);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(48, 22);
            this.txtidempleado.TabIndex = 31;
            this.txtidempleado.Visible = false;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(48, 291);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(201, 22);
            this.txtdni.TabIndex = 30;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(397, 208);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(221, 22);
            this.txtdireccion.TabIndex = 29;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(45, 208);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(201, 22);
            this.txtapellidos.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Apellidos";
            // 
            // rbtninactivo
            // 
            this.rbtninactivo.AutoSize = true;
            this.rbtninactivo.Location = new System.Drawing.Point(511, 291);
            this.rbtninactivo.Name = "rbtninactivo";
            this.rbtninactivo.Size = new System.Drawing.Size(74, 20);
            this.rbtninactivo.TabIndex = 24;
            this.rbtninactivo.TabStop = true;
            this.rbtninactivo.Text = "Inactivo";
            this.rbtninactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Location = new System.Drawing.Point(397, 293);
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Size = new System.Drawing.Size(65, 20);
            this.rbtnactivo.TabIndex = 23;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Seleccione estado";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(394, 103);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(221, 22);
            this.txttelefono.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Teléfono";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(45, 103);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(201, 22);
            this.txtnombre.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrar Nuevo Empleado";
            // 
            // FrmRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancerlar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtidempleado);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtninactivo);
            this.Controls.Add(this.rbtnactivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarEmpleado";
            this.Text = "FrmRegistrarEmpleado";
            this.Load += new System.EventHandler(this.FrmRegistrarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancerlar;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.TextBox txtidempleado;
        public System.Windows.Forms.TextBox txtdni;
        public System.Windows.Forms.TextBox txtdireccion;
        public System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton rbtninactivo;
        public System.Windows.Forms.RadioButton rbtnactivo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}