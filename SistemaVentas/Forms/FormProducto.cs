using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaVentas.Forms
{
    /// <summary>
    /// Pantalla de Registro/Edición de Productos con generación de código de barras.
    /// </summary>
    public class FormProducto : Form
    {
        private TextBox txtNombre, txtPrecioCompra, txtPrecioVenta, txtStock, txtStockMin, txtCodigo;
        private ComboBox cmbCategoria, cmbAlmacen;
        private PictureBox picBarcode;
        private Button btnGenerarCodigo, btnGuardar, btnCancelar;
        private Label lblPreviewCodigo;

        public FormProducto()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Text = "Registrar / Editar Producto";
            this.Size = new Size(860, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(241, 245, 249);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // ── Header ─────────────────────────────────────────────
            var pnlHeader = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(30, 41, 59) };
            var lblTitulo = new Label { Text = "  📦  Registrar Producto", ForeColor = Color.White, Font = new Font("Segoe UI", 14, FontStyle.Bold), AutoSize = true, Location = new Point(12, 15), BackColor = Color.Transparent };
            pnlHeader.Controls.Add(lblTitulo);
            this.Controls.Add(pnlHeader);

            // ── Panel izquierdo: datos ─────────────────────────────
            var pnlLeft = new Panel { Location = new Point(16, 76), Size = new Size(480, 480), BackColor = Color.White };
            pnlLeft.Paint += (s, e) => {
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240)))
                    e.Graphics.DrawRectangle(pen, 0, 0, pnlLeft.Width - 1, pnlLeft.Height - 1);
            };

            var lblDatos = new Label { Text = "Datos del Producto", Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.FromArgb(30, 41, 59), AutoSize = true, Location = new Point(16, 14) };
            pnlLeft.Controls.Add(lblDatos);

            int y = 44;
            txtNombre       = AddField(pnlLeft, "Nombre del Producto *", ref y, 448);
            cmbCategoria    = AddCombo(pnlLeft, "Categoría", ref y, 448, new[]{ "Electrónica", "Ropa", "Alimentos", "Hogar", "Otros" });
            cmbAlmacen      = AddCombo(pnlLeft, "Almacén", ref y, 448, new[]{ "Almacén Principal", "Almacén Secundario" });

            // Fila de precios (lado a lado)
            var lblPC = new Label { Text = "Precio Compra *", Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(16, y) };
            var lblPV = new Label { Text = "Precio Venta *",  Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(240, y) };
            pnlLeft.Controls.Add(lblPC); pnlLeft.Controls.Add(lblPV);
            y += 20;
            txtPrecioCompra = new TextBox { Location = new Point(16, y), Size = new Size(200, 30), Font = new Font("Segoe UI", 10), Text = "0.00" };
            txtPrecioVenta  = new TextBox { Location = new Point(240, y), Size = new Size(208, 30), Font = new Font("Segoe UI", 10), Text = "0.00" };
            pnlLeft.Controls.Add(txtPrecioCompra); pnlLeft.Controls.Add(txtPrecioVenta);
            y += 48;

            // Stock
            var lblS = new Label { Text = "Stock Actual",  Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(16, y) };
            var lblSM = new Label { Text = "Stock Mínimo", Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(240, y) };
            pnlLeft.Controls.Add(lblS); pnlLeft.Controls.Add(lblSM);
            y += 20;
            txtStock    = new TextBox { Location = new Point(16, y),  Size = new Size(200, 30), Font = new Font("Segoe UI", 10), Text = "0" };
            txtStockMin = new TextBox { Location = new Point(240, y), Size = new Size(208, 30), Font = new Font("Segoe UI", 10), Text = "5" };
            pnlLeft.Controls.Add(txtStock); pnlLeft.Controls.Add(txtStockMin);
            y += 60;

            // Botones
            btnGuardar = new Button { Text = "💾  Guardar Producto", Location = new Point(16, y), Size = new Size(220, 44) };
            StyleBtn(btnGuardar, Color.FromArgb(37, 99, 235)); btnGuardar.Click += BtnGuardar_Click;
            pnlLeft.Controls.Add(btnGuardar);

            btnCancelar = new Button { Text = "Cancelar", Location = new Point(246, y), Size = new Size(202, 44) };
            StyleBtn(btnCancelar, Color.FromArgb(226, 232, 240)); btnCancelar.ForeColor = Color.FromArgb(71, 85, 105);
            btnCancelar.Click += (s, e) => this.Close();
            pnlLeft.Controls.Add(btnCancelar);

            this.Controls.Add(pnlLeft);

            // ── Panel derecho: código de barras ────────────────────
            var pnlRight = new Panel { Location = new Point(512, 76), Size = new Size(320, 480), BackColor = Color.White };
            pnlRight.Paint += (s, e) => {
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240)))
                    e.Graphics.DrawRectangle(pen, 0, 0, pnlRight.Width - 1, pnlRight.Height - 1);
            };

            var lblBarcodeTitle = new Label { Text = "Código de Barras", Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.FromArgb(30, 41, 59), AutoSize = true, Location = new Point(16, 14) };
            pnlRight.Controls.Add(lblBarcodeTitle);

            // Campo código
            var lblCod = new Label { Text = "Código del Producto", Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(16, 48) };
            pnlRight.Controls.Add(lblCod);
            txtCodigo = new TextBox { Location = new Point(16, 68), Size = new Size(288, 30), Font = new Font("Segoe UI", 10), PlaceholderText = "Ej: 7501234567891" };
            pnlRight.Controls.Add(txtCodigo);

            // Botón generar
            btnGenerarCodigo = new Button { Text = "⚡  Generar Código Automático", Location = new Point(16, 108), Size = new Size(288, 38) };
            StyleBtn(btnGenerarCodigo, Color.FromArgb(124, 58, 237));
            btnGenerarCodigo.Click += BtnGenerarCodigo_Click;
            pnlRight.Controls.Add(btnGenerarCodigo);

            // Vista previa código de barras
            var lblPreviewTitle = new Label { Text = "Vista Previa:", Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(16, 160) };
            pnlRight.Controls.Add(lblPreviewTitle);

            picBarcode = new PictureBox { Location = new Point(16, 180), Size = new Size(288, 100), BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, SizeMode = PictureBoxSizeMode.Zoom };
            pnlRight.Controls.Add(picBarcode);

            lblPreviewCodigo = new Label { Text = "", Font = new Font("Courier New", 11, FontStyle.Bold), ForeColor = Color.FromArgb(30, 41, 59), AutoSize = false, Size = new Size(288, 24), Location = new Point(16, 285), TextAlign = ContentAlignment.MiddleCenter };
            pnlRight.Controls.Add(lblPreviewCodigo);

            // Info
            var lblInfo = new Label
            {
                Text = "💡 El código de barras se genera\nautomáticamente al guardar si\nno ingresa uno manualmente.",
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.FromArgb(100, 116, 139),
                AutoSize = true,
                Location = new Point(16, 324)
            };
            pnlRight.Controls.Add(lblInfo);

            // Botón imprimir etiqueta
            var btnPrintLabel = new Button { Text = "🖨  Imprimir Etiqueta", Location = new Point(16, 410), Size = new Size(288, 42) };
            StyleBtn(btnPrintLabel, Color.FromArgb(71, 85, 105));
            btnPrintLabel.Click += BtnImprimirEtiqueta_Click;
            pnlRight.Controls.Add(btnPrintLabel);

            this.Controls.Add(pnlRight);
            this.ResumeLayout(false);
        }

        // ── Helpers ────────────────────────────────────────────────
        private TextBox AddField(Panel parent, string label, ref int y, int width)
        {
            var lbl = new Label { Text = label, Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(16, y) };
            parent.Controls.Add(lbl);
            y += 20;
            var txt = new TextBox { Location = new Point(16, y), Size = new Size(width, 30), Font = new Font("Segoe UI", 10) };
            parent.Controls.Add(txt);
            y += 48;
            return txt;
        }

        private ComboBox AddCombo(Panel parent, string label, ref int y, int width, string[] items)
        {
            var lbl = new Label { Text = label, Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(16, y) };
            parent.Controls.Add(lbl);
            y += 20;
            var cmb = new ComboBox { Location = new Point(16, y), Size = new Size(width, 30), Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList };
            cmb.Items.AddRange(items);
            if (items.Length > 0) cmb.SelectedIndex = 0;
            parent.Controls.Add(cmb);
            y += 48;
            return cmb;
        }

        private void StyleBtn(Button btn, Color color)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        // ── Eventos ────────────────────────────────────────────────
        private void BtnGenerarCodigo_Click(object sender, EventArgs e)
        {
            // Generar código EAN-13 de ejemplo
            var rnd = new Random();
            string codigo = "750" + rnd.Next(1000000000).ToString("D10");
            txtCodigo.Text = codigo;
            DibujarCodigoBarras(codigo);
        }

        private void DibujarCodigoBarras(string codigo)
        {
            // Representación visual simplificada de barras
            Bitmap bmp = new Bitmap(288, 90);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                var rnd = new Random(codigo.GetHashCode());
                int x = 10;
                // Barras iniciales
                for (int i = 0; i < codigo.Length * 7 && x < 278; i++)
                {
                    int barW = rnd.Next(1, 4);
                    Color c = (i % 2 == 0) ? Color.Black : Color.White;
                    using (SolidBrush brush = new SolidBrush(c))
                        g.FillRectangle(brush, x, 5, barW, 75);
                    x += barW;
                }
                // Texto del código
                using (Font f = new Font("Courier New", 7))
                using (SolidBrush sb = new SolidBrush(Color.Black))
                    g.DrawString(codigo, f, sb, 20, 78);
            }
            picBarcode.Image = bmp;
            lblPreviewCodigo.Text = codigo;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) { MessageBox.Show("El nombre del producto es requerido.", "Aviso"); return; }

            // Generar código si no tiene
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                var rnd = new Random();
                txtCodigo.Text = "750" + rnd.Next(1000000000).ToString("D10");
                DibujarCodigoBarras(txtCodigo.Text);
            }

            // TODO: Guardar en BD
            MessageBox.Show("✅ Producto guardado exitosamente.\nCódigo: " + txtCodigo.Text, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnImprimirEtiqueta_Click(object sender, EventArgs e)
        {
            if (picBarcode.Image == null) { MessageBox.Show("Primero genere un código de barras.", "Aviso"); return; }
            // TODO: Implementar impresión de etiqueta
            MessageBox.Show("Enviando etiqueta a la impresora...", "Imprimir");
        }
    }
}
