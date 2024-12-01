using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IA
{
    public class Heuristica
    {
        public Nodo origen;
        public Nodo destino;
        public float coste;

        public Heuristica(Nodo origen, Nodo destino, float coste)
        {
            this.origen=origen;
            this.destino=destino;
            this.coste=coste;
        }
    }
}
