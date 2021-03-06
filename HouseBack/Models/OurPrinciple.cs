﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseBack.Models
{
    public class OurPrinciple
    {
        public int Id { get; set; }

        public string BgImgUrl { get; set; }

        [Required]
        public string Content { get; set; }

        [NotMapped]
        public IFormFile BgPhoto { get; set; }
    }
}
