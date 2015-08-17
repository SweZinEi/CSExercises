using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            int input;
            Console.Write("Pls enter your mark ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input >= 0 && input <= 40)
            {
                Console.WriteLine("Your scored {0} marks which is grade F. ", input);
            }
            else if (input > 40 && input <= 59)
            {
                Console.WriteLine("Your scored {0} marks which is grade C. ", input);
            }

            else if (input >= 60 && input <= 79)
            {
                Console.WriteLine("Your scored {0} marks which is grade B. ", input);
            }

            else if (input >= 80 && input <= 100)
            {
                Console.WriteLine("Your scored {0} marks which is grade A. ", input);
            }

            else
            {
                Console.WriteLine("Error ", input);
            }
        }
    }
}