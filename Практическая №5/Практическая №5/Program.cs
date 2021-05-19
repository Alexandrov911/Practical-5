using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__5
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            int sum = 0;
            int k = 2;
            while(k<=20)
            {
                sum = sum + k;
                k = k + 2;
            }
            
         Console.WriteLine(sum);
         Console.ReadKey();
        }
    }
}
