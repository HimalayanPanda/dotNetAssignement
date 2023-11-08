using System.Diagnostics;
using QuizApp.Model;

namespace QuizApp.Data
{
    // This class interacts with the database and creates all the functions
    // the front-end will need
    public class Database
    {
        private AppDbContext _context;
        public Database(AppDbContext context) {
            this._context = context;
            var students = context.Students.ToList();
            Debug.WriteLine(students.ToString());
        }

        public string checkCredentials(string email, string password)
        {
            // For Admins
            var user = from admin in _context.Admins
                       where admin.Email == email && admin.Password == password
                       select admin;
            if (user.Count() == 1)
            {
                return "Admin";
            }

            // For Teachers
            var teach = from teacher in _context.Teachers
                        where teacher.Email == email && teacher.Password == password
                        select teacher;
            if (teach.Count() == 1)
            {
                return "Teacher";
            }

            // For Student
            var stu = from student in _context.Students
                      where student.Email == email && student.Password == password
                      select student;
            if (stu.Count() == 1)
            {
                return "Student";
            }
            // If no users exist return null
            return null;
        }

        // Returns true if email already exists in the database
        public bool emailExistsAlready(string email)
        {
            // For Admins
            var user = from admin in _context.Admins
                       where admin.Email == email
                       select admin;
            if (user.Count() == 1)
            {
                return true;
            }

            // For Teachers
            var teach = from teacher in _context.Teachers
                        where teacher.Email == email
                        select teacher;
            if (teach.Count() == 1)
            {
                return true;
            }

            // For Student
            var stu = from student in _context.Students
                      where student.Email == email
                      select student;
            if (stu.Count() == 1)
            {
                return true;
            }

            return false;
        }

        // Adds a Student to the database
        public int addStudent(string email, string password)
        {
            _context.Students.Add(new Student { Email = email, Password = password });
            _context.SaveChanges();
            var user = from student in _context.Students
                       where student.Email == email
                       select student;

            return user.ElementAt(0).ID;
        }

        public int addTeacher(string email, string password, int subjectID)
        {
            _context.Teachers.Add(new Teacher { Email = email, Password = password, SubjectID = subjectID });
            _context.SaveChanges();
            var user = from teacher in _context.Teachers
                       where teacher.Email == email
                       select teacher;

            return user.ElementAt(0).ID;
        }

        // addQuiz (create a new quiz with no questions)
        public int addQuiz(string title, string desc, int subjectID)
        {
            _context.Quizzes.Add(new Quiz { Title = title, Description = desc, SubjectID = subjectID });
            _context.SaveChanges();
            var e = from quiz in _context.Quizzes
                    where quiz.Title == title
                    select quiz;

            return e.ElementAt(0).ID;
        }

        public void addQuestionToQuiz(int quizID, string qt, string a1, string a2, string a3, string a4, string correctA)
        {
            _context.Questions.Add(new Question { QuestionText = qt, AnswerA = a1, AnswerB = a2, AnswerC = a3, AnswerD = a4, CorrectAnswer = correctA });
            var qID = from question in _context.Questions
                      where question.QuestionText == qt
                      select question.Id;

            _context.QuestionAllocations.Add(new QuestionAllocation { QuestionID = qID.ElementAt(0), QuizID = quizID });
            _context.SaveChanges();
        }

        // enrolStudent
        public void enrolStudent(int studentID, int subjectID)
        {
            _context.Enrolments.Add(new Enrolment { StudentID = studentID, SubjectID = subjectID });
            _context.SaveChanges();
        }

        // getQuestionsByQuiz
        public List<Question> getQuestionsByQuiz(int quizID)
        {
            var questions = new List<Question>();
            var allocations = from allocation in _context.QuestionAllocations
                              where allocation.QuizID == quizID
                              select allocation;
            foreach (QuestionAllocation alloc in allocations)
            {
                questions.Add(alloc.Question);
            }
            return questions;
        }

        // addSubject
        public int addSubject(string name, string desc)
        {
            _context.Subjects.Add(new Subject { Name = name, Description = desc });
            _context.SaveChanges();
            var e = from subject in _context.Subjects
                    where subject.Name == name
                    select subject;

            return e.ElementAt(0).ID;
        }

        // getResults -> [{QuizName: Marks received}]
        public Dictionary<string, double> getResults(int studentID)
        {
            var results = new Dictionary<string, double>();
            var sessions = from session in _context.QuizSessions
                    where session.StudentID == studentID
                    select session;

            foreach (var session in sessions)
            {
                results.Add(session.Quiz.Title, session.Marks);
            }
            return results;
        }

        // availableQuizzesForStudents --> not taken
        public List<Quiz> availableQuizzes(int studentID)
        {
            var quizzes = new List<Quiz>();

            var subjects = from enrol in _context.Enrolments
                           where enrol.StudentID == studentID
                           select enrol.Subject;
            
            foreach (var subject in subjects)
            {
                var e = from quiz in _context.Quizzes
                        where quiz.Subject == subject
                        select quiz;
                foreach (Quiz q in e)
                {
                    quizzes.Add(q);
                }
            }

            var finishedQuizzes = from session in _context.QuizSessions
                           where session.StudentID == studentID
                           select session.Quiz;

            foreach(Quiz q in finishedQuizzes)
            {
                quizzes.Remove(q);
            }
            return quizzes;
        }

        // Functions for validation
        // --> questionTitleExists for the same quiz
        public bool questionExists(string text, int quizID)
        {
            var q = from question in _context.Questions
                    where question.QuestionText == text
                    select question;

            foreach(Question quest in q)
            {
                var allocs = from a in _context.QuestionAllocations
                               where a.QuizID == quizID && a.Question == quest
                               select a;
                
                if (allocs.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        // --> quizTitleExists
        public bool quizExists(string title)
        {
            var q = from quiz in _context.Quizzes
                    where quiz.Title == title
                    select quiz;

            if (q.Count() > 0)
            {
                return true;
            }
            return false;
        }

        // --> subjectNameExists
        public bool subjectExists(string name)
        {
            var s = from subject in _context.Subjects
                    where subject.Name == name
                    select subject;

            if (s.Count() > 0)
            {
                return true;
            }
            return false;
        }

        // Functions for getting id
        // --> questionIdByTitle
        public int questionIdByText(string text)
        {
            var q = _context.Questions.First(q => q.QuestionText == text);
            return q.Id;
        }

        // --> quizIdByTitle
        public int quizIdByTitle(string title)
        {
            var q = _context.Quizzes.First(q => q.Title == title);
            return q.ID;
        }

        // --> subjectIdByName
        public int subjectIdByName(string name)
        {
            var s = _context.Subjects.First(sub => sub.Name == name);
            return s.ID;
        }

        public int startQuiz(int quizID, int studentID)
        {
            _context.QuizSessions.Add(new QuizSession { QuizID = quizID, StudentID = studentID, IsFinished = false });
            _context.SaveChanges();
            var id = from s in _context.QuizSessions
                     where s.QuizID == quizID && s.StudentID == studentID
                     select s.ID;
            return id.First();
        }

        public void finishQuiz(int quizSessionID, double marks)
        {
            var result = _context.QuizSessions.SingleOrDefault(s => s.ID == quizSessionID);
            if (result != null)
            {
                result.Marks = marks;
                result.IsFinished = true;
                _context.SaveChanges();
            }
        }
    }
}
