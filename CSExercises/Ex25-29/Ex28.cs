using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int input, prime = 1, count = 1;
            Console.Write("Pls enter an number  ");
            input = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= input; j++)
            {
                count++;

                if (input % count == 0)
                {
                    prime += 1;
                    //Console.WriteLine("{0}", prime);
                }

            }
            //Console.WriteLine("{0}", prime);
            if (prime == 2)
            {

                Console.WriteLine("Prime number", input);

            }
            else
            {
                Console.WriteLine("Not Prime number", input);

            }
	            }
                
            
            //prime = prime * j;
            
        }
    }
