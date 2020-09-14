using System;
using System.Collections.Generic;
using System.Text;

namespace gym_Entidades.Comunes
{
    public class Auditable
    {
        public string IdCreador { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
