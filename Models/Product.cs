using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMVCAppV2.Models
{
    public class Product
    {
        [Key] // Primary Key ဖြစ်ကြောင်း သတ်မှတ်တာပါ
        [Column(TypeName = "char(36)")] // SQL Database ထဲမှာ char(36) ဖြစ်သွားစေမယ့်နေရာ
        public string ProductId { get; set; } = string.Empty;

        [Required]
        public string Code { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, 1000000000)]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string? Specification { get; set; } = "Premium Edition";
    }
}
