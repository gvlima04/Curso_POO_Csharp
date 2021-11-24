using System;
using System.Collections.Generic;
using Set.Entities;

namespace Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>();

            Console.Write("How many courses: ");
            int numberOfCourses = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCourses; i++)
            {
                Console.Write($"Number of Students for course {i}: ");
                int numStudents = int.Parse(Console.ReadLine());

                for (int j = 1; j <= numStudents; j++)
                {
                    Console.Write($"Student Id: ");
                    int id = int.Parse(Console.ReadLine());


                    set.Add(new Student(id));

                    Console.WriteLine("");
                }

            }

            Console.WriteLine($"Total students: {set.Count}");
        }
    }
}
