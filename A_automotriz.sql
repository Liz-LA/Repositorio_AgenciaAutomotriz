CREATE DATABASE A_automotriz;
USE A_automotriz;
a_automotriza_automotriz

CREATE TABLE Usuarios (
    idUsuario INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    Nombre VARCHAR(255) NOT NULL,
    Apellidop VARCHAR(255) NOT NULL,
    Apellidom VARCHAR(255),
    Fechadenacimiento DATE,
    Rfc VARCHAR(15) UNIQUE,
    NombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    Clave VARCHAR(255) NOT NULL,  -- Se recomienda almacenar la clave encriptada
    Rol VARCHAR(50)
);

create table Productos(
Codigo_Barras int primary key not null,
Nombre varchar(255),
Descripcion varchar(255),
Marca varchar(255));

DROP TABLE productos;

create table Herramientas(
Codigo_Herramienta int primary key not null,
Nombre varchar(255),
Medida varchar(50),
Marca varchar(50),
Descripcion varchar(255));

DROP TABLE herramientas;

CREATE TABLE Permisos (
    idPermiso INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    idUsuario INT NOT NULL,
    Productos VARCHAR(50) NOT NULL,
    Herramientas varchar(20) NOT NULL,
    PermisoLectura BIT,
    PermisoEscritura BIT,
    PermisoEliminacion BIT,
    PermisoActualizacion BIT,
    FOREIGN KEY (idUsuario) REFERENCES Usuarios(idUsuario)
);


-- -------------------------------------

CREATE TABLE Permisos (
    idPermiso INT PRIMARY KEY AUTO_INCREMENT,
    idUsuario INT,
    idFormulario INT,
    Lectura BIT DEFAULT 0,
    Escritura BIT DEFAULT 0,
    Actualizacion BIT DEFAULT 0,
    Eliminacion BIT DEFAULT 0,
    FOREIGN KEY (idUsuario) REFERENCES Usuarios(idUsuario),
    FOREIGN KEY (idFormulario) REFERENCES Formularios(idFormulario)
);


CREATE TABLE Formularios (
    idFormulario INT PRIMARY KEY AUTO_INCREMENT,
    NombreFormulario VARCHAR(255) UNIQUE
);



-- --------------------------------------------------------------------------------------

Procedures de la tabla usuarios 

DELIMITER //

DROP PROCEDURE IF EXISTS p_insertar_usuario;

