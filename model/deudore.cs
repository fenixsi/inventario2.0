//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario2._0.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class deudore
    {
        public deudore()
        {
            this.ventas = new HashSet<venta>();
        }
    
        public int id_deudor { get; set; }
        public string nombre_deudor { get; set; }
        public int telefono_deudor { get; set; }
        public int deuda_deudor { get; set; }
    
        public virtual ICollection<venta> ventas { get; set; }
    }
}