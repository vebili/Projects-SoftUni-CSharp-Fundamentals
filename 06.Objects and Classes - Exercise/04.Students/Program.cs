using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string secondName = input[1];
                double grade = double.Parse(input[2]);
                Student currentStudent = new Student(firstName, secondName, grade);
                students.Add(currentStudent);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }
    class Student
    {
        public Student(string firsName, string secondName, double grade)
        {
            FirstName = firsName;
            SecondName = secondName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:f2}";
        }
    }
}