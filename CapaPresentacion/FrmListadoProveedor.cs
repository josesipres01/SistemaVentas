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
    public partial class FrmListadoProveedor : Form
    {
        public FrmListadoProveedor()
        {
            InitializeComponent();
            this.Mostrar();
        }

        private void FrmListadoProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CNProveedor.Listar();
        }

        public void BuscarRazonsocial()
        {
            this.dlistado.DataSource = CNProveedor.BuscarRazonsocial(txtbuscar.Text);
        }

        public void BuscarDni()
        {
            this.dlistado.DataSource = CNProveedor.BuscarDni(txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnrazonsocial.Checked)
            {
                this.BuscarRazonsocial();
            }
            else if (rbtndni.Checked)
            {
                this.BuscarDni();
            }
            else
            {
                MessageBox.Show("Ingrese un criterio de busqueda",
                    "Sistema de ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarProveedor form = new FrmRegistrarProveedor();
            form.Show();
            form.Insert = true;
            form.Edit = false;
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarProveedor form = new FrmRegistrarProveedor();
            form.Edit = true;
            form.Insert = false;

            form.txtidproveedor.Text = this.dlistado.CurrentRow.Cells["idproveedor"].Value.ToString();
            form.txtrazonsocial.Text = this.dlistado.CurrentRow.Cells["razonsocial"].Value.ToString();
            form.txtdni.Text = this.dlistado.CurrentRow.Cells["dni"].Value.ToString();
            form.txtrfc.Text = this.dlistado.CurrentRow.Cells["rfc"].Value.ToString();
            form.txttelefono.Text = this.dlistado.CurrentRow.Cells["telefono"].Value.ToString();
            form.txtdireccion.Text = this.dlistado.CurrentRow.Cells["direccion"].Value.ToString();

            string estado = Convert.ToString(this.dlistado.CurrentRow.Cells["estado"].Value);
            if (estado == "ACTIVO")
            {
                form.rbtnactivo.Checked = true;
            }
            else
            {
                form.rbtninactivo.Checked = true;
            }

            form.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult op;
                op = MessageBox.Show("Realmente desea eliminar el registro",
                    "Sistema de ventas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0)
                {
                    if (op == DialogResult.OK)
                    {
                        string idproveedor = dlistado.CurrentRow.Cells["idproveedor"].Value.ToString();
                        CNProveedor.Eliminar(Convert.ToInt32(idproveedor.ToString()));
                        MessageBox.Show("Rigistro eliminado",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Mostrar();
                    }
                }
                this.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
