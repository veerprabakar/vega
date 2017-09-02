using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega.Controllers.Resources
{
    public class FeatureResources
    {
        public FeatureResources()
        {
            Features = new Collection<FeatureResources>();
        }      
       
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<FeatureResources> Features { get; set; }  
    }
}