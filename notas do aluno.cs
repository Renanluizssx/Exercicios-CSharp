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
            string[] nomes = new string[5];
            int[] p1 = new int[5];
            int[] p2 = new int[5];
            int soma;
           
            for (int c = 0; c<=4; c++) {
            Console.WriteLine("Digite seu nome");
         nomes[c]= Console.ReadLine();
            Console.WriteLine("Digite sua nota da p1");
            p1[c] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua nota da p2");
            p2[c] = Convert.ToInt32(Console.ReadLine());
               
           
               

           
         
            }
            for(int c = 0; c<=4; c++)
            {
                soma = (p1[c] + p2[c]) / 2;
                Console.WriteLine(" Seu nome é: " + nomes[c] + " Sua nota da p1 é " + p1[c] + " Sua nota da p2 é " + p2[c] +
                   " então sua média é " + soma);

            }





            Console.ReadKey();
        }
       
    }
   
}

