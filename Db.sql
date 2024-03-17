create database EmpresaDeTransporte
Use EmpresaDeTransporte
/*					Tablas*/
CREATE TABLE Conductores (
    IdConductor INT IDENTITY PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNac DATE NOT NULL,
    Cedula VARCHAR(13) NOT NULL,
    IdAutobus INT,
    IdRuta INT,
    Disponibilidad BIT NOT NULL

);

CREATE TABLE Rutas (
    IdRuta INT IDENTITY PRIMARY KEY NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200) NOT NULL,
    IdConductor INT,
    IdAutobus INT,
    Disponibilidad BIT NOT NULL
);

CREATE TABLE Autobuses (
    IdAutobus INT IDENTITY PRIMARY KEY NOT NULL,
    Marca VARCHAR(50) NOT NULL,
    Modelo VARCHAR(200) NOT NULL,
    Placa VARCHAR(20) NOT NULL,
    Color VARCHAR(50) NOT NULL,
    Anio DATE NOT NULL,
    IdConductor INT,
    IdRuta INT,
    Disponibilidad BIT NOT NULL
);

CREATE TABLE RutaDeViaje (
    IdRutaViaje INT IDENTITY PRIMARY KEY NOT NULL,
    IdConductor INT,
    IdRuta INT,
    IdAutobus INT,
    CONSTRAINT Fk_IdConductor FOREIGN KEY (IdConductor) REFERENCES Conductores(IdConductor),
    CONSTRAINT Fk_IdRuta FOREIGN KEY (IdRuta) REFERENCES Rutas(IdRuta),
    CONSTRAINT Fk_IdAutobus FOREIGN KEY (IdAutobus) REFERENCES Autobuses(IdAutobus)
);

/*					Restricciones*/
ALTER TABLE Conductores
ADD CONSTRAINT Fk_Conductores_Autobuses FOREIGN KEY (IdAutobus) REFERENCES Autobuses(IdAutobus);

ALTER TABLE Conductores
ADD CONSTRAINT Fk_Conductores_Rutas FOREIGN KEY (IdRuta) REFERENCES Rutas(IdRuta);

ALTER TABLE Rutas
ADD CONSTRAINT Fk_Rutas_Conductores FOREIGN KEY (IdConductor) REFERENCES Conductores(IdConductor);

ALTER TABLE Rutas
ADD CONSTRAINT Fk_Rutas_Autobuses FOREIGN KEY (IdAutobus) REFERENCES Autobuses(IdAutobus);

ALTER TABLE Autobuses
ADD CONSTRAINT Fk_Autobuses_Conductores FOREIGN KEY (IdConductor) REFERENCES Conductores(IdConductor);

ALTER TABLE Autobuses
ADD CONSTRAINT Fk_Autobuses_Rutas FOREIGN KEY (IdRuta) REFERENCES Rutas(IdRuta);


-- CRUD por entidad

-- Conductores
CREATE PROCEDURE CrearConductor(
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaNac DATE,
    @Cedula VARCHAR(13)
	)
AS
BEGIN
    INSERT INTO Conductores (Nombre, Apellido, FechaNac, Cedula, Disponibilidad)
    VALUES (@Nombre, @Apellido, @FechaNac, @Cedula, 0)
END

CREATE PROCEDURE ActualizarConductor(
    @IdConductor INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaNac DATE,
    @Cedula VARCHAR(13))
AS
BEGIN
    UPDATE Conductores
    SET Nombre = @Nombre, Apellido = @Apellido, FechaNac = @FechaNac, Cedula = @Cedula
    WHERE IdConductor = @IdConductor
END

-- Crear procedimiento almacenado para eliminar conductor
CREATE PROCEDURE EliminarConductor
    (@IdConductor INT)
AS
BEGIN
	ALTER TABLE Rutas NOCHECK CONSTRAINT ALL;

    -- Eliminar la fila de la tabla principal
    DELETE FROM Conductores WHERE IdConductor = @IdConductor

    -- Volver a activar las restricciones de clave externa
    ALTER TABLE Rutas CHECK CONSTRAINT ALL;
END
-- Crear procedimiento almacenado para crear autobús
CREATE PROCEDURE CrearAutobus
    (@Marca VARCHAR(50),
    @Modelo VARCHAR(200),
    @Placa VARCHAR(20),
    @Color VARCHAR(50),
    @Anio DATE)
AS
BEGIN
    INSERT INTO Autobuses (Marca, Modelo, Placa, Color, Anio,Disponibilidad)
    VALUES (@Marca, @Modelo, @Placa, @Color, @Anio,0)
END

-- Crear procedimiento almacenado para actualizar autobús
CREATE PROCEDURE ActualizarAutobus
    (@IdAutobus INT,
    @Marca VARCHAR(50),
    @Modelo VARCHAR(200),
    @Placa VARCHAR(20),
    @Color VARCHAR(50),
    @Anio DATE)
AS
BEGIN
    UPDATE Autobuses
    SET Marca = @Marca, Modelo = @Modelo, Placa = @Placa, Color = @Color, Anio = @Anio
    WHERE IdAutobus = @IdAutobus
