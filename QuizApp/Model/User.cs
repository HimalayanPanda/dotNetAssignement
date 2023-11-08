using System.ComponentModel.DataAnnotations;

namespace QuizApp.Model
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Password { get; set; }

        [Required]
        public string Type { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public DateTime Updated { get; set; } = DateTime.UtcNow;
    }
}
