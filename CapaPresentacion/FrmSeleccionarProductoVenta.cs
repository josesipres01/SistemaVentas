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
    public partial class FrmSeleccionarProductoVenta : Form

    {
        public DataTable ProductosSeleccionados = new DataTable();

        public bool Insert = false;
        public bool Edit = false;
        string criterioBusqueda;



        public FrmSeleccionarProductoVenta()
        {
            InitializeComponent();

        }

        private void FrmSeleccionarProductoVenta_Load(object sender, EventArgs e)
        {
            dseleccionar.AutoGenerateColumns = false;
            dseleccionar.DataSource = CNProducto.Listar(); // Usamos tu capa de negocio

        }

 
        private void btnagregar_Click(object sender, EventArgs e)
        {
            ProductosSeleccionados.Rows.Clear();
            ProductosSeleccionados = new DataTable();
            ProductosSeleccionados.Columns.Add("idproducto", typeof(int));
            ProductosSeleccionados.Columns.Add("nombre", typeof(string));
            ProductosSeleccionados.Columns.Add("precio_venta", typeof(double));
            ProductosSeleccionados.Columns.Add("cantidad", typeof(int));
            bool haySeleccion = false;

            foreach (DataGridViewRow fila in dseleccionar.Rows)
            {
                // Revisamos si tiene la palomita
                bool isChecked = Convert.ToBoolean(fila.Cells["chkSeleccionar"].Value);

                if (isChecked)
                {
                    haySeleccion = true;

                    // --- CAPTURA DE DATOS ---
                    int stockDisponible = Convert.ToInt32(fila.Cells["stock"].Value);

                    // Validamos que la celda de cantidad no sea nula o vacía
                    var celdaCant = fila.Cells["cantidad_venta"].Value;
                    int cantidadPedida = (celdaCant == null || string.IsNullOrWhiteSpace(celdaCant.ToString()))
                                         ? 1 : Convert.ToInt32(celdaCant);

                    // --- VALIDACIÓN 1: STOCK ---
                    if (cantidadPedida > stockDisponible)
                    {
                        MessageBox.Show("No puedes agregar " + cantidadPedida + " unidades de '" +
                                        fila.Cells["nombre"].Value + "'. \nSolo quedan " + stockDisponible + " en stock.",
                                        "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // IMPORTANTE: Limpiamos lo que se haya acumulado en este clic y nos salimos SIN CERRAR
                        ProductosSeleccionados.Rows.Clear();
                        return;
                    }

                    // --- VALIDACIÓN 2: CERO O NEGATIVOS ---
                    if (cantidadPedida <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ProductosSeleccionados.Rows.Clear();
                        return;
                    }

                    // Si pasó las validaciones, agregamos a la tabla temporal
                    ProductosSeleccionados.Rows.Add(
                        fila.Cells["idproducto"].Value,
                        fila.Cells["nombre"].Value,
                        fila.Cells["precio_venta"].Value,
                        cantidadPedida
                    );
                }
            }

            // --- VALIDACIÓN FINAL: ¿SELECCIONÓ ALGO? ---
            if (haySeleccion == false)
            {
                MessageBox.Show("Debe seleccionar al menos un producto con la palomita.",
                                "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Detiene el código aquí y NO cierra la ventana
            }

            // SI EL CÓDIGO LLEGÓ HASTA AQUÍ, es porque todo está perfecto
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void dseleccionar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que la columna editada sea la de "Cantidad"
            if (dseleccionar.Columns[e.ColumnIndex].Name == "cantidad")
            {
                int stock = Convert.ToInt32(dseleccionar.Rows[e.RowIndex].Cells["stock"].Value);
                var valorCelda = dseleccionar.Rows[e.RowIndex].Cells["cantidad"].Value;

                if (valorCelda != null)
                {
                    int cant = Convert.ToInt32(valorCelda);

                    if (cant > stock)
                    {
                        MessageBox.Show("La cantidad ingresada supera el stock disponible (" + stock + ").",
                                        "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // Opcional: Resetear la celda al máximo disponible
                        dseleccionar.Rows[e.RowIndex].Cells["cantidad"].Value = stock;
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
