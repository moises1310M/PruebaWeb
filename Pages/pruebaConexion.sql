CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    NombreUsuario NVARCHAR(50) NOT NULL,
    Contrasena NVARCHAR(255) NOT NULL
);

INSERT INTO Usuarios (NombreUsuario, Contrasena) 
VALUES ('admin', 'admin123');
