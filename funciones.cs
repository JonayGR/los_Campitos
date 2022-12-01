using System;

namespace EJE0601_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Maquina maquina = new Maquina();
            maquina.CrearProductos();

            ConsoleKeyInfo option = ShowMenu();
            while (option.KeyChar != '4')
            {
                switch (option.KeyChar)
                {
                    case '1': maquina.ExtraerProducto(); break;
                    case '2': maquina.RellenarMaquina(); break;
                    case '3': maquina.ListarMaquina(); break;
                }
                option = ShowMenu();
            }
            Bye();
        }

        public static ConsoleKeyInfo ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-         Gestión de productos          -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- Elige entre siguientes opciones       -");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- 1. Extraer producto                   -");
            Console.WriteLine("- 2. Rellenar la maquina                -");
            Console.WriteLine("- 3. Listar maquina                     -");
            Console.WriteLine("- 4. Salir                              -");
            Console.WriteLine("-----------------------------------------");

            ConsoleKeyInfo option = Console.ReadKey(true);
            return option;
        }
        public static void Bye()
        {
            Console.Clear();
            Console.Write("Pulsa una tecla para finalizar ....");
            Console.ReadKey();
        }
    }
}