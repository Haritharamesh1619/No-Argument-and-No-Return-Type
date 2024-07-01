using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_Argument_and_No_Return_Type
{
     class Program
    {
        static void Main(string[] args)
        {
            studentInfo();
            Console.ReadKey();
        }
        public static void studentInfo()
    // void = no return
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            
           
            
        }
    }
}
