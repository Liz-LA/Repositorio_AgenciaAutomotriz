CREATE TABLE Usuarios (
    idUsuario INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    Nombre VARCHAR(255) NOT NULL,
    Apellidop VARCHAR(255) NOT NULL,
    Apellidom VARCHAR(255),
    Fechadenacimiento DATE,
    Rfc VARCHAR(15) UNIQUE,
    NombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    Clave VARCHAR(255) NOT NULL  -- Se recomienda almacenar la clave encriptada
);


create table Productos(
Codigo_Barras varchar(20) primary key not null,
Nombre varchar(255),
Descripcion varchar(255),
Marca varchar(255));



create table Herramientas(
Codigo_Herramienta varchar(50) primary key not null,
Nombre varchar(255),
Medida varchar(50),
Marca varchar(50),
Descripcion varchar(255));


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

-----------------------------------------------------------------------------------------
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
    IN _clave VARCHAR(255)
)
BEGIN
    DECLARE exit handler for sqlexception
    BEGIN
        -- Manejo de excepciones
        ROLLBACK;
    END;

    START TRANSACTION;

    -- Inserta el nuevo usuario
    INSERT INTO Usuarios (Nombre, Apellidop, Apellidom, Fechadenacimiento, Rfc, NombreUsuario, Clave)
    VALUES (_nombre, _apellidop, _apellidom, _fechanacimiento, _rfc, _nombreUsuario, _clave);

    COMMIT;
END //

DELIMITER ;

DELIMITER //

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
    IN _clave VARCHAR(255)
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
        Clave = _clave  -- Asegúrate de que la clave esté encriptada
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

-----------------------------------------------------------------------------------------
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

DROP PROCEDURE IF EXISTS p_validar_usuario;

CREATE PROCEDURE p_validar_usuario
(
    IN _nombreUsuario VARCHAR(50),
    IN _clave VARCHAR(255)
)
BEGIN 
    DECLARE x INT;

    -- Comparar el nombre de usuario y la clave
    SELECT COUNT(*) INTO x
    FROM Usuarios
    WHERE NombreUsuario = _nombreUsuario AND Clave = _clave;  -- Asegúrate de que _clave esté encriptada al llamarlo

    IF x > 0 THEN
        SELECT 'correcto' AS rs;
    ELSE
        SELECT 'error' AS rs;
    END IF;
END //

DELIMITER ;

