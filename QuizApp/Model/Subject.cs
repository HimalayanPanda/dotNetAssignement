using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace QuizApp.Model
{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public ICollection<Enrolment> Allocations { get; set; } = new List<Enrolment>();

    }
}
