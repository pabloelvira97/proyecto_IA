using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IA
{
    public class Program
    {
        static void Main(string[] args) 
        {

            Grafo grafo = new Grafo(36);

            grafo.AgregarArista(0, 1);
            grafo.AgregarArista(0, 2);
            grafo.AgregarArista(0, 3);
            grafo.AgregarArista(0, 4);

            grafo.AgregarArista(1, 5);
            grafo.AgregarArista(1, 6);
            grafo.AgregarArista(1, 7);
            grafo.AgregarArista(1, 8);

            grafo.AgregarArista(2, 9);
            grafo.AgregarArista(2, 10);
            grafo.AgregarArista(2, 11);
            grafo.AgregarArista(2, 12);

            grafo.AgregarArista(3, 13);
            grafo.AgregarArista(3, 14);
            grafo.AgregarArista(3, 15);
            grafo.AgregarArista(3, 16);

            grafo.AgregarArista(4, 17);
            grafo.AgregarArista(4, 18);
            grafo.AgregarArista(4, 19);
            grafo.AgregarArista(4, 20);

            grafo.AgregarArista(6, 21);
            grafo.AgregarArista(6, 22);
            grafo.AgregarArista(6, 23);

            grafo.AgregarArista(10, 24);
            grafo.AgregarArista(10, 25);

            grafo.AgregarArista(15, 26);
            grafo.AgregarArista(15, 27);

            grafo.AgregarArista(21, 28);

            Stopwatch crono = new Stopwatch();
            crono.Start();

            for (int i = 0; i < 1000; i++)
            {
                var fin = false;

                grafo.AlgoritmoAnchura(0, 28);
                grafo.AlgoritmoProfundidad(0, 28, ref fin);
                i++;
            }

            crono.Stop();

            Console.WriteLine($"Tiempo={crono.ElapsedMilliseconds}");



            List<Nodo> nodos= new List<Nodo>();
            Nodo nodo0 = new Nodo("0");
            Nodo nodo1 = new Nodo("1");
            Nodo nodo2 = new Nodo("2");
            Nodo nodo3 = new Nodo("3");
            Nodo nodo4 = new Nodo("4");
            Nodo nodo5 = new Nodo("5");
            Nodo nodo6 = new Nodo("6");
            Nodo nodo7 = new Nodo("7");
            Nodo nodo8 = new Nodo("8");
            Nodo nodo9 = new Nodo("9");
            Nodo nodo10 = new Nodo("10");
            Nodo nodo11 = new Nodo("11");
            Nodo nodo12 = new Nodo("12");
            Nodo nodo13 = new Nodo("13");
            Nodo nodo14 = new Nodo("14");
            Nodo nodo15 = new Nodo("15");
            Nodo nodo16 = new Nodo("16");
            Nodo nodo17 = new Nodo("17");
            Nodo nodo18 = new Nodo("18");
            Nodo nodo19 = new Nodo("19");
            Nodo nodo20 = new Nodo("20");
            Nodo nodo21 = new Nodo("21");
            Nodo nodo22 = new Nodo("22");
            Nodo nodo23 = new Nodo("23");
            Nodo nodo24 = new Nodo("24");
            Nodo nodo25 = new Nodo("25");
            Nodo nodo26 = new Nodo("26");
            Nodo nodo27 = new Nodo("27");
            Nodo nodo28 = new Nodo("28");

            nodos.Add(nodo1);
            nodos.Add(nodo2);
            nodos.Add(nodo3);
            nodos.Add(nodo4);
            nodos.Add(nodo5);
            nodos.Add(nodo6);
            nodos.Add(nodo7);
            nodos.Add(nodo8);
            nodos.Add(nodo9);
            nodos.Add(nodo10);
            nodos.Add(nodo11);
            nodos.Add(nodo12);
            nodos.Add(nodo13);
            nodos.Add(nodo14);
            nodos.Add(nodo15);
            nodos.Add(nodo16);
            nodos.Add(nodo17);
            nodos.Add(nodo18);
            nodos.Add(nodo19);
            nodos.Add(nodo20);
            nodos.Add(nodo21);
            nodos.Add(nodo22);
            nodos.Add(nodo23);
            nodos.Add(nodo24);
            nodos.Add(nodo25);
            nodos.Add(nodo26);
            nodos.Add(nodo27);
            nodos.Add(nodo28);


            nodo0.AgregarArista(nodo1, 1);
            nodo0.AgregarArista(nodo2, 1);
            nodo0.AgregarArista(nodo3, 1);
            nodo0.AgregarArista(nodo4, 1);

            nodo1.AgregarArista(nodo5, 1);
            nodo1.AgregarArista(nodo6, 1);
            nodo1.AgregarArista(nodo7, 1);
            nodo1.AgregarArista(nodo8, 1);

            nodo2.AgregarArista(nodo9, 1);
            nodo2.AgregarArista(nodo10, 1);
            nodo2.AgregarArista(nodo11, 1);
            nodo2.AgregarArista(nodo12, 1);

            nodo3.AgregarArista(nodo13, 1);
            nodo3.AgregarArista(nodo14, 1);
            nodo3.AgregarArista(nodo15, 1);
            nodo3.AgregarArista(nodo16, 1);

            nodo4.AgregarArista(nodo17, 1);
            nodo4.AgregarArista(nodo18, 1);
            nodo4.AgregarArista(nodo19, 1);
            nodo4.AgregarArista(nodo20, 1);

            nodo6.AgregarArista(nodo21, 1);
            nodo6.AgregarArista(nodo22, 1);
            nodo6.AgregarArista(nodo23, 1);
            nodo6.AgregarArista(nodo24, 1);

            nodo10.AgregarArista(nodo24, 1);
            nodo10.AgregarArista(nodo25, 1);

            nodo15.AgregarArista(nodo26, 1);
            nodo15.AgregarArista(nodo27, 1);

            nodo21.AgregarArista(nodo28, 1);

            foreach(Nodo nodo in nodos)
            {
                int name = Convert.ToInt16(nodo.name);

                if (name == 0)
                {
                    nodo.AgregarHeuristica(nodo15, 2);

                }

                if (name == 3)
                {
                    nodo.AgregarHeuristica(nodo15, 1);

                }

                if (name >=1 && name <=4 && name != 3)
                {
                    nodo.AgregarHeuristica(nodo15, 3);

                }

                if (name >=5 && name <=12)
                {
                    nodo.AgregarHeuristica(nodo15, 4);

                }
                if (name >=13 && name <=16 && name != 15)
                {
                    nodo.AgregarHeuristica(nodo15, 2);

                }

                if (name == 28)
                {
                    nodo.AgregarHeuristica(nodo15, 6);

                }
                if (name >=17 && name <=20)
                {
                    nodo.AgregarHeuristica(nodo15, 4);

                }
                if (name == 15)
                {
                    nodo.AgregarHeuristica(nodo15, 0);

                }


            }

            List<Nodo> list = new List<Nodo>();
            //crono.Start();

            //for (int i = 0; i<1000; i++)
            //{
            //   list = Nodo.AlgoritmoA(nodo0, nodo15);
            //    i++;
            //}

            //crono.Stop();

            //List<string> result = new List<string>();

            //for (int i = 0; i < list.Count; i++)
            //    result.Add(list[i].name);

            //Console.WriteLine($"El recorrido es {String.Join("-", result)}: {crono.ElapsedMilliseconds} ");

        }
    }
}
