using System.ComponentModel.DataAnnotations;

namespace ShopProjectAsp_PhamVanLinh.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int Product_id { get; set; }
        public int Order_id { get; set; }
        public int Quantity { get; set; }

    }
}
