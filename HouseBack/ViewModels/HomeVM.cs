using HouseBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseBack.ViewModels
{
    public class HomeVM
    {
        public HomeBanner HomeBanner { get; set; }
        public WhatWeDoHomePage WhatWeDoHome { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Award> Awards { get; set; }
    }
}
