﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseBack.Models
{
    public class OurMission
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public string Content { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
