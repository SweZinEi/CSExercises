
using System;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int a = 0; int sum = 0,count = 0,subaverage = 0;
            int[,] student = new int[12, 4];
            //{1,2,3,4,5,6,7,8,9,10,11,12};
            student[0, 0] = 56;
            student[1, 0] = 94;
            student[2, 0] = 41;
            student[3, 0] = 99;
            student[4, 0] = 62;
            student[5, 0] = 40;
            student[6, 0] = 81;
            student[7, 0] = 21;
            student[8, 0] = 88;
            student[9, 0] = 48;
            student[10, 0] = 64;
            student[11, 0] = 16;

            student[0, 1] = 84;
            student[1, 1] = 73;
            student[2, 1] = 63;
            student[3, 1] = 9;
            student[4, 1] = 3;
            student[5, 1] = 96;
            student[6, 1] = 15;
            student[7, 1] = 70;
            student[8, 1] = 50;
            student[9, 1] = 54;
            student[10, 1] = 71;
            student[11, 1] = 93;


            student[0, 2] = 68;
            student[1, 2] = 31;
            student[2, 2] = 36;
            student[3, 2] = 18;
            student[4, 2] = 65;
            student[5, 2] = 53;
            student[6, 2] = 27;
            student[7, 2] = 100;
            student[8, 2] = 13;
            student[9, 2] = 52;
            student[10, 2] = 67;
            student[11, 2] = 46;

            student[0, 3] = 29;
            student[1, 3] = 89;
            student[2, 3] = 90;
            student[3, 3] = 17;
            student[4, 3] = 75;
            student[5, 3] = 23;
            student[6, 3] = 30;
            student[7, 3] = 22;
            student[8, 3] = 12;
            student[9, 3] = 78;
            student[10, 3] = 25;
            student[11, 3] = 72;


            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.Write("{0} \t", student[i, j]);
                    if (j == 3)
                    {
                        Console.Write("\n");

                    }


                }
            }

/////////////////////////////////////////

            for (int k = 0; k < student.GetLength(0); k++)
            {
                for (int l = 0; l < student.GetLength(1); l++)
                {

                  
                    a += student[k, l];

                }

                Console.WriteLine("Total Marks for each student:  " + a);
                sum += a;
                a = 0;
                count++;
                Console.Write("\n");
               
            }
            

            Console.Write("\n");
            Console.WriteLine("Sum of class : " + sum);
            Console.WriteLine("Average of class: " + sum / count);

////average for each subject for all students

            for (int k = 0; k < student.GetLength(1); k++)
            {
                for (int l = 0; l < student.GetLength(0); l++)
                {
 
                    subaverage += student[l, k];
                 

                }

                Console.Write("Total for each subject: {0} \n", subaverage);
               
            }




        }
    }
}
