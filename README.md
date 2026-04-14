# 🛒 Sistema de Ventas (Point of Sale)

![Estado del Proyecto](https://img.shields.io/badge/Estado-En%20Desarrollo-green)
![Tecnología](https://img.shields.io/badge/C%23-.NET-blue)
![DB](https://img.shields.io/badge/SQL%20Server-Database-red)

## 📝 Descripción
Este es un sistema integral de gestión de ventas e inventario diseñado para optimizar el control de negocios. Permite gestionar productos, categorías, ventas, proveedores y usuarios con diferentes niveles de acceso.

El proyecto está desarrollado utilizando **C#** con el framework **.NET**, siguiendo una arquitectura robusta y una interfaz de usuario intuitiva.

## ✨ Características Principales
- **Dashboard:** Resumen visual de las ventas y estadísticas clave.
- **Gestión de Inventario:** Control total de productos, stock, categorías y marcas.
- **Módulo de Ventas:** Registro de transacciones en tiempo real con generación de recibos/comprobantes.
- **Gestión de Usuarios:** Sistema de login y roles (Administrador, Empleado).
- **Proveedores:** Directorio y control de compras a proveedores.
- **Reportes:** Generación de reportes detallados en formatos descargables (PDF/Excel).

## 🚀 Tecnologías Utilizadas
*   **Lenguaje:** C#
*   **Framework:** .NET (ASP.NET MVC / WinForms - *ajustar según corresponda*)
*   **Base de Datos:** Microsoft SQL Server
*   **Frontend:** Bootstrap, HTML5, CSS3 (si es Web) / Material Design (si es Desktop)
*   **ORM/Acceso a datos:** Entity Framework / Dapper

## 🛠️ Instalación y Configuración

Sigue estos pasos para ejecutar el proyecto localmente:

### Requisitos Previos
*   Visual Studio 2019 o superior.
*   SQL Server Management Studio (SSMS).
*   .NET SDK (versión correspondiente).

### Pasos a seguir:

1.  **Clonar el repositorio:**
    ```bash
    git clone https://github.com/josesipres01/SistemaVentas.git
    ```

2.  **Configurar la Base de Datos:**
    *   Abre SQL Server Management Studio.
    *   Busca la carpeta `Database` o `Scripts` dentro del proyecto.
    *   Ejecuta el archivo `.sql` para crear la estructura de las tablas y los datos iniciales.

3.  **Configurar Cadena de Conexión:**
    *   Abre la solución (`.sln`) en Visual Studio.
    *   Busca el archivo `appsettings.json` o `Web.config`.
    *   Actualiza la cadena de conexión (`ConnectionString`) con tus credenciales locales de SQL Server.

4.  **Ejecutar el proyecto:**
    *   Presiona `F5` o haz clic en el botón **Iniciar** en Visual Studio.


## 👤 Autor
*   **Jose Sipres** - [josesipres01](https://github.com/josesipres01)

