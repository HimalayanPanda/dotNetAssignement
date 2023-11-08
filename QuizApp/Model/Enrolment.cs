using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Model
{
    [Table("Enrolments")]
    public class Enrolment
    {
        [Key]
        public int ID { get; set; }

        public Subject Subject { get; set; }

        [ForeignKey("Subject")]
        [Required]
        public int SubjectID { get; set; }

        public Student Student { get; set; }

        [ForeignKey("Student")]
        [Required]
        public int StudentID { get; set; }
    }
}
