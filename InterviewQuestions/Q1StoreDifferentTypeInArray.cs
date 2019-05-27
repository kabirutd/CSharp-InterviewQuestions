using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    public abstract class Q1StoreDifferentTypeInArray
    {

        public static void Q1StoreDifferentTypeInArrayMethod()
        {
            Console.WriteLine("Q1StoreDifferentTypeInArray");
            Console.WriteLine("===========================================================");

            int[] array = new int[2];

            //array[1] = "Test string";  //will trhow error saying can't store string in integer array

            object[] arrayObject = new object[4];
            arrayObject[0] = 12; //storing integer
            arrayObject[1] = "string value";  //string is ok since t's an object array

            Customer c = new Customer();

            c.Id = 2;
            c.Name = "Mohammad kabir";

            Customer c2 = new Customer
            {
                Id = 3,
                Name = "Mohammad Sagir"

            };

            //assign class object to object array
            arrayObject[2] = c; //storing class object
            arrayObject[3] = c2;

            //now loop through

            foreach (object obj in arrayObject)
            {
                Console.WriteLine(obj);

            }

        }
    }

    class Customer
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return this.Name;
        }
    }
}
