CREATE DATABASE bd_Bookflix;
USE bd_Bookflix;

INSERT INTO Registro (idRegistro, Correo, Contrasena, Nombre, Apellido)
VALUES
 (1,'admin2@gmail.com', 'admin123', 'a', 'bb'),
 (2,'usuari1@gmail.com', 'clave123', '222', 'ss'),
 (3,'usuarios2@gmail.com', 'pass456', 'cas', 'sss');

-- Inserta libros
INSERT INTO Libro (Id,Titulo, Autor, Anio, Descripcion, Precio, Imagen, Categoria)
VALUES 
(1,'Cien años de soledad', 'Gabriel García Márquez', 1967, 'Novela emblemática del realismo mágico latinoamericano.', 12000.50, 'img/cien_anos.jpg', 'Novela'),
(2,'El principito', 'Antoine de Saint-Exupéry', 1943, 'Cuento filosófico sobre la inocencia y la amistad.', 9500.00, 'img/principito.jpg', 'Infantil'),
(3,'1984', 'George Orwell', 1949, 'Distopía sobre la vigilancia y el control estatal.', 10500.00, 'img/1984.jpg', 'Ciencia Ficción');

