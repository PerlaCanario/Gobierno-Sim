using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobierno_Sim
{
    public class Pueblo
    {
        public enum NivelMalestar
        {
            Baja,
            Alta
        }
        public NivelMalestar EstadoMalestar { get; set; }
    }
}
