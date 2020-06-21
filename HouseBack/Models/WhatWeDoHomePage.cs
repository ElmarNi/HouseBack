using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseBack.Models
{
    public class WhatWeDoHomePage
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Header { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }


        [StringLength(200)]
        public string ImageUrl { get; set; }
    }
}
