using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaVentas.Forms
{
    public partial class FormLogin : Form
    {
        private bool isDragging = false;
        private Point dragOffset;

        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(480, 560);
            this.BackColor = Color.FromArgb(15, 23, 42);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Fondo degradado
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(15, 23, 42),
                Color.FromArgb(30, 41, 59),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            // Borde con brillo
            using (Pen pen = new Pen(Color.FromArgb(59, 130, 246), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragOffset = new Point(e.X, e.Y);
        }
        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
                this.Location = new Point(
                    this.Left + e.X - dragOffset.X,
                    this.Top + e.Y - dragOffset.Y);
        }
        private void FormLogin_MouseUp(object sender, MouseEventArgs e) { isDragging = false; }

        private void InitializeComponent()
        {
            // ── Controles ──────────────────────────────────────────
            var pnlTop = new Panel();
            var lblTitle = new Label();
            var lblSubtitle = new Label();
            var btnCerrar = new Button();

            var pnlCenter = new Panel();
            var lblUsuario = new Label();
            var txtUsuario = new TextBox();
            var lblPassword = new Label();
            var txtPassword = new TextBox();
            var btnIngresar = new Button();
            var lblVersion = new Label();

            this.SuspendLayout();

            // ── Panel Superior (header) ────────────────────────────
            pnlTop.BackColor = Color.FromArgb(30, 41, 59);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Height = 130;
            pnlTop.MouseDown += FormLogin_MouseDown;
            pnlTop.MouseMove += FormLogin_MouseMove;
            pnlTop.MouseUp += FormLogin_MouseUp;
            pnlTop.Paint += (s, e) =>
            {
                using (LinearGradientBrush b = new LinearGradientBrush(
                    pnlTop.ClientRectangle,
                    Color.FromArgb(37, 99, 235),
                    Color.FromArgb(30, 41, 59),
                    LinearGradientMode.Vertical))
                    e.Graphics.FillRectangle(b, pnlTop.ClientRectangle);
                // Icono/logo circular
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush sb = new SolidBrush(Color.FromArgb(59, 130, 246)))
                    e.Graphics.FillEllipse(sb, 195, 10, 90, 90);
                using (SolidBrush sb2 = new SolidBrush(Color.White))
                    e.Graphics.FillEllipse(sb2, 207, 22, 66, 66);
                // Letra S dentro del círculo
                using (Font f = new Font("Segoe UI", 28, FontStyle.Bold))
                using (SolidBrush sb3 = new SolidBrush(Color.FromArgb(37, 99, 235)))
                    e.Graphics.DrawString("$", f, sb3, 215, 28);
            };

            // Botón cerrar
            btnCerrar.Text = "✕";
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.Size = new Size(32, 32);
            btnCerrar.Location = new Point(440, 4);
            btnCerrar.Font = new Font("Segoe UI", 10);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Click += (s, e) => Application.Exit();
            pnlTop.Controls.Add(btnCerrar);

            // Título
            lblTitle.Text = "Sistema de Ventas";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(130, 105);
            lblTitle.BackColor = Color.Transparent;
            pnlTop.Controls.Add(lblTitle);

            // ── Panel central ──────────────────────────────────────
            pnlCenter.BackColor = Color.Transparent;
            pnlCenter.Dock = DockStyle.Fill;
            pnlCenter.Padding = new Padding(50, 20, 50, 20);

            // Subtítulo
            lblSubtitle.Text = "Iniciar Sesión";
            lblSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitle.Font = new Font("Segoe UI", 10);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(50, 20);
            pnlCenter.Controls.Add(lblSubtitle);

            // Label Usuario
            lblUsuario.Text = "Usuario";
            lblUsuario.ForeColor = Color.FromArgb(148, 163, 184);
            lblUsuario.Font = new Font("Segoe UI", 9);
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(50, 55);
            pnlCenter.Controls.Add(lblUsuario);

            // TextBox Usuario
            txtUsuario.Location = new Point(50, 75);
            txtUsuario.Size = new Size(370, 36);
            txtUsuario.Font = new Font("Segoe UI", 11);
            txtUsuario.BackColor = Color.FromArgb(30, 41, 59);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.PlaceholderText = "Ingrese su usuario...";
            pnlCenter.Controls.Add(txtUsuario);

            // Label Password
            lblPassword.Text = "Contraseña";
            lblPassword.ForeColor = Color.FromArgb(148, 163, 184);
            lblPassword.Font = new Font("Segoe UI", 9);
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 130);
            pnlCenter.Controls.Add(lblPassword);

            // TextBox Password
            txtPassword.Location = new Point(50, 150);
            txtPassword.Size = new Size(370, 36);
            txtPassword.Font = new Font("Segoe UI", 11);
            txtPassword.BackColor = Color.FromArgb(30, 41, 59);
            txtPassword.ForeColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Ingrese su contraseña...";
            pnlCenter.Controls.Add(txtPassword);

            // Botón Ingresar
            btnIngresar.Text = "INGRESAR AL SISTEMA";
            btnIngresar.Location = new Point(50, 220);
            btnIngresar.Size = new Size(370, 48);
            btnIngresar.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.BackColor = Color.FromArgb(37, 99, 235);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Click += BtnIngresar_Click;
            // Hover
            btnIngresar.MouseEnter += (s, e2) => btnIngresar.BackColor = Color.FromArgb(29, 78, 216);
            btnIngresar.MouseLeave += (s, e2) => btnIngresar.BackColor = Color.FromArgb(37, 99, 235);
            pnlCenter.Controls.Add(btnIngresar);

            // Versión
            lblVersion.Text = "Sistema de Ventas v1.0  |  © 2026";
            lblVersion.ForeColor = Color.FromArgb(71, 85, 105);
            lblVersion.Font = new Font("Segoe UI", 8);
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(130, 300);
            pnlCenter.Controls.Add(lblVersion);

            // ── Ensamblado ────────────────────────────────────────
            pnlTop.Controls.Add(lblTitle);
            this.Controls.Add(pnlCenter);
            this.Controls.Add(pnlTop);

            this.MouseDown += FormLogin_MouseDown;
            this.MouseMove += FormLogin_MouseMove;
            this.MouseUp += FormLogin_MouseUp;
            this.Name = "FormLogin";
            this.Text = "Login - Sistema de Ventas";
            this.ResumeLayout(false);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // TODO: Validar credenciales con base de datos
            string usuario = "";
            string password = "";

            // Buscar controles por nombre
            foreach (Control c in this.Controls)
                foreach (Control cc in c.Controls)
                {
                    if (cc is TextBox tb)
                    {
                        if (tb.PlaceholderText?.Contains("usuario") == true) usuario = tb.Text;
                        if (tb.PlaceholderText?.Contains("contraseña") == true) password = tb.Text;
                    }
                }

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación de ejemplo (reemplazar con consulta BD)
            if (usuario == "admin" && password == "admin")
            {
                FormPrincipal frmPrincipal = new FormPrincipal();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
