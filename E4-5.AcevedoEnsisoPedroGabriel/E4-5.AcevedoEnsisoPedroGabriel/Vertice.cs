using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_5.AcevedoEnsisoPedroGabriel
{
    class Vertice//esta es mi clase vertice es la que se utiliza para generar los grafos del ejercicio 9 y 10
    {
        public string Info { get; set; }
        public List<Vertice> Adyacentes;//esta lista la uso para indicar que vertices tiene adyacente el vertice actual
        List<string> caminosConexos;//lista para guardar los caminos
        public Vertice(string info)
        {
            Info = info;
            Adyacentes = new List<Vertice>();
        }
        public void AgregarAdyacente(Vertice punto)//metodo con el que le agrego elementos a la lista de adyacentes de este nodo
        {
            Adyacentes.Add(punto);
        }
        public void ImprimirInfo()//metodo con el que imprimo la informacion de este vertice asi como los vertices que tiene adyacentes
        {
            Console.Write("Vertice: " + Info + "   vertices adyacentes:");
            foreach(Vertice i in Adyacentes)
            {
                Console.Write(i.Info + " ");
            }
            Console.WriteLine();
        }
        public void RutasFuertementeaConexas()//metodo que uso para encontrar las rutas que sean circulares y tambien aquellas que sean conexas
        {
            caminosConexos = new List<string>();
            foreach (Vertice i in Adyacentes)
            {
                RutasFuertementeaConexas(i, Info + " " , Info);
            }
        }
        public void RutasFuertementeaConexas(Vertice nodo, string road, string inicio)//este metdo recursivo se manda a llamar por el metodo anterior
        {
            if(nodo.Info == inicio)//cuando el vertice sea igual al vertice que esta recorriendo quiere decir que regreso a donde empeso entonces agrego este valor al camino y despues a la lista
            {
                road = road + nodo.Info + " ";
                caminosConexos.Add(road);
            }
            if(road.Contains(nodo.Info) == false)//mientras el camino no contenga el valor del nodo que se esta revisando seguira recorriendo sus caminos
            {
                road = road + nodo.Info + " ";
                foreach(Vertice j in nodo.Adyacentes)//por cada vertice en la lista de adyacentes corremos de nuevo el metodo recursivo
                {
                    RutasFuertementeaConexas(j, road, inicio);
                }
            }
        }
        public void ImprimirRutasFuertementeConexas()//simplemente imprimimos las rutas encontradas
        {
            foreach(string i in caminosConexos)
            {
                Console.WriteLine(i);
            }
        }
    }    
}
