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
    public partial class FrmReporteEmpleado : Form
    {
        public FrmReporteEmpleado()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmReporteEmpleado_Load);

        }

        private void FrmReporteEmpleado_Load(object sender, EventArgs e)
        {

            try
            {
                // 1. Traemos TODOS los datos de los empleados desde la base de datos
                // Asegúrate de tener el método Listar() en tu clase CNEmpleado
                DataTable dt = CNEmpleado.Listar();

                // 2. Limpiamos cualquier origen de datos previo en el visor
                reportViewer1.LocalReport.DataSources.Clear();

                // 3. Conectamos los datos al "DataSet1" (El nombre por defecto en tu diseño RDLC)
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                // 4. Se lo pasamos al visor y refrescamos para que dibuje la tabla
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de empleados: " + ex.Message, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}