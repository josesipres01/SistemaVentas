using CapaNegocio;
using Microsoft.Reporting.WinForms; 
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteCategoria : Form
    {
        public FrmReporteCategoria()
        {
            InitializeComponent();
        }

        private void FrmReporteCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtenemos los datos
                DataTable dt = CNCategoria.Listar();

                // ---> LA PRUEBA DE FUEGO <---
                MessageBox.Show("Registros que llegaron a C#: " + dt.Rows.Count, "Prueba");

                // 2. Renombramos columnas
                if (dt.Columns.Count >= 2)
                {
                    dt.Columns[0].ColumnName = "Codigo";
                    dt.Columns[1].ColumnName = "Descripcion";
                }

                // 3. Limpiamos 
                reportViewer1.LocalReport.DataSources.Clear();

                // 4. USAMOS EL NOMBRE QUE SÍ ES CORRECTO: DsCategoria
                ReportDataSource rds = new ReportDataSource("DsCategoria", dt);

                // 5. Agregamos y refrescamos
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message, "DonRoberton");
            }
        }
    }
}