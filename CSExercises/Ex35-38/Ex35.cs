using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            String input, number;
            int count = 0; int count2 = 0;
            Char[] vowels = new Char [5];
           
             Console.Write("Pls enter a phrase ");
             input = Console.ReadLine();

             for (int i = 0; i < input.Length; i++)
             {
                
                 number = input.Substring(i, 1);
                 if (number == "a" || number == "e" || number == "i" || number == "o" || number == "u")
                 {
                     count++;
                 }

                 //if (number == "a")
                 //{
                 //    count++;
                 //}
                 //else if (number == "e")
                 //{
                 //    count++;
                 //}

                 //else if (number == "i")
                 //{
                 //    count++;
                 //}

                 //else if (number == "o")
                 //{
                 //    count++;
                 //}

                 //else if (number == "u")
                 //{
                 //    count++;
                 //}
             }


             //for (int i = 0; i < count; i++)
             //{


             //    if (i == i +1)
             //    {
                     
             //    }
             //}

             Console.WriteLine("Total number of vowels: {0} ", count);
    
            
        }
    }
}
