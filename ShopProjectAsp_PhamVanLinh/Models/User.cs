using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopProjectAsp_PhamVanLinh.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, DisplayName("Tên Người dùng")]
        public string Name { get; set; }
        [Required, DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required, DisplayName("Password")]
        public string Password { get; set; }
        public string? Address { get; set; }
        public string? Role { get; set; }
    }
}
