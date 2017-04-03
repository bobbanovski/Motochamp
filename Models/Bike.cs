using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WebApplicationBasic.Models
{    
    public class Bike
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Year { get; set; }

        public string Registration {get;set;}

        public ICollection<Model> Models {get; set; }
        
        public Bike() 
        {
            Models = new Collection<Model>();
        }
    }
}