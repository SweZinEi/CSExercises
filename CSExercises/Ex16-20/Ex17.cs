using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string name, gender;
            int age;
            Console.Write("Pls enter your name ");
            name = Console.ReadLine();
            Console.Write("Pls write Male of M or Female for F ");
            gender = Console.ReadLine();
            Console.Write("Pls enter your age ");
            age = Convert.ToInt32(Console.ReadLine());

            if (gender == "M")
            {
               
               
              if (age >= 40)
              {
                  gender ="Uncle ";
                  Console.WriteLine("Good Morning {0} ", gender + name);
                
              }

                else {
                          gender = "Mr.";
                  Console.WriteLine("Good Morning {0} ", gender + name);
              }


            }
          
            else
            {
                 if (age >= 40)
              {
                  gender ="Aunty ";
                  Console.WriteLine("Good Morning {0} ", gender + name);
                
              }

                else {
                          gender = "Mr.";
                  Console.WriteLine("Good Morning {0} ", gender + name);
              }

                
            }
        }
        
    }
}