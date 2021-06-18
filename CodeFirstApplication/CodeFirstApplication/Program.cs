using System;
using System.Data.Entity;

namespace CodeFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Students() { StudentName = "Jessie" };

                context.Students.Add(student);
                context.SaveChanges();
            }


        }
    }
    public class Students
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
    
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Students> Students { get; set; }
    }
}

