using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int input;
            int prime = 1;
            Console.Write("Pls enter an number");
            input = Convert.ToInt32(Console.ReadLine());

          
  
	         if (input % 2 != 0 )
                {
                    prime = input;
                    Console.WriteLine("The prime number {0} ", prime);
                    
                }
                else
                {
                    Console.WriteLine("Not Prime number! ", prime);
                }
	            }
                
            
            //prime = prime * j;
            
        }
    }
