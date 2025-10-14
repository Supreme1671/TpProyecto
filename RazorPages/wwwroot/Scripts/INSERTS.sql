USE bd_Bookflix;

INSERT INTO Registro (Correo, Contrasena)
VALUES ('admin@gmail.com', 'admin123'),
       ('usuario1@gmail.com', 'clave123'),
       ('usuario2@gmail.com', 'pass456');

INSERT INTO Libro (Titulo, Autor, Anio, Descripcion, Precio, Imagen, Categoria)
VALUES 
('Cien años de soledad', 'Gabriel García Márquez', 1967, 'Novela emblemática del realismo mágico latinoamericano.', 12000.50, 'img/cien_anos.jpg', 'Novela'),
('El principito', 'Antoine de Saint-Exupéry', 1943, 'Cuento filosófico sobre la inocencia y la amistad.', 9500.00, 'img/principito.jpg', 'Infantil'),
('1984', 'George Orwell', 1949, 'Distopía sobre la vigilancia y el control estatal.', 10500.00, 'img/1984.jpg', 'Ciencia Ficción');
