using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double x1, y1, x2, y2, distance;

            Console.WriteLine("To compute the distance of two points (x,y) \n ");
            Console.Write("Pls enter the value of x1 ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pls enter the value of y1 ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pls enter the value of x2 ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pls enter the value of y2 ");
            y2 = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt((Math.Sqrt((x2 - x1)) + Math.Sqrt((y2 - y1))));
            Console.WriteLine("The distance between x and y is {0}  ", distance);
            Console.ReadLine();
        }
    }
}
