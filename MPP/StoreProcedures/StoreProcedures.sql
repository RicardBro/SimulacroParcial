CREATE PROCEDURE ModificarVideojuego
@nombre varchar(50),
@estudio varchar(50),
@genero varchar(50),
@id int

AS
BEGIN
UPDATE Videojuego
SET Nombre = @nombre,
estudio = @estudio,
genero = @genero
WHERE ID = @id
END

CREATE PROCEDURE ModificarJugador
@nombre varchar(50),
@apellido varchar(50),
@fechaNacimiento date,
@usuario varchar(50),
@id int

AS
BEGIN
UPDATE Jugador
SET Nombre = @nombre,
Apellido = @apellido,
FechaNacimiento = @fechaNacimiento,
Usuario = @usuario
WHERE ID = @id
END

CREATE PROCEDURE ListarVideojuego

AS
BEGIN
select *  from Videojuego
END

CREATE PROCEDURE ListarJugador
AS
BEGIN
Select * from  Jugador
END

CREATE PROCEDURE InsertarVideojuego
@nombre varchar(50),
@estudio varchar(50),
@genero varchar(50),
@id int

AS
BEGIN
Insert into Videojuego (id,nombre,estudio,genero)
values(@id,@nombre,@estudio,@genero)
END

CREATE PROCEDURE [dbo].[InsertarJugador]
@nombre varchar(50),
@apellido varchar(50),
@fechaNacimiento date,
@usuario varchar(50),
@id int
AS
BEGIN
INSERT INTO Jugador (Nombre, Apellido, FechaNacimiento, Usuario, ID)
VALUES (@nombre, @apellido, @fechaNacimiento, @usuario,@id)
END

CREATE PROCEDURE [EliminarVideojuego]
@id int

AS
BEGIN
Delete from Videojuego where id=@id
END

CREATE PROCEDURE EliminarJugador
@id int

AS
BEGIN

Delete from Jugador  Where ID=@id

END


CREATE PROCEDURE Top3Jugadores
AS
BEGIN
SELECT TOP 3 IDJugador, IDVideojuego, Puntaje
FROM Puntaje
ORDER BY IDJugador DESC, Score DESC
END
GO