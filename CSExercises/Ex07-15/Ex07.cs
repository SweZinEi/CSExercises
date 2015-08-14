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
            int salary, allowance,transport;
            Console.Write("Enter Salary ");
            salary = Convert.ToInt32(Console.ReadLine());
            allowance = ((80/salary) * 100);

            Console.WriteLine("The Salary is {0}", salary );
            Console.WriteLine("The Allowance {0}", allowance);
           // Console.WriteLine("The Transport {0}", allowance);
           Console.ReadLine();
        }
    }
}
