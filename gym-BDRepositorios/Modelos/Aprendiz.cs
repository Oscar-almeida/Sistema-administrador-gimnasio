using System;
using System.Collections.Generic;

namespace gym_BDRepositorios.Modelos
{
    public partial class Aprendiz
    {
        public Aprendiz()
        {
            HistorialCorporal = new HashSet<HistorialCorporal>();
            Rutina = new HashSet<Rutina>();
        }

        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public byte Edad { get; set; }
        public string Email { get; set; }
        public string Contrasenha { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoFijo { get; set; }
        public string Ficha { get; set; }
        public string Rh { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public virtual ICollection<HistorialCorporal> HistorialCorporal { get; set; }
        public virtual ICollection<Rutina> Rutina { get; set; }
    }
}
