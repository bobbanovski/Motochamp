using System.ComponentModel.DataAnnotations;

namespace WebApplicationBasic.Models
{
    public class Model
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name {get; set; }

        public Bike Bike {get; set; }

        public int BikeId {get; set; }
    }
}