using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
           
            String[] a = new String[4];
            for (int i = 0; i < a.Length; i++ )
            {
                a[0] = "No";
                a[1] = "Inverse";
                a[2] = "Square Root";
                a[3] = "Square";
                Console.Write("{0} \t", a[i]);

               
              
            }
            Console.WriteLine("\n");
            for (double j = 1; j < 11; j++)
            {


                Console.WriteLine("{0}\t {1:0.0##}\t\t {2:0.###}\t\t{3}", j, (1 / j), Math.Sqrt(j), j * j);
            }
                
           
         
        }
    }
}
