//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastFix_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class citas
    {
        public int id_cita { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> id_empleado { get; set; }
        public string descripcion_de_la_averia { get; set; }
        public Nullable<double> monto_acordado { get; set; }
        public Nullable<System.DateTime> fecha_de_la_cita { get; set; }
    
        public virtual clientes clientes { get; set; }
        public virtual Empleados Empleados { get; set; }
    }
}
