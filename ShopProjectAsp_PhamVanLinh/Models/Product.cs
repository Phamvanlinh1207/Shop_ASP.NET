using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShopProjectAsp_PhamVanLinh.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        public string? img { get; set; }
        [DisplayName("Mô tả")]
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Category_id { get; set; }

        //public Category Category { get; set; }

    }
}
