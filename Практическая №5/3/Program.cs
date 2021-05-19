using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 2
            Console.WriteLine("введите число,  где все цифры различны");
            int n = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            while (n != 0)
            {
                int a = n % 10;
                if (max<a)
                {
                    max=a;
                }
                n = n / 10;
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
