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
    public partial class FrmRegistrarUsuario : Form
    {
        public bool Insert = false;
        public bool Edit = false;


        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtidempleado.Visible = false;
            txtidusuario.Visible = false;

        }

        private void btnbuscarempleado_Click(object sender, EventArgs e)
        {
            FrmVistaEmpleado form = new FrmVistaEmpleado();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                txtidempleado.Text = Convert.ToString(form.dlistado.CurrentRow.Cells["idempleado"].Value);
            }

            txtnombre.Text = Convert.ToString(form.dlistado.CurrentRow.Cells["nombre"].Value);
            txtapellidos.Text = Convert.ToString(form.dlistado.CurrentRow.Cells["apellidos"].Value);


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
                    MessageBox.Show("Ingrese un Empleado",
                        "Sistema de ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (this.Insert)
                    {
                        CNUsuario.Guardar(txtusuario.Text,
                            txtpassword.Text,
                            cboacceso.Text,
                            estado,
                            Convert.ToInt32(txtidempleado.Text));

                        MessageBox.Show("Usuario Registrado",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (this.Edit)
                    {
                        CNUsuario.Editar(Convert.ToInt32(txtidusuario.Text),
                            txtusuario.Text,
                            txtpassword.Text,
                            cboacceso.Text,
                            estado,
                            Convert.ToInt32(txtidempleado.Text));

                        MessageBox.Show("Usuario Editado",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoUsuario form = new FrmListadoUsuario();

                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + Ex.StackTrace);
            }


        }

        private void btncancerlar_Click(object sender, EventArgs e)
        {
            FrmListadoUsuario form = new FrmListadoUsuario();

            form.Show();
            this.Hide();

        }
    }
}
