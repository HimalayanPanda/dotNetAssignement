using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Model
{
    [Table("QuizSessions")]
    public class QuizSession
    {
        [Key]
        public int ID { get; set; }

        public Quiz Quiz { get; set; }

        [ForeignKey("Quiz")]
        [Required]
        public int QuizID { get; set; }

        public Student Student { get; set; }

        [ForeignKey("Student")]
        [Required]
        public int StudentID { get; set; }
    }
}