using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SistemaVentas.Forms
{
    /// <summary>
    /// Pantalla de Reportes de Ventas con filtros por fecha, vista previa e impresión.
    /// </summary>
    public class FormReportes : Form
    {
        private DataGridView dgvReporte;
        private DateTimePicker dtpDesde, dtpHasta;
        private ComboBox cmbTipoReporte;
        private Button btnGenerar, btnImprimir, btnExportar;
        private Label lblTotalVentas, lblCantidadVentas, lblTicketPromedio;
        private Panel pnlResumen;

        public FormReportes()
        {
            InitializeComponent();
            GenerarReporteEjemplo();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Text = "Reportes de Ventas";
            this.Size = new Size(1100, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(241, 245, 249);

            // ── Header ─────────────────────────────────────────────
            var pnlHeader = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(30, 41, 59) };
            var lblTitulo = new Label { Text = "  📊  Reportes de Ventas", ForeColor = Color.White, Font = new Font("Segoe UI", 14, FontStyle.Bold), AutoSize = true, Location = new Point(12, 15), BackColor = Color.Transparent };
            pnlHeader.Controls.Add(lblTitulo);
            this.Controls.Add(pnlHeader);

            // ── Barra de filtros ───────────────────────────────────
            var pnlFiltros = new Panel { Dock = DockStyle.Top, Height = 68, BackColor = Color.White };
            pnlFiltros.Paint += (s, e) => {
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                    e.Graphics.DrawLine(pen, 0, pnlFiltros.Height - 1, pnlFiltros.Width, pnlFiltros.Height - 1);
            };

            var lblTipo = new Label { Text = "Tipo de Reporte:", Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(16, 12) };
            pnlFiltros.Controls.Add(lblTipo);
            cmbTipoReporte = new ComboBox { Location = new Point(16, 30), Size = new Size(180, 28), Font = new Font("Segoe UI", 9), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbTipoReporte.Items.AddRange(new object[] { "Ventas por Período", "Por Producto", "Por Cliente", "Por Empleado" });
            cmbTipoReporte.SelectedIndex = 0;
            pnlFiltros.Controls.Add(cmbTipoReporte);

            var lblDesde = new Label { Text = "Desde:", Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(210, 12) };
            pnlFiltros.Controls.Add(lblDesde);
            dtpDesde = new DateTimePicker { Location = new Point(210, 30), Size = new Size(160, 28), Font = new Font("Segoe UI", 9), Format = DateTimePickerFormat.Short, Value = DateTime.Now.AddDays(-30) };
            pnlFiltros.Controls.Add(dtpDesde);

            var lblHasta = new Label { Text = "Hasta:", Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(382, 12) };
            pnlFiltros.Controls.Add(lblHasta);
            dtpHasta = new DateTimePicker { Location = new Point(382, 30), Size = new Size(160, 28), Font = new Font("Segoe UI", 9), Format = DateTimePickerFormat.Short, Value = DateTime.Now };
            pnlFiltros.Controls.Add(dtpHasta);

            btnGenerar = new Button { Text = "🔍  Generar", Location = new Point(558, 28), Size = new Size(110, 34) };
            StyleBtn(btnGenerar, Color.FromArgb(37, 99, 235)); btnGenerar.Click += (s, e) => GenerarReporteEjemplo();
            pnlFiltros.Controls.Add(btnGenerar);

            btnImprimir = new Button { Text = "🖨  Imprimir", Location = new Point(678, 28), Size = new Size(110, 34) };
            StyleBtn(btnImprimir, Color.FromArgb(71, 85, 105)); btnImprimir.Click += BtnImprimir_Click;
            pnlFiltros.Controls.Add(btnImprimir);

            btnExportar = new Button { Text = "📄  Exportar", Location = new Point(798, 28), Size = new Size(110, 34) };
            StyleBtn(btnExportar, Color.FromArgb(5, 150, 105)); btnExportar.Click += BtnExportar_Click;
            pnlFiltros.Controls.Add(btnExportar);

            this.Controls.Add(pnlFiltros);

            // ── Panel resumen (tarjetas KPI) ───────────────────────
            pnlResumen = new Panel { Dock = DockStyle.Top, Height = 100, BackColor = Color.Transparent, Padding = new Padding(12, 8, 12, 8) };

            lblTotalVentas    = BuildKPI(pnlResumen, "Total Ventas",     "S/. 0.00", Color.FromArgb(37, 99, 235), 12);
            lblCantidadVentas = BuildKPI(pnlResumen, "N° de Ventas",     "0",        Color.FromArgb(5, 150, 105), 262);
            lblTicketPromedio = BuildKPI(pnlResumen, "Ticket Promedio",  "S/. 0.00", Color.FromArgb(124, 58, 237), 512);

            this.Controls.Add(pnlResumen);

            // ── DataGrid ───────────────────────────────────────────
            var pnlGrid = new Panel { Dock = DockStyle.Fill, Padding = new Padding(12, 4, 12, 12), BackColor = Color.Transparent };
            dgvReporte = new DataGridView { Dock = DockStyle.Fill };
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.ColumnHeadersHeight = 40;
            dgvReporte.RowTemplate.Height = 36;
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.ReadOnly = true;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.GridColor = Color.FromArgb(226, 232, 240);
            dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporte.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReporte.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvReporte.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvReporte.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvReporte.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 64, 175);

            dgvReporte.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Numero",   HeaderText = "N° Comprobante", Width = 140 },
                new DataGridViewTextBoxColumn { Name = "Fecha",    HeaderText = "Fecha",           Width = 120 },
                new DataGridViewTextBoxColumn { Name = "Cliente",  HeaderText = "Cliente",         Width = 200 },
                new DataGridViewTextBoxColumn { Name = "Tipo",     HeaderText = "Tipo",            Width = 100 },
                new DataGridViewTextBoxColumn { Name = "Items",    HeaderText = "Ítems",           Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Subtotal", HeaderText = "Subtotal",        Width = 100 },
                new DataGridViewTextBoxColumn { Name = "IGV",      HeaderText = "IGV",             Width = 90 },
                new DataGridViewTextBoxColumn { Name = "Total",    HeaderText = "Total",           Width = 110, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "Estado",   HeaderText = "Estado",          Width = 90 },
            });

            pnlGrid.Controls.Add(dgvReporte);
            this.Controls.Add(pnlGrid);

            // Status bar
            var statusBar = new Panel { Dock = DockStyle.Bottom, Height = 30, BackColor = Color.FromArgb(30, 41, 59) };
            var lblStatus = new Label { Text = "  Sistema de Ventas  |  Módulo: Reportes", ForeColor = Color.FromArgb(148, 163, 184), Font = new Font("Segoe UI", 8), AutoSize = true, Location = new Point(4, 7) };
            statusBar.Controls.Add(lblStatus);
            this.Controls.Add(statusBar);

            this.ResumeLayout(false);
        }

        private Label BuildKPI(Panel parent, string titulo, string valor, Color color, int x)
        {
            var card = new Panel { Location = new Point(x, 8), Size = new Size(230, 80), BackColor = Color.White };
            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, 0, 0, 5, card.Height);
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240)))
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
            };

            var lblT = new Label { Text = titulo, Font = new Font("Segoe UI", 8), ForeColor = Color.FromArgb(100, 116, 139), AutoSize = true, Location = new Point(14, 10) };
            card.Controls.Add(lblT);

            var lblV = new Label { Text = valor, Font = new Font("Segoe UI", 16, FontStyle.Bold), ForeColor = color, AutoSize = true, Location = new Point(12, 32) };
            card.Controls.Add(lblV);

            parent.Controls.Add(card);
            return lblV;
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

        private void GenerarReporteEjemplo()
        {
            dgvReporte.Rows.Clear();
            var rnd = new Random();
            decimal totalAcum = 0; int cantVentas = 0;

            for (int i = 1; i <= 15; i++)
            {
                decimal subtotal = Math.Round((decimal)(rnd.Next(50, 500) + rnd.NextDouble()), 2);
                decimal igv = Math.Round(subtotal * 0.18m, 2);
                decimal total = subtotal + igv;
                totalAcum += total; cantVentas++;

                dgvReporte.Rows.Add(
                    $"0001-{i:D5}",
                    DateTime.Now.AddDays(-rnd.Next(0, 30)).ToString("dd/MM/yyyy"),
                    new[] { "Carlos Mendoza", "Ana García", "Roberto Sánchez", "Miguel Torres", "Consumidor Final" }[rnd.Next(5)],
                    new[] { "Factura", "Boleta", "Recibo" }[rnd.Next(3)],
                    rnd.Next(1, 8),
                    "S/. " + subtotal.ToString("N2"),
                    "S/. " + igv.ToString("N2"),
                    "S/. " + total.ToString("N2"),
                    "Emitida"
                );
            }

            lblTotalVentas.Text    = "S/. " + totalAcum.ToString("N2");
            lblCantidadVentas.Text = cantVentas.ToString();
            lblTicketPromedio.Text = cantVentas > 0 ? "S/. " + Math.Round(totalAcum / cantVentas, 2).ToString("N2") : "S/. 0.00";
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            var pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                var g = ev.Graphics;
                // Encabezado
                using (Font fTitle = new Font("Arial", 14, FontStyle.Bold))
                    g.DrawString("REPORTE DE VENTAS", fTitle, Brushes.Black, 220, 30);
                using (Font fSub = new Font("Arial", 9))
                    g.DrawString($"Período: {dtpDesde.Value:dd/MM/yyyy} al {dtpHasta.Value:dd/MM/yyyy}   |   Generado: {DateTime.Now:dd/MM/yyyy HH:mm}", fSub, Brushes.Gray, 160, 55);

                // Línea separadora
                g.DrawLine(Pens.Black, 30, 72, 750, 72);

                // Cabeceras
                int y = 82;
                string[] cols = { "N° Comprobante", "Fecha", "Cliente", "Tipo", "Total" };
                int[] xs = { 30, 140, 230, 440, 580 };
                using (Font fHead = new Font("Arial", 9, FontStyle.Bold))
                    for (int i = 0; i < cols.Length; i++)
                        g.DrawString(cols[i], fHead, Brushes.Black, xs[i], y);
                y += 20;
                g.DrawLine(Pens.Gray, 30, y, 750, y);
                y += 6;

                // Filas
                using (Font fRow = new Font("Arial", 8))
                    foreach (DataGridViewRow row in dgvReporte.Rows)
                    {
                        string[] vals = { row.Cells["Numero"].Value?.ToString(), row.Cells["Fecha"].Value?.ToString(), row.Cells["Cliente"].Value?.ToString(), row.Cells["Tipo"].Value?.ToString(), row.Cells["Total"].Value?.ToString() };
                        for (int i = 0; i < vals.Length; i++)
                            g.DrawString(vals[i], fRow, Brushes.Black, xs[i], y);
                        y += 18;
                    }

                g.DrawLine(Pens.Black, 30, y + 4, 750, y + 4);
                using (Font fTotal = new Font("Arial", 10, FontStyle.Bold))
                    g.DrawString("TOTAL GENERAL: " + lblTotalVentas.Text, fTotal, Brushes.Black, 450, y + 12);
            };

            var ppd = new PrintPreviewDialog { Document = pd, Width = 900, Height = 700 };
            ppd.ShowDialog();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            // TODO: Exportar a Excel/PDF
            MessageBox.Show("Función de exportación disponible.\nIntegre con EPPlus para Excel o iTextSharp para PDF.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
