using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Model
{
    [Table("Teachers")]
    public class Teacher : User
    {
        public string Type { get; } = "teacher";
    }
}
