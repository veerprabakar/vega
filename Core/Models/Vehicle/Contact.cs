using System;
using System.ComponentModel.DataAnnotations;

namespace vega.Models.Vehicle
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}