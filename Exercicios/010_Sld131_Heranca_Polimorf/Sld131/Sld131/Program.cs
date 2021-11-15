using System;
using System.Collections.Generic;
using Sld131.Entities;

namespace Sld131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= numEmployees; i++)
            {
                Console.WriteLine($"Employee #{i}:");

                Console.Write($"Outsourced (y/n)? ");
                string outsourced = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourced.ToLower() == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine("");

            }

            Console.WriteLine("Payments:");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment());
            }

        }
    }
}
