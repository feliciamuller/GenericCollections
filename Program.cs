using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

namespace GenericCollections
{
    public class Program
    {

        static void Main(string[] args)
        {
            //create objects
            Employee E1 = new Employee(10, "Karin", "kvinna", 30000);
            Employee E2 = new Employee(11, "Lars", "man", 31000);
            Employee E3 = new Employee(12, "Freja", "kvinna", 28000);
            Employee E4 = new Employee(13, "Linnea", "kvinna", 33500);
            Employee E5 = new Employee(14, "Karl", "man", 30200);

            //create a stack and adding objects to it
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            //loop to write out the stack
            foreach (var employees in stack)
            {  
                Console.WriteLine($"{employees.Id} - {employees.Name} - {employees.Gender} - {employees.Salary}");
                Console.WriteLine("Antal element i stacken: " + stack.Count());
            }

            Console.WriteLine("-------------------------");

            //loop to retrive objects with pop method
            while (stack.Count() > 0)
            {
                Employee empRemove = stack.Pop();
                Console.WriteLine($"{empRemove.Id} - {empRemove.Name} - {empRemove.Gender} - {empRemove.Salary}");
                Console.WriteLine("Antal element i stacken: " + stack.Count());
            }

            Console.WriteLine("-------------------------");

            //adding objects back to the stack
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            //loop to peek at objects in the stack
            int counter = 0;
            while (counter < 2)
            {
                Employee empPeek = stack.Peek();
                Console.WriteLine($"Du tittar på: {empPeek.Id} - {empPeek.Name} - {empPeek.Gender} - {empPeek.Salary} ");
                Console.WriteLine("Antal element i stacken: " + stack.Count());
                counter++;
            }

            Console.WriteLine("-------------------------");

            //conditions to check if E3 is in the stack
            if (stack.Contains(E3))
            {
                Console.WriteLine("Ja, E3 finns i stacken");
            }

            else
            {
                Console.WriteLine("Nej, E3 finns inte i stacken");
            }

            Console.WriteLine("-------------------------");

            //create list and adding objects to it
            List<Employee> list = new List<Employee>
            {
                E1,
                E2,
                E3,
                E4,
                E5
            };

            //conditions to check if E2 is in the list
            if (list.Contains(E2))
            {
                Console.WriteLine("Ja, E2 finns i listan");
            }
            else
            {
                Console.WriteLine("Nej E2 finns inte i listan");
            }

            Console.WriteLine("-------------------------");

            Employee empFirstMan = list.Find(x => x.Gender.Contains("man"));

            //check conditions to find the first man in the list 
            if (empFirstMan != null)
            {
                Console.WriteLine("Den första mannen i listan är: " + empFirstMan.Name);
            }

            else
            {
                Console.WriteLine("Det finns inga män i listan");
            }

            Console.WriteLine("-------------------------");

            //create a new list with all men
            List<Employee> empAllMen = list.FindAll(man => man.Gender.Contains("man"));

            //loop to write out all the men in the list
            Console.WriteLine("Männen i listan är:");
            foreach (var men in empAllMen)
            {
                Console.WriteLine(men.Name);
            }


        }
    }

}

