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
    public partial class FrmConsultaCompra : Form
    {
        public FrmConsultaCompra()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = datetimeinicio.Value;
                DateTime fechaFin =  datetimefin.Value;

                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La Fecha de Inicio no puede ser mayor a la Fecha Fin.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamamos a la base de datos de COMPRAS
                DataTable dt = CNCompra.BuscarFechas(fechaInicio, fechaFin);

                // Llenamos el DataGridView (Asegúrate de que se llame dlistado)
                dataGridView1.DataSource = dt;

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron compras en este rango de fechas.", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar las compras: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el reporte. Busque primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime inicio = datetimeinicio.Value;
                DateTime fin = datetimefin.Value;

                // Deberás crear un FrmReporteConsultaCompras (igualito al de ventas)
                FrmReporteConsultaCompras rpt = new FrmReporteConsultaCompras(inicio, fin);
                rpt.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int idCompraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idcompra"].Value);

                    // Deberás crear un FrmDetalleCompra (igualito al FrmDetalleVenta)
                    FrmDetalleCompra frm = new FrmDetalleCompra(idCompraSeleccionada);
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al abrir el detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una compra de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string estadoActual = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
                if (estadoActual == "Anulada")
                {
                    MessageBox.Show("Esta compra ya se encuentra anulada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult opcion = MessageBox.Show("¿Está seguro de anular esta compra?\nLos productos se restarán automáticamente de su inventario.", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    // ¡OJO! Asegúrate que la columna de tu DataGridView se llame "idcompra"
                    int idCompraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idcompra"].Value);

                    string rpta = CNCompra.Anular(idCompraSeleccionada);

                    if (rpta == "OK")
                    {
                        MessageBox.Show("La compra se anuló correctamente y el stock fue actualizado.", "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnbuscar.PerformClick(); // Refresca la tabla
                    }
                    else
                    {
                        MessageBox.Show("Error al anular: " + rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione la compra que desea anular.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmConsultaCompra_Load(object sender, EventArgs e)
        {
            datetimeinicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            datetimefin.Value = DateTime.Now;
        }
    }
}
