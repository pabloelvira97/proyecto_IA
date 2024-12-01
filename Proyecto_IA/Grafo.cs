using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IA
{
    public class Grafo
    {
        public int nodos;
        public List<int>[] listaAdyacencia;
        public bool[] visitados;
        public Grafo(int nodos)
        {
            this.nodos = nodos;
            listaAdyacencia = new List<int>[this.nodos];
            visitados = new bool[nodos];

            for (int i = 0; i<nodos; i++)
            {
                listaAdyacencia[i] = new List<int>();
            }
        }

        public void AgregarArista (int nodoOrigen, int nodoDestino)
        {
            listaAdyacencia[nodoOrigen].Add(nodoDestino);
        }

        public void AlgoritmoAnchura(int nodoInicio, int nodoSolucion)
        {
            Queue<int> cola = new Queue<int>();

            bool[] visitado = new bool[nodos];

            visitado[nodoInicio] = true;
            cola.Enqueue(nodoInicio);

            while(cola.Count> 0) 
            {
                int nodo = cola.Dequeue();

                Console.WriteLine($"Nodo Estudiado ={nodo}");

                if(nodo == nodoSolucion)
                {
                    return;
                }

                foreach(int nodoAdyacente in listaAdyacencia[nodo])
                {
                    if (!visitado[nodoAdyacente])
                    {
                        visitado[nodoAdyacente] = true;
                        cola.Enqueue(nodoAdyacente);
                    }
                   
                }

            }

        }

        public void AlgoritmoProfundidad(int nodoInicio, int nodoSolucion, ref bool finalizado)
        {
            if (finalizado == true)
                return;

            visitados[nodoInicio] = true;
            int nodo = nodoInicio;

            Console.WriteLine($"Nodo Estudiado ={nodo}");

            if (nodo == nodoSolucion)
            {
                finalizado = true;
            }

            foreach (int nodoAdyacente in listaAdyacencia[nodo])
            {
                if (finalizado == true && nodoAdyacente != nodoSolucion)
                    return;

                AlgoritmoProfundidad(nodoAdyacente, nodoSolucion, ref finalizado);
            }
        }


    }
}
