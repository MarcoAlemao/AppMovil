//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionMovil.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class nutricion
    {
        public int id { get; set; }
        public Nullable<int> diagnostico_id { get; set; }
        public Nullable<decimal> peso_usual { get; set; }
        public Nullable<decimal> c_muñeca { get; set; }
        public Nullable<decimal> a_rodilla { get; set; }
        public Nullable<decimal> c_braquial { get; set; }
        public Nullable<decimal> c_abdominal { get; set; }
        public Nullable<decimal> c_cadera { get; set; }
        public Nullable<int> porcentaje_grasa { get; set; }
        public Nullable<int> talla_utilizar { get; set; }
        public Nullable<decimal> PI_utilizar { get; set; }
        public Nullable<decimal> IMC { get; set; }
    
        public virtual diagnostico diagnostico { get; set; }
    }
}
