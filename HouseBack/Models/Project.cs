using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseBack.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        [Required, StringLength(200)]
        public string ShortTitle { get; set; }

        [Required, StringLength(500)]
        public string MainTitle { get; set; }

        [Required, Range(30, double.PositiveInfinity)]
        public int TotalArea { get; set; }

        [Required, Range(1, double.PositiveInfinity)]
        public int Floors { get; set; }

        [Required, Range(1, double.PositiveInfinity)]
        public int LivingRooms { get; set; }

        [Required, Range(1, double.PositiveInfinity)]
        public int ConstructionPeriod { get; set; }

        [Required]
        public int Year { get; set; }

        public DateTime AddedDate { get; set; }
        public string MainImageUrl { get; set; }
        public string PlanImgUrl { get; set; }

        [NotMapped]
        public IFormFile MainImagePhoto { get; set; }

        [NotMapped]
        public IFormFile PlanImagePhoto { get; set; }

        public virtual ICollection<ProjectDetailImage> ProjectDetailImages { get; set; }
    }
}
