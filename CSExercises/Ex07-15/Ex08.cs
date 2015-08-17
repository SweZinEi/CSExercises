using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Double temperature, far;
            Console.Write("Pls enter temperature ");
            temperature = Convert.ToDouble(Console.ReadLine());
            far = 1.8 * temperature + 32;
            Console.WriteLine("Fahrenheit {0} ", far);
            Console.ReadLine();
        }
    }
}
