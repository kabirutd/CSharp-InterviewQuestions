using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{

    /*
     Practice LINQ: https://www.codingame.com/playgrounds/213/using-c-linq---a-practical-overview/combined-exercise-1
     
    Code Snippet: https://tech.io/snippet/BiU21PU
         */
    class Program
    {
        static void Main(string[] args)
        {

            IList<Student> studentList = new List<Student> {

                new Student {StudentName = "Mohammad Kabir", Age = 12 },
                new Student {StudentName = "Mohammad Sagir", Age = 16 },
                new Student {StudentName = "Mohammad Jabir", Age = 21 },
                new Student {StudentName = "Mohammad Amir", Age = 14},
                new Student {StudentName = "Mohammad Namir", Age = 23}

            };

            //LINQ Query Syntax

            var teenagerStudents = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select s;

            Console.WriteLine($"Teenager Students (Age<20)");
            foreach (var s in teenagerStudents)
            {

                Console.WriteLine($"\nStudentName: {s.StudentName} \nAge: {s.Age}");
            }


            Console.WriteLine($"\n\nTeenager Student List 2 (Age<20)");
            //LINQ Method Syntax with Lambda Expressions
            var teenagerStudents2 = studentList.Where(s =>
                                      s.Age > 12 && s.Age < 20
                                        )
                                        .ToList<Student>();

            foreach(var s in teenagerStudents2)
            {

                Console.WriteLine($"\nStudentName: {s.StudentName} \nAge: {s.Age}");
            }

        
        }
    }

    public class Student
    {
        public string StudentName { get; set;}
        public int Age { get; set; }
         


    }
}
