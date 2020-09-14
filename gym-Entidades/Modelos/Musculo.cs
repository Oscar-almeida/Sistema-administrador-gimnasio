using System;
using System.Collections.Generic;

namespace sag_Modelos
{
    public partial class Musculo
    {
        public Musculo()
        {
            Ejercicio = new HashSet<Ejercicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<Ejercicio> Ejercicio { get; set; }
    }
}
