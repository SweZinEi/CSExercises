using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int number, secretnum;
            int count = 0;
            Random r = new Random();
            secretnum = r.Next(0,10);

            do {
               count++;
                Console.WriteLine("Enter an number! ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == secretnum){
                   
                    switch(count)
                    {
                        case 1:
                        Console.WriteLine("You are a Wizard!");
                        break;
                        case 2:
                        Console.WriteLine("You are a good guess!");
                        break;
                        case 3:
                        Console.WriteLine("You are a lousy!");
                        break;
                            
                    }
                }
                else 
                Console.WriteLine("You attempts {0} times", count);
               
            }
            while(number != secretnum);


        }
    }
}
