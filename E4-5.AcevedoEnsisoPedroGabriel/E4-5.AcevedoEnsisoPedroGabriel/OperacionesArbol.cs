using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_5.AcevedoEnsisoPedroGabriel
{
    class OperacionesArbol//arbol que se utiliza para crear arboles binarios con letras del alfabeto funciona de una manera muy similar al arbol numerico
    {//la clase se modifico de esa para poder utilizar string en el nodo
        Nodo raiz;
        public List<string> Caminos;
        public OperacionesArbol()
        {
            raiz = null;
        }

        public void Insertar(string info)//la primera diferencia esta aqui enves de aceptar enteros lo cambiamos a string
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (Convert.ToInt32(info[0]) < Convert.ToInt32(reco.info[0]))//en la parte que comparamos cual letra es mayor nosotros convertimos esa letra a su valor en codigo ASCII y asi comparamos sus valores
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (Convert.ToInt32(info[0]) < Convert.ToInt32(anterior.info[0]))
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }//los metodos de impresion son identicos a los del arbol numerico
        private void ImprimirPre(Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);
                ImprimirPre(reco.der);
            }
        }

        public void ImprimirPre()
        {
            Console.WriteLine("Pre-orden");
            ImprimirPre(raiz);
            Console.WriteLine();
        }

        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }
        public void ImprimirEntre()
        {
            Console.WriteLine("In-orden");
            ImprimirEntre(raiz);
            Console.WriteLine();
        }
        private void ImprimirPost(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }
        public void ImprimirPost()
        {
            Console.WriteLine("Pos-orden");
            ImprimirPost(raiz);
            Console.WriteLine();
        }
        public void Imprimir()
        {
            ImprimirEntre();
            ImprimirPost();
            ImprimirPre();
        }
        public void ImprimirCaminos()//metodo que simplemente imprime todos los caminos que se encontrron 
        {
            foreach (string i in Caminos)//los cuales se encuentran en la lista caminos
            {
                Console.WriteLine(i);
            }
        }
        public void CaminoBinario()//metodo que nos ayudara a ir contando el camino seguido en forma de unos y ceros
        {
            Caminos = new List<string>();
            CaminoBinario(raiz, "", "");
        }
        private void CaminoBinario(Nodo reco, string road, string numero)//metodo recursivo
        {//este ejercicio se utiliza mas que nada en el ejercicio 7 donde necesitamos llevar un control de los numeros que siguio el arbol
            if (reco != null)
            {
                road = road + numero + " ";
                if (reco.izq == null && reco.der == null)//una ves que el nodo ya no tiene hijos se agrega el elemento que posee al camino y se agrega a la lista
                {
                    road = road + "Es el camino de:  " + reco.info;
                    Caminos.Add(road);
                }
                CaminoBinario(reco.izq, road, "0");//basicamente si el arbol viaja por la derecha se agregara un uno al camino de caso contrario se agregara un 0
                CaminoBinario(reco.der, road, "1");
            }
        }
    }
}
    

