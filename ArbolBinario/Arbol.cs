using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinario
{
    public class Arbol
    {
        Nodo raiz;      
       // int index = 0;
        
        public Arbol()
        {
            this.raiz = null;
           
        }
        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo();
            nuevo.Data = valor;
            
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, recorrido;
                recorrido = raiz;
                while (recorrido != null)
                {
                    anterior = recorrido;
                    if (valor < recorrido.Data)
                        recorrido = recorrido.Left;
                    else
                        recorrido = recorrido.Right;
                }
                if (valor < anterior.Data)
                    anterior.Left = nuevo;
                else
                    anterior.Right = nuevo;
            }
        }
        //Recorrido PreOrden
        private void ImprimirPre(Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(reco.Data + " ");
                ImprimirPre(reco.Left);
                ImprimirPre(reco.Right);
            }
            else
            {
                Console.WriteLine("Listado esta vacio\n\n");
            }
        }

        public void PrintPreOrder()
        {
            Console.WriteLine("Recorrido PreOrder");
            ImprimirPre(raiz);
            Console.WriteLine("\n");
        }
        //Fin Recorrido PreOrden

        //Recorrido InOrder
        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.Left);
                Console.Write(reco.Data + " ");
                ImprimirEntre(reco.Right);
            }
            else
            {
                Console.WriteLine("Listado esta vacio\n\n");
            }
        }
        public void PrintInOrder()
        {
            Console.WriteLine("Recorrido InOrder");
            ImprimirEntre(raiz);
            Console.WriteLine("\n");
        }
        //Fin Recorrido InOrder

        //Recorrido PostOrder
        private void ImprimirPost(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirPost(reco.Left);
                ImprimirPost(reco.Right);
                Console.Write(reco.Data + " ");
            }
            else
            {
                Console.WriteLine("Listado esta vacio\n\n");
            }
        }
        public void PrintPostOrder()
        {
            Console.WriteLine("Recorrido PostOrder");
            ImprimirPost(raiz);
            Console.WriteLine("\n");
        }
        //Fin recorrido PostOrder
    }
}
