
using System;
using System.ComponentModel.DataAnnotations;
namespace LoginServer.Model
{
    

    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password_Hash { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } // 新增全名

        [MaxLength(200)] // 地址可以不是必填项
        public string Address { get; set; } // 新增地址

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
