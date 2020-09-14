using System;
using System.Collections.Generic;

namespace gym_BDRepositorios.Modelos
{
    public partial class Inventario
    {
        public Inventario()
        {
            EjercicioInventario = new HashSet<EjercicioInventario>();
            HistorialInventario = new HashSet<HistorialInventario>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CantidadTotal { get; set; }
        public int CantidadDisponible { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<EjercicioInventario> EjercicioInventario { get; set; }
        public virtual ICollection<HistorialInventario> HistorialInventario { get; set; }
    }
}
