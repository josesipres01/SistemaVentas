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

        public FrmInicio()
        {
            InitializeComponent();
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
    }
}
