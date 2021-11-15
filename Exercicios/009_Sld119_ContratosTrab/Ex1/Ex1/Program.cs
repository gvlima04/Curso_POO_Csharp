using Ex1.Entities;
using Ex1.Entities.Enums;
using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Department department = new Department(Console.ReadLine());

            Console.WriteLine("Enter worker data: ");
            
            Console.Write("   Name: ");
            string name = Console.ReadLine();

            Console.Write("   Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("   Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int numContracts = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            for (int i = 0; i < numContracts; i++)
            {
                Console.WriteLine("Contract " + (i+1) + ":");
                Console.Write("    Date in format (dd/mm/aaaa): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("    Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("    Duration: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
                    
            }

            Console.Write("\nEnter a mouth and year to calculate income (mm/yyyy): ");

            string mounthAndYear = Console.ReadLine();
            string[] vetMounthAndYear = mounthAndYear.Split('/');

            Console.WriteLine(worker);

            Console.WriteLine("Income for " + mounthAndYear + ": " + worker.Income(int.Parse(vetMounthAndYear[1]), int.Parse(vetMounthAndYear[0])));
        
        }
    }
}
