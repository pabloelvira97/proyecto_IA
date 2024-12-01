using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IA
{
    public class Nodo
    {
        public string name;
        public List<Arista> vecinos = new List<Arista>();
        public List<Heuristica> heuristicas = new List<Heuristica>();
        public float G;
        public float H;
        public Nodo nodoPadre = null;
        public float F => G + H;

        public Nodo(string name)
        {
            this.name = name;
        }

        public Nodo(string name, Nodo nodoPadre)
        {
            this.name = name;
            this.nodoPadre = nodoPadre;
        }
        public void AgregarArista (Nodo nodovecino, float coste)
        {
            vecinos.Add(new Arista(this, nodovecino, coste));
        }
        
        public void AgregarHeuristica (Nodo destino, float coste)
        {
            heuristicas.Add(new Heuristica(this, destino, coste));
        }

        public float GetHeuristica( Nodo destino)
        {
            float resultado = -1;
            foreach(var heuristica in heuristicas)
            {
                if (heuristica.origen == this && heuristica.destino == destino)
                    return resultado = heuristica.coste;
            }
            return resultado;
        }
        public static List<Nodo> AlgoritmoA (Nodo origen, Nodo solucion)
        {
            var nodosPorExplorar = new List<Nodo>(){origen};
            var nodosExplorados = new List<Nodo>();

            origen.G = 0;

            while(nodosPorExplorar.Count > 0 )
            {
                nodosPorExplorar.Sort((node1, node2) => node1.F.CompareTo(node2.F));

                Nodo nodoEstudiado = nodosPorExplorar[0];
                nodosPorExplorar.Remove(nodoEstudiado);

                if(nodoEstudiado == solucion) 
                {
                    List<Nodo> recorrido = new List<Nodo>();
                    while(nodoEstudiado != null)
                    {
                        recorrido.Add(nodoEstudiado);
                        nodoEstudiado = nodoEstudiado.nodoPadre;
                    }

                    recorrido.Reverse();
                    return recorrido;
                }

                nodosExplorados.Add(nodoEstudiado);

                Nodo siguienteNodo = null;

                foreach(Arista arista in nodoEstudiado.vecinos)
                {
                    Nodo vecino = arista.destino;

                    if (nodosExplorados.Contains(vecino))
                        continue;

                    vecino.G = nodoEstudiado.G + arista.coste;
                    vecino.H = vecino.GetHeuristica(solucion);
                    
                    if(siguienteNodo == null)
                        siguienteNodo= vecino;

                    else
                    {
                        if (vecino.F < siguienteNodo.F)
                            siguienteNodo = vecino;
                    }
                }

                siguienteNodo.nodoPadre = nodoEstudiado;
                if(!nodosPorExplorar.Contains(siguienteNodo))
                    nodosPorExplorar.Add(siguienteNodo);
            }
            return null;
        }
    }
}
