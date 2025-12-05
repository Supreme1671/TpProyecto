# 📚 Proyecto TP – Bookflix (Razor Pages)

---

## 👥 Integrantes del grupo
- **Casimiro Enzo**
- **Sofía Gonzalez**
- **Yanina Piuca**

---
📘 1. Misión

Permitir a los usuarios acceder a una amplia variedad de libros digitales que puedan comprar y leer desde cualquier dispositivo. La plataforma facilita guardar libros favoritos, realizar compras sin necesidad de ir a una librería física y ahorrar tiempo; además, promueve la lectura mediante un entorno totalmente digital.
🛠️ Tecnologías Utilizadas
Tecnología	Uso
ASP.NET Core 9 (Razor Pages)	Backend + Frontend
C#	Lógica del sistema
JSON / MySQL	Persistencia de datos (libros y usuarios)
Bootstrap 5	Diseño y UI
Session / TempData	Manejo de carrito y estado de usuario
Identity / RegistroService	Autenticación y registro de usuarios
Git / GitHub	Control de versiones
👨‍💻 Explicación del Código (Resumen Técnico)
📌 Program.cs

Configura servicios de Razor Pages.

Configura sesión para manejar carrito y usuario logueado.

Configura rutas, middlewares y seguridad básica.

Inyección de dependencias de servicios como RegistroService y LibroService.

📌 Models

Libro: ID, Título, Autor, Año, Descripción, Precio, Imagen, Categoría.

Registro/Usuario: Correo, Contraseña, Nombre, Apellido.

CarritoItem: Libro + Cantidad (para manejo del carrito en sesión).

📌 Pages

Las Razor Pages se dividen en carpetas según módulos: Index, Login, Registro, Carrito, LibroDetalle.

Cada página tiene su PageModel con la lógica (OnGet, OnPost).

Manejo de libros desde JSON (wwwroot/data/libros.json) para cargar datos.

Categorías únicas generadas dinámicamente desde los libros.

Filtro por búsqueda y categoría.

Carrito manejado con sesión (HttpContext.Session) y mensajes con TempData.

Inicio de sesión y registro de usuarios conectados a MySQL vía RegistroService.

Validaciones de usuario y correo con mensajes de error en la interfaz.

Estilos modernos con Bootstrap 5 para formularios, botones y tarjetas de libros.

🔹 Funcionalidades

Visualización de libros desde JSON o base de datos.

Búsqueda por título o autor.

Filtrado por categoría.

Carrito de compras en sesión, con total y cantidad de libros.

Registro de usuarios con validaciones (correo Gmail obligatorio, contraseña mínima).

Inicio de sesión con sesión activa.

Interfaz amigable y responsive con Bootstrap 5.

Mensajes de éxito/error dinámicos para carrito y login/registro.

## 📝 Lista de Tareas

| Tarea | Descripción | Duración | Precedencia | Encargados |
|------|-------------|----------|-------------|------------|
| A | Crear repositorio GitHub | 15 min | –––– | Enzo Casimiro |
| B | Crear proyecto en HTML (estructura básica) | 2 h | –––– | Enzo Casimiro |
| C | Crear proyecto en Razor Pages | 1 h | B | Enzo Casimiro |
| D | Implementar contenido HTML en Razor Pages | 40 min | C | Enzo Casimiro, Yanina Piuca, Sofía Gonzalez |
| E | Crear login/registro de usuario | 2 h | C | Enzo Casimiro |
| F | Modificar pantalla principal | 2 h | E | Sofía Gonzalez, Yanina Piuca, Enzo Casimiro |
| G | Agregar libros a la pantalla principal | 1 h | F | Yanina Piuca, Enzo Casimiro, Sofía Gonzalez |
| H | Botón “Ver más” (más info del libro) | 1 h | G | Enzo Casimiro |
| I | Agregar filtros por categoría | 1 h | G | Enzo Casimiro, Yanina Piuca, Sofía Gonzalez |
| J | Agregar buscador | 2 h | G | Enzo Casimiro |
| K | Agregar diseño | 1 h | F | Sofía Gonzalez, Yanina Piuca |
| L | Crear Base de Datos | 5 h | B, C | Enzo Casimiro |

---

Duración total estimada: **10.25 horas**

Diagrama de Gantt
<img width="868" height="250" alt="Captura de pantalla de 2025-12-05 14-24-53" src="https://github.com/user-attachments/assets/a094ebdf-389c-4bf2-9fef-146c772ce437" />


---

## 📄 Descripción general
Proyecto creado con **ASP.NET Razor Pages**, con gestión de libros, login, filtros, buscador y base de datos propia.

---
