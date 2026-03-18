using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistrarProveedor : Form
    {
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtidproveedor.Visible = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (rbtnactivo.Checked)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "INACTIVO";
            }

            try
            {
                if (this.txtrazonsocial.Text == "" || this.txtdni.Text == "")
                {
                    MessageBox.Show("Ingrese un Proveedor",
                        "Sistema de ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (this.Insert)
                    {
                        CNProveedor.Guardar(this.txtrazonsocial.Text, this.txtdni.Text,
                            txtrfc.Text, txttelefono.Text, txtdireccion.Text, estado);
                        MessageBox.Show("Proveedor Registrado",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }


                    else if (this.Edit)
                    {
                        CNProveedor.Editar(Convert.ToInt32(this.txtidproveedor.Text),
                            this.txtrazonsocial.Text, this.txtdni.Text, txtrfc.Text,
                            txttelefono.Text, txtdireccion.Text, estado);
                        MessageBox.Show("Proveedor Editado",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoProveedor form = new FrmListadoProveedor();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + Ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoProveedor form = new FrmListadoProveedor();
            form.Show();
            this.Hide();
        }
    }
}