//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAPA_ENTITY.ModelEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIO
    {
        public decimal us_id { get; set; }
        public Nullable<decimal> us_nid { get; set; }
        public string us_password { get; set; }
        public string us_typeuser { get; set; }
        public string us_name { get; set; }
        public string us_lastname { get; set; }
        public string us_email { get; set; }
        public Nullable<decimal> us_phone { get; set; }
        public Nullable<bool> us_reestablecer { get; set; }
        public Nullable<System.DateTime> us_date { get; set; }
    
        public virtual CORDINADORA CORDINADORA { get; set; }
        public virtual INSTRUCTOR INSTRUCTOR { get; set; }
    }
}
