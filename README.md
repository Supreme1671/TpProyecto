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

🟦 1. Proyecto Frontend: Razor Pages

Ubicación:
/RazorPages

Es la aplicación web encargada de mostrar todas las pantallas (UI).
Usa:

ASP.NET Core Razor Pages

HTML + CSS

C# para manejar la lógica de páginas

Integración con el backend mediante servicios o clases internas

✔ Estructura típica encontrada:

Pages/

Index.cshtml → pantalla principal con listado de libros

Login.cshtml → login y registro

LibroDetalle.cshtml → página del botón "Ver más"

Categorias.cshtml → filtros por género (fantasía, acción, etc.)

Buscar.cshtml → buscador

wwwroot/

CSS

Imágenes

Scripts

Models/

Clases como Libro, Usuario, Categoria, etc.

Services/

Servicios intermediarios entre frontend y backend

Ejemplo: LibroService, UsuarioService

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
