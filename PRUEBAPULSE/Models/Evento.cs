using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRUEBAPULSE.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}