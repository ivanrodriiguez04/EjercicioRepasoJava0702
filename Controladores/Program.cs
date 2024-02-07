using RepasoJava0702.Dto;
using RepasoJava0702.Servicios;

namespace RepasoJava0702.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 07/02/2024
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 07/02/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creamos la lista donde guardaremos la informacion de la actividad
            List<ActividadDto> listaActividad= new List<ActividadDto>();
            //Creamos los objetos
            MenuInterfaz mI = new MenuImplementacion();

            //Creamos los atributos necesarios
            int opcionSeleccionada = 0;
            bool cerrarMenu=false;

            while(!cerrarMenu) 
            { 
                opcionSeleccionada=mI.mostrarMenuYSeleccion();
                switch(opcionSeleccionada) 
                { 
                    case 0:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion cerrar app");
                        cerrarMenu=true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion dar de alta a una actividad");
                        
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion eliminar una actividad");
                        
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                        break;

                }
            }

        }
    }
}