END

-- Crear procedimiento almacenado para eliminar autobús
CREATE PROCEDURE EliminarAutobus
    (@IdAutobus INT)
AS
BEGIN
	ALTER TABLE Rutas NOCHECK CONSTRAINT ALL;

    -- Eliminar la fila de la tabla principal
    DELETE FROM Autobuses WHERE IdAutobus = @IdAutobus

    -- Volver a activar las restricciones de clave externa
    ALTER TABLE Rutas CHECK CONSTRAINT ALL;
END

-- Crear procedimiento almacenado para crear ruta
CREATE PROCEDURE CrearRuta
    (@Nombre VARCHAR(50),
    @Descripcion VARCHAR(200))
AS
BEGIN
    INSERT INTO Rutas (Nombre, Descripcion,Disponibilidad)
    VALUES (@Nombre, @Descripcion,0)
END

-- Crear procedimiento almacenado para actualizar ruta
CREATE PROCEDURE ActualizarRuta
    (@IdRuta INT,
    @Nombre VARCHAR(50),
    @Descripcion VARCHAR(200))
AS
BEGIN
    UPDATE Rutas
    SET Nombre = @Nombre, Descripcion = @Descripcion
    WHERE IdRuta = @IdRuta
END

-- Crear procedimiento almacenado para eliminar ruta
CREATE PROCEDURE EliminarRuta
    (@IdRuta INT)
AS
BEGIN
	ALTER TABLE Rutas NOCHECK CONSTRAINT ALL;

    -- Eliminar la fila de la tabla principal
    DELETE FROM Rutas WHERE IdRuta = @IdRuta

    -- Volver a activar las restricciones de clave externa
    ALTER TABLE Rutas CHECK CONSTRAINT ALL;
END

-- Crear procedimiento almacenado para ver conductores disponibles
CREATE PROCEDURE VerConductoresDisponibles
AS
BEGIN
    SELECT * FROM Conductores WHERE Disponibilidad = 0
END
Execute VerConductoresDisponibles
-- Crear procedimiento almacenado para ver autobuses disponibles
CREATE PROCEDURE VerAutobusesDisponibles
AS
BEGIN
    SELECT * FROM Autobuses WHERE Disponibilidad = 0
END

-- Crear procedimiento almacenado para ver rutas disponibles
CREATE PROCEDURE VerRutasDisponibles
AS
BEGIN
    SELECT * FROM Rutas WHERE Disponibilidad = 0
END

-- Crear procedimiento almacenado para ver conductor por ID
CREATE PROCEDURE VerConductorPorId
    (@IdConductor INT)
AS
BEGIN
    SELECT * FROM Conductores WHERE IdConductor = @IdConductor
END


CREATE PROCEDURE VerTravelPorId
    (@IdTravel INT)
AS
BEGIN
    SELECT * FROM RutaDeViaje WHERE IdRutaViaje = @IdTravel
END
-- Crear procedimiento almacenado para ver autobús por ID
CREATE PROCEDURE VerAutobusPorId
    (@IdAutobus INT)
AS
BEGIN
    SELECT * FROM Autobuses WHERE IdAutobus = @IdAutobus
END

-- Crear procedimiento almacenado para ver ruta por ID
CREATE PROCEDURE VerRutaPorId
    (@IdRuta INT)
AS
BEGIN
    SELECT * FROM Rutas WHERE IdRuta = @IdRuta
END





-- Crear procedimiento almacenado para actualizar conductor por entidad
CREATE PROCEDURE ActualizarConductorPorEntidad
    (@IdConductor INT,
    @IdAutobus INT NULL, -- Permitir valores nulos
    @IdRuta INT NULL, -- Permitir valores nulos
    @ValorDisponibilidad bit)
AS
BEGIN
    UPDATE Conductores
    SET IdAutobus = @IdAutobus, IdRuta = @IdRuta, Disponibilidad = @ValorDisponibilidad
    WHERE IdConductor = @IdConductor
END






EXEC ActualizarAutobusPorEntidad @IdAutobus = 1, @IdConductor = null, @IdRuta = null, @ValorDisponibilidad = 0;
EXEC ActualizarConductorPorEntidad @IdConductor = 1, @IdAutobus = null, @IdRuta = null, @ValorDisponibilidad = 0;
EXEC ActualizarRutaPorEntidad @IdRuta = 1, @IdConductor = null, @IdAutobus = null, @ValorDisponibilidad = 0;
Drop Procedure ActualizarConductorPorEntidad
-- Crear procedimiento almacenado para actualizar autobús por entidad
CREATE PROCEDURE ActualizarAutobusPorEntidad
    (@IdAutobus INT,
    @IdConductor INT,
    @IdRuta INT,
	@ValorDisponibilidad bit)
AS
BEGIN
    UPDATE Autobuses
    SET IdConductor = @IdConductor, IdRuta = @IdRuta, Disponibilidad = @ValorDisponibilidad
    WHERE IdAutobus = @IdAutobus
END
Drop Procedure ActualizarAutobusPorEntidad

