using System.ComponentModel.DataAnnotations;

namespace WebAPIsBeginners.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string Address1 { get; set; }
        
        public string? Address2 { get; set; }

        [Required]
        public string City { get; set; }
        
        public string? ZipCode { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
