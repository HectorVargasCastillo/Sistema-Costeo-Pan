//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema
{
    using System;
    using System.Collections.Generic;
    
    public partial class receta
    {
        public receta()
        {
            this.detalle_receta = new HashSet<detalle_receta>();
        }
    
        public int id { get; set; }
        public int producto_id { get; set; }
        public int es_actual { get; set; }
        public System.DateTime fecha { get; set; }
        public System.DateTime creado_el { get; set; }
        public Nullable<System.DateTime> modificado_el { get; set; }
        public Nullable<System.DateTime> eliminado_el { get; set; }
    

        public virtual ICollection<detalle_receta> detalle_receta { get; set; }

        public virtual producto producto { get; set; }
        
    }
}
