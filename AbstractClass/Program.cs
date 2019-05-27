using System;

namespace AbstractClass
{

    /*
    
        http://csharp-video-tutorials.blogspot.com/2013/09/part-3-why-and-when-should-we-use.html

        http://csharp-video-tutorials.blogspot.com/2016/10/c-abstract-class-virtual-method.html

     */
    class Program
    {
        static void Main(string[] args)
        {
            //overriding abstract class virtual methods

            SomeClassThatDoesNotOverride c1 = new SomeClassThatDoesNotOverride();
            c1.AbstractClassMethod();

            SomeClassThatOverrides c2 = new SomeClassThatOverrides();
            c2.AbstractClassMethod();

            //employee class override.

            FullTimeEmployee fte = new FullTimeEmployee();

            fte.AnnualSalary = 130000;
            fte.FirstName = "Mohammad";
            fte.LastName = "kabir";

            string name = fte.GetFullName();
            float monthlySalary = fte.GetMonthlySalary();

            Console.WriteLine("Monthly salary of Fulltime employee, " + name + " is: " + monthlySalary);

            ContractEmployee ce = new ContractEmployee();

            ce.FirstName = "Mohammad";
            ce.LastName = "Sagir";

            string ceName = ce.GetFullName();
            ce.HourlyRate = 120;
            ce.TotalHoursWorked = 160;
            float ceMonthlySalary = ce.GetMonthlySalary();

            Console.WriteLine("Monthly salary of Contract employee, " + ceName + " is: " + ceMonthlySalary);






        }
    }

    public abstract class AbstractClass
    {
        public virtual void AbstractClassMethod()
        {
            Console.WriteLine("Abstact Class - Default Implementation");

        }

    }

    public class SomeClassThatOverrides : AbstractClass
    {
        public override void AbstractClassMethod()
        {
            //base.AbstractClassMethod();
            Console.WriteLine("Abstact Class - Override Implementation");
        }
    }

    public class SomeClassThatDoesNotOverride : AbstractClass
    {

    }


    public abstract class BaseEmployee
    {
        public int Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public abstract float GetMonthlySalary();

        // We could also declare as Virtual CalculateSalary(). But then it will have to have some implemenation
        //public virtual float CalculateSalary()
        //{
        //    //Console.WriteLine("Abstact Class - Default Implementation");


        //}

    }

    public class FullTimeEmployee : BaseEmployee
    {
        public float AnnualSalary
        {
            get;
            set;
        }

        public override float GetMonthlySalary()
        {
            return this.AnnualSalary / 12;

        }


    }

    public class ContractEmployee : BaseEmployee
    {
        public float HourlyRate
        {
            get;
            set;
        }

        public float TotalHoursWorked
        {
            get;
            set;
        }

        public override float GetMonthlySalary()
        {
            //throw new NotImplementedException();

            return this.HourlyRate * this.TotalHoursWorked;
        }
    }
}
