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
Bootstrap 5	Diseño y UI responsivo
Session / TempData	Manejo del carrito y estado del usuario
Identity / RegistroService	Registro y autenticación de usuarios
Git / GitHub	Control de versiones
👨‍💻 Estructura y Explicación Técnica
📌 Program.cs

Configura servicios de Razor Pages.

Configura sesión para manejo de carrito y usuario logueado.

Inyección de dependencias para RegistroService y LibroService.

Configura rutas, middlewares y seguridad básica.

📌 Models

Libro:

public class Libro {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anio { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public string Imagen { get; set; }
    public string Categoria { get; set; }
}


Registro/Usuario: correo, contraseña, nombre y apellido.

CarritoItem: libro + cantidad (para el carrito en sesión).

📌 Pages

Las Razor Pages se organizan por módulos: Index, Login, Registro, Carrito, LibroDetalle.

Cada página tiene su PageModel con la lógica OnGet / OnPost.

Libros cargados desde JSON (wwwroot/data/libros.json) o MySQL.

Categorías dinámicas generadas automáticamente.

Filtrado de libros por título, autor y categoría.

Carrito manejado con sesión y mensajes con TempData.

Registro de usuarios con validaciones y login con sesión activa.

Estilos con Bootstrap 5 para formularios, botones y tarjetas de libros.

🔹 Funcionalidades

✅ Visualización de libros desde JSON o base de datos.

✅ Búsqueda de libros por título o autor.

✅ Filtrado por categorías dinámicas.

✅ Carrito de compras en sesión con cantidad y total calculado.

✅ Registro de usuarios con validaciones:

Correo Gmail obligatorio.

Contraseña mínima de 6 caracteres.

✅ Inicio de sesión y sesión activa del usuario.

✅ Mensajes de error y éxito dinámicos en la UI.

✅ Interfaz amigable, responsive y moderna con Bootstrap 5.

📂 Estructura de Carpetas
Bookflix/
│
├─ wwwroot/
│   ├─ data/
│   │   └─ libros.json
│   ├─ img/
│   └─ css/
│
├─ Pages/
│   ├─ Index.cshtml (+ PageModel)
│   ├─ Login.cshtml (+ PageModel)
│   ├─ Registro.cshtml (+ PageModel)
│   ├─ Carrito.cshtml (+ PageModel)
│   └─ LibroDetalle.cshtml (+ PageModel)
│
├─ Models/
│   ├─ Libro.cs
│   ├─ Registro.cs
│   └─ CarritoItem.cs
│
├─ Services/
│   └─ RegistroService.cs
│
└─ Program.cs

🔧 Cómo Ejecutar el Proyecto

Clonar el repositorio:

git clone https://github.com/tuusuario/bookflix.git


Restaurar dependencias:

dotnet restore


Ejecutar el proyecto:

dotnet run


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
