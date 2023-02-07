using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopProjectAsp_PhamVanLinh.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, DisplayName("Tên danh mục")]
        public string Name { get; set; }
        [Required, DisplayName("Mô tả")]
        public string Description { get; set; }
        //public ICollection<Product> Products { get; set; }

    }
}
