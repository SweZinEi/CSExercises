using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double distance, totalfare;
            Console.Write("Pls enter the distance (km) to calculate total fare ");
            distance = Convert.ToDouble(Console.ReadLine());
            totalfare = 2.40 + distance * 0.4;
            Console.WriteLine("The total fare is {0:0.00}  ", Math.Ceiling(totalfare));
            Console.ReadLine();
        }
    }
}
