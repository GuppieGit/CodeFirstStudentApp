using System;
using StudentApp.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ensure that the database is created
            using (var context = new StudentContext())
            {
                context.Database.EnsureCreated();  // Create the database if it doesn't exist

                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 20
                };

                // Add the student to the Students DbSet
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added to the database!");

                // Retrieve and display the student from the database
                var addedStudent = context.Students.Find(student.Id);
                Console.WriteLine($"Student: {addedStudent.FirstName} {addedStudent.LastName}, Age: {addedStudent.Age}");
            }
        }
    }
}
