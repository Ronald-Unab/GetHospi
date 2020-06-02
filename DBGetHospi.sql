Use master
Go
create Database GetHospi
Go
use GetHospi
go
Create Table Medicos
(
IdMedicos int identity primary key not null,
CedulaMedico int not null,
Nombre Varchar (50) not null,
Direccion Varchar (100) not null,
Dui Varchar (25) not null,
Telefono Varchar (15) not null,
)
 
Create table Especialidades
(
IdEspecialidades int identity primary key not null,
IdMedico int,
Nombre varchar(50) not null,
constraint FK_IdMedicoE foreign key (IdMedico) references Medicos(IdMedicos)
)
Create table Pacientes 
(
IdPacientes int identity primary key not null,
CedulaPaciente int not null,
NumeroRegistro int not null,
Nombre Varchar (50) not null,
Direccion Varchar (100) not null,
Telefono Varchar (15) not null,
FechaNacimiento Date not null,
Sexo Varchar (2) not null,
NombrePadre Varchar (50) not null,
NombreMadre Varchar(50) not null,
GrupoSanguineo varchar (50) not null
)

Create table Archivos
(
IdArchivos int identity primary key not null,
IdPaciente int,
Peso Varchar (20) not null,
PresionArterial Varchar (20) not null,
Temperatura Varchar(20) not null,
constraint FK_IdPacienteA foreign key (IdPaciente) references Pacientes(IdPacientes)
)
Create table Consultas 
(
IdConsultas int primary key not null,
IdMedico int,
IdArchivo int,
Nombre Varchar (50) not null,
constraint FK_IdMedicoC foreign key (IdMedico) references Medicos(IdMedicos),
constraint FK_IdArchvioC foreign key (IdArchivo) references Archivos(IdArchivos)
)

Create Table Diagonosticos
(
IdDiagonosticos int identity primary key not null,
IdConsulta int,
Diagnostico Varchar (500) not null,
Recetas varchar (200) not null,
constraint FK_IdConsulta foreign key (IdConsulta) references Consultas (IdConsultas)
)

Create table Usuarios 
(
IdUsuarios int identity primary key not null,
Nombre Varchar (50) not null,
Direccion Varchar (50) not null,
Dui Varchar (25) not null,
Nit varchar (25) not null,
Usuario Varchar (50) not null,
Clave varchar (50) not null,
Fecha Date not null
)

--tablas con CRUD
--Usuarios, Consultas, Archivos, Pacientes, Medicos