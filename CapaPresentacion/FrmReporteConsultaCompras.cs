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
    public partial class FrmReporteConsultaCompras : Form
    {
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        public FrmReporteConsultaCompras(DateTime inicio, DateTime fin)
        {
            InitializeComponent();
            this._fechaInicio = inicio;
            this._fechaFin = fin;
            this.Load += new EventHandler(FrmReporteConsultaCompras_Load);
        }

        private void FrmReporteConsultaCompras_Load(object sender, EventArgs e)
        {

            try
            {
                // 1. Buscamos las compras en ese rango de fechas
                DataTable dt = CNCompra.BuscarFechas(_fechaInicio, _fechaFin);

                // 2. Enviamos las fechas a los parámetros del reporte (.rdlc)
                ReportParameter[] prm = new ReportParameter[2];
                prm[0] = new ReportParameter("prmFechaInicio", _fechaInicio.ToString("dd/MM/yyyy"));
                prm[1] = new ReportParameter("prmFechaFin", _fechaFin.ToString("dd/MM/yyyy"));

                reportViewer1.LocalReport.SetParameters(prm);

                // 3. Limpiamos y enlazamos la tabla
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 4. Refrescamos para que se pinte en pantalla
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
