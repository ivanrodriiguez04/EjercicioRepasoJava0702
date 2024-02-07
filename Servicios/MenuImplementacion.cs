using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoJava0702.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz del menu
    /// irodhan -> 07/02/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|                Menú               |");
            Console.WriteLine("|___________________________________|");
            Console.WriteLine("| 0. Cerrar menu                    |");
            Console.WriteLine("| 1. Dar alta a una actividad       |");
            Console.WriteLine("| 2. Eliminar una actividad         |");
            Console.WriteLine("|___________________________________|");
            Console.WriteLine("\nIntroduzca la opcion deseada;");
            opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;

        }
    }
}
