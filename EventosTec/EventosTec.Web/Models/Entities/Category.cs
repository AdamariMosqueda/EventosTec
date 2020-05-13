using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EventosTec.Web.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre Categoría")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }
}
