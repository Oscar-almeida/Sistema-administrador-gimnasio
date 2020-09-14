using System;
using System.Collections.Generic;

namespace gym_BDRepositorios.Modelos
{
    public partial class EjercicioInventario
    {
        public int Id { get; set; }
        public int EjercicioId { get; set; }
        public int InventarioId { get; set; }

        public virtual Ejercicio Ejercicio { get; set; }
        public virtual Inventario Inventario { get; set; }
    }
}
