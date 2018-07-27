using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var db = new UniversityDbContext();
            Console.WriteLine("Enter a student name: ");
            // Insert new student
            var name = Console.ReadLine();
            db.Database.ExecuteSqlCommand("INSERT INTO Students (Name) VALUES (@Name)", new SqlParameter("@Name", name));
            // Print all students
            var students = db.Students.FromSql("SELECT * FROM Students").ToList();
            foreach (var student in students)
            {
                Console.WriteLine(String.Format("ID: {0}, Name: {1}", student.ID, student.Name));
            }
        }
    }
}
