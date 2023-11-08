using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Model
{
    [Table("Teachers")]
    public class Teacher : User
    {
        public string Type { get; } = "teacher";

        public Subject Subject { get; set; }

        [ForeignKey("Subject")]
        [Required]
        public int SubjectID { get; set; }
    }
}
