using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int input;
           
           do{

                 Console.Write("Pls enter an integer: ");
                 input = Convert.ToInt32(Console.ReadLine());
                  if (input == 88){
                      Console.WriteLine("Lucky you...");
                  }
                  else
                  {
                      Console.WriteLine("Try again...");
                  }
           }
               while(input != 88);          

          
           

        }
    }
}
