using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplicationBasic.Models;

namespace WebApplicationBasic.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Bike> Bikes { get; set; }
    }
}