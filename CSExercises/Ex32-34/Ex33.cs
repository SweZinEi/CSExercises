using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
             int[] A = new int[] { 86,44,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
            for (int i = 0; i < A.Length -1 ; i++)
            {

              
                for (int j = i +1 ; j < A.Length; j++)
                {
                    if (A[i] < A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;

                    }
                }
            }
            for (int k = 0; k < A.Length; k++)
            {
                Console.Write("{0}\t",A[k]);
            }
            Console.WriteLine();
        }
        }
    
}
