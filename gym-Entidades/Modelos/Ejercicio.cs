using System;
using System.Collections.Generic;

namespace sag_Modelos
{
    public partial class Ejercicio
    {
        public Ejercicio()
        {
            EjercicioInventario = new HashSet<EjercicioInventario>();
            RutinaEjercicio = new HashSet<RutinaEjercicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int MusculoId { get; set; }

        public virtual Musculo Musculo { get; set; }
        public virtual ICollection<EjercicioInventario> EjercicioInventario { get; set; }
        public virtual ICollection<RutinaEjercicio> RutinaEjercicio { get; set; }
    }
}
