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
    public partial class FrmRegistrarProducto : Form
    {

        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

       
  

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
                
            LlenarComboCategorias();


        }

        private void LlenarComboCategorias()
        {
            cbidcategoria.DataSource = CNCategoria.Listar();
            cbidcategoria.DisplayMember = "descripcion";
            cbidcategoria.ValueMember = "idcategoria";
        }

 private void btnguardar_Click_1(object sender, EventArgs e)
{
    try
    {
        if (string.IsNullOrWhiteSpace(txtcodigo.Text) || string.IsNullOrWhiteSpace(txtnombre.Text) ||
            string.IsNullOrWhiteSpace(txtpreciocompra.Text) || string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
            string.IsNullOrWhiteSpace(txtcantidad.Text))
        {
            MessageBox.Show("Por favor, complete todos los campos obligatorios (Código, Precio Compra y Cantidad).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string rpta = "";
        string estado = rbactivo.Checked ? "Activo" : "Inactivo";

        if (this.Edit)
        {
            rpta = CNProducto.Editar(
                Convert.ToInt32(txtidproducto.Text),
                txtcodigo.Text.Trim(),
                txtnombre.Text.Trim(),
                txtdescripcion.Text.Trim(),
                dtfechaingreso.Value,
                dtfechavencimiento.Value,
                Convert.ToDouble(txtpreciocompra.Text),
                Convert.ToDouble(txtprecioventa.Text),
                Convert.ToInt32(txtcantidad.Text),
                estado,
                Convert.ToInt32(cbidcategoria.SelectedValue));
        }
        else
        {
            rpta = CNProducto.Guardar(
                txtcodigo.Text.Trim(),
                txtnombre.Text.Trim(),
                txtdescripcion.Text.Trim(),
                dtfechaingreso.Value,
                dtfechavencimiento.Value,
                Convert.ToDouble(txtpreciocompra.Text),
                Convert.ToDouble(txtprecioventa.Text),
                Convert.ToInt32(txtcantidad.Text),
                estado,
                Convert.ToInt32(cbidcategoria.SelectedValue));
        }

        if (rpta.Equals("OK"))
        {
            string mensaje = this.Edit ? "¡Producto editado exitosamente!" : "¡Producto guardado exitosamente!";
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Edit = false;
            FrmListadoProducto form = new FrmListadoProducto();
            form.Show();
           this.Hide();
         }
        else
        {
            MessageBox.Show("Error: " + rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    catch (FormatException)
    {
        MessageBox.Show("Asegúrese de que los precios y el stock tengan solamente números.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Ocurrió un error: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void LimpiarControles()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
            txtcantidad.Clear();
            rbactivo.Checked = true;
            cbidcategoria.SelectedIndex = 0;
            dtfechaingreso.Value = DateTime.Now;
            dtfechavencimiento.Value = DateTime.Now;
        }
        private void btncancerlar_Click(object sender, EventArgs e)
        {
            FrmListadoProducto form = new FrmListadoProducto();
            form.Show();
            this.Hide();
        }

        private void validaciónPrecio(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dtfechavencimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

