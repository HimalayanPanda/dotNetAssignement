using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Model
{
    [Table("QuestionAllocations")]
    public class QuestionAllocation
    {
        [Key]
        public int ID { get; set; }

        public Quiz Quiz { get; set; }

        [ForeignKey("Quiz")]
        [Required]
        public int QuizID { get; set; }

        public Question Question { get; set; }

        [ForeignKey("Question")]
        [Required]
        public int QuestionID { get; set; }



    }
}
