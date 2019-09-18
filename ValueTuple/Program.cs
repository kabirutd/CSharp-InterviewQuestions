using System;

namespace ValueTuple
{

    /*
    
        https://www.tutorialsteacher.com/csharp/valuetuple

        C# 7.0 (.NET Framework 4.7) introduced ValueTuple, a structure which is a value type representation 
        of the Tuple.
        The ValueTuple is only available in .NET Framework 4.7. If you don't see ValueTuple in your 
        project then you need to install the ValueTuple. (.NET Framework 4.7 or higher, or .NET Standard 
        Library 2.0 or higher already includes ValueTuple.)

        To install the ValueTuple package, right click on the project in the solution explorer and 
        select Manage NuGet Packages... This will open the NuGet Package Manager. Click the Browse 
        tab, search for ValueTuple in the search box and select the System.ValueTuple package, as shown.

        ValueTuple Initialization
        It is easy to create and initialize ValueTuple. It can be created and initialized using 
        parentheses () and specifying the values between them.
        var person = (1, "Bill", "Gates");
    
        //equivalent Tuple
        //var person = Tuple.Create(1, "Bill", "Gates");
        ValueTuple can also be initialized by specifying the type of each element, as shown below.
        ValueTuple<int, string,string> person = (1, "Bill", "Gates");
        person.Item1;  // returns 1
        person.Item2;   // returns "Bill"
        person.Item3;   // returns "Gates"
        The following is a short way of declaring types for each member.

        (int, string, string) person = (1, "Bill", "Gates");
        person.Item1;  // returns 1
        person.Item2;   // returns "Bill"
        person.Item3;   // returns "Gates"
        Please notice that we have not used var in the above tuple initialization statement; instead we provided the type of each member values inside the brackets.
        Tuple requires at least two values. The following is NOT a tuple.
        var number = (1);  // int type, NOT a tuple
        var numbers = (1,2); //valid tuple
        Unlike Tuple, a ValueTuple can include more than eight values.
        var numbers = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14); 


     */
    class Program
    {
        static void Main(string[] args)
        {
            //Named Members:
            //We can assign names to ValueTuple properties instead of having the default property 
            //names Item1, Item2 and so on.

            (int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
            var id = person.Id;   // returns 1
            var firstName = person.FirstName;  // returns "Bill"
            var lastName = person.LastName; // returns "Gates"
            //We can also assign member names at the right side with values, as below.
            var person2 = (Id: 1, FirstName: "Bill", LastName: "Gates");
            //Please note that we can provide member names either at the left side or at the 
            //right side but not at both side.The left side has precedence over the left side.
            //The following will ignore names at the right side.

          // PersonId, FName, LName will be ignored.
          (int Id, string FirstName, string LastName) person3 = (PersonId: 1, FName: "Bill", LName: "Gates");
            
          // PersonId, FirstName, LastName will be ignored. It will have the default names: Item1, Item2, Item3.
          //(string, string, int) person4 = (PersonId: 1, FName: "Bill", LName: "Gates");

            //We can also assign variables as member values.
            string firstName2 = "Bill", lastName2 = "Gates";
            var per = (FirstName: firstName2, LastName: lastName2);

        }
    }
}
