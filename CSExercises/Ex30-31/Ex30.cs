using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            bool isprime = true;
            Console.WriteLine("Prime numbers");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }

                if (isprime)
                {
                    Console.WriteLine(i);
                }

                isprime = true;
            }
            Console.ReadKey(); 
        }
    }
}
