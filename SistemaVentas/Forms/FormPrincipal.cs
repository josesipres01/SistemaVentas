using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaVentas.Forms
{
    public partial class FormPrincipal : Form
    {
        private bool isDragging = false;
        private Point dragOffset;
        private Panel pnlMenu;
        private Panel pnlContent;
        private Panel pnlTopBar;
        private Label lblUsuarioConectado;
        private Panel pnlSubmenuActivo;
        private bool menuExpandido = false;
        private string usuarioActual = "Administrador"; // Se asigna desde login

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public string UsuarioActual
        {
            set { usuarioActual = value; if (lblUsuarioConectado != null) lblUsuarioConectado.Text = "👤  " + value; }
            get { return usuarioActual; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1280, 720);
            this.BackColor = Color.FromArgb(241, 245, 249);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de Ventas - Principal";

            BuildTopBar();
            BuildSideMenu();
            BuildContentArea();

            this.ResumeLayout(false);
        }

        // ── TOP BAR ────────────────────────────────────────────────
        private void BuildTopBar()
        {
            pnlTopBar = new Panel();
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Height = 56;
            pnlTopBar.BackColor = Color.FromArgb(30, 41, 59);
            pnlTopBar.MouseDown += FormPrincipal_MouseDown;
            pnlTopBar.MouseMove += FormPrincipal_MouseMove;
            pnlTopBar.MouseUp += FormPrincipal_MouseUp;

            // Logo / Título
            var lblTitulo = new Label();
            lblTitulo.Text = "  💲 Sistema de Ventas";
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 14);
            lblTitulo.BackColor = Color.Transparent;
            pnlTopBar.Controls.Add(lblTitulo);

            // Usuario conectado
            lblUsuarioConectado = new Label();
            lblUsuarioConectado.Text = "👤  " + usuarioActual;
            lblUsuarioConectado.ForeColor = Color.FromArgb(148, 163, 184);
            lblUsuarioConectado.Font = new Font("Segoe UI", 10);
            lblUsuarioConectado.AutoSize = true;
            lblUsuarioConectado.Location = new Point(950, 17);
            lblUsuarioConectado.BackColor = Color.Transparent;
            pnlTopBar.Controls.Add(lblUsuarioConectado);

            // Fecha/Hora
            var lblFecha = new Label();
            lblFecha.ForeColor = Color.FromArgb(100, 116, 139);
            lblFecha.Font = new Font("Segoe UI", 9);
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(780, 19);
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Text = DateTime.Now.ToString("dddd dd/MM/yyyy  HH:mm");
            pnlTopBar.Controls.Add(lblFecha);

            // Timer para actualizar hora
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => lblFecha.Text = DateTime.Now.ToString("dddd dd/MM/yyyy  HH:mm");
            timer.Start();

            // Botones ventana
            MakeWinBtn("─", Color.FromArgb(50, 60, 80), pnlTopBar, 1185, () => this.WindowState = FormWindowState.Minimized);
            MakeWinBtn("□", Color.FromArgb(50, 60, 80), pnlTopBar, 1218, () =>
                this.WindowState = this.WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal : FormWindowState.Maximized);
            MakeWinBtn("✕", Color.FromArgb(220, 38, 38), pnlTopBar, 1251, () => Application.Exit());

            this.Controls.Add(pnlTopBar);
        }

        private void MakeWinBtn(string txt, Color bgColor, Panel parent, int x, Action onClick)
        {
            var btn = new Button();
            btn.Text = txt;
            btn.Size = new Size(28, 28);
            btn.Location = new Point(x, 14);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = bgColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9);
            btn.Cursor = Cursors.Hand;
            btn.Click += (s, e) => onClick();
            parent.Controls.Add(btn);
        }

        // ── MENÚ LATERAL ───────────────────────────────────────────
        private void BuildSideMenu()
        {
            pnlMenu = new Panel();
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Width = 220;
            pnlMenu.BackColor = Color.FromArgb(15, 23, 42);
            pnlMenu.Padding = new Padding(0, 8, 0, 8);

            int y = 10;

            // Definición de menús con submenús
            var menuItems = new (string icon, string texto, string[] subs)[]
            {
                ("🏠", "Inicio", null),
                ("📦", "Almacén", new[]{ "Categoría", "Productos", "Stock Mínimo" }),
                ("👥", "Clientes", new[]{ "Lista de Clientes", "Nuevo Cliente" }),
                ("🛒", "Compras", new[]{ "Registrar Compra", "Historial" }),
                ("💰", "Ventas", new[]{ "Nueva Venta", "Historial Ventas" }),
                ("👷", "Empleados", null),
                ("📊", "Reportes", new[]{ "Ventas", "Compras", "Inventario", "Imprimir" }),
                ("⚙️", "Configuración", null),
            };

            foreach (var item in menuItems)
            {
                y = AddMenuButton(item.icon, item.texto, item.subs, y);
            }

            // Botón salir al fondo
            var btnSalir = CreateMenuButton("🚪", "Salir", null);
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.Click += (s, e) => { this.Close(); };
            pnlMenu.Controls.Add(btnSalir);

            this.Controls.Add(pnlMenu);
        }

        private int AddMenuButton(string icon, string texto, string[] subs, int y)
        {
            var btn = CreateMenuButton(icon, texto, subs);
            btn.Location = new Point(0, y);
            pnlMenu.Controls.Add(btn);
            y += btn.Height + 2;

            if (subs != null)
            {
                // Submenú (oculto por defecto)
                var pnlSub = new Panel();
                pnlSub.Width = pnlMenu.Width;
                pnlSub.Height = subs.Length * 38;
                pnlSub.BackColor = Color.FromArgb(8, 15, 30);
                pnlSub.Visible = false;
                pnlSub.Location = new Point(0, y);
                pnlSub.Tag = "submenu";

                int sy = 0;
                foreach (var sub in subs)
                {
                    var btnSub = new Button();
                    btnSub.Text = "    ◦  " + sub;
                    btnSub.TextAlign = ContentAlignment.MiddleLeft;
                    btnSub.FlatStyle = FlatStyle.Flat;
                    btnSub.FlatAppearance.BorderSize = 0;
                    btnSub.ForeColor = Color.FromArgb(148, 163, 184);
                    btnSub.BackColor = Color.Transparent;
                    btnSub.Font = new Font("Segoe UI", 9);
                    btnSub.Size = new Size(pnlMenu.Width, 36);
                    btnSub.Location = new Point(0, sy);
                    btnSub.Cursor = Cursors.Hand;
                    btnSub.Tag = sub;
                    btnSub.MouseEnter += (s2, e2) => ((Button)s2).ForeColor = Color.White;
                    btnSub.MouseLeave += (s2, e2) => ((Button)s2).ForeColor = Color.FromArgb(148, 163, 184);
                    btnSub.Click += SubMenu_Click;
                    pnlSub.Controls.Add(btnSub);
                    sy += 38;
                }

                // Toggle submenú al hacer clic en el padre
                btn.Click += (s, e) =>
                {
                    // Ocultar submenu previo
                    if (pnlSubmenuActivo != null && pnlSubmenuActivo != pnlSub)
                        pnlSubmenuActivo.Visible = false;

                    pnlSub.Visible = !pnlSub.Visible;
                    pnlSubmenuActivo = pnlSub.Visible ? pnlSub : null;
                };

                pnlMenu.Controls.Add(pnlSub);
                if (!pnlSub.Visible) return y; // no sumar altura si está oculto
                y += pnlSub.Height;
            }
            else
            {
                btn.Click += MenuSinSub_Click;
            }

            return y;
        }

        private Button CreateMenuButton(string icon, string texto, string[] subs)
        {
            var btn = new Button();
            btn.Text = $"  {icon}  {texto}" + (subs != null ? "  ›" : "");
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.FromArgb(203, 213, 225);
            btn.BackColor = Color.Transparent;
            btn.Font = new Font("Segoe UI", 10);
            btn.Size = new Size(220, 44);
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(30, 41, 59);
                btn.ForeColor = Color.White;
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(203, 213, 225);
            };
            return btn;
        }

        private void MenuSinSub_Click(object sender, EventArgs e)
        {
            // Cerrar submenú activo
            if (pnlSubmenuActivo != null) { pnlSubmenuActivo.Visible = false; pnlSubmenuActivo = null; }
            // TODO: Abrir formulario correspondiente
        }

        private void SubMenu_Click(object sender, EventArgs e)
        {
            string opcion = ((Button)sender).Tag?.ToString();
            AbrirFormularioPorNombre(opcion);
        }

        private void AbrirFormularioPorNombre(string nombre)
        {
            pnlContent.Controls.Clear();
            // TODO: Instanciar el form correspondiente y cargarlo en pnlContent
            var lbl = new Label();
            lbl.Text = $"📋  {nombre}";
            lbl.Font = new Font("Segoe UI", 18, FontStyle.Regular);
            lbl.ForeColor = Color.FromArgb(100, 116, 139);
            lbl.AutoSize = false;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            pnlContent.Controls.Add(lbl);
        }

        // ── ÁREA DE CONTENIDO ──────────────────────────────────────
        private void BuildContentArea()
        {
            pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.FromArgb(241, 245, 249);
            pnlContent.Padding = new Padding(24);

            // Panel de bienvenida / dashboard
            BuildDashboard();

            this.Controls.Add(pnlContent);
        }

        private void BuildDashboard()
        {
            // Título bienvenida
            var lblBienvenida = new Label();
            lblBienvenida.Text = "Panel Principal";
            lblBienvenida.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(15, 23, 42);
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(24, 24);
            pnlContent.Controls.Add(lblBienvenida);

            var lblSub = new Label();
            lblSub.Text = "Resumen del día - " + DateTime.Now.ToString("dd MMMM yyyy");
            lblSub.Font = new Font("Segoe UI", 10);
            lblSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblSub.AutoSize = true;
            lblSub.Location = new Point(26, 60);
            pnlContent.Controls.Add(lblSub);

            // Tarjetas de resumen
            string[] titulos = { "Ventas Hoy", "Clientes", "Productos", "Compras" };
            string[] valores = { "$0.00", "0", "0", "$0.00" };
            string[] iconos = { "💰", "👥", "📦", "🛒" };
            Color[] colores = {
                Color.FromArgb(37, 99, 235),
                Color.FromArgb(5, 150, 105),
                Color.FromArgb(124, 58, 237),
                Color.FromArgb(220, 38, 38)
            };

            for (int i = 0; i < 4; i++)
            {
                var card = BuildCard(titulos[i], valores[i], iconos[i], colores[i]);
                card.Location = new Point(24 + i * 240, 100);
                pnlContent.Controls.Add(card);
            }
        }

        private Panel BuildCard(string titulo, string valor, string icono, Color color)
        {
            var card = new Panel();
            card.Size = new Size(220, 110);
            card.BackColor = Color.White;
            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                // Barra color izquierda
                using (SolidBrush b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, 0, 0, 5, card.Height);
            };

            var lblIcono = new Label();
            lblIcono.Text = icono;
            lblIcono.Font = new Font("Segoe UI Emoji", 24);
            lblIcono.AutoSize = true;
            lblIcono.Location = new Point(15, 15);
            card.Controls.Add(lblIcono);

            var lblTitulo = new Label();
            lblTitulo.Text = titulo;
            lblTitulo.Font = new Font("Segoe UI", 9);
            lblTitulo.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(15, 65);
            card.Controls.Add(lblTitulo);

            var lblValor = new Label();
            lblValor.Text = valor;
            lblValor.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblValor.ForeColor = Color.FromArgb(15, 23, 42);
            lblValor.AutoSize = true;
            lblValor.Location = new Point(15, 82);
            card.Controls.Add(lblValor);

            return card;
        }

        // ── Arrastre de ventana ────────────────────────────────────
        private void FormPrincipal_MouseDown(object sender, MouseEventArgs e) { isDragging = true; dragOffset = new Point(e.X, e.Y); }
        private void FormPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging) this.Location = new Point(this.Left + e.X - dragOffset.X, this.Top + e.Y - dragOffset.Y);
        }
        private void FormPrincipal_MouseUp(object sender, MouseEventArgs e) { isDragging = false; }
    }
}
