using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_5.AcevedoEnsisoPedroGabriel
{
    class NodoManual//nodo que utilizamos en el arbol manual para crear arboles especificos
    {
        public string info;
        public NodoManual Uno, Dos;
        public void Instanciar2Nodos()//los siguientes metodos los usamos para instanciar los nodos hijos que vamos a necesitar
        {
            Uno = new NodoManual();
            Dos = new NodoManual();
        }
        public void InstanciarNodoDerecho()//si solo necesitamos el nodo derecho...
        {
            Dos = new NodoManual();
        }
        public void InstanciarNodoIzquierdo()//si solo necesitamos el nodo izquierdo...
        {
            Uno = new NodoManual();
        }
    }
}
