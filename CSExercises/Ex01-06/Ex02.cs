using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            String name; int name2;
            Console.Write("Enter a number ");
            name = Console.ReadLine();

            name2 = Int32.Parse(name);

            Console.WriteLine("The square of that number is {0}", name2 * name2);
            Console.ReadLine();
        }
    }
}
