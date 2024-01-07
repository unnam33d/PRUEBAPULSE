using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PRUEBAPULSE.Models
{
    public class Data : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Invitacion> Invitaciones { get; set; }
    }
}