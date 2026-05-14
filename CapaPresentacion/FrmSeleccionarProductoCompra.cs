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
    public partial class FrmSeleccionarProductoCompra : Form
    {
        public DataTable ProductosSeleccionados = new DataTable();

        public bool Insert = false;
        public bool Edit = false;
        string criterioBusqueda;

        public FrmSeleccionarProductoCompra()
        {
            InitializeComponent();
        }

        private void FrmSeleccionarProductoCompra_Load(object sender, EventArgs e)
        {
            dseleccionar.AutoGenerateColumns = false;
            dseleccionar.DataSource = CNProducto.Listar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            ProductosSeleccionados.Rows.Clear();
            ProductosSeleccionados = new DataTable();
            ProductosSeleccionados.Columns.Add("idproducto", typeof(int));
            ProductosSeleccionados.Columns.Add("nombre", typeof(string));

            // OJO AQUÍ: Usamos decimal y se llamará precio_compra en lugar de precio_venta
            ProductosSeleccionados.Columns.Add("precio_compra", typeof(decimal));
            ProductosSeleccionados.Columns.Add("cantidad", typeof(int));

            bool haySeleccion = false;

            foreach (DataGridViewRow fila in dseleccionar.Rows)
            {
                // Revisamos si tiene la palomita
                bool isChecked = Convert.ToBoolean(fila.Cells["chkSeleccionar"].Value);

                if (isChecked)
                {
                    haySeleccion = true;

                    // NOTA: Asegúrate que la columna en tu diseño se llame "cantidad_compra" (o adaptalo al nombre que le pusiste)
                    var celdaCant = fila.Cells["cantidad_compra"].Value;
                    int cantidadPedida = (celdaCant == null || string.IsNullOrWhiteSpace(celdaCant.ToString()))
                                         ? 1 : Convert.ToInt32(celdaCant);

                    // --- VALIDACIÓN ÚNICA: CERO O NEGATIVOS ---
                    // Eliminamos la validación de stock porque estamos SURTIENDO el inventario
                    if (cantidadPedida <= 0)
                    {
                        MessageBox.Show("La cantidad a comprar debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ProductosSeleccionados.Rows.Clear();
                        return;
                    }

                    // Extraemos el Precio de Compra (Asegúrate que la columna se llame "precio_compra")
                    decimal precioCompra = Convert.ToDecimal(fila.Cells["precio_compra"].Value);

                    // Agregamos a la tabla temporal
                    ProductosSeleccionados.Rows.Add(
                        fila.Cells["idproducto"].Value,
                        fila.Cells["nombre"].Value,
                        precioCompra,
                        cantidadPedida
                    );
                }
            }

            // --- VALIDACIÓN FINAL: ¿SELECCIONÓ ALGO? ---
            if (haySeleccion == false)
            {
                MessageBox.Show("Debe seleccionar al menos un producto con la palomita.",
                                "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Si todo está bien, mandamos el OK y cerramos
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dseleccionar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que la columna editada sea la de "Cantidad"
            if (dseleccionar.Columns[e.ColumnIndex].Name == "cantidad_compra") // Asegúrate del nombre
            {
                var valorCelda = dseleccionar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (valorCelda != null)
                {
                    // Solo validamos que no metan letras o números negativos
                    int cant;
                    if (!int.TryParse(valorCelda.ToString(), out cant) || cant <= 0)
                    {
                        MessageBox.Show("Por favor, ingrese una cantidad válida y mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dseleccionar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1; // Reseteamos a 1
                    }
                }
            }
        }

        //Método para buscar por nombre
        public void BuscarNombre()
        {
            this.dseleccionar.DataSource = CNProducto.BuscarNombre(this.txtbuscar.Text);
        }

        //Método para buscar por código
        public void BuscarCódigo()
        {
            this.dseleccionar.DataSource = CNProducto.BuscarCodigo(this.txtbuscar.Text);
        }

        private void rbtnnombre_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "Nombre";
            BuscarNombre();
        }

        private void rbtnrfc_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "Código";
            BuscarCódigo();
        }
    }
}