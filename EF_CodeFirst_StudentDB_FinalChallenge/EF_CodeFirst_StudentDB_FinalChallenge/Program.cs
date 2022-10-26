using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EF_CodeFirst_StudentDB_FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Final Challenge\nConsole Application of Student database\n" +
                "Using: Entity Framework 6 - Code First approach");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Software Developer: Mirwais Sarwary");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n");

            // 2. Add a student using context class
            using (var ctx = new SchoolContext())
            {
                // initializing student
                var stud = new Student()
                {
                    StudentName = "Mirwais",
                    StudentID = 001,
                    DateOfBirth= new DateTime(1977,3,8),
                    Height=5.8m,
                    Weight= 180               
                };
                // Adding Student into the database
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }

            // Keep the console Open
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        // 1. Create required Classes
        //Initial domain classes- Creating Student Class
        public class Student
        {
            // Properties
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public byte[] Photo { get; set; }
            public decimal Height { get; set; }
            public float Weight { get; set; }
            // One-to-many relationship with class Grade
            public Grade Grade { get; set; }

        }
        // Initial domain classes- Creating Grade Class
        public class Grade
        {
            // Properties
            public int GradeId { get; set; }
            public string GradeName { get; set; }
            public string Section { get; set; }
            // One-to-many relationship with class Student
            public ICollection<Student> Students { get; set; }
        }
        // Code-first requires a context class (derived from DbContext class)
        // creates the database based on the parameter passed in the base constructor of your context class.
        public class SchoolContext: DbContext
        {
            // If parameter is not passed in the constructor of our context class, it automatically creates
            // required database in the local SQLEXPRESS database
            public SchoolContext(): base()
            {
            }
            // Using DbContext DbSet properties for our classes (part of our model)
            // Note: DbSet is a collection of entity classes
            public DbSet<Student> Students { get; set; }
            public DbSet<Grade> Grades { get; set; }
        }

    }
}
