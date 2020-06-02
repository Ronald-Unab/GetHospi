--TABLA MEDICOS
-- INSERTANDO DATOS
create procedure Insert_Medicos
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

--ACTUALIZANDO DATOS
Create procedure Update_Medicos
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

-- ELIMINANDO DATOS
Create procedure Delete_Medicos
(
 @IdMedico int
) 
as
delete  from Medicos
 where @IdMedico = idMedicos
GO
---------------------------------------------------------------------------------------------

--TABLA ESPECIALIDADES
--INSERTANDO DATOS
Create procedure Insert_Especialidades
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

--ACTUALIZANDO DATOS
Create procedure Update_Especialidades
(
@IdMedico int,
@Nombre varchar(50)
) 
as
update Especialidades set @IdMedico = idmedico, @Nombre = nombre 
GO

--ELIMINANDO DATOS
Create procedure Delete_Especialidades
(
 @IdEspecialidades int
) 
as
delete  from Especialidades
 where @IdEspecialidades = idespecialidades
GO
---------------------------------------------------------------------------------------------

--TABLA PACIENTES
--INSERTANDO DATOS
Create procedure Insert_Pacientes
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

--ACTUALIZANDO DATOS
Create procedure Update_Pacientes
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

--ELIMINANDO DATOS
Create procedure Delete_Pacientes
(
 @IdPacientes int
) 
as
delete  from Pacientes
where @IdPacientes = idpacientes
GO
---------------------------------------------------------------------------------------------

--TABLA ARCHIVOS
--INSERTANDO DATOS
Create procedure Insert_Archivos
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

--ACTUALIZANDO DATOS 
Create procedure Update_Archivos
(
@IdPacientes int,
@Peso Varchar(20),
@PresionArterial Varchar(20),
@Temperatura Varchar(20)
)
as
update Archivos set @IdPacientes = idpaciente, @Peso = peso, @PresionArterial = presionarterial, @Temperatura = temperatura
GO

--ELIMINANDO DATOS
Create procedure Delete_Archivos
(
 @IdArchivos int
) 
as
delete  from Archivos
where @IdArchivos = idarchivos
GO
---------------------------------------------------------------------------------------------

--TABLA CONSULTAS
--INSERTANDO DATOS
Create procedure Insert_Consulta 
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

--ACTUALIZANDO DATOS
Create procedure Update_Consulta
(
@IdMedico int,
@IdArchivo int,
@Nombre Varchar(50)
)
as
update Consultas set @IdMedico = idmedico, @IdArchivo = idarchivo, @Nombre = nombre
GO

--ELIMINANDO DATOS
Create procedure Delete_Consultas
(
 @IdConsultas int
) 
as
delete  from Consultas
where @IdConsultas = idconsultas
GO
---------------------------------------------------------------------------------------------

--TABLA DIAGNOSTICO
--INSERTANDO DATOS
Create procedure Insert_Diagnostico
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

--ACTUALIZANDO DATOS
Create procedure Update_Diagnostico
(
@IdConsulta int,
@Diagnostico Varchar(500),
@Recetas varchar(200)
)
as
update Diagonosticos set @IdConsulta = idconsulta, @Diagnostico = diagnostico, @Recetas = recetas
GO

--ELIMINANDO DATOS
Create procedure Delete_Diagnostico
(
 @IdDiagonosticos int
) 
as
delete  from Diagonosticos
where @IdDiagonosticos = iddiagonosticos 
GO
---------------------------------------------------------------------------------------------

--TABLA USUARIOS
--INSERTANDO DATOS
Create procedure Insert_Usuarios
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

--ACTUALIZANDO DATOS
Create procedure Update_Usuarios
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

--ELIMINANDO DATOS 
Create procedure Delete_Usuarios
(
 @IdUsuarios int
) 
as
delete  from Usuarios
where @IdUsuarios = idusuarios
GO
