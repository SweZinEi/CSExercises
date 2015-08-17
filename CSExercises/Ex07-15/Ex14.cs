using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, s, area;

            Console.WriteLine("To calculate the area of triangle ");

            Console.Write("Pls enter the length of side  A ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pls enter the length of side  B  ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pls enter the length of side  C  ");
            c = Convert.ToDouble(Console.ReadLine());
            s = (a + b + c) / 2;
            area = Math.Sqrt((s - a) * (s - b) * (s - c));

            Console.WriteLine("The the area of triangle is {0}  ", area);
            Console.ReadLine();
        }
    }
}