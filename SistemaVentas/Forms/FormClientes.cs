using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaVentas.Forms
{
    /// <summary>
    /// Pantalla de gestión de Clientes.
    /// Puede usarse embebida en FormPrincipal (Dock=Fill) o como ventana independiente.
    /// </summary>
    public class FormClientes : Form
    {
        private DataGridView dgvClientes;
        private TextBox txtBuscar;
        private Button btnNuevo, btnEditar, btnEliminar, btnActualizar;
        private Panel pnlToolbar;
        private Label lblTotal;

        public FormClientes()
        {
            InitializeComponent();
            CargarDatosEjemplo();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Text = "Gestión de Clientes";
            this.Size = new Size(1020, 660);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(241, 245, 249);
            this.Font = new Font("Segoe UI", 9);

            // ── Encabezado ─────────────────────────────────────────
            var pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.BackColor = Color.White;
            pnlHeader.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                    e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
            };

            var lblTitulo = new Label();
            lblTitulo.Text = "👥  Clientes";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 18);
            pnlHeader.Controls.Add(lblTitulo);

            lblTotal = new Label();
            lblTotal.Text = "0 registros";
            lblTotal.Font = new Font("Segoe UI", 9);
            lblTotal.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(22, 48);
            pnlHeader.Controls.Add(lblTotal);

            // ── Barra de herramientas ──────────────────────────────
            pnlToolbar = new Panel();
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Height = 56;
            pnlToolbar.BackColor = Color.FromArgb(248, 250, 252);
            pnlToolbar.Padding = new Padding(12, 10, 12, 10);

            // Botón Nuevo
            btnNuevo = MakeToolBtn("➕  Nuevo", Color.FromArgb(37, 99, 235));
            btnNuevo.Location = new Point(12, 10);
            btnNuevo.Click += BtnNuevo_Click;
            pnlToolbar.Controls.Add(btnNuevo);

            // Botón Editar
            btnEditar = MakeToolBtn("✏️  Editar", Color.FromArgb(5, 150, 105));
            btnEditar.Location = new Point(132, 10);
            btnEditar.Click += BtnEditar_Click;
            pnlToolbar.Controls.Add(btnEditar);

            // Botón Eliminar
            btnEliminar = MakeToolBtn("🗑️  Eliminar", Color.FromArgb(220, 38, 38));
            btnEliminar.Location = new Point(252, 10);
            btnEliminar.Click += BtnEliminar_Click;
            pnlToolbar.Controls.Add(btnEliminar);

            // Botón Actualizar
            btnActualizar = MakeToolBtn("🔄  Actualizar", Color.FromArgb(71, 85, 105));
            btnActualizar.Location = new Point(372, 10);
            btnActualizar.Click += (s, e) => CargarDatosEjemplo();
            pnlToolbar.Controls.Add(btnActualizar);

            // Buscador
            var lblBuscar = new Label();
            lblBuscar.Text = "🔍";
            lblBuscar.Font = new Font("Segoe UI", 12);
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(580, 14);
            pnlToolbar.Controls.Add(lblBuscar);

            txtBuscar = new TextBox();
            txtBuscar.Location = new Point(610, 14);
            txtBuscar.Size = new Size(220, 30);
            txtBuscar.Font = new Font("Segoe UI", 10);
            txtBuscar.PlaceholderText = "Buscar cliente...";
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            pnlToolbar.Controls.Add(txtBuscar);

            // ── DataGridView ───────────────────────────────────────
            dgvClientes = new DataGridView();
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersHeight = 42;
            dgvClientes.RowTemplate.Height = 38;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.GridColor = Color.FromArgb(226, 232, 240);
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Estilo cabecera
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvClientes.EnableHeadersVisualStyles = false;

            // Estilo filas alternas
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvClientes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvClientes.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 64, 175);

            // Columnas
            dgvClientes.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "ID",       HeaderText = "ID",         Width = 60 },
                new DataGridViewTextBoxColumn { Name = "Nombre",   HeaderText = "Nombre",     Width = 200 },
                new DataGridViewTextBoxColumn { Name = "Apellido", HeaderText = "Apellido",   Width = 180 },
                new DataGridViewTextBoxColumn { Name = "DNI",      HeaderText = "DNI / RUC",  Width = 130 },
                new DataGridViewTextBoxColumn { Name = "Telefono", HeaderText = "Teléfono",   Width = 130 },
                new DataGridViewTextBoxColumn { Name = "Email",    HeaderText = "Email",      Width = 220, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "Estado",   HeaderText = "Estado",     Width = 80 },
            });

            // ── Barra de estado ────────────────────────────────────
            var statusBar = new Panel();
            statusBar.Dock = DockStyle.Bottom;
            statusBar.Height = 30;
            statusBar.BackColor = Color.FromArgb(30, 41, 59);
            var lblStatus = new Label();
            lblStatus.Text = "  Sistema de Ventas  |  Módulo: Clientes";
            lblStatus.ForeColor = Color.FromArgb(148, 163, 184);
            lblStatus.Font = new Font("Segoe UI", 8);
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(4, 7);
            statusBar.Controls.Add(lblStatus);

            // ── Ensamblado ─────────────────────────────────────────
            this.Controls.Add(dgvClientes);
            this.Controls.Add(pnlToolbar);
            this.Controls.Add(pnlHeader);
            this.Controls.Add(statusBar);

            this.ResumeLayout(false);
        }

        private Button MakeToolBtn(string text, Color bgColor)
        {
            var btn = new Button();
            btn.Text = text;
            btn.Size = new Size(110, 36);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = bgColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Dark(bgColor, 0.1f);
            btn.MouseLeave += (s, e) => btn.BackColor = bgColor;
            return btn;
        }

        private void CargarDatosEjemplo()
        {
            dgvClientes.Rows.Clear();
            // Datos de ejemplo - reemplazar con consulta a BD
            var datos = new object[,]
            {
                { 1, "Carlos",   "Mendoza",    "12345678",  "555-1001", "carlos.mendoza@mail.com",   "Activo" },
                { 2, "Ana",      "García",     "87654321",  "555-1002", "ana.garcia@mail.com",        "Activo" },
                { 3, "Roberto",  "Sánchez",    "11223344",  "555-1003", "roberto.sanchez@mail.com",   "Activo" },
                { 4, "Lucía",    "Ramírez",    "44332211",  "555-1004", "lucia.ramirez@mail.com",     "Inactivo" },
                { 5, "Miguel",   "Torres",     "55667788",  "555-1005", "miguel.torres@mail.com",     "Activo" },
            };

            for (int i = 0; i < datos.GetLength(0); i++)
                dgvClientes.Rows.Add(datos[i, 0], datos[i, 1], datos[i, 2], datos[i, 3], datos[i, 4], datos[i, 5], datos[i, 6]);

            lblTotal.Text = dgvClientes.Rows.Count + " registros";
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                bool visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.Value?.ToString().ToLower().Contains(filtro) == true) { visible = true; break; }
                row.Visible = visible;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new FormNuevoCliente();
            if (frm.ShowDialog() == DialogResult.OK)
                CargarDatosEjemplo(); // Recargar datos
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0) { MessageBox.Show("Seleccione un cliente.", "Aviso"); return; }
            var frm = new FormNuevoCliente(); // Pasar datos de la fila seleccionada
            frm.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0) { MessageBox.Show("Seleccione un cliente.", "Aviso"); return; }
            if (MessageBox.Show("¿Eliminar el cliente seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // TODO: Eliminar de BD
                dgvClientes.Rows.Remove(dgvClientes.SelectedRows[0]);
                lblTotal.Text = dgvClientes.Rows.Count + " registros";
            }
        }
    }

    // ── Sub-formulario: Nuevo / Editar Cliente ─────────────────────
    public class FormNuevoCliente : Form
    {
        public FormNuevoCliente()
        {
            this.Text = "Nuevo Cliente";
            this.Size = new Size(460, 520);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(241, 245, 249);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            var pnlHeader = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(30, 41, 59) };
            var lblTitulo = new Label { Text = "  👤  Nuevo Cliente", ForeColor = Color.White, Font = new Font("Segoe UI", 13, FontStyle.Bold), AutoSize = true, Location = new Point(10, 16), BackColor = Color.Transparent };
            pnlHeader.Controls.Add(lblTitulo);
            this.Controls.Add(pnlHeader);

            int y = 80;
            string[] campos = { "Nombre", "Apellido", "DNI / RUC", "Teléfono", "Dirección", "Email" };
            foreach (var campo in campos)
            {
                var lbl = new Label { Text = campo, Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true, Location = new Point(30, y) };
                this.Controls.Add(lbl);
                var txt = new TextBox { Location = new Point(30, y + 20), Size = new Size(390, 30), Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle };
                this.Controls.Add(txt);
                y += 60;
            }

            var btnGuardar = new Button { Text = "💾  Guardar", Location = new Point(30, y + 10), Size = new Size(180, 42), FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(37, 99, 235), ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };
            this.Controls.Add(btnGuardar);

            var btnCancelar = new Button { Text = "Cancelar", Location = new Point(240, y + 10), Size = new Size(180, 42), FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(226, 232, 240), ForeColor = Color.FromArgb(71, 85, 105), Font = new Font("Segoe UI", 10) };
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            this.Controls.Add(btnCancelar);
        }
    }
}
