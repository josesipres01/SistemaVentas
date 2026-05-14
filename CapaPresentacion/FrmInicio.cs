using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        string opcion;
        bool expanderalmacen;
        bool expandercompras;
        bool expanderventas;
        bool expanderconsultas;
        bool expanderconfiguraciones;
        bool expanderreportes;

        public FrmInicio(string nombreUsuario, string apellidoUsuario)
        {   
            InitializeComponent();

            lblNombre.Text = nombreUsuario;
            lblApellido.Text = apellidoUsuario;
            MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tmrsubmenu_Tick(object sender, EventArgs e)
        {
            if (opcion.Equals("mnualmacen"))
            {
                if (expanderalmacen)
                {
                    mnualmacen.Height -= 10;
                    if (mnualmacen.Height == mnualmacen.MinimumSize.Height)
                    {
                        expanderalmacen = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnualmacen.Height += 10;
                    if (mnualmacen.Height == mnualmacen.MaximumSize.Height)
                    {
                        expanderalmacen = true;
                        tmrsubmenu.Stop();
                    }
                }
            }

            if (opcion.Equals("mnucompras"))
            {
                if (expandercompras)
                {
                    mnucompra.Height -= 10;
                    if (mnucompra.Height == mnucompra.MinimumSize.Height)
                    {
                        expandercompras = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnucompra.Height += 10;
                    if (mnucompra.Height == mnucompra.MaximumSize.Height)
                    {
                        expandercompras = true;
                        tmrsubmenu.Stop();
                    }
                }
            }

            if (opcion.Equals("mnuventas"))
            {
                if (expanderventas)
                {
                    mnuventa.Height -= 10;
                    if (mnuventa.Height == mnuventa.MinimumSize.Height)
                    {
                        expanderventas = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnuventa.Height += 10;
                    if (mnuventa.Height == mnuventa.MaximumSize.Height)
                    {
                        expanderventas = true;
                        tmrsubmenu.Stop();
                    }
                }
            }


            if (opcion.Equals("mnuconsultas"))
            {
                if (expanderconsultas)
                {
                    mnuconsultas.Height -= 10;
                    if (mnuconsultas.Height == mnuconsultas.MinimumSize.Height)
                    {
                        expanderconsultas = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnuconsultas.Height += 10;
                    if (mnuconsultas.Height == mnuconsultas.MaximumSize.Height)
                    {
                        expanderconsultas = true;
                        tmrsubmenu.Stop();
                    }
                }
            }

            if (opcion.Equals("mnuconfiguraciones"))
            {
                if (expanderconfiguraciones)
                {
                    mnuconfiguraciones.Height -= 10;
                    if (mnuconfiguraciones.Height == mnuconfiguraciones.MinimumSize.Height)
                    {
                        expanderconfiguraciones = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnuconfiguraciones.Height += 10;
                    if (mnuconfiguraciones.Height == mnuconfiguraciones.MaximumSize.Height)
                    {
                        expanderconfiguraciones = true;
                        tmrsubmenu.Stop();
                    }
                }
            }

            if (opcion.Equals("mnureportes"))
            {
                if (expanderreportes)
                {
                    mnureportes.Height -= 10;
                    if (mnureportes.Height == mnureportes.MinimumSize.Height)
                    {
                        expanderreportes = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnureportes.Height += 10;
                    if (mnureportes.Height == mnureportes.MaximumSize.Height)
                    {
                        expanderreportes = true;
                        tmrsubmenu.Stop();
                    }
                }
            }
        }

        private void btnalmacen_Click(object sender, EventArgs e)
        {
            opcion = "mnualmacen";
            tmrsubmenu.Start();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            opcion = "mnucompras";
            tmrsubmenu.Start();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            opcion = "mnuventas";
            tmrsubmenu.Start();
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            opcion = "mnuconsultas";
            tmrsubmenu.Start();
        }

        private void btnconfiguraciones_Click(object sender, EventArgs e)
        {
            opcion = "mnuconfiguraciones";
            tmrsubmenu.Start();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            opcion = "mnureportes";
            tmrsubmenu.Start();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmListadoCliente frm = new FrmListadoCliente();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmListadoProducto frm = new FrmListadoProducto();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cajeroActual = lblNombre.Text + " " + lblApellido.Text;

            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmVenta frm = new FrmVenta(cajeroActual);

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cajeroActual = lblNombre.Text + " " + lblApellido.Text;

            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmCompra frm = new FrmCompra(cajeroActual);

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmListadoEmpleado frm = new FrmListadoEmpleado();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // Cerramos el formulario actual (FrmInicio)
                this.Close();

                // Creamos y mostramos el formulario de Login nuevamente
                Login frmLogin = new Login();
                frmLogin.Show();
            }
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmListadoCategoria frm = new FrmListadoCategoria();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmListadoProducto frm = new FrmListadoProducto();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();

        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmListadoProveedor frm = new FrmListadoProveedor();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();
        }

        private void btngenerarventa_Click(object sender, EventArgs e)
        {
            string cajeroActual = lblNombre.Text + " " + lblApellido.Text;

            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmVenta frm = new FrmVenta(cajeroActual);

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            string cajeroActual = lblNombre.Text + " " + lblApellido.Text;

            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmListadoCliente frm = new FrmListadoCliente();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmListadoEmpleado frm = new FrmListadoEmpleado();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmListadoUsuario frm = new FrmListadoUsuario();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();
        }

        private void btnreportecategorias_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            // 2. Creamos la ventana nueva
            FrmReporteCategoria frm = new FrmReporteCategoria();

            frm.MdiParent = this;

            frm.FormBorderStyle = FormBorderStyle.None;

            // 3. ESTIRAR LA VENTANA (Para que no quede flotando y se vea como página web)
            frm.Dock = DockStyle.Fill;

            // 4. Mostramos la ventana
            frm.Show();
        }
    }
}
