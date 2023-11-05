using Microsoft.EntityFrameworkCore;
using QuizApp.Model;

namespace QuizApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Subject> Subjects {  get; set; }
        public DbSet<QuestionAllocation> QuestionAllocations { get; set; }
        public DbSet<QuizSession> QuizSessions { get; set; }
    }
}
