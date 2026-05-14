using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCompra : Form
    {
        // Variable para guardar el nombre del usuario conectado
        private string nombreUsuario;

        // 1. CONSTRUCTOR MODIFICADO: Recibe el nombre desde el menú de inicio
        public FrmCompra(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            LlenarComboProveedores();
            LlenarComboUsuarios();
        }

        // =========================================================================
        // LLENAR COMBOBOX DE PROVEEDORES Y USUARIOS
        // =========================================================================
        public void LlenarComboProveedores()
        {
            try
            {
                DataTable dt = CNProveedor.Listar();
                cbproveedor.DataSource = dt;
                cbproveedor.DisplayMember = "razonsocial"; 
                cbproveedor.ValueMember = "idproveedor";
                cbproveedor.SelectedIndex = -1;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Atención, error al cargar proveedores: " + ex.Message, "DonRoberton");
            }
        }

        public void LlenarComboUsuarios()
        {
            cbcajero.Items.Clear(); // Asegúrate de que tu ComboBox se llame cbusuario o cbcajero
            cbcajero.Items.Add(nombreUsuario);
            cbcajero.SelectedIndex = 0;
            cbcajero.Enabled = false;
        }

        // =========================================================================
        // MÉTODO PUENTE: Recibe los productos desde el buscador
        // =========================================================================
        public void AgregarProductoDetalle(int idProducto, string nombre, int cantidad, decimal precioCompra)
        {
            decimal subtotal = cantidad * precioCompra;

            // Agrega a la tabla (Asegúrate de que tus columnas se llamen así)
            dlistadocompra.Rows.Add(idProducto, nombre, cantidad, precioCompra, subtotal);
            CalcularGranTotal();
        }

        // =========================================================================
        // BOTONES DE AGREGAR Y ELIMINAR PRODUCTOS
        // =========================================================================
        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProductoCompra buscador = new FrmSeleccionarProductoCompra();
            buscador.Owner = this;

            // 1. Abrimos la ventana y esperamos a ver si el cajero le dio al botón "Agregar" (DialogResult.OK)
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                // 2. Si dio OK, recorremos la tablita temporal que llenó el buscador
                foreach (DataRow fila in buscador.ProductosSeleccionados.Rows)
                {
                    // 3. Extraemos los datos respetando los nombres de tu DataTable
                    int id = Convert.ToInt32(fila["idproducto"]);
                    string nombre = fila["nombre"].ToString();
                    decimal precioCompra = Convert.ToDecimal(fila["precio_compra"]);
                    int cantidad = Convert.ToInt32(fila["cantidad"]);

                    // 4. Usamos tu método puente para meterlos al DataGridView y sumar el Total
                    this.AgregarProductoDetalle(id, nombre, cantidad, precioCompra);
                }
            }
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlistadocompra.CurrentRow != null && !dlistadocompra.CurrentRow.IsNewRow)
                {
                    DialogResult opcion = MessageBox.Show("¿Desea quitar este producto de la compra?", "DonRoberton", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcion == DialogResult.Yes)
                    {
                        dlistadocompra.Rows.RemoveAt(dlistadocompra.CurrentRow.Index);
                        this.CalcularGranTotal();
                        MessageBox.Show("Producto eliminado de la lista.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione el producto que desea eliminar.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        // =========================================================================
        // CÁLCULOS MATEMÁTICOS
        // =========================================================================
        private void CalcularGranTotal()
        {
            decimal subtotalAcumulado = 0;
            decimal porcentajeIva = 0.16m; // La "m" es para indicar que es tipo decimal

            foreach (DataGridViewRow fila in dlistadocompra.Rows)
            {
                if (fila.Cells["cantidad"].Value != null && fila.Cells["precio_unit"].Value != null)
                {
                    decimal cant = Convert.ToDecimal(fila.Cells["cantidad"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["precio_unit"].Value);
                    subtotalAcumulado += (cant * precio);
                }
            }

            decimal ivaCalculado = subtotalAcumulado * porcentajeIva;
            decimal totalFinal = subtotalAcumulado + ivaCalculado;

            tboxsubtotal.Text = subtotalAcumulado.ToString("N2");
            tboxiva.Text = ivaCalculado.ToString("N2");
            tboxtotal.Text = totalFinal.ToString("N2");
        }

        // =========================================================================
        // BOTÓN: REALIZAR COMPRA
        // =========================================================================
        private void btnrealizarcompra_Click(object sender, EventArgs e)
        {
            // 1. VALIDAR PROVEEDOR
            if (cbproveedor.SelectedValue == null || cbproveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un proveedor válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idProveedorFinal = Convert.ToInt32(cbproveedor.SelectedValue);

            try
            {
                // 2. VALIDACIONES DE SEGURIDAD
                if (dlistadocompra.Rows.Count == 0 || (dlistadocompra.AllowUserToAddRows && dlistadocompra.Rows.Count == 1))
                {
                    MessageBox.Show("No hay productos en la compra.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tboxtotal.Text))
                {
                    MessageBox.Show("El total no ha sido calculado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. PREPARAR LISTA DE DETALLES (Usando CDDetalleCompra)
                List<CDDetalleCompra> detalles = new List<CDDetalleCompra>();
                foreach (DataGridViewRow fila in dlistadocompra.Rows)
                {
                    if (fila.Cells["idproducto"].Value != null)
                    {
                        CDDetalleCompra det = new CDDetalleCompra();
                        det.Idproducto = Convert.ToInt32(fila.Cells["idproducto"].Value);
                        det.Cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);
                        det.Precio = Convert.ToDecimal(fila.Cells["precio_unit"].Value);
                        det.Total = det.Cantidad * det.Precio;

                        detalles.Add(det);
                    }
                }

                // 4. DATOS DEL DOCUMENTO
                // Asume que tienes un ComboBox para Tipo (Factura/Nota) y un TextBox para el Número
                string tipoDoc = "Factura"; // Puedes cambiarlo por: cbtipodocumento.Text si lo tienes
                string numDoc = "000001";   // Puedes cambiarlo por: txtnumdocumento.Text si lo tienes

                // 5. GUARDAR COMPRA
                string rpta = CNCompra.Guardar(
                    DateTime.Now,
                    numDoc, // Número de factura que te dio el proveedor
                    tipoDoc,
                    Convert.ToDecimal(tboxsubtotal.Text),
                    Convert.ToDecimal(tboxiva.Text),
                    Convert.ToDecimal(tboxtotal.Text),
                    idProveedorFinal,
                    2, // ID USUARIO TEMPORAL (Cambiar por el real luego)
                    detalles
                );

                // 6. RESPUESTA FINAL
                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("¡Compra Realizada con éxito!\nEl stock de estos productos aumentó en tu almacén.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar pantalla
                    dlistadocompra.Rows.Clear();
                    tboxsubtotal.Clear();
                    tboxiva.Clear();
                    tboxtotal.Clear();
                    cbproveedor.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Error al guardar la compra: " + rpta, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: " + ex.Message, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    }
}