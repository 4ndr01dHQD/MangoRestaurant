using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Mango.Services.ProductAPI.Models.Dto
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        [AllowNull]
        public string Description { get; set; }
        [AllowNull]
        public string CategoryName { get; set; }
        [AllowNull]
        public string ImageUrl { get; set; }

    }
}
