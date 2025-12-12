DROP DATABASE IF EXISTS bd_Bookflix;
CREATE DATABASE bd_Bookflix;
USE bd_Bookflix;

CREATE TABLE Registro (
    idRegistro INT AUTO_INCREMENT PRIMARY KEY,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    Contrasena VARCHAR(50) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL;
);

CREATE TABLE Libro (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Titulo VARCHAR(255) NOT NULL,
    Autor VARCHAR(255) NOT NULL,
    Anio INT,
    Descripcion TEXT,
    Precio DECIMAL(10,2) NOT NULL,
    Imagen VARCHAR(255),
    Categoria VARCHAR(100);
);

