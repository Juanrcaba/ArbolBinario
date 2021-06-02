using System;
using System.Linq;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
          

            arbol.Insertar(6);
            arbol.Insertar(2);
            arbol.Insertar(0);
            arbol.Insertar(1);
            arbol.Insertar(3);
            arbol.Insertar(10);
            arbol.Insertar(32);
            arbol.Insertar(14);
            arbol.Insertar(35);

            Console.WriteLine("Datos Insertados: 6,2,0,1,3,10,32,14,35 \n\n");

            arbol.PrintPreOrder();
            arbol.PrintInOrder();
            arbol.PrintPostOrder();
           
        }
    }
}
