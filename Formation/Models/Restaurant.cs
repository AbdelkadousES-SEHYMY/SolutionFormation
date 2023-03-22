using System.ComponentModel.DataAnnotations;

namespace Formation.Models
{
    public class Restaurant
    {
        public string Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
