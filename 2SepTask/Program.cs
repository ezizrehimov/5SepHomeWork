using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SepTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("value: " + value);

            if (value % 3 == 0)
            {
                if (value / 3 % 3 == 0)
                {
                    Console.WriteLine("duzdu");
                }
                else
                {
                    Console.WriteLine("qaliqsiz bolundu, amma quvveti deyil");
                }
            }
            else
            {
                Console.WriteLine("qaliqsiz bolunmedi");
            }
        }
    }

}
