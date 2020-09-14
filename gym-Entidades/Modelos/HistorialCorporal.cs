using System;
using System.Collections.Generic;

namespace sag_Modelos
{
    public partial class HistorialCorporal
    {
        public int Id { get; set; }
        public decimal Peso { get; set; }
        public byte Estatura { get; set; }
        public decimal Imc { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string AprendizIdentificacion { get; set; }

        public virtual Aprendiz AprendizIdentificacionNavigation { get; set; }
    }
}
