using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            
            double x, y;
            Console.WriteLine("X \t Y");
            Console.WriteLine("---------------------------");
           
            for ( x = -5; x < 5; x++)
            {
                y = (2 * Math.Pow(x, 2)) - (4 * x) + 3;
               
                Console.WriteLine("{0} \t {1}", x,y);
               
            }

           
           
        }
    }
}
