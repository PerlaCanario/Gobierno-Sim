using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobierno_Sim
{
    public class Gobierno
    {
        public enum Partido
        {
            Conservador,
            Liberal
        }

        public enum Politica
        {
            Permisiva,
            Coercitiva
        }

        public Partido PartidoPolitico { get; set; }
        public Politica PoliticaGubernamental { get; set; }
    }
}
