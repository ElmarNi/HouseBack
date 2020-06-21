using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseBack.Models
{
    public class HomeBanner
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

    }
}
