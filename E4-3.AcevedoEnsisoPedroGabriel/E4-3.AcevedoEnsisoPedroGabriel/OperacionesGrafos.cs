using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3.AcevedoEnsisoPedroGabriel
{
    class OperacionesGrafos
    {
        Arista miArista;
        List<Arista> MisAristas;//lista de aristas que se usaran para generar el grafo
        List<string> recorridos;//aqui guardaremos todos los recorridos que hagamos cuando realizamos el ejercicio
        public OperacionesGrafos()
        {
            recorridos = new List<string>();
            MisAristas = new List<Arista>();
        }
        public void CrearGrafoEjercicio1()//creamos el grafo del ejercicio E4-3
        {
            miArista = new Arista("A", "B");//simplemente usamos el constructor para crear cada arista y la agregamos a la lista de aristas
            MisAristas.Add(miArista);
            miArista = new Arista("B", "C");
            MisAristas.Add(miArista);
            miArista = new Arista("B", "G");
            MisAristas.Add(miArista);
            miArista = new Arista("C", "G");
            MisAristas.Add(miArista);
            miArista = new Arista("C", "D");
            MisAristas.Add(miArista);
            miArista = new Arista("G", "F");
            MisAristas.Add(miArista);
            miArista = new Arista("D", "F");
            MisAristas.Add(miArista);
            miArista = new Arista("D", "E");
            MisAristas.Add(miArista);
            miArista = new Arista("F", "E");
        }
        private void RecorrerGrafo(Arista temp, string camino)//metodo recursivo que usamos para encontrar el recorrido de los caminos que pueden existir
        {
            if (camino.Length == 7)//si el camino es de longitud 7 entonces ya habra recorrido todos los vertices
            {
                recorridos.Add(camino);//se agrega a nuestra lista de caminos
            }
            else
            {
                foreach(Arista i in MisAristas)//en este metodo vamos agregando las letras del camino
                {
                    //Console.WriteLine(camino);
                    //Console.ReadKey();
                    if (camino[camino.Length - 1] == i.Vertice1.Letra[0])//notas de estas condiciones al fondo
                    {
                        if (camino.Contains(i.Vertice2.Letra) == false)
                        {
                            RecorrerGrafo(i, camino + i.Vertice2.Letra);
                        }
                    }
                    if (camino[camino.Length - 1] == i.Vertice2.Letra[0])
                    {
                        if (camino.Contains(i.Vertice1.Letra) == false)
                        {
                            RecorrerGrafo(i, camino + i.Vertice1.Letra);
                        }
                    }
                }
            }
        }
        public void RecorrerEjercicio1()//metodo que mandamos llamar para iniciar el recorrido
        {
            foreach(Arista i in MisAristas)//usamos un foreach para recorrer todas las aristas
            {              
                RecorrerGrafo(i, i.Vertice1.Letra + i.Vertice2.Letra);//esto lo hice dos veces para recorrer de las dos maneras 
                RecorrerGrafo(i, i.Vertice2.Letra + i.Vertice1.Letra);//ya que los vertices se pueden recorrer de un sentido al otro
            }
        }
        public void ImprimirRecorridos()//metodo en el que imprimimos todos los recorridos que encontramos
        {
            Console.WriteLine("Los caminos encontrados en este grafo son:");
            foreach(string i in recorridos)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        //en este ejercico tuve muchos problemas con las condiciones que use aqui la verdad no encontre como hacer que aparecieran los demas caminos 
        //el programa se detiene en 6 letras en todos los demas caminos excepto en el ABCGFDE y EDFGCBA
        //y no puedo encontrar en donde me equivoco con las condiciones el porque no permiten agregar esa ultima letra
        //aqui le envio detodosmodos el ejercicio con lo que pude hacer antes de la hora de entrega
    }
}
