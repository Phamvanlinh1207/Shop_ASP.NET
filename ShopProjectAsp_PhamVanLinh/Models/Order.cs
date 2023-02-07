using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ShopProjectAsp_PhamVanLinh.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public int User_id { get; set; }
    }
}
