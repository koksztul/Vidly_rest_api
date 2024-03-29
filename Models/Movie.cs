﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {  
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
    }
}