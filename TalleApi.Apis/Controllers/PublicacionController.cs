using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalleApi.Apis.Models;

namespace TalleApi.Apis.Controllers
{
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (var context = new MiPublicacionContext())
            {

                return context.Publicaciones.ToList();
            }
        }

        [HttpGet]
        public Publicacion Get(int id)
        {
            using (var context = new MiPublicacionContext())
            {

                return context.Publicaciones.FirstOrDefault(x => x.Id == id);
            }
        }

        [HttpPost]
        public Publicacion Post(Publicacion publicacion)
        {
            using (var context = new MiPublicacionContext())
            {
                context.Publicaciones.Add(publicacion);
                context.SaveChanges();
                return publicacion;
            }
        }

        [HttpPut]
        public Publicacion Put(Publicacion publicacion)
        {
            using (var context = new MiPublicacionContext())
            {
                var publicacionAct = context.Publicaciones.FirstOrDefault(x => x.Id == publicacion.Id);
                publicacionAct.Usuario = publicacion.Usuario;
                publicacionAct.Descripcion = publicacion.Descripcion;
                publicacionAct.FechaPubliacion = publicacion.FechaPubliacion;
                publicacionAct.MeGusta = publicacion.MeGusta;
                publicacionAct.MeDisgusta = publicacion.MeDisgusta;
                publicacionAct.VecesCompartido = publicacion.VecesCompartido;
                publicacionAct.EsPrivado = publicacion.EsPrivado;
                context.SaveChanges();
                return publicacion;
            }
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new MiPublicacionContext())
            {
                var publicacionDel = context.Publicaciones.FirstOrDefault(x => x.Id == id);
                context.Publicaciones.Remove(publicacionDel);
                context.SaveChanges();
                return true;
            }
        }
    }
}
