using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {

            int a, decide; int count = 1;
            int value, maxnum,minmax;
            int sum = 0;
            for (int i = 0; i < 13; i++)
            {
                count++;


                int[] array  = new int[i];
             
                Console.Write("Enter sales for month {0}:", i);
                a = Convert.ToInt32(Console.ReadLine());

                a = a + array[i];
            
              



            }

            
          

            if (count == 12)
            {

              //maxnum = Math.Max(a, a);
              // minmax = Math.Min(a, a);

                Console.WriteLine("Maximun sales: " );
                Console.WriteLine("Minimum sales: " );
                Console.WriteLine("Average: " + sum / 12);
                
            }
        }
    }
}
