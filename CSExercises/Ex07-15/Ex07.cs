using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double salary, allowance, transport;
            Console.Write("Pls enter your salary ");
            salary = Convert.ToDouble(Console.ReadLine());
            allowance = (salary * 0.1);
            transport = (salary * 0.3);
            Console.WriteLine("Your total income is {0} ", salary + allowance + transport);
            Console.ReadLine();
        }
    }
}
