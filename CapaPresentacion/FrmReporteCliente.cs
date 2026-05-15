using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteCliente : Form
    {
        public FrmReporteCliente()
        {
            InitializeComponent();
            // Aseguramos que el evento Load se ejecute siempre
            this.Load += new EventHandler(FrmReporteCliente_Load);
        }

        private void FrmReporteCliente_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Traemos TODOS los datos de los clientes desde la base de datos
                DataTable dt = CNCliente.Listar();

                // 2. Limpiamos cualquier origen de datos previo en el visor
                reportViewer1.LocalReport.DataSources.Clear();

                // 3. Conectamos los datos al "DataSet1" (El nombre que tienes en tu diseño RDLC)
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                // 4. Se lo pasamos al visor y refrescamos para que dibuje la tabla
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de clientes: " + ex.Message, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}