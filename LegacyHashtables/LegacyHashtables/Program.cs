using System;
using System.Collections;

namespace LegacyHashtables
{
    internal class Program
    {
        // Key - Value Pairs
        // Auto - Car
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();
            Student student1 = new Student(1, "Alice", 3.5);
            Student student2 = new Student(2, "Bob", 3.8);
            Student student3 = new Student(3, "Charlie", 3.2);
            Student student4 = new Student(4, "Diana", 3.9);

            studentsTable.Add(student1.Id, student1);
            studentsTable.Add(student2.Id, student2);
            studentsTable.Add(student3.Id, student3);
            studentsTable.Add(student4.Id, student4);

            // retrive individual value with know ID
            Student storedStudent1 = (Student)studentsTable[student1.Id];

            // Retrive all values from hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student s = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}, Name{1}, GPA{2}", s.Id, s.Name, s.GPA);
            }
           // Console.WriteLine("Student ID:{0}, Name{1}, GPA{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

        }
    }

    class Student
    {
        // Property called Id
        public int Id { get; set; }
        // Property called Name
        public string Name { get; set; }
        // Property called GPA
        public double GPA { get; set; }
        // Simple Constructor
        public Student(int id, string name, double gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
