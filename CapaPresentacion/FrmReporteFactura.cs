using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteFactura : Form
    {
        // Variable para recibir el ID de la venta que acabamos de hacer
        private int idVentaActual;

        // Constructor modificado para recibir el ID
        public FrmReporteFactura(int idVenta)
        {
            InitializeComponent();
            this.idVentaActual = idVenta;
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtenemos TODOS los datos de la factura desde la BD
                DataTable dt = CNVenta.ImprimirFactura(idVentaActual);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // 2. Extraemos los datos únicos (de la fila 0) para los Parámetros
                    DataRow fila = dt.Rows[0];

                    // CREAMOS LOS 9 PARÁMETROS EXACTOS QUE TIENES EN TU DISEÑO .RDLC
                    ReportParameter[] prm = new ReportParameter[9];
                    prm[0] = new ReportParameter("prmFolio", fila["folio"].ToString());
                    prm[1] = new ReportParameter("prmCliente", fila["cliente"].ToString());
                    prm[2] = new ReportParameter("prmDocumento", fila["documento"].ToString());

                    // Si no tienes teléfono en tu BD, esto evita que marque error
                    string telefono = dt.Columns.Contains("telefono") ? fila["telefono"].ToString() : "N/A";
                    prm[3] = new ReportParameter("prmTelefono", telefono);

                    prm[4] = new ReportParameter("prmTrabajador", fila["trabajador"].ToString());

                    // Formateamos la fecha y los dineros
                    DateTime fecha = Convert.ToDateTime(fila["fecha"]);
                    prm[5] = new ReportParameter("prmFecha", fecha.ToString("dddd, dd 'de' MMMM 'de' yyyy"));
                    prm[6] = new ReportParameter("prmSubtotal", Convert.ToDecimal(fila["subtotal"]).ToString("N2"));
                    prm[7] = new ReportParameter("prmIva", Convert.ToDecimal(fila["iva"]).ToString("N2"));
                    prm[8] = new ReportParameter("prmTotalPagar", Convert.ToDecimal(fila["total_pagar"]).ToString("N2"));

                    // 3. ¡ESTA ES LA LÍNEA MÁGICA QUE ENVÍA LOS PARÁMETROS AL REPORTE!
                    reportViewer1.LocalReport.SetParameters(prm);

                    // 4. Renombramos las columnas de la tabla de detalles para que coincidan
                    if (dt.Columns.Contains("codigo")) dt.Columns["codigo"].ColumnName = "codigo";
                    if (dt.Columns.Contains("descripcion")) dt.Columns["descripcion"].ColumnName = "descripcion";
                    if (dt.Columns.Contains("precio")) dt.Columns["precio"].ColumnName = "precio";
                    if (dt.Columns.Contains("cantidad")) dt.Columns["cantidad"].ColumnName = "cantidad";
                    if (dt.Columns.Contains("subtotal_fila")) dt.Columns["subtotal_fila"].ColumnName = "subtotal_fila";

                    // 5. Enviamos la lista de productos al reporte
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // 6. Dibuja el reporte en pantalla
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos en la base de datos para esta factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento vacío para evitar errores del diseñador
        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}