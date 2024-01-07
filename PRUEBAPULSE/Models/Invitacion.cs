using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRUEBAPULSE.Models
{
    public class Invitacion
    {
        public int Id { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Asistencia { get; set; }
    }
}