-- Crear procedimiento almacenado para actualizar ruta por entidad
CREATE PROCEDURE ActualizarRutaPorEntidad
    (@IdRuta INT,
    @IdConductor INT,
    @IdAutobus INT,
	@ValorDisponibilidad bit)
AS
BEGIN
    UPDATE Rutas
    SET IdConductor = @IdConductor, IdAutobus = @IdAutobus, Disponibilidad = @ValorDisponibilidad
    WHERE IdRuta = @IdRuta
END
Drop Procedure ActualizarRutaPorEntidad

-- Procedimientos almacenados para seleccionar toda la tabla de cada entidad

-- Para Conductores
CREATE PROCEDURE SeleccionarTodosConductores
AS
BEGIN
    SELECT * FROM Conductores
END

-- Para Autobuses
CREATE PROCEDURE SeleccionarTodosAutobuses
AS
BEGIN
    SELECT * FROM Autobuses
END

-- Para Rutas
CREATE PROCEDURE SeleccionarTodasRutas
AS
BEGIN
    SELECT * FROM Rutas
END

-- Para RutaDeViaje (si es necesario)
CREATE PROCEDURE SeleccionarTodasRutasDeViaje
AS
BEGIN
    SELECT * FROM RutaDeViaje
END


CREATE PROCEDURE CrearRutaDeViaje
    @IdConductor INT,
    @IdRuta INT,
    @IdAutobus INT
AS
BEGIN
    INSERT INTO RutaDeViaje (IdConductor, IdRuta, IdAutobus)
    VALUES (@IdConductor, @IdRuta, @IdAutobus);
END;

CREATE PROCEDURE EliminarRutaDeViaje
    @IdRutaViaje INT
AS
BEGIN
    DELETE FROM RutaDeViaje
    WHERE IdRutaViaje = @IdRutaViaje;
END;

CREATE PROCEDURE ActualizarRutaDeViaje
    @IdRutaViaje INT,
    @IdConductor INT,
    @IdRuta INT,
    @IdAutobus INT
AS
BEGIN
    UPDATE RutaDeViaje
    SET IdConductor = @IdConductor,
        IdRuta = @IdRuta,
        IdAutobus = @IdAutobus
    WHERE IdRutaViaje = @IdRutaViaje;
END;



/*Datos-----------*/
INSERT INTO Conductores (Nombre, Apellido, FechaNac, Cedula, Disponibilidad)
VALUES 
('Juan', 'Perez', '15/05/1990', '1234567890123', 0),
('Maria', 'Gonzalez', '20/08/1985', '9876543210987', 0),
('Carlos', 'Martinez', '10/12/1988', '5678901234567', 0),
('Luis', 'Hernandez', '25/04/1992', '2345678901234', 0),
('Ana', 'Lopez', '30/07/1995', '8901234567890', 0),
('Laura', 'Diaz', '05/09/1993', '4567890123456', 0),
('Pedro', 'Sanchez', '18/11/1987', '0123456789012', 0),
('Sofia', 'Ramirez', '22/02/1991', '6789012345678', 0),
('Daniel', 'Torres', '12/06/1989', '3456789012345', 0),
('Alejandro', 'Flores', '08/10/1986', '9012345678901', 0);
INSERT INTO Rutas (Nombre, Descripcion, Disponibilidad)
VALUES 
('Ruta 1', 'Descripción de la Ruta 1', 0),
('Ruta 2', 'Descripción de la Ruta 2', 0),
('Ruta 3', 'Descripción de la Ruta 3', 0),
('Ruta 4', 'Descripción de la Ruta 4', 0),
('Ruta 5', 'Descripción de la Ruta 5', 0),
('Ruta 6', 'Descripción de la Ruta 6', 0),
('Ruta 7', 'Descripción de la Ruta 7', 0),
('Ruta 8', 'Descripción de la Ruta 8', 0),
('Ruta 9', 'Descripción de la Ruta 9', 0),
('Ruta 10', 'Descripción de la Ruta 10', 0);
INSERT INTO Autobuses (Marca, Modelo, Placa, Color, Anio, Disponibilidad)
VALUES 
('Marca 1', 'Modelo 1', 'ABC123', 'Rojo', '01/01/2018', 0),
('Marca 2', 'Modelo 2', 'DEF456', 'Azul', '01/02/2019', 0),
('Marca 3', 'Modelo 3', 'GHI789', 'Verde', '01/03/2020', 0),
('Marca 4', 'Modelo 4', 'JKL012', 'Blanco', '01/04/2021', 0),
('Marca 5', 'Modelo 5', 'MNO345', 'Negro', '01/05/2017', 0),
('Marca 6', 'Modelo 6', 'PQR678', 'Gris', '01/06/2016', 0),
('Marca 7', 'Modelo 7', 'STU901', 'Amarillo', '01/07/2015', 0),
('Marca 8', 'Modelo 8', 'VWX234', 'Naranja', '01/08/2014', 0),
('Marca 9', 'Modelo 9', 'YZA567', 'Morado', '01/09/2013', 0),
('Marca 10', 'Modelo 10', 'BCD890', 'Café', '01/10/2012', 0);
