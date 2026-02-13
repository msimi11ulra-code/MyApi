using System.ComponentModel.DataAnnotations;

namespace MyApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(0, 1000000)]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public string? Category { get; set; }
    }
}