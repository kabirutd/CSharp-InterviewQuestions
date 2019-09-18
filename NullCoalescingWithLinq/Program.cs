using System;
using System.Collections.Generic;
using System.Linq;

namespace NullCoalescingWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> lstEmployee = new List<Employee>
            {
                new Employee { Id = 1, Age = 20, Name = "Mohammad Kabir", Gender = "M" },
                new Employee {Id = 2, Age=30, Name="Mohammad Jabir", Gender="M"},
                new Employee {Id=3, Age = 40, Name ="Umme Kulsum", Gender = "F"},
                new Employee {Id=4, Age = 50 , Name = "", Gender = "F"}
            };


            List<Employee> lstEmployee2 = new List<Employee>();

            lstEmployee2.Add(new Employee { Id = 5, Age = 25, Name = "Mohammad Sabir", Gender = "M" });
            lstEmployee2.Add(new Employee { Id = 6, Age = 35, Name = "Mohammad Dabir", Gender = "M" });
            lstEmployee2.Add(new Employee {Id = 7, Age = 45, Name = "Amina Abbas", Gender = "F" });
            lstEmployee2.Add(new Employee {Id = 8, Age = 55, Name = null, Gender = "F" });

            //Employee Id = 3
            //var data = from emp in lstEmployee where emp.Id == 3 select new { Name = emp.Name ?? "No name" };
            var data = from emp in lstEmployee where emp.Id == 3 select new { Id = emp.Id, Name = emp.Name ?? "No name", Age = emp.Age, Gender = emp.Gender };


            //All Employees
            var data2 = from emp in lstEmployee2 select new { Id = emp.Id, Name = emp.Name ?? "No name", Age = emp.Age, Gender = emp.Gender  };


            foreach (var obj in data)
            {
                Console.WriteLine($"Id: {obj.Id} \nName: {obj.Name} \nAge: {obj.Age} \nGender: {obj.Gender} \n\n");
            }

            foreach (var obj in data2)
            {
                Console.WriteLine($"Id: {obj.Id} \nName: {obj.Name} \nAge: {obj.Age} \nGender: {obj.Gender} \n\n");
            }

        }
    }

    public class Employee
    {
        public int Id { get;set;}
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
}
