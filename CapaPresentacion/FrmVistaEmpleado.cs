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
    public partial class FrmVistaEmpleado : Form
    {
        public FrmVistaEmpleado()
        {
            InitializeComponent();
        }

        private void FrmVistaEmpleado_Load(object sender, EventArgs e)
        {
            this.Mostrar();

        }
        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNEmpleado.BuscarNombre(txtbuscar.Text);
        }

        public void BuscarDni()
        {
            this.dlistado.DataSource = CNEmpleado.BuscarDni(txtbuscar.Text);
        }
    

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                this.BuscarNombre();
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

        private void dlistado_DoubleClick(object sender, EventArgs e)
        {
            if (dlistado.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
            this.Hide();

        }
        public void Mostrar()
        {
            this.dlistado.DataSource = CNEmpleado.Listar();
        }

    }
}
