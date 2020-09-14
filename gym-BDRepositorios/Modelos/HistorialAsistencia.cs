using System;
using System.Collections.Generic;

namespace gym_BDRepositorios.Modelos
{
    public partial class HistorialAsistencia
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaSalida { get; set; }
        public int RutinaId { get; set; }

        public virtual Rutina Rutina { get; set; }
    }
}
