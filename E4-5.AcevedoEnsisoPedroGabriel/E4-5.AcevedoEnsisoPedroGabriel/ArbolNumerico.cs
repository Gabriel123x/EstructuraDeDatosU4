using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_5.AcevedoEnsisoPedroGabriel
{
    class ArbolNumerico
    {
        public List<string> Caminos;//lista de string que utilizo para encontrar los distintos caminos que hay
        NodoNumerico raiz;//nuestro nodo raiz
        public ArbolNumerico()//constructor de la clase arbol binario ordenado 
        {
            raiz = null;
        }
        public void Insertar(int info)//llamando este metodo insertas nuevos elementos al arbol en este caso se insertan elementos enteros
        {
            NodoNumerico nuevo;
            nuevo = new NodoNumerico();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)//entiendo que si la raiz no tiene ningun elemento entonces se guarda en el
                raiz = nuevo;
            else//de no ser asi se guardara en el que siga
            {
                NodoNumerico anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)//condicion que utilizamos para saber si el numero insertado es mayor o menor al nodo acctual
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }
        private void ImprimirPre(NodoNumerico reco)//metodo para imprimir en preorden este es un metodo recursivo
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);//aqui se vuelve a llamar asi mismo este metodo por la izquierda y luego la derecha
                ImprimirPre(reco.der);
            }
        }
        public void ImprimirPre()//este metodo manda a llamar el metodo recursivo ImprimirPre
        {
            ImprimirPre(raiz);//comenzando desde la raiz (el elemento de mas arriba)
            Console.WriteLine();
        }
        private void ImprimirEntre(NodoNumerico reco)//metodo recursivo con el que imprimimos los elementos en orden in-orden
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }
        public void ImprimirEntre()//este es el metodo inicial que mandara a llamar la recursividad de in-orden
        {
            ImprimirEntre(raiz);//en este caso el primer elemento que se va a imprimir sera el elemento que este en la parte inferior izquierda
            Console.WriteLine();
        }
        private void ImprimirPost(NodoNumerico reco)//metodo recursivo que se usa para imprimir en pos-orden
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }
        public void ImprimirPost()//metodo que inicialmete mandara a llamar el metodo recursivo
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
        public void Imprimir()//este metodo manda a llamar los 3 metodos de imprimir
        {
            ImprimirEntre();
            ImprimirPost();
            ImprimirPre();
        }
        private void Conteo(NodoNumerico reco, string road)//metodo con el que encontramos todas las diferentes rutas que hay en el arbol
        {
            if (reco != null)
            {
                road = road + reco.info + " ";//vamos agregando cada elemento que hay en el arbol
                if (reco.izq == null && reco.der == null)//hasta que ese nodo ya no tenga hijos
                {
                    Caminos.Add(road);//lo agregamos a la lista de caminos
                }
                Conteo(reco.izq, road);
                Conteo(reco.der, road);
            }
        }
        public void Conteo()//este metodo es el que inicialmente llamara al metodo recursivo Conteo
        {
            Caminos = new List<string>();
            Conteo(raiz, "");
        }
        public void ImprimirCaminos()//metodo que simplemente imprime todos los caminos que se encontrron 
        {
            foreach(string i in Caminos)//los cuales se encuentran en la lista caminos
            {
                Console.WriteLine(i);
            }
        }
    }
}
