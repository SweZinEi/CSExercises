using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int input, result=1;
           

            Console.Write("Pls enter an number to find out its factorial ");
            input = Convert.ToInt32(Console.ReadLine());
           // int[] a = new int[input];

           
          
//decrement
            for (int i = input; i >= 2; i--)
            {
        
                    result = result * i;
                 
                   
;               
            }
            Console.WriteLine("The decrement {0} number factorial is {1}  ", input,  result);
           
//increment

            for (int j = 1; j >= input; j++)
            {

                result = result * j;


            }
            Console.WriteLine("The increment {0} number factorial is {1}  ", input, result);
           
        }
    }
}
