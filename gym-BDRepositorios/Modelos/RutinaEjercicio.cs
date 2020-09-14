using System;
using System.Collections.Generic;

namespace gym_BDRepositorios.Modelos
{
    public partial class RutinaEjercicio
    {
        public int Id { get; set; }
        public byte Series { get; set; }
        public byte Repeticiones { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int EjercicioId { get; set; }
        public int RutinaId { get; set; }

        public virtual Ejercicio Ejercicio { get; set; }
        public virtual Rutina Rutina { get; set; }
    }
}
