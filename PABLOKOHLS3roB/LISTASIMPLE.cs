using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PABLOKOHLS3roB
{
    class LISTASIMPLE
    {
        // LISTA SIMPLEMENTE ENLAZADA DE DATOS ENTEROS

        int dat = 0;
        private PABLOKOHLS3roB.NODO Primero;
        private int size;
        public LISTASIMPLE()
        {
            this.Primero = null;
            this.size = 0;
        }
        public void Vacia()
        {
            if (Primero == null)
            {
                Console.WriteLine("LISTA VACIA");
            }
            else
            {
                Console.WriteLine("LISTA CON DATOS");
            }
        }
        public void InsertarDato(int dato)
        {
            PABLOKOHLS3roB.NODO Nuevo = new NODO(dato);
            Nuevo.siguiente = Primero;
            Primero = Nuevo;
            size++;
        }
        public int Size()
        {
            return size;
        }
        public void Visualizar()
        {
            Nodo actual = Primero;
            while (actual != null)
            {
                Console.WriteLine("[" + actual.dato + "]");
                actual = actual.siguiente;
            }
        }
        static void Main(string[] args)
        {
            LISTASIMPLE Lista = new LISTASIMPLE();
            Lista.Vacia();
            Lista.InsertarDato(2);
            Lista.InsertarDato(4);
            Lista.InsertarDato(6);
            Lista.InsertarDato(8);
            Lista.InsertarDato(10);
            Lista.Visualizar();
            Console.WriteLine("TAMAÑO DE LA LISTA: " + Lista.Size());
            Lista.Vacia();
            Console.ReadKey();
        }
    }
}