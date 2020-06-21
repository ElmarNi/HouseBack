using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseBack.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required, StringLength(200), MinLength(2)]
        public string Name { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
