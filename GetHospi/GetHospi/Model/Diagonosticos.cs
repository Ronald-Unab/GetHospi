//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Diagonosticos
    {
        public int IdDiagonosticos { get; set; }
        public Nullable<int> IdConsulta { get; set; }
        public string Diagnostico { get; set; }
        public string Recetas { get; set; }
    
        public virtual Consultas Consultas { get; set; }
    }
}