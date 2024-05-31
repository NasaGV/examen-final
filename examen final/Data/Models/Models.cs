using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_final.Models
{
    public class ArmasModels
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int DañoFisico { get; set; }
        public int DañoMagico { get; set; }
        public float Peso { get; set; }
        public string EscaladoFuerza { get; set; }
        public string EscaladoDestreza { get; set; }
        public string Descripcion { get; set; }
    }
}
