using System;
using System.ComponentModel.DataAnnotations;

namespace vega.Models.Vehicle
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public int Name { get; set; }

        [StringLength(15)]
        public int Phone { get; set; }

        [StringLength(50)]
        public int Email { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}