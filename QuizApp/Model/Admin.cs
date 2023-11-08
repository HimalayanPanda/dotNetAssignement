using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApp.Model
{

    [Table("Admins")]
    public class Admin : User
    {
        public string Type { get; } = "admin";
    }
}
