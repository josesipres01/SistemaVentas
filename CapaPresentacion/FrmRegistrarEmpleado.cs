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
    public partial class FrmRegistrarEmpleado : Form
    {
        public bool Insert = false;

        public bool Edit = false;

        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmRegistrarEmpleado_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtidempleado.Visible = false;

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
                if (txtnombre.Text == "" || txtapellidos.Text == "")
                {
                    MessageBox.Show("Ingrese un Empleado", "Sistema de ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (Insert)
                    {
                        CNEmpleado.Guardar(txtnombre.Text, txtapellidos.Text,
                            txtdni.Text, txttelefono.Text, txtdireccion.Text, estado);
                        MessageBox.Show("Empleado Registrado", "Sistema de ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Edit)
                    {
                        CNEmpleado.Editar(Convert.ToInt32(txtidempleado.Text),
                            txtnombre.Text, txtapellidos.Text, txtdni.Text,
                            txttelefono.Text, txtdireccion.Text, estado);
                        MessageBox.Show("Empleado Editado", "Sistema de ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Insert = false;
                    Edit = false;

                    FrmListadoEmpleado form = new FrmListadoEmpleado();
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
            FrmListadoEmpleado form = new FrmListadoEmpleado();
            form.Show();
            this.Hide();
        }
    }
}

