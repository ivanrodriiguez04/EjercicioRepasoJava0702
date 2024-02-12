using RepasoJava0702.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoJava0702.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de la aplicacion
    /// irodhan -> 07/02/2024
    /// </summary>/
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        public void altaActividad(List<ActividadDto> listaActividadAntigua)
        {
            ActividadDto nuevaActividad = crearActividad();
            listaActividadAntigua.Add(nuevaActividad);
        }

        private ActividadDto crearActividad() 
        { 
            ActividadDto actividad = new ActividadDto();
            Console.WriteLine("Introduzca el id de la actividad:");
            actividad.Id=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre de la actividad:");
            actividad.NombreActividad = Console.ReadLine();
            Console.WriteLine("Introduzca la fecha de inicio de la actividad: (DD/MM/YYYY hh:mm:ss)");
            actividad.FechaInicio = Console.ReadLine();
            DateTime fcIni = Convert.ToDateTime(actividad.FechaInicio);
            DateTime fcFIn = DateTime.Now;
            fcFIn.ToString("yy - MM - ddThh:mm:ss");
            actividad.FechaFin = fcFIn.ToString();
            TimeSpan diferencia=fcFIn-fcIni;
            actividad.DuracionActividad = diferencia.TotalMinutes;
            return actividad;
        }

        public void eliminarActividad(List<ActividadDto> listaActividadAntigua)
        {
            ActividadDto actividad2=new ActividadDto();
            foreach (ActividadDto act in listaActividadAntigua) 
            {
                Console.WriteLine(act.ToString());
            }
            Console.WriteLine("Introduzca el nombre de la actividad a borrar:");
            string actividadBorrar = Console.ReadLine();

            foreach (ActividadDto actividad in listaActividadAntigua) 
            {
                if (actividad.NombreActividad.Equals(actividadBorrar))
                {
                    Console.WriteLine("[INFO] -  La actividad ha sido encontrada");
                    actividad2 = actividad;
                    break;
                }
                else
                {
                    Console.WriteLine("[INFO] - La actividad no ha sido encontrada");
                }
            }
            listaActividadAntigua.Remove(actividad2);
        }
    }
}
