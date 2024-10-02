using System.ComponentModel.DataAnnotations;

namespace auth.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? UserName { get; set; }
        [Required]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [EmailAddress]
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
