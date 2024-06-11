using Iron_Bussness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsUsers  Person = clsUsers.Find(1);

            
            
            

            if (Person != null)
            {
                
                Console.WriteLine(Person.PersonID);
                Console.WriteLine(Person.UserName);
                Console.WriteLine(Person.Password);
                Console.WriteLine(Person.IsActive);
                Console.WriteLine(Person.DataCreated);
                 
            }
            else
            {
                Console.WriteLine("Fai");
            }
            Console.ReadKey();
        }
    }
}
