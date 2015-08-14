using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
           /* String name;
            double name2;
            Console.Write("Enter a double ");
            name = Console.ReadLine();
            name2 = double.Parse(name);

            Console.WriteLine("The square of that number is {0}", Math.Sqrt(name2));
            Console.ReadLine();   */
          
            double name;
            Console.Write("Enter a double ");
            name = Double.Parse(Console.ReadLine());
           

            Console.WriteLine("The square of that number is {0}", Math.Sqrt(name));
            Console.ReadLine();
        }
    }
}
