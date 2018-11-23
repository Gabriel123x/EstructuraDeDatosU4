using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_5.AcevedoEnsisoPedroGabriel
{
    class EjerciciosBinarios
    {
        ArbolManual E6;//este es el arbol que usamos en los ejercicio que necesiten de un arbol especifico
        OperacionesArbol E4;//este es el arbol que uso cuando necesito vertices que tienen letras
        ArbolNumerico E5;//este es el arbol que uso cuando necesito vertices que tienen numeros
        public EjerciciosBinarios() { }
        public void Ejercicio1()//aqui hacemos el ejercicio 1
        {
            Console.WriteLine("Ejercicio 1");
            E5 = new ArbolNumerico();
            E5.Insertar(50);//insertamos valores al arbol de tal manera que se acomoden como en el braquet que genere para 25 jugadores
            E5.Insertar(60);
            E5.Insertar(59);
            E5.Insertar(55);
            E5.Insertar(52);
            E5.Insertar(51);
            E5.Insertar(53);
            E5.Insertar(57);
            E5.Insertar(56);
            E5.Insertar(58);
            E5.Insertar(75);
            E5.Insertar(70);
            E5.Insertar(73);
            E5.Insertar(72);
            E5.Insertar(74);
            E5.Insertar(65);
            E5.Insertar(64);
            E5.Insertar(66);
            E5.Insertar(80);
            E5.Insertar(85);
            E5.Insertar(84);
            E5.Insertar(86);
            E5.Insertar(25);
            E5.Insertar(17);
            E5.Insertar(40);
            E5.Insertar(13);
            E5.Insertar(21);
            E5.Insertar(30);
            E5.Insertar(45);
            E5.Insertar(12);
            E5.Insertar(15);
            E5.Insertar(19);
            E5.Insertar(23);
            E5.Insertar(27);
            E5.Insertar(35);
            E5.Insertar(43);
            E5.Insertar(48);
            E5.Insertar(11);
            E5.Insertar(14);
            E5.Insertar(16);
            E5.Insertar(18);
            E5.Insertar(20);
            E5.Insertar(22);
            E5.Insertar(24);
            E5.Insertar(26);
            E5.Insertar(28);
            E5.Insertar(34);
            E5.Insertar(36);
            E5.Insertar(41);
            E5.Insertar(44);
            E5.Insertar(47);
            E5.Insertar(49);
            Console.WriteLine("Imprimimos primero la representacion del arbol generado en in-orden");
            E5.ImprimirEntre();
            Console.WriteLine("\nAqui represento los distintos caminos que hay para llegar a la victoria\nEl numero 50 representa el campeon\nAqui simplemente generamos un braquet y luego lo creamos como\nUn arbol alreves con numeros que representen cada jugador o juego");
            E5.Conteo();//realizamos una busqueda de los distintos caminos que toma el arbol
            E5.ImprimirCaminos();//imprimimos todos esos caminos y nos damos cuenta que el arbol es de altura 6 diciendonos que los jugadores deben jusgar 5 juegos ya que la raiz es tecnicamente nuestro campeon
            Console.WriteLine("\nComo el 50 es el campeon ese elemento enrealidad no es un juego\nEntonces el numero de juegos que uno debe jugar para ser campeon son 5\nAunque por la manera en que distribuimos los braquets\nEs posible que algun jugador sea ganador con solo 4 juegos");
            Console.ReadKey();//por la manera en que generamos el braquet descubri que es posible terminar en 4 juegos si tienes suerte....
            Console.Clear();
        }
        //intente lo mejor que pude maestro pero no supe como hacerle en el ejercicio 2 :(
        //public void Ejercicio2()
        //{

        //}
        public void Ejercicio3()//aqui hacemos nuestro ejercicio 3
        {
            E6 = new ArbolManual();
            E6.CrearArbolE3();//en nuestra clase arbol manual esta la creacion de este arbol se creo asi ya que la manera en que se nos indicaba estaban ordenados los elementos no se podia ordenar automaticamente con nuestro algoritmo de arboles binarios
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Imprimimos el arbol generado en pos-orden para comprovar su correcta generacion");
            E6.ImprimirPost();//primero imprimimos nuestro arbol generado en pos-orden para comprovar que es el mismo que el que el ejercicio nos indicaba
            Console.WriteLine("A continuacion imprimimos el dibujo del arbol generado");
            E6.ImprimirGraficamenteBinario();//inprimimos una representacion un poco mas amigable del arbol
            Console.ReadKey();//note que el arbol que nos da el ejercicio es imposible que pueda ser de altura 3 ya que este arbol enrealidad cuenta con una altura de 4 pero aun asi lo construi como me indicaba la lista de pos-orden
            Console.Clear();

        }
        public void Ejercicio4()//aqui hacemos nuestro ejercicio 4
        {
            Console.WriteLine("Ejercicio 4");//en los ejercicios 4 5 y 6 simplemente instanciamos nuestro arbol y le insertamos las letras en el orden que nos indica la palabra que debemos usar
            E4 = new OperacionesArbol();
            E4.Insertar("b");
            E4.Insertar("a");
            E4.Insertar("n");
            E4.Insertar("a");
            E4.Insertar("n");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra banana");
            E4.Imprimir();//imprimimos los 3 tipos de recorridos con los que contamos usando este metod
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();//y volvemos a instanciar la clase para usarse en la siguiente palabra y de esta manera por igual se realizaron los ejercicio 5 y 6
            E4.Insertar("m");
            E4.Insertar("e");
            E4.Insertar("l");
            E4.Insertar("o");
            E4.Insertar("c");
            E4.Insertar("o");
            E4.Insertar("t");
            E4.Insertar("o");
            E4.Insertar("n");
            Console.WriteLine("Arbol de la palabra melocoton");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("m");
            E4.Insertar("a");
            E4.Insertar("n");
            E4.Insertar("z");
            E4.Insertar("a");
            E4.Insertar("n");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra manzana");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("p");
            E4.Insertar("e");
            E4.Insertar("r");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra pera");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("c");
            E4.Insertar("o");
            E4.Insertar("c");
            E4.Insertar("o");
            Console.WriteLine("Arbol de la palabra coco");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("m");
            E4.Insertar("a");
            E4.Insertar("n");
            E4.Insertar("g");
            E4.Insertar("o");
            Console.WriteLine("Arbol de la palabra mango");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("p");
            E4.Insertar("a");
            E4.Insertar("p");
            E4.Insertar("a");
            E4.Insertar("y");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra papaya");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
        }
        public void Ejercicio5()//aqui hacemos nuestro ejercicio 5
        {
            Console.WriteLine("Ejercicio 5");
            E4 = new OperacionesArbol();
            E4.Insertar("e");
            E4.Insertar("n");
            E4.Insertar("o");
            E4.Insertar("l");
            E4.Insertar("o");
            E4.Insertar("g");
            E4.Insertar("i");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra enologia");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("f");
            E4.Insertar("r");
            E4.Insertar("e");
            E4.Insertar("n");
            E4.Insertar("o");
            E4.Insertar("l");
            E4.Insertar("o");
            E4.Insertar("g");
            E4.Insertar("i");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra frenologia");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("c");
            E4.Insertar("a");
            E4.Insertar("m");
            E4.Insertar("p");
            E4.Insertar("a");
            E4.Insertar("n");
            E4.Insertar("o");
            E4.Insertar("l");
            E4.Insertar("o");
            E4.Insertar("g");
            E4.Insertar("i");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra campanologia");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("o");
            E4.Insertar("r");
            E4.Insertar("n");
            E4.Insertar("i");
            E4.Insertar("t");
            E4.Insertar("o");
            E4.Insertar("l");
            E4.Insertar("o");
            E4.Insertar("g");
            E4.Insertar("i");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra ornitologia");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("i");
            E4.Insertar("c");
            E4.Insertar("t");
            E4.Insertar("i");
            E4.Insertar("o");
            E4.Insertar("l");
            E4.Insertar("o");
            E4.Insertar("g");
            E4.Insertar("i");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra ictiologia");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("l");
            E4.Insertar("i");
            E4.Insertar("m");
            E4.Insertar("n");
            E4.Insertar("o");
            E4.Insertar("l");
            E4.Insertar("o");
            E4.Insertar("g");
            E4.Insertar("i");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra limnologia");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("a");
            E4.Insertar("l");
            E4.Insertar("q");
            E4.Insertar("u");
            E4.Insertar("i");
            E4.Insertar("m");
            E4.Insertar("i");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra alquimia");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
            E4 = new OperacionesArbol();
            E4.Insertar("a");
            E4.Insertar("s");
            E4.Insertar("t");
            E4.Insertar("r");
            E4.Insertar("o");
            E4.Insertar("l");
            E4.Insertar("o");
            E4.Insertar("g");
            E4.Insertar("i");
            E4.Insertar("a");
            Console.WriteLine("Arbol de la palabra astrologia");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
        }
        public void Ejercicio6()//aqui hacemos nuestro ejercicio 6
        {
            Console.WriteLine("Ejercicio 6");
            E4 = new OperacionesArbol();
            E4.Insertar("E");
            E4.Insertar("l");

            E4.Insertar("r");
            E4.Insertar("a");
            E4.Insertar("p");
            E4.Insertar("i");
            E4.Insertar("d");
            E4.Insertar("o");

            E4.Insertar("z");
            E4.Insertar("o");
            E4.Insertar("r");
            E4.Insertar("r");
            E4.Insertar("o");

            E4.Insertar("m");
            E4.Insertar("a");
            E4.Insertar("r");
            E4.Insertar("r");
            E4.Insertar("o");
            E4.Insertar("n");

            E4.Insertar("s");
            E4.Insertar("a");
            E4.Insertar("l");
            E4.Insertar("t");
            E4.Insertar("a");

            E4.Insertar("s");
            E4.Insertar("o");
            E4.Insertar("b");
            E4.Insertar("r");
            E4.Insertar("e");

            E4.Insertar("e");
            E4.Insertar("l");

            E4.Insertar("p");
            E4.Insertar("e");
            E4.Insertar("r");
            E4.Insertar("r");
            E4.Insertar("o");

            E4.Insertar("p");
            E4.Insertar("e");
            E4.Insertar("r");
            E4.Insertar("e");
            E4.Insertar("z");
            E4.Insertar("o");
            E4.Insertar("s");
            E4.Insertar("o");
            Console.WriteLine("Arbol de la frase El rápido zorro marrón salta sobre el perro perezoso");
            E4.Imprimir();
            Console.ReadKey();
            Console.Clear();
        }
        public void Ejercicio7()//aqui hacemos nuestro ejercicio 7
        {
            Console.WriteLine("Ejercicio 7");//en el ejercicio 7 necesitamos generar un arbol donde los ultimos nodos sean A E I K O P U
            E4 = new OperacionesArbol();
            E4.Insertar("j");//Y resulta que es posible crear un arbol asi si introduces las palabras adecuadas
            E4.Insertar("h");
            E4.Insertar("i");
            E4.Insertar("b");
            E4.Insertar("a");
            E4.Insertar("e");

            E4.Insertar("j");
            E4.Insertar("p");
            E4.Insertar("m");
            E4.Insertar("k");
            E4.Insertar("o");

            E4.Insertar("p");
            E4.Insertar("q");
            E4.Insertar("p");
            E4.Insertar("u");
            E4.CaminoBinario();//en este metodo encontramos todos los caminos que se tienen que seguir para llegar al ultimo nodo de este arbol 
            E4.ImprimirCaminos();//y porsupuesto lo imprmimos para comprovar que son correctos
            Console.ReadKey();
            Console.Clear();
        }
        public void Ejercicio8()//aqui hacemos nuestro ejercicio 8
        {
            Console.WriteLine("Ejercicio 8");
            E5 = new ArbolNumerico();//en este ejercicio utilizaremos nuestro arbol numerico 
            E5.Insertar(-1);//simplemente insertamos los valores que nos dio el ejercicio y el algoritmo se encargara de ordenarlos
            E5.Insertar(0);
            E5.Insertar(2);
            E5.Insertar(-2);
            E5.Insertar(3);
            E5.Insertar(6);
            E5.Insertar(-3);
            E5.Insertar(5);
            E5.Insertar(1);
            E5.Insertar(4);
            Console.WriteLine("Se imprimiran la serie de numeros -1,0,2,-2,3,6,-3,5,1,4 en in-orden");
            E5.ImprimirEntre();
            Console.ReadKey();
            Console.Clear();
            E5 = new ArbolNumerico();//lo mismo hacemos con la otra serie de numeros instanciando de nuevo la clase para comenzar de cero
            E5.Insertar(-1);
            E5.Insertar(7);
            E5.Insertar(4);
            E5.Insertar(11);
            E5.Insertar(5);
            E5.Insertar(-8);
            E5.Insertar(15);
            E5.Insertar(-3);
            E5.Insertar(-2);
            E5.Insertar(6);
            E5.Insertar(10);
            E5.Insertar(3);
            Console.WriteLine("Se imprimiran la serie de numeros -1,7,4,11,5,-8,15,-3,-2,6,10,3 en in-orden");
            E5.ImprimirEntre();
            Console.ReadKey();
            Console.Clear();
        }
        public void Ejercicio9()//aqui hacemos nuestro ejercicio 9
        {            
            Console.WriteLine("Ejercicio 9");//para los 3 grafos hicimos lo mismo en este ejercicio
            Vertice PuntoA = new Vertice("A");//primero instanciamos los puntos que utilizaremos en el grafo cada uno con su identificador apropiado
            Vertice PuntoB = new Vertice("B");
            Vertice PuntoC = new Vertice("C");
            Vertice PuntoD = new Vertice("D");
            Vertice PuntoE = new Vertice("E");
            PuntoA.AgregarAdyacente(PuntoE);//utilizamos el metodo de agregar adyacente para indicarle a cada punto a que otros vertices estan conectados

            PuntoE.AgregarAdyacente(PuntoB);

            PuntoB.AgregarAdyacente(PuntoA);
            PuntoB.AgregarAdyacente(PuntoC);

            PuntoD.AgregarAdyacente(PuntoC);
            PuntoD.AgregarAdyacente(PuntoB);
            PuntoD.AgregarAdyacente(PuntoE);

            List<Vertice> MiGrafo = new List<Vertice>();//agregamos estos puntos a una lista
            MiGrafo.Add(PuntoA);
            MiGrafo.Add(PuntoB);
            MiGrafo.Add(PuntoC);
            MiGrafo.Add(PuntoD);
            MiGrafo.Add(PuntoE);

            Console.WriteLine("Grafo 1");
            foreach (Vertice i in MiGrafo)//imprimimos la informacion de cada vertice de nuestro grafo
            {
                i.ImprimirInfo();
            }
            Console.WriteLine("Las rutas fuertemente conexas son las siguientes");//utilizando el metodo RutasFuertementeConexas encontramos las diferenetes rutas que tiene cada uno de los vertices de nuestro grafo
            foreach(Vertice i in MiGrafo)
            {
                i.RutasFuertementeaConexas();
                i.ImprimirRutasFuertementeConexas();//imrprimimos los caminos encontrados
            }
            Console.WriteLine("Por lo tanto los puntos fuertemente conexos son A B y E");//basado en estos resultados podemos dar nuestra respuesta
            
            Console.ReadKey();
            Console.Clear();
            PuntoA = new Vertice("A");///comenzamos de nuevo con el siguiente grafo instanciando de nuevo los puntos....
            PuntoB = new Vertice("B");
            PuntoC = new Vertice("C");
            PuntoD = new Vertice("D");
            PuntoE = new Vertice("E");
            Vertice PuntoF = new Vertice("F");
            PuntoA.AgregarAdyacente(PuntoF);

            PuntoE.AgregarAdyacente(PuntoC);
            PuntoE.AgregarAdyacente(PuntoB);
            PuntoE.AgregarAdyacente(PuntoF);

            PuntoB.AgregarAdyacente(PuntoA);

            PuntoD.AgregarAdyacente(PuntoE);

            PuntoC.AgregarAdyacente(PuntoB);
            PuntoC.AgregarAdyacente(PuntoD);
            MiGrafo = new List<Vertice>();
            MiGrafo.Add(PuntoA);
            MiGrafo.Add(PuntoB);
            MiGrafo.Add(PuntoC);
            MiGrafo.Add(PuntoD);
            MiGrafo.Add(PuntoE);
            MiGrafo.Add(PuntoF);

            Console.WriteLine("Grafo 2");
            foreach (Vertice i in MiGrafo)
            {
                i.ImprimirInfo();
            }
            Console.WriteLine("Las rutas fuertemente conexas son las siguientes");
            foreach (Vertice i in MiGrafo)
            {
                i.RutasFuertementeaConexas();
                i.ImprimirRutasFuertementeConexas();
            }
            Console.WriteLine("Por lo tanto los puntos fuertemente conexos son C D y E");
            Console.ReadKey();
            Console.Clear();

            PuntoA = new Vertice("A");
            PuntoB = new Vertice("B");
            PuntoC = new Vertice("C");
            PuntoD = new Vertice("D");
            PuntoE = new Vertice("E");
            PuntoF = new Vertice("F");
            Vertice PuntoG = new Vertice("G");
            Vertice PuntoH = new Vertice("H");
            Vertice PuntoI = new Vertice("I");
            PuntoA.AgregarAdyacente(PuntoI);
            PuntoA.AgregarAdyacente(PuntoC);

            PuntoB.AgregarAdyacente(PuntoA);
            PuntoB.AgregarAdyacente(PuntoC);
            PuntoB.AgregarAdyacente(PuntoH);

            PuntoD.AgregarAdyacente(PuntoC);
            PuntoD.AgregarAdyacente(PuntoE);

            PuntoE.AgregarAdyacente(PuntoD);

            PuntoF.AgregarAdyacente(PuntoG);
            PuntoF.AgregarAdyacente(PuntoD);
            PuntoF.AgregarAdyacente(PuntoE);

            PuntoG.AgregarAdyacente(PuntoC);
            PuntoG.AgregarAdyacente(PuntoD);

            PuntoH.AgregarAdyacente(PuntoF);
            PuntoH.AgregarAdyacente(PuntoG);
            PuntoH.AgregarAdyacente(PuntoI);

            PuntoI.AgregarAdyacente(PuntoA);
            PuntoI.AgregarAdyacente(PuntoG);
            MiGrafo = new List<Vertice>();
            MiGrafo.Add(PuntoA);
            MiGrafo.Add(PuntoB);
            MiGrafo.Add(PuntoC);
            MiGrafo.Add(PuntoD);
            MiGrafo.Add(PuntoE);
            MiGrafo.Add(PuntoF);
            MiGrafo.Add(PuntoG);
            MiGrafo.Add(PuntoH);
            MiGrafo.Add(PuntoI);

            Console.WriteLine("Grafo 3");
            foreach (Vertice i in MiGrafo)
            {
                i.ImprimirInfo();
            }
            Console.WriteLine("Las rutas fuertemente conexas son las siguientes");
            foreach (Vertice i in MiGrafo)
            {
                i.RutasFuertementeaConexas();
                i.ImprimirRutasFuertementeConexas();
            }
            Console.WriteLine("Por lo tanto los puntos fuertemente conexos son A I E y D");
            Console.ReadKey();
            Console.Clear();
        }
        public void Ejercicio10()//aqui hacemos nuestro ejercicio 10
        {
            Console.WriteLine("Ejercicio 10");
            Vertice PuntoA = new Vertice("A");
            Vertice PuntoB = new Vertice("B");
            Vertice PuntoC = new Vertice("C");
            Vertice PuntoD = new Vertice("D");
            Vertice PuntoE = new Vertice("E");

            PuntoA.AgregarAdyacente(PuntoB);
            PuntoA.AgregarAdyacente(PuntoD);

            PuntoB.AgregarAdyacente(PuntoA);
            PuntoB.AgregarAdyacente(PuntoE);

            PuntoC.AgregarAdyacente(PuntoB);

            PuntoD.AgregarAdyacente(PuntoA);

            PuntoE.AgregarAdyacente(PuntoD);
            PuntoE.AgregarAdyacente(PuntoC);
            List<Vertice> MiGrafo = new List<Vertice>();
            MiGrafo.Add(PuntoA);
            MiGrafo.Add(PuntoB);
            MiGrafo.Add(PuntoC);
            MiGrafo.Add(PuntoD);
            MiGrafo.Add(PuntoE);
            Console.WriteLine("Representamos el grafo a continuacion");
            foreach (Vertice i in MiGrafo)
            {
                i.ImprimirInfo();//imprimimos la informacion de cada vertice
            }
            Console.WriteLine("Las rutas circulares encontradas en este grafo son");
            foreach (Vertice i in MiGrafo)
            {
                i.RutasFuertementeaConexas();//resulta el metodo usado en el ejercicio 9 nos es muy util para encontrar las rutas circulares asi que lo usamos aqui de nuevo
                i.ImprimirRutasFuertementeConexas();
            }
            Console.WriteLine("Por lo tanto vemos que las ruta A D A D A es circular por la ruta mostrada A D A");//en este ultimo ejercicio podemos escribir nuestros resultados basado en lo que se imprime aqui
            Console.WriteLine("Las rutas A D B E A y  A B E C B D A son imposibles ya que B y D no tienen adyacencia alguna");
            Console.WriteLine("Por ultimo la ruta A B E C D no es circular");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

