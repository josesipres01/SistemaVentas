using CapaDatos;
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
    public partial class FrmDetalleCompra : Form
    {
        private int _idCompra;

        public FrmDetalleCompra(int idCompraSeleccionada)
        {
            InitializeComponent();
            this._idCompra = idCompraSeleccionada;
            this.Load += new EventHandler(FrmDetalleCompra_Load);
        }

        private void FrmDetalleCompra_Load(object sender, EventArgs e)
        {
            try
            {
                // Ponemos el número de compra en la ventana
                this.Text = "Detalle de Compra #" + _idCompra;

                // 2. Llenar los datos de arriba (Proveedor, Cajero, Fecha, Total)
                DataTable dtCabecera = CNCompra.ImprimirCompra(_idCompra);

                if (dtCabecera != null && dtCabecera.Rows.Count > 0)
                {
                    // Llenamos los datos generales
                    txtProveedor.Text = dtCabecera.Rows[0]["proveedor"].ToString();
                    txtCajero.Text = dtCabecera.Rows[0]["empleado"].ToString();

                    DateTime fechaCompra = Convert.ToDateTime(dtCabecera.Rows[0]["fecha"]);
                    txtFecha.Text = fechaCompra.ToString("dd/MM/yyyy");

                    txtSubtotal.Text = Convert.ToDecimal(dtCabecera.Rows[0]["subtotal"]).ToString("N2");
                    txtIva.Text = Convert.ToDecimal(dtCabecera.Rows[0]["iva"]).ToString("N2");
                    txtTotal.Text = Convert.ToDecimal(dtCabecera.Rows[0]["total"]).ToString("N2");
                }

                // 3. Llenar la tabla con los productos de esta compra
                DataTable dtDetalle = CNCompra.MostrarDetalle(_idCompra);

                // Asegúrate que tu DataGridView se llame dlistadoDetalle
                dataGridView1.DataSource = dtDetalle;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles: " + ex.Message, "DonRoberton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            FrmReporteFacturaCompra rpt = new FrmReporteFacturaCompra(_idCompra);
            rpt.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
