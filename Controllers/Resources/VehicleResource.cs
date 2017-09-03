using System.Collections.Generic;
using System.Collections.ObjectModel;
using vega.Models;
using vega.Models.Vehicle;

namespace vega.Controllers.Resources
{
    public class VehicleResource
    {
        public VehicleResource()
        {
            Features = new Collection<string>();
            Contact = new ContactResource();
        }
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int MakeId { get; set; }
               
        public bool IsRegistered { get; set; }

        public ContactResource Contact { get; set; }

        public ICollection<string> Features { get; set; }
    }
}