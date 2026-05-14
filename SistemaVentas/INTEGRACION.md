# 📋 Instrucciones de Integración — Sistema de Ventas
## Visual Studio 2026 (Windows Forms · C#)

---

## Archivos incluidos

| Archivo | Pantalla |
|---|---|
| `FormLogin.cs` | Acceso al sistema — sin bordes, arrastrable, degradado |
| `FormPrincipal.cs` | Pantalla principal — menú lateral con submenús, dashboard de KPIs |
| `FormClientes.cs` | Gestión de clientes — DataGrid + búsqueda + CRUD |
| `FormFactura.cs` | Emisión de Facturas / Recibos — detalle, totales, IGV |
| `FormProducto.cs` | Registro de productos + generación de código de barras |
| `FormReportes.cs` | Reportes de ventas — filtros, KPIs, vista previa de impresión |

---

## Cómo agregar los formularios a tu proyecto

### Opción A — Agregar archivos existentes (recomendado)
1. En **Explorador de soluciones**, clic derecho sobre tu proyecto → **Agregar → Elemento existente...**
2. Selecciona todos los archivos `.cs` de la carpeta entregada.
3. Visual Studio los importa directamente. Verás cada Form en el diseñador.

> ⚠️ **Nota importante**: Estos formularios fueron escritos en **code-only** (sin archivo `.Designer.cs` separado).
> Al abrir el archivo, Visual Studio puede mostrar un aviso. Simplemente haz clic en **"Sí"** para continuar.
> El diseñador visual NO es necesario; todo el UI se construye por código en `InitializeComponent()`.

---

## Ajustar el namespace

Todos los archivos usan:
```csharp
namespace SistemaVentas.Forms
```

Si tu proyecto tiene un namespace diferente, haz **Ctrl+H** (Reemplazar en archivos) y cambia:
- Buscar: `SistemaVentas.Forms`
- Reemplazar: `TuNamespace.Forms`

---

## Punto de entrada: Program.cs

Edita tu `Program.cs` para iniciar con el login:
```csharp
using System;
using System.Windows.Forms;
using SistemaVentas.Forms;  // ← ajusta si cambiaste el namespace

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormLogin());  // ← pantalla de inicio
    }
}
```

---

## Cómo abrir formularios desde FormPrincipal

En `FormPrincipal.cs`, localiza el método `AbrirFormularioPorNombre(string nombre)` y reemplaza el switch por los formularios reales:

```csharp
private void AbrirFormularioPorNombre(string nombre)
{
    pnlContent.Controls.Clear();
    Form frm = nombre switch
    {
        "Lista de Clientes"  => new FormClientes(),
        "Nueva Venta"        => new FormFactura(),
        "Registrar Compra"   => new FormFactura(), // reusar o crear FormCompra
        "Categoría"          => new FormProducto(),
        "Productos"          => new FormProducto(),
        "Ventas"             => new FormReportes(),
        "Inventario"         => new FormReportes(),
        _                    => null
    };

    if (frm != null)
    {
        frm.TopLevel = false;       // Embeber dentro del panel
        frm.FormBorderStyle = FormBorderStyle.None;
        frm.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(frm);
        frm.Show();
    }
}
```

---

## Conectar la base de datos

Cada formulario tiene comentarios `// TODO:` marcando donde conectar tu BD.
Los archivos usan ADO.NET puro — agrega tu cadena de conexión en un archivo de configuración:

```csharp
// Ejemplo con SQL Server
string connStr = "Server=localhost;Database=SistemaVentas;Integrated Security=True;";
using (SqlConnection conn = new SqlConnection(connStr))
{
    conn.Open();
    // ... tu consulta
}
```

---

## Paleta de colores (CSS variables → C# Color)

| Uso | Color |
|---|---|
| Fondo oscuro / barra lateral | `Color.FromArgb(15, 23, 42)` |
| Header superior | `Color.FromArgb(30, 41, 59)` |
| Acento principal (azul) | `Color.FromArgb(37, 99, 235)` |
| Éxito (verde) | `Color.FromArgb(5, 150, 105)` |
| Peligro (rojo) | `Color.FromArgb(220, 38, 38)` |
| Fondo claro | `Color.FromArgb(241, 245, 249)` |
| Texto gris | `Color.FromArgb(100, 116, 139)` |

---

## Imágenes del proyecto

Los iconos extraídos del archivo `imagenes.7z` pueden cargarse así:

```csharp
// Ejemplo: cargar icono en un PictureBox
picIcono.Image = Image.FromFile(Application.StartupPath + @"\Resources\cliente.png");

// O desde recursos embebidos (recomendado para distribución):
// 1. Agrega la imagen en Propiedades → Recursos
// 2. picIcono.Image = Properties.Resources.cliente;
```

Carpetas de imágenes incluidas:
- `iconos azul sub menu/` → cliente, compra, empleados, producto, salir, stockminimo, venta
- `imagenes FORMDI/` → almacen, cerrar, compras, empleados, pagos, reportes, users, ventas, etc.
- `iconosisventa1.ico` y `logosisventa.ico` → ícono de la aplicación

Para usar el ícono de la app:
1. En las propiedades del proyecto → **Aplicación → Icono**: selecciona `logosisventa.ico`

---

## ¿Dudas?

Cada formulario está totalmente documentado con comentarios `// TODO:` donde debes conectar tu lógica de negocio. El diseño es consistente con la paleta de tu repositorio original.
