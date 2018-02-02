using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Inscripcion.Entity
{
    public class Estudiantes
    {
        [Key]//Es obligatorio indicar cual es la clave primaria de la entidad
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaActual { get; set; }
        public Estudiantes()
        {
            
            this.Nombre = string.Empty;
            this.Monto = 0;
            this.Observaciones = string.Empty;
            this.FechaActual = DateTime.Now;
           
        }

        public Estudiantes(int EstudianteId, string nombres, string observaciones, decimal monto)
        {
            this.EstudianteId = EstudianteId;
            this.Nombre = nombres;
            this.Observaciones = observaciones;
            this.Monto = monto;
            FechaActual =  DateTime.Now;
        }
    }
}
