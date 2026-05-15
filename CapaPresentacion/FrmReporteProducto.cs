using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteProducto : Form
    {
        public FrmReporteProducto()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmReporteProducto_Load);
        }

        private void FrmReporteProducto_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Traemos TODOS los datos de los productos
                DataTable dt = CNProducto.Listar();

                // 2. Limpiamos
                reportViewer1.LocalReport.DataSources.Clear();

                // 3. Conectamos los datos al DataSet1 (El que tienes en tu diseño)
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                // 4. Se lo pasamos al visor y refrescamos
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de productos: " + ex.Message, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}