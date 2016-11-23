using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CineplexService.Models
{
    public class Movie30022962
    {
        [Key]
        public int MovieId { get; set; } 
        public string Name { get; set; } 
        public string Duration { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
