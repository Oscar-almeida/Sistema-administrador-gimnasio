using System;
using System.Collections.Generic;

namespace gym_BDRepositorios.Modelos
{
    public partial class HistorialInventario
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public int InventarioId { get; set; }
        public string AdministradorIdentificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual Administrador AdministradorIdentificacionNavigation { get; set; }
        public virtual Inventario Inventario { get; set; }
    }
}
