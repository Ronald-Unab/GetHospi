USE [GetHospi]
GO
/****** Object:  Table [dbo].[Archivos]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Archivos](
	[IdArchivos] [int] IDENTITY(1,1) NOT NULL,
	[IdPaciente] [int] NULL,
	[Peso] [varchar](20) NOT NULL,
	[PresionArterial] [varchar](20) NOT NULL,
	[Temperatura] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdArchivos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consultas]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consultas](
	[IdConsultas] [int] NOT NULL,
	[IdMedico] [int] NULL,
	[IdArchivo] [int] NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdConsultas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagonosticos]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagonosticos](
	[IdDiagonosticos] [int] IDENTITY(1,1) NOT NULL,
	[IdConsulta] [int] NULL,
	[Diagnostico] [varchar](500) NOT NULL,
	[Recetas] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDiagonosticos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[IdEspecialidades] [int] IDENTITY(1,1) NOT NULL,
	[IdMedico] [int] NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEspecialidades] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[IdMedicos] [int] IDENTITY(1,1) NOT NULL,
	[CedulaMedico] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Dui] [varchar](25) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMedicos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[IdPacientes] [int] IDENTITY(1,1) NOT NULL,
	[CedulaPaciente] [int] NOT NULL,
	[NumeroRegistro] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Sexo] [varchar](2) NOT NULL,
	[NombrePadre] [varchar](50) NOT NULL,
	[NombreMadre] [varchar](50) NOT NULL,
	[GrupoSanguineo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPacientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuarios] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Dui] [varchar](25) NOT NULL,
	[Nit] [varchar](25) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Clave] [varchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Archivos]  WITH CHECK ADD  CONSTRAINT [FK_IdPacienteA] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Pacientes] ([IdPacientes])
GO
ALTER TABLE [dbo].[Archivos] CHECK CONSTRAINT [FK_IdPacienteA]
GO
ALTER TABLE [dbo].[Consultas]  WITH CHECK ADD  CONSTRAINT [FK_IdArchvioC] FOREIGN KEY([IdArchivo])
REFERENCES [dbo].[Archivos] ([IdArchivos])
GO
ALTER TABLE [dbo].[Consultas] CHECK CONSTRAINT [FK_IdArchvioC]
GO
ALTER TABLE [dbo].[Consultas]  WITH CHECK ADD  CONSTRAINT [FK_IdMedicoC] FOREIGN KEY([IdMedico])
REFERENCES [dbo].[Medicos] ([IdMedicos])
GO
ALTER TABLE [dbo].[Consultas] CHECK CONSTRAINT [FK_IdMedicoC]
GO
ALTER TABLE [dbo].[Diagonosticos]  WITH CHECK ADD  CONSTRAINT [FK_IdConsulta] FOREIGN KEY([IdConsulta])
REFERENCES [dbo].[Consultas] ([IdConsultas])
GO
ALTER TABLE [dbo].[Diagonosticos] CHECK CONSTRAINT [FK_IdConsulta]
GO
ALTER TABLE [dbo].[Especialidades]  WITH CHECK ADD  CONSTRAINT [FK_IdMedicoE] FOREIGN KEY([IdMedico])
REFERENCES [dbo].[Medicos] ([IdMedicos])
GO
ALTER TABLE [dbo].[Especialidades] CHECK CONSTRAINT [FK_IdMedicoE]
GO
/****** Object:  StoredProcedure [dbo].[Delete_Archivos]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ELIMINANDO DATOS
Create procedure [dbo].[Delete_Archivos]
(
 @IdArchivos int
) 
as
delete  from Archivos
where @IdArchivos = idarchivos
GO
/****** Object:  StoredProcedure [dbo].[Delete_Consultas]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ELIMINANDO DATOS
Create procedure [dbo].[Delete_Consultas]
(
 @IdConsultas int
) 
as
delete  from Consultas
where @IdConsultas = idconsultas
GO
/****** Object:  StoredProcedure [dbo].[Delete_Diagnostico]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ELIMINANDO DATOS
Create procedure [dbo].[Delete_Diagnostico]
(
 @IdDiagonosticos int
) 
as
delete  from Diagonosticos
where @IdDiagonosticos = iddiagonosticos 
GO
/****** Object:  StoredProcedure [dbo].[Delete_Especialidades]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ELIMINANDO DATOS
Create procedure [dbo].[Delete_Especialidades]
(
 @IdEspecialidades int
) 
as
delete  from Especialidades
 where @IdEspecialidades = idespecialidades
GO
/****** Object:  StoredProcedure [dbo].[Delete_Medicos]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ELIMINANDO DATOS
Create procedure [dbo].[Delete_Medicos]
(
 @IdMedico int
) 
as
delete  from Medicos
 where @IdMedico = idMedicos
GO
/****** Object:  StoredProcedure [dbo].[Delete_Pacientes]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ELIMINANDO DATOS
Create procedure [dbo].[Delete_Pacientes]
(
 @IdPacientes int
) 
as
delete  from Pacientes
where @IdPacientes = idpacientes
GO
/****** Object:  StoredProcedure [dbo].[Delete_Usuarios]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ELIMINANDO DATOS 
Create procedure [dbo].[Delete_Usuarios]
(
 @IdUsuarios int
) 
as
delete  from Usuarios
where @IdUsuarios = idusuarios
GO
/****** Object:  StoredProcedure [dbo].[Insert_Archivos]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------

--TABLA ARCHIVOS
--INSERTANDO DATOS
Create procedure [dbo].[Insert_Archivos]
(
@IdPacientes int,
@Peso Varchar(20),
@PresionArterial Varchar(20),
@Temperatura Varchar(20)
)
as
begin
insert into Archivos( idpaciente, peso, presionarterial, temperatura)
values(@IdPacientes, @Peso, @PresionArterial, @Temperatura)
end 
GO
/****** Object:  StoredProcedure [dbo].[Insert_Consulta]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------

--TABLA CONSULTAS
--INSERTANDO DATOS
Create procedure [dbo].[Insert_Consulta] 
(
@IdMedico int,
@IdArchivo int,
@Nombre Varchar(50)
)
as
begin
insert into Consultas( idmedico, idarchivo, nombre)
values(@IdMedico, @IdArchivo, @Nombre)
end 
GO
/****** Object:  StoredProcedure [dbo].[Insert_Diagnostico]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------

--TABLA DIAGNOSTICO
--INSERTANDO DATOS
Create procedure [dbo].[Insert_Diagnostico]
(
@IdConsulta int,
@Diagnostico Varchar(500),
@Recetas varchar(200)
)
as
begin
insert into Diagonosticos (idconsulta, diagnostico, recetas)
values(@IdConsulta, @Diagnostico, @Recetas)
end 
GO
/****** Object:  StoredProcedure [dbo].[Insert_Especialidades]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------

--TABLA ESPECIALIDADES
--INSERTANDO DATOS
Create procedure [dbo].[Insert_Especialidades]
(
@IdMedico int,
@Nombre varchar(50) 
)
as
begin
insert into Especialidades(idmedico, nombre)
values(@IdMedico,  @Nombre)
end 
GO
/****** Object:  StoredProcedure [dbo].[Insert_Medicos]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TABLA MEDICOS
-- INSERTANDO DATOS
create procedure [dbo].[Insert_Medicos]
(
@CedulaMedico int,
@Nombre varchar(50),
@Direccion varchar(100),
@DUI varchar(50),
@Telefono varchar(15)
)
as
begin
insert into Medicos (cedulamedico, nombre, direccion, dui, telefono)
values(@CedulaMedico,  @Nombre, @DUI, @Direccion, @Telefono)
end 
GO
/****** Object:  StoredProcedure [dbo].[Insert_Pacientes]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------

--TABLA PACIENTES
--INSERTANDO DATOS
Create procedure [dbo].[Insert_Pacientes]
(
@CedulaPaciente int,
@NumeroRegistro int,
@Nombre Varchar(50),
@Direccion Varchar(100),
@Telefono Varchar(15),
@FechaNacimiento Date,
@Sexo Varchar(2),
@NombrePadre Varchar(50),
@NombreMadre Varchar(50),
@GrupoSanguineo varchar(50)
)
as
begin
insert into Pacientes(cedulapaciente,numeroregistro, nombre, direccion, telefono, fechanacimiento, sexo, 
nombrepadre, nombremadre,gruposanguineo)
values(@CedulaPaciente,  @NumeroRegistro, @Nombre, @Direccion, @Telefono, @FechaNacimiento, @Sexo,
@NombrePadre, @NombreMadre, @GrupoSanguineo)
end 
GO
/****** Object:  StoredProcedure [dbo].[Insert_Usuarios]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------------

--TABLA USUARIOS
--INSERTANDO DATOS
Create procedure [dbo].[Insert_Usuarios]
(
@Nombre Varchar (50),
@Direccion Varchar (50),
@Dui Varchar (25),
@Nit varchar (25),
@Usuario Varchar (50),
@Clave varchar (50),
@Fecha Date
)
as
begin
insert into Usuarios (nombre, direccion, dui, nit, usuario, clave, fecha)
values(@Nombre, @Direccion, @Dui, @Nit, @Usuario, @Clave, @Fecha)
end 
GO
/****** Object:  StoredProcedure [dbo].[Update_Archivos]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ACTUALIZANDO DATOS 
Create procedure [dbo].[Update_Archivos]
(
@IdPacientes int,
@Peso Varchar(20),
@PresionArterial Varchar(20),
@Temperatura Varchar(20)
)
as
update Archivos set @IdPacientes = idpaciente, @Peso = peso, @PresionArterial = presionarterial, @Temperatura = temperatura
GO
/****** Object:  StoredProcedure [dbo].[Update_Consulta]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ACTUALIZANDO DATOS
Create procedure [dbo].[Update_Consulta]
(
@IdMedico int,
@IdArchivo int,
@Nombre Varchar(50)
)
as
update Consultas set @IdMedico = idmedico, @IdArchivo = idarchivo, @Nombre = nombre
GO
/****** Object:  StoredProcedure [dbo].[Update_Diagnostico]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ACTUALIZANDO DATOS
Create procedure [dbo].[Update_Diagnostico]
(
@IdConsulta int,
@Diagnostico Varchar(500),
@Recetas varchar(200)
)
as
update Diagonosticos set @IdConsulta = idconsulta, @Diagnostico = diagnostico, @Recetas = recetas
GO
/****** Object:  StoredProcedure [dbo].[Update_Especialidades]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ACTUALIZANDO DATOS
Create procedure [dbo].[Update_Especialidades]
(
@IdMedico int,
@Nombre varchar(50)
) 
as
update Especialidades set @IdMedico = idmedico, @Nombre = nombre 
GO
/****** Object:  StoredProcedure [dbo].[Update_Medicos]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ACTUALIZANDO DATOS
Create procedure [dbo].[Update_Medicos]
(
@CedulaMedico int,
@Nombre varchar(50),
@Direccion varchar(100),
@DUI varchar(50),
@Telefono varchar(15)
) 
as
update Medicos set @CedulaMedico=cedulamedico,  @Nombre = nombre, @Direccion=direccion, @DUI = dui, 
@Telefono = telefono
GO
/****** Object:  StoredProcedure [dbo].[Update_Pacientes]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ACTUALIZANDO DATOS
Create procedure [dbo].[Update_Pacientes]
(
@CedulaPaciente int,
@NumeroRegistro int,
@Nombre Varchar(50),
@Direccion Varchar(100),
@Telefono Varchar(15),
@FechaNacimiento Date,
@Sexo Varchar(2),
@NombrePadre Varchar(50),
@NombreMadre Varchar(50),
@GrupoSanguineo varchar(50)
) 
as
update Pacientes set @CedulaPaciente = cedulapaciente, @NumeroRegistro = numeroregistro, @Nombre = nombre, @Direccion = direccion,
@Telefono = telefono, @FechaNacimiento = fechanacimiento, @Sexo =sexo, @NombrePadre = nombrepadre, 
@NombreMadre = nombremadre, @GrupoSanguineo = gruposanguineo
GO
/****** Object:  StoredProcedure [dbo].[Update_Usuarios]    Script Date: 1/6/2020 23:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ACTUALIZANDO DATOS
Create procedure [dbo].[Update_Usuarios]
(
@Nombre Varchar (50),
@Direccion Varchar (50),
@Dui Varchar (25),
@Nit varchar (25),
@Usuario Varchar (50),
@Clave varchar (50),
@Fecha Date
)
as
update Usuarios set @Nombre = nombre, @Direccion = direccion, @Dui = dui, @Nit =nit, 
@Usuario = usuario, @Clave = clave, @Fecha = fecha
GO
