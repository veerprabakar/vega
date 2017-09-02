using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models.Vehicle
{
    [Table("Vehicles")]
    public class Vehicle
    {
        public Vehicle()
        {
            Features = new Collection<Feature>();
        }
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }

        public bool IsRegistered { get; set; }

        public Contact Contact { get; set; }

        public ICollection<Feature> Features { get; set; }
    }
}