using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPruebafactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            double res = APPPROGRAMACIONCAP.Class1.fact(num);
            Console.WriteLine("el factorial de ",num,res );
            Console.ReadKey();//pausa

        }
    }
}
