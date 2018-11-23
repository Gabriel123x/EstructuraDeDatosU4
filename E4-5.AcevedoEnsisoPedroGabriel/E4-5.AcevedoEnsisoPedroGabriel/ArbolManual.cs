using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_5.AcevedoEnsisoPedroGabriel
{
    class ArbolManual//aqui creamos los arboles especificos para los ejercicios
    {
        NodoManual miNodo;
        public void CrearArbolE3()//construimos el arbol para el ejercicio 3
        {
            miNodo = new NodoManual();
            miNodo.info = "A";//raiz
            miNodo.Instanciar2Nodos();
            miNodo.Uno.info = "J";
            miNodo.Dos.info = "C";
            miNodo.Uno.Instanciar2Nodos();
            miNodo.Uno.Uno.info = "B";
            miNodo.Uno.Dos.info = "F";
            miNodo.Dos.InstanciarNodoDerecho();
            miNodo.Dos.Dos.info = "G";
            miNodo.Dos.Dos.InstanciarNodoIzquierdo();
            miNodo.Dos.Dos.Uno.info = "K";
            miNodo.Uno.Uno.Instanciar2Nodos();
            miNodo.Uno.Uno.Uno.info = "D";
            miNodo.Uno.Uno.Dos.info = "E";
            miNodo.Uno.Dos.Instanciar2Nodos();
            miNodo.Uno.Dos.Uno.info = "H";
            miNodo.Uno.Dos.Dos.info = "I";
        }
        private void ImprimirPost(NodoManual reco)//metodo recursivo con el que imprimimos en pos-orden
        {
            if (reco != null)
            {
                ImprimirPost(reco.Uno);
                ImprimirPost(reco.Dos);
                Console.Write(reco.info + " ");
            }
        }
        public void ImprimirPost()//metodo con el que inicialmente se manda a llamar el metodo que imprime en pos-orden
        {
            ImprimirPost(miNodo);
            Console.WriteLine();
        }
        public void ImprimirGraficamenteBinario(NodoManual reco, string espacio)//metodo con el que imprimimos graficamente nuestro arbol
        {
            if (reco != null)
            {
                Console.WriteLine(espacio + reco.info);
                ImprimirGraficamenteBinario(reco.Uno, espacio + "-");
                ImprimirGraficamenteBinario(reco.Dos, espacio + "-");
            }
        }
        public void ImprimirGraficamenteBinario()//metodo con el que inicialmente mandamos llamar el metodo recursivo que nos va a imprimir el arbol graficamente
        {
            ImprimirGraficamenteBinario(miNodo, "|");
        }
    }
}
