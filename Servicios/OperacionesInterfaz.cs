using RepasoJava0702.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoJava0702.Servicios
{
    /// <summary>
    /// Interfaz de las operaciones de la aplicacion
    /// irodhan -> 07/02/2024
    /// </summary>
    internal interface OperacionesInterfaz
    {
        /// <summary>
        /// Metodo que da el alta para una nueva actividad
        /// irohan -> 07/02/2024
        /// </summary>
        /// <param name="listaActividadAntigua"></param>
        public void altaActividad(List<ActividadDto> listaActividadAntigua);

        /// <summary>
        /// Metodo que elimina la actividad deseada
        /// irodhan -> 07/02/2024
        /// </summary>
        /// <param name="listaActividadAntigua"></param>
        public void eliminarActividad(List<ActividadDto> listaActividadAntigua);
    }
}
