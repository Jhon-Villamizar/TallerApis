using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TalleApi.Apis.Models
{
    public class MiPublicacionContext : DbContext
    {
        public MiPublicacionContext() : base("MiPublicacionConnection")
        {

        }

        public DbSet<Publicacion> Publicaciones { get; set; }
    }
}