CREATE PROCEDURE p_insertar_usuario
(
    IN _nombre VARCHAR(255),
    IN _apellidop VARCHAR(255),
    IN _apellidom VARCHAR(255),
    IN _fechanacimiento DATE,
    IN _rfc VARCHAR(15),
    IN _nombreUsuario VARCHAR(50),
    IN _clave VARCHAR(255),
    IN _rol VARCHAR(255)
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Inserta el nuevo usuario
    INSERT INTO Usuarios (Nombre, Apellidop, Apellidom, Fechadenacimiento, Rfc, NombreUsuario, Clave, Rol)
    VALUES (_nombre, _apellidop, _apellidom, _fechanacimiento, _rfc, _nombreUsuario, _clave, _rol);

    COMMIT;
END //

DELIMITER ;



DROP PROCEDURE IF EXISTS p_eliminar_usuario;

CREATE PROCEDURE p_eliminar_usuario
(
    IN _idUsuario INT
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Eliminar el usuario
    DELETE FROM Usuarios WHERE idUsuario = _idUsuario;

    COMMIT;
END //

DELIMITER ;



DELIMITER //

DROP PROCEDURE IF EXISTS p_modificar_usuario;

CREATE PROCEDURE p_modificar_usuario
(
    IN _idUsuario INT,
    IN _nombre VARCHAR(255),
    IN _apellidop VARCHAR(255),
    IN _apellidom VARCHAR(255),
    IN _fechanacimiento DATE,
    IN _rfc VARCHAR(15),
    IN _nombreUsuario VARCHAR(50),
    IN _clave VARCHAR(255),
    IN _rol VARCHAR(50)  -- Se agregó el parámetro del Rol
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Modificar el usuario
    UPDATE Usuarios 
    SET 
        Nombre = _nombre,
        Apellidop = _apellidop,
        Apellidom = _apellidom,
        Fechadenacimiento = _fechanacimiento,
        Rfc = _rfc,
        NombreUsuario = _nombreUsuario,
        Clave = _clave,  -- Asegúrate de que la clave esté encriptada
        Rol = _rol  -- Se agregó la actualización del Rol
    WHERE idUsuario = _idUsuario;

    COMMIT;
END //

DELIMITER ;


-----------------------------------------------------------------------------------------
Procedures de la tabla productos 
DELIMITER //

DROP PROCEDURE IF EXISTS p_insertar_producto;

CREATE PROCEDURE p_insertar_producto
(
    IN _codigoBarras VARCHAR(20),
    IN _nombre VARCHAR(255),
    IN _descripcion VARCHAR(255),
    IN _marca VARCHAR(255)
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Insertar el nuevo producto
    INSERT INTO Productos (Codigo_Barras, Nombre, Descripcion, Marca)
    VALUES (_codigoBarras, _nombre, _descripcion, _marca);

    COMMIT;
END //

DELIMITER ;
DELIMITER //

DROP PROCEDURE IF EXISTS p_eliminar_producto;

CREATE PROCEDURE p_eliminar_producto
(
    IN _codigoBarras VARCHAR(20)
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Eliminar el producto
    DELETE FROM Productos WHERE Codigo_Barras = _codigoBarras;

    COMMIT;
END //

DELIMITER ;
DELIMITER //

DROP PROCEDURE IF EXISTS p_actualizar_producto;

CREATE PROCEDURE p_actualizar_producto
(
    IN _codigoBarras VARCHAR(20),
    IN _nombre VARCHAR(255),
    IN _descripcion VARCHAR(255),
    IN _marca VARCHAR(255)
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Actualizar el producto
    UPDATE Productos 
    SET 
        Nombre = _nombre,
        Descripcion = _descripcion,
        Marca = _marca
    WHERE Codigo_Barras = _codigoBarras;

    COMMIT;
END //

DELIMITER ;

---------------------------------------------------------------------------------------
Procedimientos de la tabla Herramientas

DELIMITER //

DROP PROCEDURE IF EXISTS p_insertar_herramienta;

CREATE PROCEDURE p_insertar_herramienta
(
    IN _codigoHerramienta VARCHAR(50),
    IN _nombre VARCHAR(255),
    IN _medida VARCHAR(50),
    IN _marca VARCHAR(50),
    IN _descripcion VARCHAR(255)
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Insertar la nueva herramienta
    INSERT INTO Herramientas (Codigo_Herramienta, Nombre, Medida, Marca, Descripcion)
    VALUES (_codigoHerramienta, _nombre, _medida, _marca, _descripcion);

    COMMIT;
END //

DELIMITER ;

DELIMITER //

DROP PROCEDURE IF EXISTS p_eliminar_herramienta;

CREATE PROCEDURE p_eliminar_herramienta
(
    IN _codigoHerramienta VARCHAR(50)
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Eliminar la herramienta
    DELETE FROM Herramientas WHERE Codigo_Herramienta = _codigoHerramienta;

    COMMIT;
END //

DELIMITER ;

DELIMITER //

DROP PROCEDURE IF EXISTS p_actualizar_herramienta;

CREATE PROCEDURE p_actualizar_herramienta
(
    IN _codigoHerramienta VARCHAR(50),
    IN _nombre VARCHAR(255),
    IN _medida VARCHAR(50),
    IN _marca VARCHAR(50),
    IN _descripcion VARCHAR(255)
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Actualizar la herramienta
    UPDATE Herramientas 
    SET 
        Nombre = _nombre,
        Medida = _medida,
        Marca = _marca,
        Descripcion = _descripcion
    WHERE Codigo_Herramienta = _codigoHerramienta;

    COMMIT;
END //

DELIMITER ;

------------------------------------------------------------------------------------------
DELIMITER //
DROP PROCEDURE IF EXISTS p_Validar;
CREATE PROCEDURE p_Validar
(
	IN _NombreUsuario VARCHAR(50),
	IN _Clave VARCHAR(255)
	
)
BEGIN 

	DECLARE x INT;
	SELECT COUNT(*) INTO x FROM usuarios WHERE NombreUsuario= _NombreUsuario AND Clave = _Clave;
	if X > 0 then
	
		SELECT 'C0rr3ct0' AS rs,(SELECT rol FROM usuarios WHERE NombreUsuario = _NombreUsuario) AS rol;
		
	ELSE  
	
		SELECT 'Error' AS rs, 0 AS rol;
		
	end if;
	
END //

DELIMITER ;


CALL p_Validar('liz',SHA1('123'));
CALL p_Validar('ana',SHA1('123'));


-- ---------------------------------------------------

CALL p_insertar_usuario(
    'Lizbeth',
    'Lopez',
    'Abundiz',
    '1995-06-12',  
    'LIZL9506',  
    'liz',
    SHA1('123'),
    'superusuario'
);

CALL p_insertar_usuario(
    'Ana',
    'Santos',
    'Pedroza',
    '1995-06-12',  
    'RTCVL9506',  
    'ana',
    SHA1('123'),
    'usuario'
);



SELECT * FROM usuarios;

SELECT * FROM permisos;




CREATE DATABASE LIZBETH;
USE LIZBETH;


SELECT COUNT(*) 
FROM Permisos 
WHERE idUsuario = 1 AND idFormulario = 1;

SELECT COUNT(*) 
FROM Permisos 
WHERE idUsuario = @idUsuario AND idFormulario = @idFormulario;


SELECT u.NombreUsuario, f.NombreFormulario, p.Lectura, p.Escritura, p.Actualizacion
FROM Permisos p
JOIN Usuarios u ON p.idUsuario = u.idUsuario
JOIN Formularios f ON p.idFormulario = f.idFormulario;

TRUNCATE permisos;
