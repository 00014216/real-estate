using System.ComponentModel.DataAnnotations;

namespace _00014216.Models
{
    public class Property
    {
        [Key]
        public int PropertyID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string PropertyType { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int? SquareFeet { get; set; }
        public DateTime DateListed { get; set; }
    }
}
