using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            //Random r = new Random();
            //int input, guess;
          
            //Console.Write("Pls enter an number");
            //input = Convert.ToInt32(Console.ReadLine());
            //guess = r.Next(1,input);
            int N;
            double guess;

            Random r = new Random();

            bool b = true;
            while (b)
            {
                {
                    Console.Write("Pls enter an number ");
                    N = Convert.ToInt32(Console.ReadLine());
                    guess = r.Next(1, N);

                    if ((guess * guess) == N)
                    {
                        Console.WriteLine("Guess is correct ");
                        b = false;
                    }
                    else
                    {
                        guess = (guess + (N / guess)) / 2;
                        Console.WriteLine("Guess is approximates to N {0:0.00000}", guess);
                    }
                }
            }
            int input, result;
            Console.Write("Pls enter an number to find out its factorial ");
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {

                while (i < input)
                {
                    // Console.WriteLine(input);

                    input = input - 1;
                    result = input;

                    Console.WriteLine("Your number factorial is {0}", input);

                }


            }
        }

    }

}