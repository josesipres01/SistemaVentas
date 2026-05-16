using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmDetalleVenta : Form
    {
        private int _idVenta;

        public FrmDetalleVenta(int idVentaSeleccionada)
        {
            InitializeComponent();
            this._idVenta = idVentaSeleccionada;
            this.Load += new EventHandler(FrmDetalleVenta_Load);
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Llenar los datos de arriba (Cliente, Cajero, Fecha)
                // Usamos el método de la factura porque ya trae los nombres unidos
                DataTable dtCabecera = CNVenta.ImprimirFactura(_idVenta);
                
                if (dtCabecera != null && dtCabecera.Rows.Count > 0)
                {
                    // ¡OJO! Asegúrate de que tus cuadros de texto se llamen así:
                    txtCliente.Text = dtCabecera.Rows[0]["cliente"].ToString();
                    txtCajero.Text = dtCabecera.Rows[0]["trabajador"].ToString();
                    
                    DateTime fechaVenta = Convert.ToDateTime(dtCabecera.Rows[0]["fecha"]);
                    txtFecha.Text = fechaVenta.ToString("dd/MM/yyyy");
                    txtSubtotal.Text = Convert.ToDecimal(dtCabecera.Rows[0]["subtotal"]).ToString("N2");
                    txtIva.Text = Convert.ToDecimal(dtCabecera.Rows[0]["iva"]).ToString("N2");
                    txtTotal.Text = Convert.ToDecimal(dtCabecera.Rows[0]["total_pagar"]).ToString("N2");
                }

                // 2. Llenar la tabla con los productos
                DataTable dtDetalle = CNVenta.MostrarDetalle(_idVenta);
                
                // Asegúrate que tu tabla se llame dlistadoDetalle
                dataGridView1.DataSource = dtDetalle; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles: " + ex.Message, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Solo llamamos al formulario que ya diseñaste pasándole el mismo ID
            FrmReporteFactura rpt = new FrmReporteFactura(_idVenta);
            rpt.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}