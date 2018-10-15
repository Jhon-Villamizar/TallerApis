using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TalleApi.Apis.Models
{
    [Table("Publicacion")]
    public class Publicacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaPubliacion { get; set; }

        [Required]
        public int MeGusta { get; set; }

        public int MeDisgusta { get; set; }

        public int VecesCompartido { get; set; }

        [Required]
        public bool EsPrivado { get; set; }
    }
}