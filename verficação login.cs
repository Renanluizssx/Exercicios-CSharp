using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string emaila = "renangameplays@gmail.com";
            int senhaa = 987654;
            string email = "0";
            int senha = 0;



            for (int c = 1; c <= 3;c++)
            {
                Console.WriteLine("Digite seu email");
                email = Console.ReadLine();
                Console.WriteLine("Digite a senha");
                senha = Convert.ToInt32(Console.ReadLine());

                if (email == emaila && senha == senhaa)
                {
                    Console.WriteLine("cadastrado com sucesso");
                    c = 5;
                }

                else
                {
                    Console.WriteLine("senha incorreta");
                }

            }
            if (email != emaila && senha != senhaa)
            {
                Console.WriteLine("Login bloqueado");
            }
      
            
            Console.ReadKey();


        }
    }
}