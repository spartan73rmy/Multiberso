using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiberso
{
    public class Indicador
    {
        public string Nombre { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public string Parametro { get; set; }

        public double Valor { get; set; }

        public bool Inverso { get; set; }
    }

}
