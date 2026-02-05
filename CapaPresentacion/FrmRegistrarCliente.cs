
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmRegistrarCliente : Form
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarCliente()
        {
            InitializeComponent();

        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (rbtnactivo.Checked == true)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "INACTIVO";
            }

            try
            {
                if (this.txtnombre.Text == string.Empty && this.txtapellidos.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del cliente", "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNCliente.Guardar(this.txtnombre.Text,
                                          this.txtapellidos.Text,
                                          this.txtdni.Text,
                                          this.txtrfc.Text,
                                          this.txttelefono.Text,
                                          estado);
                        MessageBox.Show("Cliente registrado correctamente", "Sistema de Ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (this.Edit == true)
                    {
                        CNCliente.Editar(Convert.ToInt32(this.txtidcliente.Text),
                                         this.txtnombre.Text,
                                         this.txtapellidos.Text,
                                         this.txtdni.Text,
                                         this.txtrfc.Text,
                                         this.txttelefono.Text,
                                         estado);
                        MessageBox.Show("Cliente editado correctamente", "Sistema de Ventas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoCliente form = new FrmListadoCliente();
                    form.Show();
                    this.Hide();
                }
            } catch (Exception ex) {

            }
            
        }

        private void btncancerlar_Click(object sender, EventArgs e)
        {
        FrmListadoCliente form=new FrmListadoCliente();
            form.Show();
            this.Hide();
        }
    } 
        
}


    

