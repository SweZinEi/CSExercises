using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int input, totalsum = 0;
            Console.Write("Pls enter an number  ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input % 2 == 0)
            {
                for (int i = 1; i < input; i++)
                {


                    if (input % i == 0)
                    {

                        totalsum += i;
                        // Console.WriteLine(i);


                    }




                }


            }

            else
            {
                for (int i = 1; i <= input; i++)
                {


                    if (input % i == 0)
                    {

                        totalsum += i;


                        //Console.WriteLine(i);

                    }

                }
                //  Console.WriteLine("Perfect Number{0}", totalsum);

            }

            if (totalsum == input)
            {
                Console.WriteLine("Perfect Number");


            }
            else
            {
                Console.WriteLine("Not Perfect Number");

            }
        }
    }
}
