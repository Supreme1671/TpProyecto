# 📚 Proyecto TP – Bookflix (Razor Pages)

---

## 👥 Integrantes del grupo
- **Casimiro Enzo**
- **Sofía Gonzalez**
- **Yanina Piuca**

---
📘 1. Misión

Permitir a los usuarios acceder a una amplia variedad de libros digitales que puedan comprar y leer desde cualquier dispositivo. La plataforma facilita guardar libros favoritos, realizar compras sin necesidad de ir a una librería física y ahorrar tiempo; además, promueve la lectura mediante un entorno totalmente digital.
🧠 Arquitectura General del Proyecto

El proyecto está dividido en dos grandes módulos principales:

🛠️ Tecnologías Utilizadas
Tecnología	Uso
ASP.NET Core 9 (Razor Pages)	Backend + Frontend

C#	Lógica del sistema

Entity Framework Core	ORM y acceso a datos
SQL Server o MySQL	Base de datos
Bootstrap 5	Diseño y UI
Identity	Autenticación y roles
Git / GitHub	Control de versiones

👨‍💻 Explicación del Código (Resumen Técnico)
📌 Program.cs

Configura servicios de Razor Pages.

Conecta EF Core a la base.

Implementa Identity para registrar/administrar usuarios.

Configura rutas, middlewares y seguridad.

📌 Models

Libro: ID, Título, Autor, Año, Descripción, Precio, Imagen.

Usuario: Identidad + Perfil.

Compra / DetalleCompra: Relación 1-N entre usuario y compra.

Favorito: Relación M-M entre usuario y libro.

📌 Pages

Las Razor Pages se dividen en carpetas según módulos.

Cada página tiene su PageModel con la lógica (OnGet, OnPost).

Se maneja el acceso a la base vía inyección de dependencias.

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
<img width="912" height="233" alt="image" src="https://github.com/user-attachments/assets/94b7b999-9f2c-47d5-9a7a-6b38292c9b09" />

---

## 📄 Descripción general
Proyecto creado con **ASP.NET Razor Pages**, con gestión de libros, login, filtros, buscador y base de datos propia.

---
