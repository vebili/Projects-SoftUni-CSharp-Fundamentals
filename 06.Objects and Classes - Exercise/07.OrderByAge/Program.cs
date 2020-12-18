using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Student
    {
        public Student(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> studentsList = new List<Student>();
            while (input != "End")
            {
                string[] arguments = input.Split().ToArray();
                string name = arguments[0];
                string id = arguments[1];
                int age = int.Parse(arguments[2]);
                Student currentStudent = new Student(name, id, age);
                studentsList.Add(currentStudent);
                input = Console.ReadLine();
            }
            studentsList = studentsList.OrderBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, studentsList));
        }
    }
}