using Ex1.Entities.Enums;
using System.Collections.Generic;

namespace Ex1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Dep { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department dep)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Dep = dep;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            
            return sum;
        }

        public override string ToString()
        {
            return "Name: " + Name
                    + "\nLevel: " + Level.ToString()
                    + "\nBase Salary: " + BaseSalary
                    +"\nDepartment: " + Dep.Name;
        }
    }
}
