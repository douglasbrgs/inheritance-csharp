using Course.Entities;
using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>(n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i + 1} data:");

                Console.Write("Outsourced (y/n) ? ");
                char outsourced = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee employee;

                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employee = new OutsourcedEmployee(name, hours, valuePerHour, additional);
                }
                else
                {
                    employee = new Employee(name, hours, valuePerHour);
                }

                employees.Add(employee);
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}