using CapaNegocio;
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
    public partial class FrmListadoEmpleado : Form
    {
        public FrmListadoEmpleado()
        {
            InitializeComponent();
        }

        private void FrmListadoEmpleado_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();


        }

        public void Mostrar()
        {
            dlistado.DataSource = CNEmpleado.Listar();
        }

        public void BuscarNombre()
        {
            dlistado.DataSource = CNEmpleado.BuscarNombre(txtbuscar.Text);
        }

        public void BuscarDni()
        {
            dlistado.DataSource = CNEmpleado.BuscarDni(txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rbtndni.Checked)
            {
                BuscarDni();
            }
            else
            {
                MessageBox.Show("Ingrese un criterio de busqueda",
                   "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado form = new FrmRegistrarEmpleado();
            form.Insert = true;
            form.Edit = false;
            form.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado form = new FrmRegistrarEmpleado();
            form.Edit = true;
            form.Insert = false;

            form.txtidempleado.Text = dlistado.CurrentRow.Cells["idempleado"].Value.ToString();
            form.txtnombre.Text = dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtapellidos.Text = dlistado.CurrentRow.Cells["apellidos"].Value.ToString();
            form.txtdni.Text = dlistado.CurrentRow.Cells["dni"].Value.ToString();
            form.txttelefono.Text = dlistado.CurrentRow.Cells["telefono"].Value.ToString();
            form.txtdireccion.Text = dlistado.CurrentRow.Cells["direccion"].Value.ToString();

            string estado = dlistado.CurrentRow.Cells["estado"].Value.ToString();
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
                op = MessageBox.Show("Realmente desea eliminar el registro", "Sistema de ventas",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0)
                {
                    if (op == DialogResult.OK)
                    {
                        string idempleado = dlistado.CurrentRow.Cells["idempleado"].Value.ToString();
                        CNEmpleado.Eliminar(Convert.ToInt32(idempleado.ToString()));
                        MessageBox.Show("Rigistro eliminado", "Sistema de ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                    }
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

