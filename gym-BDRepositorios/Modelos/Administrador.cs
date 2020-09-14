using System;
using System.Collections.Generic;

namespace gym_BDRepositorios.Modelos
{
    public partial class Administrador
    {
        public Administrador()
        {
            HistorialInventario = new HashSet<HistorialInventario>();
        }

        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contrasenha { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<HistorialInventario> HistorialInventario { get; set; }
    }
}
