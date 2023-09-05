using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

             Console.WriteLine("Elija una Mes del primer semestre: del 1 al 6");
           /* Console.WriteLine("1. Enero");
            Console.WriteLine("2. Febrero");
            Console.WriteLine("3. Marzo");
            Console.WriteLine("4. Abril");
            Console.WriteLine("5. Mayo");
            Console.WriteLine("6. Junio");
             */
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor ingrese un número del 1 al 6.");
                    break;

              Console.ReadKey();
            }
        }
    }
}
