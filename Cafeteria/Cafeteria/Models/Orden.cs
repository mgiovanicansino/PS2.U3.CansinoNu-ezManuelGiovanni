using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cafeteria.Models
{
    public class Orden
    {
        [Key]
        public int IdOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Estatus { get; set; }

        public int IdProduct { get; set; }
        [ForeignKey("IdProduct")]
        public Product product { get; set; }
        
    }
}