using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TAD_piLA
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Desarrollar el TAD PILA en una estructura orientada a objetos.

            
                Stack Pila = new Stack();

                int boton;
                do
                {
                    Console.WriteLine("BIENVENIDO AL MENU DE SU PILA\n");
                    Console.WriteLine("1.- Agregar Elemento A la Pila");
                    Console.WriteLine("2- ELiminar Elementos de la Pila");
                    Console.WriteLine("3. Cima");
                    Console.WriteLine("4.-salir");

                    Console.WriteLine("ELIJA OPCCION \n");
                    boton = Convert.ToInt32(Console.ReadLine());

                    switch (boton)
                    {
                        case 1:
                            Apilar(ref Pila);

                            break;

                        case 2:
                            Desapilar(ref Pila);


                            break;
                        case 3:
                            Cima(ref Pila);
                            break;
                        case 4: break;

                    }
                } while (boton != 4);
                Console.ReadKey();

            }
            public static void Apilar(ref Stack pila)
            {
                Console.WriteLine("INGRESE ELEMENTO A LA PILA "); int num = Convert.ToInt32(Console.ReadLine());
                pila.Push(num);

            }
            public static void Desapilar(ref Stack pila)
            {
                int num1 = Convert.ToInt32(Console.ReadLine());

                pila.Clear();
                Console.WriteLine("Pila vaciada");
            }
            public static void Cima(ref Stack pila)
            {

                int num = 0;


                Console.WriteLine("EL Ultimo valor de la pila es ");
                Console.WriteLine(num = (int)pila.Pop());

            }
        }
    }

    

