using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3.AcevedoEnsisoPedroGabriel
{
    class Vertice//clase vertice que contiene los vertices de cada arista
    {
        public string Letra { get; set; }//cada vertice tiene su letra
        public Vertice(string letra)
        {
            Letra = letra;
        }
    }
}
