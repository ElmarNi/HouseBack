﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseBack.Models
{
    public class WhatWeDo
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Header { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
