using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string NationalId { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Sample student data
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "mohamed", NationalId = "123456789", Age = 15, Grade = "10" },
            new Student { StudentId = 2, Name = "amr", NationalId = "987654321", Age = 16, Grade = "11" }
        };

        Console.WriteLine("Enter Name or National ID to search for a student:");
        string searchInput = Console.ReadLine();

        // Search logic
        var results = students.Where(s =>
            s.Name.Equals(searchInput, StringComparison.OrdinalIgnoreCase) ||
            s.NationalId.Equals(searchInput, StringComparison.OrdinalIgnoreCase)).ToList();

        if (results.Any())
        {
            Console.WriteLine("Search Results:");
            foreach (var student in results)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, National ID: {student.NationalId}, Age: {student.Age}, Grade: {student.Grade}");
            }
        }
        else
        {
            Console.WriteLine("No student found with the given input.");
        }
    }
}
