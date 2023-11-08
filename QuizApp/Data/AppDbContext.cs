using Microsoft.EntityFrameworkCore;
using QuizApp.Model;

namespace QuizApp.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        private const string connection = @"database=QuizDB; Data Source=LAPTOP-AOJL4TJP;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Subject> Subjects {  get; set; }
        public DbSet<QuestionAllocation> QuestionAllocations { get; set; }
        public DbSet<QuizSession> QuizSessions { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
    }
}
