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
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

       
  

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            LlenarComboCategorias();

        }

        private void LlenarComboCategorias()
        {
            cbcategoria.DataSource = CNCategoria.Listar();
            cbcategoria.DisplayMember = "descripcion";
            cbcategoria.ValueMember = "idcategoria";
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    string.IsNullOrWhiteSpace(txtpreciocompra.Text) ||
                    string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                    string.IsNullOrWhiteSpace(txtstock.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios (Código, Nombre, Precios y Stock).",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene el proceso si falta algo
                }

                // --- PREPARACIÓN DE DATOS ---
                string rpta = "";

                string estado = rbtnactivo.Checked ? "Activo" : "Inactivo";

                // --- LLAMADA A LA CAPA DE NEGOCIO (CNProducto) ---
                rpta = CNProducto.Guardar(
                    txtcodigo.Text.Trim(),
                    txtnombre.Text.Trim(),
                    txtdescripcion.Text.Trim(),
                    dtimeingreso.Value,          
                    dtimevencimiento.Value,       
                    Convert.ToDouble(txtpreciocompra.Text),
                    Convert.ToDouble(txtprecioventa.Text),
                    Convert.ToInt32(txtstock.Text),
                    estado,
                    Convert.ToInt32(cbcategoria.SelectedValue) // El ID de la categoría del ComboBox
                );

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("¡Producto guardado exitosamente!", "Sistema de Ventas",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + rpta, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrese de que los precios y el stock tengan solamente numeros.",
                                "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message,
                                "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
            txtstock.Clear();
            rbtnactivo.Checked = true;
            cbcategoria.SelectedIndex = 0;
            dtimeingreso.Value = DateTime.Now;
            dtimevencimiento.Value = DateTime.Now;
        }
        private void btncancerlar_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}

