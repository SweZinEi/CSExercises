using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A, B;
            Console.Write("Enter an number! ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an number! ");
            B = Convert.ToInt32(Console.ReadLine());

            while (A != B)
            {
                if (A > B)
                {
                    A = A - B;
                }

                else if (B > A)
                {
                    B = B - A;
                }
         }
            Console.WriteLine("HFC= {0}", A);
           Console.WriteLine("LCM= {0}", (A*B)/A);
         /*   do
            {

                if (A > B)
                {
                    A = A - B;
                }

                else if (B > A)
                {
                    B = B - A;
                }

                
            }
            while (A == B);
            Console.WriteLine("CORRECT! {0} {1}", A, B);
           */
        }
    }
}
