using System.Collections.Generic;
using WebApplicationBasic.Models;

namespace WebApplicationBasic.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Bike> Bikes { get; set; }
    }
}