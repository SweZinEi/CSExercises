using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int name;
            Console.Write("Enter a number ");

            try { name = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                name = 0;
            }


            Console.WriteLine("The square of that number is {0}", Math.Sqrt(name));
            Console.ReadLine();
        }
    }
}
