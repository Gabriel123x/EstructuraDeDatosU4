using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3.AcevedoEnsisoPedroGabriel
{
    class Arista//clase de aristas
    {
        public Vertice Vertice1, Vertice2;//cada arista tiene dos vertices
        public Arista(string letra1, string letra2)
        {
            Vertice1 = new Vertice(letra1);
            Vertice2 = new Vertice(letra2);
        }
    }
}
