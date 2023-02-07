using ShopProjectAsp_PhamVanLinh.Data;
using System.ComponentModel;
using System.Drawing;

namespace ShopProjectAsp_PhamVanLinh.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            GetCategory();
        }
        public ProductViewModel(int id, string name, string Img, string description, int price, int quantity, int category_id)
        {
            Id = id;
            Name = name;
            img = Img;
            Description = description;
            Price = price;
            Quantity = quantity;
            Category_id = category_id;
            GetCategory();
        }
        public int Id { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        public string? img { get; set; }
        [DisplayName("Mô tả")]
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Category_id { get; set; }
        [DisplayName("Tên danh mục")]
        public string CategoryName { get; set; }
        public void GetCategory()
        {
            if (Category_id > 0)
            {
                //using (Context db = new Context())
                //{
                //    this.CategoryName = db.categories.Find(this.Category_id) != null ?
                //        db.categories.Find(this.Category_id).Name : string.Empty;
                //}
            }
        }
    }
}
