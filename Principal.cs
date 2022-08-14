using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Ejemplo_Consola
{
    class Principal
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Programa Principal");
            System.Console.WriteLine("Primer Programa");

            System.Console.ReadKey();

            int repetir;

            do
            {
                menu_Interno();

                System.Console.WriteLine("Ingrese 1 para repetir menù ");
                System.Console.WriteLine("Ingrese 2 para salir");
                repetir = Int32.Parse(Console.ReadLine());

            }while (repetir == 1);
        }
            

        static void menu_Interno()
        {
            string opcion;
            int opcionint;

            System.Console.WriteLine(" Menu Principal");
            System.Console.WriteLine("1. Ejemplo If");
            System.Console.WriteLine("2. Ejemplo Switch");
            System.Console.WriteLine("3. Ejemplo For");
            System.Console.WriteLine("4. Ejemplo wor");
            System.Console.WriteLine("5. Ejemplo Do");

            System.Console.WriteLine("Elige una opcion:");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);


            switch (opcionint)
            {
                case 1:
                    Programa_If();

                    Programa_If();
                    
                    break;

                case 2:
                    Programa_for();
                    break;

                case 3:
                    Programa_Switch();
                    break;

                case 4:
                    Programa_while();
                    break;

                case 5:
                    Programa_dowhile();
                    break;
            }

        }   

        static void Programa_If()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo if ");
        }

        static void Programa_for()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo for ");
        }

        static void Programa_Switch()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo switch ");
        }

        static void Programa_while()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo while ");
        }

        static void Programa_dowhile()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo DoWhile ");
        }

    }
}
