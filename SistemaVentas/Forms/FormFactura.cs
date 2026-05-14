using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaVentas.Forms
{
    /// <summary>
    /// Pantalla de Emisión de Facturas / Recibos de Venta.
    /// Incluye: selección de cliente, búsqueda de producto, tabla de detalle, totales y botones de acción.
    /// </summary>
    public class FormFactura : Form
    {
        private ComboBox cmbCliente;
        private TextBox txtBuscarProducto, txtDescuento;
        private DataGridView dgvDetalle;
        private Label lblSubtotal, lblDescuento, lblIGV, lblTotal;
        private Button btnAgregar, btnEmitir, btnImprimir, btnNueva;
        private ComboBox cmbTipoComprobante;

        public FormFactura()
        {
            InitializeComponent();
            CargarClientesEjemplo();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Text = "Emisión de Comprobante";
            this.Size = new Size(1100, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(241, 245, 249);

            // ── Header ─────────────────────────────────────────────
            var pnlHeader = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(30, 41, 59) };
            var lblTitulo = new Label { Text = "  🧾  Emisión de Factura / Recibo", ForeColor = Color.White, Font = new Font("Segoe UI", 14, FontStyle.Bold), AutoSize = true, Location = new Point(12, 15), BackColor = Color.Transparent };
            pnlHeader.Controls.Add(lblTitulo);
            var lblFecha2 = new Label { Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm"), ForeColor = Color.FromArgb(148, 163, 184), Font = new Font("Segoe UI", 10), AutoSize = true, Location = new Point(850, 19), BackColor = Color.Transparent };
            pnlHeader.Controls.Add(lblFecha2);

            // Número correlativo
            var lblNumero = new Label { Text = "Nº: 0001-00001", ForeColor = Color.FromArgb(251, 191, 36), Font = new Font("Segoe UI", 11, FontStyle.Bold), AutoSize = true, Location = new Point(600, 18), BackColor = Color.Transparent };
            pnlHeader.Controls.Add(lblNumero);
            this.Controls.Add(pnlHeader);

            // ── Panel principal (split) ────────────────────────────
            var pnlMain = new Panel { Dock = DockStyle.Fill, BackColor = Color.Transparent, Padding = new Padding(16) };

            // ── Panel izquierdo: datos del comprobante ─────────────
            var pnlIzq = new Panel { Width = 360, Dock = DockStyle.Left, BackColor = Color.White, Padding = new Padding(16) };
            pnlIzq.Paint += BorderPanel;

            int y = 16;

            // Tipo de comprobante
            AddLabel(pnlIzq, "Tipo de Comprobante", ref y);
            cmbTipoComprobante = new ComboBox { Location = new Point(16, y), Size = new Size(320, 30), Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbTipoComprobante.Items.AddRange(new object[] { "Factura", "Boleta de Venta", "Recibo" });
            cmbTipoComprobante.SelectedIndex = 0;
            pnlIzq.Controls.Add(cmbTipoComprobante);
            y += 50;

            // Cliente
            AddLabel(pnlIzq, "Cliente", ref y);
            cmbCliente = new ComboBox { Location = new Point(16, y), Size = new Size(320, 30), Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList };
            pnlIzq.Controls.Add(cmbCliente);
            y += 50;

            // Separador
            var sep1 = new Label { Location = new Point(16, y), Size = new Size(320, 1), BackColor = Color.FromArgb(226, 232, 240) };
            pnlIzq.Controls.Add(sep1);
            y += 16;

            // Buscar producto
            AddLabel(pnlIzq, "Buscar Producto", ref y);
            txtBuscarProducto = new TextBox { Location = new Point(16, y), Size = new Size(240, 30), Font = new Font("Segoe UI", 10), PlaceholderText = "Nombre o código..." };
            pnlIzq.Controls.Add(txtBuscarProducto);

            btnAgregar = new Button { Text = "➕ Agregar", Location = new Point(262, y - 2), Size = new Size(74, 34) };
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.BackColor = Color.FromArgb(37, 99, 235);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            btnAgregar.Click += BtnAgregar_Click;
            pnlIzq.Controls.Add(btnAgregar);
            y += 50;

            // Descuento
            AddLabel(pnlIzq, "Descuento (%)", ref y);
            txtDescuento = new TextBox { Location = new Point(16, y), Size = new Size(100, 30), Font = new Font("Segoe UI", 10), Text = "0" };
            txtDescuento.TextChanged += (s, e) => RecalcularTotales();
            pnlIzq.Controls.Add(txtDescuento);
            y += 60;

            // Separador
            var sep2 = new Label { Location = new Point(16, y), Size = new Size(320, 1), BackColor = Color.FromArgb(226, 232, 240) };
            pnlIzq.Controls.Add(sep2);
            y += 16;

            // Totales
            lblSubtotal  = AddTotalLabel(pnlIzq, "Subtotal:",  ref y, Color.FromArgb(71, 85, 105));
            lblDescuento = AddTotalLabel(pnlIzq, "Descuento:", ref y, Color.FromArgb(220, 38, 38));
            lblIGV       = AddTotalLabel(pnlIzq, "IGV (18%):", ref y, Color.FromArgb(71, 85, 105));

            // Separador grueso
            var sep3 = new Label { Location = new Point(16, y), Size = new Size(320, 2), BackColor = Color.FromArgb(30, 41, 59) };
            pnlIzq.Controls.Add(sep3);
            y += 12;

            lblTotal = AddTotalLabel(pnlIzq, "TOTAL:", ref y, Color.FromArgb(37, 99, 235), 16, FontStyle.Bold);
            y += 20;

            // Botones de acción
            btnEmitir = new Button { Text = "✔  Emitir Comprobante", Location = new Point(16, y), Size = new Size(322, 44) };
            StyleBtn(btnEmitir, Color.FromArgb(5, 150, 105));
            btnEmitir.Click += BtnEmitir_Click;
            pnlIzq.Controls.Add(btnEmitir);
            y += 52;

            btnImprimir = new Button { Text = "🖨  Imprimir", Location = new Point(16, y), Size = new Size(155, 40) };
            StyleBtn(btnImprimir, Color.FromArgb(71, 85, 105));
            pnlIzq.Controls.Add(btnImprimir);

            btnNueva = new Button { Text = "🆕  Nueva", Location = new Point(180, y), Size = new Size(158, 40) };
            StyleBtn(btnNueva, Color.FromArgb(124, 58, 237));
            btnNueva.Click += (s, e) => { dgvDetalle.Rows.Clear(); RecalcularTotales(); };
            pnlIzq.Controls.Add(btnNueva);

            // ── Panel derecho: detalle ─────────────────────────────
            var pnlDer = new Panel { Dock = DockStyle.Fill, Padding = new Padding(12, 0, 0, 0), BackColor = Color.Transparent };

            var lblDetalleTitulo = new Label { Text = "Detalle del Comprobante", Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = Color.FromArgb(15, 23, 42), AutoSize = true, Location = new Point(12, 4) };
            pnlDer.Controls.Add(lblDetalleTitulo);

            dgvDetalle = new DataGridView { Location = new Point(12, 30), Dock = DockStyle.Fill };
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.BorderStyle = BorderStyle.None;
            dgvDetalle.ColumnHeadersHeight = 40;
            dgvDetalle.RowTemplate.Height = 36;
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.GridColor = Color.FromArgb(226, 232, 240);
            dgvDetalle.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvDetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDetalle.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvDetalle.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvDetalle.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);

            dgvDetalle.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Codigo",     HeaderText = "Código",      Width = 90 },
                new DataGridViewTextBoxColumn { Name = "Descripcion",HeaderText = "Descripción", Width = 240, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "Cantidad",   HeaderText = "Cant.",       Width = 70 },
                new DataGridViewTextBoxColumn { Name = "PrecioUnit", HeaderText = "P.Unit",      Width = 90 },
                new DataGridViewTextBoxColumn { Name = "Descuento",  HeaderText = "Desc.%",      Width = 70 },
                new DataGridViewTextBoxColumn { Name = "Total",      HeaderText = "Total",       Width = 100 },
            });
            dgvDetalle.CellValueChanged += (s, e) => RecalcularTotales();

            // Botón eliminar fila
            var colElim = new DataGridViewButtonColumn { HeaderText = "Quitar", Text = "✕", UseColumnTextForButtonValue = true, Width = 60, FlatStyle = FlatStyle.Flat };
            dgvDetalle.Columns.Add(colElim);
            dgvDetalle.CellClick += (s, e) =>
            {
                if (e.ColumnIndex == dgvDetalle.Columns[""].Index && e.RowIndex >= 0)
                { dgvDetalle.Rows.RemoveAt(e.RowIndex); RecalcularTotales(); }
            };

            pnlDer.Controls.Add(dgvDetalle);
            pnlMain.Controls.Add(pnlDer);
            pnlMain.Controls.Add(pnlIzq);

            // Status bar
            var statusBar = new Panel { Dock = DockStyle.Bottom, Height = 30, BackColor = Color.FromArgb(30, 41, 59) };
            var lblStatus = new Label { Text = "  Sistema de Ventas  |  Módulo: Facturación", ForeColor = Color.FromArgb(148, 163, 184), Font = new Font("Segoe UI", 8), AutoSize = true, Location = new Point(4, 7) };
            statusBar.Controls.Add(lblStatus);

            this.Controls.Add(pnlMain);
            this.Controls.Add(statusBar);
            this.ResumeLayout(false);

            RecalcularTotales();
        }

        private void AddLabel(Panel parent, string text, ref int y)
        {
            var lbl = new Label { Text = text, Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(16, y) };
            parent.Controls.Add(lbl);
            y += 20;
        }

        private Label AddTotalLabel(Panel parent, string caption, ref int y, Color valColor, float fontSize = 10, FontStyle fs = FontStyle.Regular)
        {
            var lbl = new Label { Text = caption, Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(16, y) };
            parent.Controls.Add(lbl);
            var lblVal = new Label { Text = "S/. 0.00", Font = new Font("Segoe UI", fontSize, fs), ForeColor = valColor, AutoSize = true, Location = new Point(220, y) };
            parent.Controls.Add(lblVal);
            y += 30;
            return lblVal;
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

        private void BorderPanel(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                e.Graphics.DrawRectangle(pen, 0, 0, ((Panel)sender).Width - 1, ((Panel)sender).Height - 1);
        }

        private void CargarClientesEjemplo()
        {
            cmbCliente.Items.AddRange(new object[] { "--- Consumidor Final ---", "Carlos Mendoza", "Ana García", "Roberto Sánchez", "Miguel Torres" });
            cmbCliente.SelectedIndex = 0;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // TODO: Buscar producto en BD. Ejemplo:
            string codigo = "P00" + (dgvDetalle.Rows.Count + 1);
            string desc = txtBuscarProducto.Text.Trim();
            if (string.IsNullOrWhiteSpace(desc)) desc = "Producto de ejemplo";
            dgvDetalle.Rows.Add(codigo, desc, 1, 10.00m, 0, 10.00m);
            txtBuscarProducto.Clear();
            RecalcularTotales();
        }

        private void RecalcularTotales()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (decimal.TryParse(row.Cells["Total"].Value?.ToString(), out decimal t))
                    subtotal += t;
            }

            decimal pctDescuento = 0;
            decimal.TryParse(txtDescuento?.Text, out pctDescuento);
            decimal descuento = subtotal * pctDescuento / 100;
            decimal baseCalculo = subtotal - descuento;
            decimal igv = baseCalculo * 0.18m;
            decimal total = baseCalculo + igv;

            lblSubtotal.Text  = "S/. " + subtotal.ToString("N2");
            lblDescuento.Text = "S/. " + descuento.ToString("N2");
            lblIGV.Text       = "S/. " + igv.ToString("N2");
            lblTotal.Text     = "S/. " + total.ToString("N2");
        }

        private void BtnEmitir_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0) { MessageBox.Show("Agregue al menos un producto.", "Aviso"); return; }
            // TODO: Guardar en BD y generar correlativo
            MessageBox.Show("✅ Comprobante emitido exitosamente.\n\nNúmero: 0001-00001", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
