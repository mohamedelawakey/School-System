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
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "mohamed", NationalId = "123456789", Age = 15, Grade = "10" },
            new Student { StudentId = 2, Name = "amr", NationalId = "987654321", Age = 16, Grade = "11" }
        };

        while (true)
        {
            Console.WriteLine("\nEnter National ID to delete a student (or type 'exit' to quit):");
            string input = Console.ReadLine();

            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            var studentToDelete = students.FirstOrDefault(s => s.NationalId == input);

            if (studentToDelete != null)
            {
                students.Remove(studentToDelete);
                Console.WriteLine($"Student {studentToDelete.Name} has been deleted.");
            }
            else
            {
                Console.WriteLine("No student found with the given National ID.");
            }

            // Display remaining students
            Console.WriteLine("\nRemaining Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, National ID: {student.NationalId}");
            }
        }
    }
}

