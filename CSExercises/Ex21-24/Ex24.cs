using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int input, guess;
          
            Console.Write("Pls enter an number");
            input = Convert.ToInt32(Console.ReadLine());
            guess = r.Next(1,input);
        }

    }

}