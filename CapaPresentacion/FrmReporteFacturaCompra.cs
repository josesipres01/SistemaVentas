using CapaNegocio;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporteFacturaCompra : Form
    {
        private int _idCompraActual;

        public FrmReporteFacturaCompra(int idCompra)
        {
            InitializeComponent();
            this._idCompraActual = idCompra;
            this.Load += new EventHandler(FrmReporteFacturaCompra_Load);
        }

        private void FrmReporteFacturaCompra_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                // 2. Traemos la información del encabezado (Proveedor, Total, etc)
                DataTable dtCabecera = CNCompra.ImprimirCompra(_idCompraActual);

                // 3. Traemos la lista de productos de esta compra
                DataTable dtDetalles = CNCompra.MostrarDetalle(_idCompraActual);

                if (dtCabecera != null && dtCabecera.Rows.Count > 0)
                {
                    DataRow fila = dtCabecera.Rows[0];

                    // 4. Llenamos los parámetros del diseño
                    ReportParameter[] prm = new ReportParameter[7];
                    prm[0] = new ReportParameter("prmFolio", "Compra #" + fila["idcompra"].ToString());
                    prm[1] = new ReportParameter("prmProveedor", fila["proveedor"].ToString());
                    prm[2] = new ReportParameter("prmCajero", fila["empleado"].ToString());

                    DateTime fecha = Convert.ToDateTime(fila["fecha"]);
                    prm[3] = new ReportParameter("prmFecha", fecha.ToString("dd/MM/yyyy"));
                    prm[4] = new ReportParameter("prmSubtotal", Convert.ToDecimal(fila["subtotal"]).ToString("N2"));
                    prm[5] = new ReportParameter("prmIva", Convert.ToDecimal(fila["iva"]).ToString("N2"));
                    prm[6] = new ReportParameter("prmTotal", Convert.ToDecimal(fila["total"]).ToString("N2"));


                    reportViewer1.LocalReport.SetParameters(prm);

                    // 5. Truco para asegurar que las columnas coincidan 100% con tu DataSet
                    if (dtDetalles.Columns.Count >= 5)
                    {
                        dtDetalles.Columns[0].ColumnName = "codigo";
                        dtDetalles.Columns[1].ColumnName = "producto";
                        dtDetalles.Columns[2].ColumnName = "cantidad";
                        dtDetalles.Columns[3].ColumnName = "precio_unitario";
                        dtDetalles.Columns[4].ColumnName = "subtotal";
                    }

                    // 6. Pasamos la tabla de productos al reporte
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rds = new ReportDataSource("DataSet1", dtDetalles);
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para imprimir esta compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
 }

