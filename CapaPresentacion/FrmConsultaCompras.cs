using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmConsultaVentas : Form
    {
        public FrmConsultaVentas()
        {
            InitializeComponent();
        }

        private void FrmConsultaVentas_Load(object sender, EventArgs e)
        {
            datetimeinicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            datetimefin.Value = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtenemos las fechas de los calendarios
                DateTime fechaInicio = datetimeinicio.Value;
                DateTime fechaFin = datetimefin.Value;

                // 2. Verificamos que la fecha de inicio no sea mayor a la final
                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La Fecha de Inicio no puede ser mayor a la Fecha Fin.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Llamamos a nuestra Capa de Negocio (El puente que hicimos antes)
                DataTable dt = CNVenta.BuscarFechas(fechaInicio, fechaFin);

                // 4. Llenamos el DataGridView
                dataGridView1.DataSource = dt;

                // 5. Pequeño aviso si no hay ventas
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas en este rango de fechas.", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            // 1. Validamos que haya datos en la tabla para no imprimir hojas en blanco
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el reporte. Realice una búsqueda primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Tomamos las fechas exactas de los calendarios
                DateTime inicio = datetimeinicio.Value;
                DateTime fin = datetimefin.Value;

                // 3. Abrimos el reporte y le pasamos las fechas
                FrmReporteConsultaVentas rpt = new FrmReporteConsultaVentas(inicio, fin);
                rpt.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnanular_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 1. Revisamos que no esté anulada ya
                string estadoActual = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
                if (estadoActual == "Anulada")
                {
                    MessageBox.Show("Esta venta ya se encuentra anulada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2. Pedimos confirmación
                DialogResult opcion = MessageBox.Show("¿Está seguro de anular esta venta?\nLos productos regresarán automáticamente al inventario.", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    int idVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idventa"].Value);

                    // 3. Llamamos al método Anular que acabamos de crear
                    string rpta = CNVenta.Anular(idVentaSeleccionada);

                    if (rpta == "OK")
                    {
                        MessageBox.Show("La venta se anuló correctamente y el stock fue restaurado.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Hacemos que se vuelva a presionar el botón "Buscar" de forma invisible 
                        // para que la tabla se refresque y muestre el nuevo estado "Anulada"
                        btnbuscar.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error al anular: " + rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione la venta que desea anular haciendo clic en su fila.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            {
                // 1. Verificamos que hayan seleccionado una fila en tu dataGridView1
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                        // 2. Extraemos el ID de la venta de la fila seleccionada
                        int idVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idventa"].Value);

                        // 3. Abrimos la ventanita nueva pasándole el ID que nos pedía el constructor
                        FrmDetalleVenta frm = new FrmDetalleVenta(idVentaSeleccionada);
                        frm.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al abrir el detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una venta de la lista haciendo clic en la fila.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}