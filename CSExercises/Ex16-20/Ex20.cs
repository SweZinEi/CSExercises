using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {


            int tv, dvd, mp3;
            double totalprice, total2,total3;
            int tvprice = 900;
            int dvdprice = 500;
            int mp3price = 700;

            Console.Write("Pls enter quantity for TV: ");
            tv =  Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Pls enter quantity for DVD: ");
            dvd =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Pls enter quantity for MP3: ");
            mp3 = Convert.ToInt32(Console.ReadLine());

            totalprice = (tv * tvprice) + (dvd * dvdprice) + (mp3 * mp3price);
            total2 = (tv * tvprice) + (dvd * dvdprice);

            if(totalprice > 5000 && totalprice < 10000){
                total3 = 0.9 * total2;
                Console.WriteLine("Total price: ${0}", (total3) + (mp3 * mp3price));
            }

            else if(totalprice > 10000)
            {
                total3 = 0.85 * total2;
                Console.WriteLine("Total price: ${0}", total3 + (mp3 * mp3price));
            }
            else
            {
                Console.WriteLine("Total price: ${0}", totalprice);
            }
            


        }
    }
}