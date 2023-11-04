using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Model
{
    [Table("Students")]
    public class Student : User
    {
        public string Type { get; } = "student";
    }
}
