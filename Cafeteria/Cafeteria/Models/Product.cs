using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cafeteria.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        [Display(Name="Producto")]
        public string NombreP { get; set; }
        public string Descripcion { get; set; }
        [Display(Name ="Veces Ordenado")]
        public int VecesOrdenado { get; set; }

    }
}