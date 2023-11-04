using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Model
{
    [Table("Quizzes")]
    public class Quiz
    {
        [Key]
        public int ID { get; set; }

        public Subject Subject { get; set; }

        [ForeignKey("Subject")]
        [Required]
        public int SubjectID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
