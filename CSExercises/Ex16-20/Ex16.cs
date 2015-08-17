using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string name, gender;
            Console.Write("Pls enter your name ");
            name = Console.ReadLine();
            Console.Write("Pls write Male of M or Female for F ");
            gender = Console.ReadLine();

            if (gender == "M")
            {
                gender = "Mr.";
                Console.WriteLine("Good Morning {0} ", gender + name);


            }
            else
            {
                gender = "Ms.";
                Console.WriteLine("Good Morning {0} ", gender + name);
            } 
        }
    }
}