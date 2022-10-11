using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = new double[10];
            double soma;
            soma = 0;

            Console.WriteLine("Digite dez números");
            for(int c = 0; c<10; c++)
            {
                nums[c] = Convert.ToDouble(Console.ReadLine());
                soma = soma + nums[c];
            }
            Console.WriteLine("A soma é:" + soma);
            Console.ReadKey();
        }
    }
}

