using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using WebApplicationBasic.Models;

namespace WebApplicationBasic.Dtos
{
    public class BikeDto
    {       
        public string Brand { get; set; }

        public ICollection<ModelDto> Models {get; set; }
        
        public BikeDto() 
        {
            Models = new Collection<ModelDto>();
        }
    }
}