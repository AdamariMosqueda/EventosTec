using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventosTec.Web.Models.Entities
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Fecha del evento")]
        public DateTime? EventDate { get; set; }

        [Display(Name = "Descripción")]
        public  string Description { get; set; }

        [Display(Name = "Foto")]
        public byte [] Picture { get; set; }

        [Display(Name = "Asistentes")]
        public int People { get; set; }

        [Display(Name ="Duración")]
        public int Duration { get; set; }

        [Required]
        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
