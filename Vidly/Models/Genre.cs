﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genre
    {
        [Display(Name="Genre")]
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }


    }
}