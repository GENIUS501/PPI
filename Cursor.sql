USE SIGVA
GO
CREATE PROCEDURE Agregar_Dias
AS
--Declarado
DECLARE @Cedula INT,
@Ano INT,
@Cantidad_Dias FLOAT,
@Ano_actual INT,
@Ano_trabajo INT

DECLARE cursor1 CURSOR --LOCAL
	FOR SELECT  Dias_Disponibles.Cedula, Dias_Disponibles.Ano, Dias_Disponibles.Cantidad_Dias
FROM (Dias_Disponibles
INNER JOIN FUNCIONARIOS ON Dias_Disponibles.Cedula = FUNCIONARIOS.Cedula AND FUNCIONARIOS.Estatus = 'Activo')ORDER BY Dias_Disponibles.Ano DESC; -- FOR UPDATE

--Abrir Cursor
OPEN cursor1

FETCH cursor1 INTO @Cedula,@Ano,@Cantidad_Dias

WHILE(@@FETCH_STATUS=0)
BEGIN
SET @Cantidad_Dias = (@Cantidad_Dias+0.034)
SET @Ano_actual = (Select year(getdate()))
SET @Ano_trabajo = (@Ano_actual-1)
IF @Ano = @Ano_actual 
BEGIN
UPDATE Dias_Disponibles SET	Cantidad_Dias=@Cantidad_Dias WHERE Ano = @Ano AND Cedula = @Cedula
END 
ELSE IF @Ano = @Ano_trabajo
BEGIN
SET @Ano = (@Ano+1)
INSERT INTO Dias_Disponibles(Ano,Cantidad_Dias,Cedula) VALUES(@Ano,0.033,@Cedula)
END
FETCH cursor1 INTO @Cedula,@Ano,@Cantidad_Dias
END
------Navegar
--FETCH NEXT FROM cursor1
------Cerrar
CLOSE cursor1
----Destruir
DEALLOCATE cursor1
go

SELECT * FROM Dias_Disponibles

EXEC Agregar_Dias;