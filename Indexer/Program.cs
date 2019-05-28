using System;
using System.Collections.Generic;

namespace Indexer

{

    /*
     C# introduces a new concept known as Indexers that allows are classes or stucts to be used as arrays. The indexers are usually known as smart arrays in C#. An indexer or an indexed property, is a class property that allows you to access a member 
     variable of a class or struct using the features of an array.

        Resources:
        https://www.dotnetperls.com/indexer

        https://www.c-sharpcorner.com/article/indexer-in-C-Sharp/

        https://csharp-station.com/Tutorial/CSharp/Lesson11  - Practie this..


     */
    class Program
    {
        static void Main(string[] args)
        {
            Customer Customers  = new Customer();
            //Customers.GetAddress(1234);

           // Customers.GetAddress("9724910884");

            Console.WriteLine("Address for pincode 1234: " + Customers[1234].Address);
            Console.WriteLine("Phone for pincode 1234: " + Customers[1234].Phone);
                                  

            Console.WriteLine("Address for pincode 4567: " + Customers[4567].Address);
            Console.WriteLine("Phone for pincode 4567: " + Customers[4567].Phone);

            Console.WriteLine();

            Console.WriteLine("Address for phone 9724910884: " + Customers["9724910884"].Address);
            Console.WriteLine("Pincode for Phone  9724910884: " + Customers["9724910884"].PinCode);

            Console.WriteLine("Address for phone 9724910889: " + Customers["9724910889"].Address);
            Console.WriteLine("Pincode for Phone  9724910889: " + Customers["9724910889"].PinCode);


            Console.WriteLine();


        }
    }

    public class Customer
    {
        public string Name { get; set; }

        private List<CustomerAddress> Addresses = new List<CustomerAddress>();

        public Customer()
        {
            Addresses.Add(new CustomerAddress
            {
                PinCode = 1234,
                Address = "13476 Mardi Gras LN",
                Phone = "9724910884"


            });

            Addresses.Add(new CustomerAddress
            {
                PinCode = 4567,
                Address = "13478 Mardi Gras LN",
                Phone = "9724910889"


            });

            Addresses.Add(new CustomerAddress
            {
                PinCode = 8901,
                Address = "13480 Mardi Gras LN",
                Phone = "9724950889"


            });

        }

        public CustomerAddress this [int PinCode]
        {
            get
            {
                foreach (CustomerAddress address in Addresses)
                {
                    if (address.PinCode == PinCode)
                    {
                        return address;
                    }
                }

                return null;
            }
        }

        public CustomerAddress this[string Phone]
        {
            get
            {
                foreach (CustomerAddress address in Addresses)
                {
                    if (address.Phone == Phone)
                    {
                        return address;
                    }
                }

                return null;
            }
        }

        public CustomerAddress GetAddress(int PinCode)
        {
            foreach (CustomerAddress address in Addresses)
            {
                if (address.PinCode== PinCode)
                {
                    return address;
                }
            }

            return null;
        }

        public CustomerAddress GetAddress(string Phone)
        {
            foreach (CustomerAddress address in Addresses)
            {
                if (address.Phone == Phone)
                {
                    return address;
                }
            }
            return null;
        }


    }

    public class CustomerAddress
    {
        
        public string Address { get; set; }

        //public string EmailAddress { get; set; }

        public string Phone { get; set; }

        public int PinCode { get; set; }

    }   
}
