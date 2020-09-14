using System;
using System.Collections.Generic;

namespace sag_Modelos
{
    public partial class Rutina
    {
        public Rutina()
        {
            HistorialAsistencia = new HashSet<HistorialAsistencia>();
            RutinaEjercicio = new HashSet<RutinaEjercicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string AprendizIdentificacion { get; set; }

        public virtual Aprendiz AprendizIdentificacionNavigation { get; set; }
        public virtual ICollection<HistorialAsistencia> HistorialAsistencia { get; set; }
        public virtual ICollection<RutinaEjercicio> RutinaEjercicio { get; set; }
    }
}
