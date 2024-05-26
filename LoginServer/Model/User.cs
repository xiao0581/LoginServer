
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
        public string FullName { get; set; } 

        [MaxLength(200)] 
        public string Address { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
