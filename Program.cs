using System.Dynamic;
using System.Reflection;

namespace DynamicLRProject
{
    //class User
    //{

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 240;
            obj = "hello";

            dynamic dyn = 240;
            dyn = dyn / 25;
            Console.WriteLine(dyn);


            dyn = "hello world";
            dyn += " hello people";
            Console.WriteLine(dyn);

            //dyn = new User();

            dynamic person = new ExpandoObject();
            person.Name = "Bob";
            person.Age = 32;
            person.Skils = new List<string> { "C++", "C#", "JavaScript" };

            person.Hello = (Action)(() => Console.WriteLine($"Hello {person.Name}"));
            person.PrintSKils = (Action)(() => 
            {
                foreach(var item in person.Skils)
                    Console.WriteLine(item);
            });


            //person.Hello();

            //person.Name = "Joe";

            //person.Hello();
            //person.PrintSKils();

            //try
            //{
            //    Assembly assembly = Assembly.LoadFrom("UserLib.dll");
            //    Type? type = assembly?.GetType("UserLib.User");

            //    dynamic? dynObj = Activator.CreateInstance(type!);
            //    dynObj?.ActionMethod();
            //    dynObj?.ActionArgMethod("Joe");

            //    //object? myobj = Activator.CreateInstance(type!);
            //    //MethodInfo? method = type?.GetMethod("ActionMethod");
            //    //method?.Invoke(myobj, null);

            //    //method = type?.GetMethod("ActionArgMethod");
            //    //object[] arg = { "Bob" };
            //    //method?.Invoke(myobj, arg);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            
            
        }
    }
}