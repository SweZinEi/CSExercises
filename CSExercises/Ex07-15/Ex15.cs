using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            string threedigit, first, second, third;

            Console.Write("Pls enter the three-digit number ");
            threedigit = Console.ReadLine();

            first = threedigit.Substring(0, 1);
            second = threedigit.Substring(1, 1);
            third = threedigit.Substring(2, 1);

            if (Convert.ToInt32(threedigit) == Math.Pow(Convert.ToInt32(first), 3) + Math.Pow(Convert.ToInt32(second), 3) + Math.Pow(Convert.ToInt32(third), 3))
            {
                Console.WriteLine("Armstrong number");


            }
            else
            {
                Console.WriteLine("Not Armstrong number");
            }

            /*  for (int i = 0; i <= threedigit.Length; i++)
              {
                  sub = Convert.ToInt32(threedigit);
               

              }

              */
        }
    }
}