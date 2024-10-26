using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomiShop.Domain.Models
{
    public class producto
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set;}
        public string description { get; set;}
        public string cantidad { get; set;}
        public int precio { get; set;}

    }
}