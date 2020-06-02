﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetHospi.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GetHospiEntities : DbContext
    {
        public GetHospiEntities()
            : base("name=GetHospiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Archivos> Archivos { get; set; }
        public virtual DbSet<Consultas> Consultas { get; set; }
        public virtual DbSet<Diagonosticos> Diagonosticos { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    
        public virtual int Delete_Archivos(Nullable<int> idArchivos)
        {
            var idArchivosParameter = idArchivos.HasValue ?
                new ObjectParameter("IdArchivos", idArchivos) :
                new ObjectParameter("IdArchivos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Archivos", idArchivosParameter);
        }
    
        public virtual int Delete_Consultas(Nullable<int> idConsultas)
        {
            var idConsultasParameter = idConsultas.HasValue ?
                new ObjectParameter("IdConsultas", idConsultas) :
                new ObjectParameter("IdConsultas", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Consultas", idConsultasParameter);
        }
    
        public virtual int Delete_Diagnostico(Nullable<int> idDiagonosticos)
        {
            var idDiagonosticosParameter = idDiagonosticos.HasValue ?
                new ObjectParameter("IdDiagonosticos", idDiagonosticos) :
                new ObjectParameter("IdDiagonosticos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Diagnostico", idDiagonosticosParameter);
        }
    
        public virtual int Delete_Especialidades(Nullable<int> idEspecialidades)
        {
            var idEspecialidadesParameter = idEspecialidades.HasValue ?
                new ObjectParameter("IdEspecialidades", idEspecialidades) :
                new ObjectParameter("IdEspecialidades", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Especialidades", idEspecialidadesParameter);
        }
    
        public virtual int Delete_Medicos(Nullable<int> idMedico)
        {
            var idMedicoParameter = idMedico.HasValue ?
                new ObjectParameter("IdMedico", idMedico) :
                new ObjectParameter("IdMedico", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Medicos", idMedicoParameter);
        }
    
        public virtual int Delete_Pacientes(Nullable<int> idPacientes)
        {
            var idPacientesParameter = idPacientes.HasValue ?
                new ObjectParameter("IdPacientes", idPacientes) :
                new ObjectParameter("IdPacientes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Pacientes", idPacientesParameter);
        }
    
        public virtual int Delete_Usuarios(Nullable<int> idUsuarios)
        {
            var idUsuariosParameter = idUsuarios.HasValue ?
                new ObjectParameter("IdUsuarios", idUsuarios) :
                new ObjectParameter("IdUsuarios", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Usuarios", idUsuariosParameter);
        }
    
        public virtual int Insert_Archivos(Nullable<int> idPacientes, string peso, string presionArterial, string temperatura)
        {
            var idPacientesParameter = idPacientes.HasValue ?
                new ObjectParameter("IdPacientes", idPacientes) :
                new ObjectParameter("IdPacientes", typeof(int));
    
            var pesoParameter = peso != null ?
                new ObjectParameter("Peso", peso) :
                new ObjectParameter("Peso", typeof(string));
    
            var presionArterialParameter = presionArterial != null ?
                new ObjectParameter("PresionArterial", presionArterial) :
                new ObjectParameter("PresionArterial", typeof(string));
    
            var temperaturaParameter = temperatura != null ?
                new ObjectParameter("Temperatura", temperatura) :
                new ObjectParameter("Temperatura", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Archivos", idPacientesParameter, pesoParameter, presionArterialParameter, temperaturaParameter);
        }
    
        public virtual int Insert_Consulta(Nullable<int> idMedico, Nullable<int> idArchivo, string nombre)
        {
            var idMedicoParameter = idMedico.HasValue ?
                new ObjectParameter("IdMedico", idMedico) :
                new ObjectParameter("IdMedico", typeof(int));
    
            var idArchivoParameter = idArchivo.HasValue ?
                new ObjectParameter("IdArchivo", idArchivo) :
                new ObjectParameter("IdArchivo", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Consulta", idMedicoParameter, idArchivoParameter, nombreParameter);
        }
    
        public virtual int Insert_Diagnostico(Nullable<int> idConsulta, string diagnostico, string recetas)
        {
            var idConsultaParameter = idConsulta.HasValue ?
                new ObjectParameter("IdConsulta", idConsulta) :
                new ObjectParameter("IdConsulta", typeof(int));
    
            var diagnosticoParameter = diagnostico != null ?
                new ObjectParameter("Diagnostico", diagnostico) :
                new ObjectParameter("Diagnostico", typeof(string));
    
            var recetasParameter = recetas != null ?
                new ObjectParameter("Recetas", recetas) :
                new ObjectParameter("Recetas", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Diagnostico", idConsultaParameter, diagnosticoParameter, recetasParameter);
        }
    
        public virtual int Insert_Especialidades(Nullable<int> idMedico, string nombre)
        {
            var idMedicoParameter = idMedico.HasValue ?
                new ObjectParameter("IdMedico", idMedico) :
                new ObjectParameter("IdMedico", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Especialidades", idMedicoParameter, nombreParameter);
        }
    
        public virtual int Insert_Medicos(Nullable<int> cedulaMedico, string nombre, string direccion, string dUI, string telefono)
        {
            var cedulaMedicoParameter = cedulaMedico.HasValue ?
                new ObjectParameter("CedulaMedico", cedulaMedico) :
                new ObjectParameter("CedulaMedico", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var dUIParameter = dUI != null ?
                new ObjectParameter("DUI", dUI) :
                new ObjectParameter("DUI", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Medicos", cedulaMedicoParameter, nombreParameter, direccionParameter, dUIParameter, telefonoParameter);
        }
    
        public virtual int Insert_Pacientes(Nullable<int> cedulaPaciente, Nullable<int> numeroRegistro, string nombre, string direccion, string telefono, Nullable<System.DateTime> fechaNacimiento, string sexo, string nombrePadre, string nombreMadre, string grupoSanguineo)
        {
            var cedulaPacienteParameter = cedulaPaciente.HasValue ?
                new ObjectParameter("CedulaPaciente", cedulaPaciente) :
                new ObjectParameter("CedulaPaciente", typeof(int));
    
            var numeroRegistroParameter = numeroRegistro.HasValue ?
                new ObjectParameter("NumeroRegistro", numeroRegistro) :
                new ObjectParameter("NumeroRegistro", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var nombrePadreParameter = nombrePadre != null ?
                new ObjectParameter("NombrePadre", nombrePadre) :
                new ObjectParameter("NombrePadre", typeof(string));
    
            var nombreMadreParameter = nombreMadre != null ?
                new ObjectParameter("NombreMadre", nombreMadre) :
                new ObjectParameter("NombreMadre", typeof(string));
    
            var grupoSanguineoParameter = grupoSanguineo != null ?
                new ObjectParameter("GrupoSanguineo", grupoSanguineo) :
                new ObjectParameter("GrupoSanguineo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Pacientes", cedulaPacienteParameter, numeroRegistroParameter, nombreParameter, direccionParameter, telefonoParameter, fechaNacimientoParameter, sexoParameter, nombrePadreParameter, nombreMadreParameter, grupoSanguineoParameter);
        }
    
        public virtual int Insert_Usuarios(string nombre, string direccion, string dui, string nit, string usuario, string clave, Nullable<System.DateTime> fecha)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var duiParameter = dui != null ?
                new ObjectParameter("Dui", dui) :
                new ObjectParameter("Dui", typeof(string));
    
            var nitParameter = nit != null ?
                new ObjectParameter("Nit", nit) :
                new ObjectParameter("Nit", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Usuarios", nombreParameter, direccionParameter, duiParameter, nitParameter, usuarioParameter, claveParameter, fechaParameter);
        }
    
        public virtual int Update_Archivos(Nullable<int> idPacientes, string peso, string presionArterial, string temperatura)
        {
            var idPacientesParameter = idPacientes.HasValue ?
                new ObjectParameter("IdPacientes", idPacientes) :
                new ObjectParameter("IdPacientes", typeof(int));
    
            var pesoParameter = peso != null ?
                new ObjectParameter("Peso", peso) :
                new ObjectParameter("Peso", typeof(string));
    
            var presionArterialParameter = presionArterial != null ?
                new ObjectParameter("PresionArterial", presionArterial) :
                new ObjectParameter("PresionArterial", typeof(string));
    
            var temperaturaParameter = temperatura != null ?
                new ObjectParameter("Temperatura", temperatura) :
                new ObjectParameter("Temperatura", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Archivos", idPacientesParameter, pesoParameter, presionArterialParameter, temperaturaParameter);
        }
    
        public virtual int Update_Consulta(Nullable<int> idMedico, Nullable<int> idArchivo, string nombre)
        {
            var idMedicoParameter = idMedico.HasValue ?
                new ObjectParameter("IdMedico", idMedico) :
                new ObjectParameter("IdMedico", typeof(int));
    
            var idArchivoParameter = idArchivo.HasValue ?
                new ObjectParameter("IdArchivo", idArchivo) :
                new ObjectParameter("IdArchivo", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Consulta", idMedicoParameter, idArchivoParameter, nombreParameter);
        }
    
        public virtual int Update_Diagnostico(Nullable<int> idConsulta, string diagnostico, string recetas)
        {
            var idConsultaParameter = idConsulta.HasValue ?
                new ObjectParameter("IdConsulta", idConsulta) :
                new ObjectParameter("IdConsulta", typeof(int));
    
            var diagnosticoParameter = diagnostico != null ?
                new ObjectParameter("Diagnostico", diagnostico) :
                new ObjectParameter("Diagnostico", typeof(string));
    
            var recetasParameter = recetas != null ?
                new ObjectParameter("Recetas", recetas) :
                new ObjectParameter("Recetas", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Diagnostico", idConsultaParameter, diagnosticoParameter, recetasParameter);
        }
    
        public virtual int Update_Especialidades(Nullable<int> idMedico, string nombre)
        {
            var idMedicoParameter = idMedico.HasValue ?
                new ObjectParameter("IdMedico", idMedico) :
                new ObjectParameter("IdMedico", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Especialidades", idMedicoParameter, nombreParameter);
        }
    
        public virtual int Update_Medicos(Nullable<int> cedulaMedico, string nombre, string direccion, string dUI, string telefono)
        {
            var cedulaMedicoParameter = cedulaMedico.HasValue ?
                new ObjectParameter("CedulaMedico", cedulaMedico) :
                new ObjectParameter("CedulaMedico", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var dUIParameter = dUI != null ?
                new ObjectParameter("DUI", dUI) :
                new ObjectParameter("DUI", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Medicos", cedulaMedicoParameter, nombreParameter, direccionParameter, dUIParameter, telefonoParameter);
        }
    
        public virtual int Update_Pacientes(Nullable<int> cedulaPaciente, Nullable<int> numeroRegistro, string nombre, string direccion, string telefono, Nullable<System.DateTime> fechaNacimiento, string sexo, string nombrePadre, string nombreMadre, string grupoSanguineo)
        {
            var cedulaPacienteParameter = cedulaPaciente.HasValue ?
                new ObjectParameter("CedulaPaciente", cedulaPaciente) :
                new ObjectParameter("CedulaPaciente", typeof(int));
    
            var numeroRegistroParameter = numeroRegistro.HasValue ?
                new ObjectParameter("NumeroRegistro", numeroRegistro) :
                new ObjectParameter("NumeroRegistro", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var nombrePadreParameter = nombrePadre != null ?
                new ObjectParameter("NombrePadre", nombrePadre) :
                new ObjectParameter("NombrePadre", typeof(string));
    
            var nombreMadreParameter = nombreMadre != null ?
                new ObjectParameter("NombreMadre", nombreMadre) :
                new ObjectParameter("NombreMadre", typeof(string));
    
            var grupoSanguineoParameter = grupoSanguineo != null ?
                new ObjectParameter("GrupoSanguineo", grupoSanguineo) :
                new ObjectParameter("GrupoSanguineo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Pacientes", cedulaPacienteParameter, numeroRegistroParameter, nombreParameter, direccionParameter, telefonoParameter, fechaNacimientoParameter, sexoParameter, nombrePadreParameter, nombreMadreParameter, grupoSanguineoParameter);
        }
    
        public virtual int Update_Usuarios(string nombre, string direccion, string dui, string nit, string usuario, string clave, Nullable<System.DateTime> fecha)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var duiParameter = dui != null ?
                new ObjectParameter("Dui", dui) :
                new ObjectParameter("Dui", typeof(string));
    
            var nitParameter = nit != null ?
                new ObjectParameter("Nit", nit) :
                new ObjectParameter("Nit", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Usuarios", nombreParameter, direccionParameter, duiParameter, nitParameter, usuarioParameter, claveParameter, fechaParameter);
        }
    }
}
