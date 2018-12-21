USE SIGVA
GO   ---83408807
CREATE PROCEDURE Agregar_Anualidad
AS
BEGIN
--Declarado
DECLARE @Cedula INT,
@Cantidad_Dias FLOAT,
@Fecha_de_Anualidad DATETIME,
@Dia INT,
@Dia_T INT,
@Mes INT,
@Mes_T INT,
@Ano INT,
@Anos_Laborados INT

DECLARE cursor2 CURSOR --LOCAL
	FOR SELECT FUNCIONARIOS.Cedula , FUNCIONARIOS.Fecha_de_Anualidad, Anualidades.Cantidad_Dias FROM Anualidades INNER JOIN FUNCIONARIOS ON Anualidades.Cedula = FUNCIONARIOS.Cedula

	--Abrir Cursor
OPEN cursor2

FETCH cursor2 INTO @Cedula,@Fecha_de_Anualidad,@Cantidad_Dias

WHILE(@@FETCH_STATUS=0)
	BEGIN
		SET @Dia =(DAY(@Fecha_de_Anualidad))
		SET @MES = (MONTH(@Fecha_de_Anualidad))
		SET @Ano = (YEAR(@Fecha_de_Anualidad))
		SET @Anos_Laborados = (YEAR(GETDATE()))-@Ano
		IF @Anos_Laborados>=1 AND @Anos_Laborados<=4
		BEGIN
		SET @Cantidad_Dias = @Cantidad_Dias+3;
		END
		IF @Anos_Laborados>=5 AND @Anos_Laborados<6
		BEGIN
		SET @Cantidad_Dias = @Cantidad_Dias+8;
		END
		IF @Anos_Laborados>=6 AND @Anos_Laborados<10
		BEGIN
		SET @Cantidad_Dias = @Cantidad_Dias+10;
		END
		IF @Anos_Laborados>=10
		BEGIN
		SET @Cantidad_Dias = @Cantidad_Dias+18;
		END
			SET @Dia_T = (DAY(GETDATE()))
			SET @Mes_T = (MONTH(GETDATE()))
			IF @Dia=@Dia_T AND @Mes=@Mes_T
				BEGIN
					UPDATE Anualidades SET Cantidad_Dias = @Cantidad_Dias WHERE Cedula = @Cedula;
				END
		FETCH cursor2 INTO @Cedula,@Fecha_de_Anualidad,@Cantidad_Dias
	END
CLOSE cursor2
----Destruir
DEALLOCATE cursor2
END

EXEC Agregar_Anualidad;