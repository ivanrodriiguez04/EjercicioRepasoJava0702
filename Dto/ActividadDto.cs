using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RepasoJava0702.Dto
{
    /// <summary>
    /// Clase de la informacion de la actividad 
    /// irodhan -> 07/02/2024
    /// </summary>
    internal class ActividadDto
    {
        //Atributos
        long id;
        string nombreActividad = "aaaaa";
        string fechaInicio = "31/12/9999";
        string fechaFin = "31/12/9999";
        double duracionActividad;

        //Constructores
        public ActividadDto()
        {
        }

        public ActividadDto(long id, string nombreActividad, string fechaInicio, string fechaFin, double duracionActividad)
        {
            this.id = id;
            this.nombreActividad = nombreActividad;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.duracionActividad = duracionActividad;
        }

        //Getters & Setters
        public long Id { get => id; set => id = value; }
        public string NombreActividad { get => nombreActividad; set => nombreActividad = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string FechaFin { get => fechaFin; set => fechaFin = value; }
        public double DuracionActividad { get => duracionActividad; set => duracionActividad = value; }

        //ToString
        public string ToString()
        {
            string concatenacion ="Nombre de la actividad: "+this.nombreActividad+"\tDuraciond de la actividad: "+this.duracionActividad;

            return concatenacion;
        }
    }
}
