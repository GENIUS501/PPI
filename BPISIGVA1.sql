CREATE DATABASE SIGVA;
GO
USE SIGVA
GO

CREATE TABLE DEPARTAMENTOS(
	Id_Departamento INT IDENTITY(1,1) PRIMARY KEY  NOT NULL,
	Nombre_Departamento VARCHAR(50) NOT NULL,
	CONSTRAINT AK_Nombre_Departamento UNIQUE(Nombre_Departamento)   
);

CREATE TABLE PUESTOS(
	Id_Puesto INT IDENTITY(1,1)  NOT NULL,
	Nombre_Puesto VARCHAR(50)  NOT NULL,
	Id_Departamento INT NOT NULL,
	PRIMARY KEY (Nombre_Puesto,Id_Departamento),
	CONSTRAINT AK_Id_Puesto UNIQUE(Id_Puesto),
	CONSTRAINT FK_PUE_DEP FOREIGN KEY (Id_Departamento) references DEPARTAMENTOS(Id_Departamento)
);

CREATE TABLE FUNCIONARIOS(
	Cedula INT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(25) NOT NULL,
	Apellido1 VARCHAR(25) NOT NULL,  
	Apellido2 VARCHAR(25) NOT NULL,
	Id_Puesto INT NOT NULL,
	Id_Departamento INT NOT NULL,
	Fecha_De_Ingreso DATE NOT NULL,
	Direccion VARCHAR(MAX) NOT NULL,
	Telefono INT NOT NULL,
	Email VARCHAR(MAX),
	Fecha_de_Anualidad DATE NOT NULL,
	Estatus VARCHAR(8) NOT NULL,
	Anos_Institucion_anterior INT,
	CONSTRAINT FK_FUN_PUE FOREIGN KEY (Id_Puesto) references Puestos(Id_Puesto),
	CONSTRAINT FK_FUN_DEP FOREIGN KEY (Id_Departamento) references DEPARTAMENTOS(Id_Departamento)
);

CREATE TABLE Dias_Disponibles(
	Ano INT  NOT NULL,
	Cantidad_Dias FLOAT NOT NULL,
	Cedula INT NOT NULL,
	CONSTRAINT FK_DIA_FUN FOREIGN KEY (Cedula) references FUNCIONARIOS(Cedula)
);

CREATE TABLE Dias_Reservados(
	Cedula	INT NOT NULL,
	Fecha_Inicial	DATE NOT NULL,
	Fecha_Final	DATE NOT NULL,
	Detalle	VARCHAR(MAX) ,
	Reservado_El	DATETIME NOT NULL,
	Id_Reservacion	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Cantidad_dias	FLOAT NOT NULL,
	CONSTRAINT FK_RES_FUN FOREIGN KEY (Cedula) references FUNCIONARIOS(Cedula)
);

CREATE TABLE Anualidades(
	Cedula INT NOT NULL,
	Cantidad_Dias DECIMAL,
	CONSTRAINT FK_ANU_FUN FOREIGN KEY (Cedula) references FUNCIONARIOS(Cedula)
);

CREATE TABLE Anos_Institucion_Anterior(
	Cedula INT NOT NULL,
	Cantidad_Dias Decimal,
	CONSTRAINT FK_INS_FUN FOREIGN KEY (Cedula) references FUNCIONARIOS(Cedula)
);

CREATE TABLE DIAS_DEVOLUCION(
	Id_Devolucion	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Fecha_de_devolucion	DATE NOT NULL,
	Detalle	VARCHAR(MAX),
	Cantidad_dias	DECIMAL NOT NULL,
	Id_Reservacion	INT NOT NULL,
	Cedula 	INT NOT NULL,
	CONSTRAINT FK_DEV_FUN FOREIGN KEY (Cedula) references FUNCIONARIOS(Cedula),
	CONSTRAINT FK_DEV_RES FOREIGN KEY (Id_Reservacion) references Dias_Reservados(Id_Reservacion)
);

CREATE TABLE Saldos_Disponibles(
	Codigo_de_reporte	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Fecha_Elaboracion	DATE NOT NULL,
	Cedula	INT NOT NULL,
	Anualidades	DECIMAL,
	CONSTRAINT FK_SAL_FUN FOREIGN KEY (Cedula) references FUNCIONARIOS(Cedula),
);

CREATE TABLE Disponibles_Saldos(
	Codigo_reporte	INT PRIMARY KEY NOT NULL,
	Ano	INT NOT NULL,
	Cantidad_dias DECIMAL NOT NULL,
	Cedula	INT NOT NULL,
	CONSTRAINT FK_DIS_SAL FOREIGN KEY (Codigo_reporte) references Saldos_Disponibles(Codigo_de_reporte),
	CONSTRAINT FK_DIS_FUN FOREIGN KEY (Cedula) references FUNCIONARIOS(Cedula),
);

CREATE TABLE Usuarios(
	Cedula	INT NOT NULL,
	Nombre	VARCHAR(25) NOT NULL,
	Apellido1	VARCHAR(25) NOT NULL,
	Apellido2	VARCHAR(25) NOT NULL,
	Usuario	VARCHAR(13) PRIMARY KEY NOT NULL,
	Clave	VARCHAR(MAX) NOT NULL,
	Rol INT NOT NULL
);

CREATE TABLE Sessiones(
	Id_session	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Usuario	VARCHAR(13)NOT NULL,
	Ingreso	DATETIME NOT NULL,
	Salida	DATETIME,
	CONSTRAINT FK_SES_USU FOREIGN KEY (Usuario) references Usuarios(Usuario)
);

CREATE TABLE Bitacora(
	Id_Movimiento	int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Accion	VARCHAR(10) NOT NULL,
	Fecha_Hora	DATE NOT NULL,
	Tabla	VARCHAR(16) NOT NULL,
	Usuario	VARCHAR(13) NOT NULL,
	CONSTRAINT FK_BIT_USU FOREIGN KEY (Usuario) references Usuarios(Usuario)
);


INSERT INTO Usuarios (Cedula,Nombre,Apellido1,Apellido2,Usuario,Clave,Rol) values (123456789,'Administrador','Super','Usuario','Administrador','Cdf/BkY5HRrUeAvNSxTUQrEdX9E=',1)

INSERT INTO Usuarios (Cedula,Nombre,Apellido1,Apellido2,Usuario,Clave,Rol) values (123456788,'Consultor','Desistema','Externo','Consultor','8WfVNiq29wB9gJCs2883NIDvkFI=',2)

INSERT INTO Usuarios (Cedula,Nombre,Apellido1,Apellido2,Usuario,Clave,Rol) values (123456787,'Auditor','Desistema','Externo','Auditor','UlYr4oS4g+kFwwPw4me+YNarSA8=',3)