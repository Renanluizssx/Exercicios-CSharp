using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
 
     

            static void Main(string[] args)
            {
                double num1, num2, r;
                string op;
                for (int c = 1; c <= 10; c++)
                {
                    Console.WriteLine("Digite um número");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite um segundo");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite uma operação");
                    op = Console.ReadLine();


                    switch (op)
                    {
                        case "+":
                            r = num1 + num2;
                            Console.WriteLine("A soma entre " + num1 + " e " + num2 + " é " + r);
                            c = 20;
                            break;
                        case "-":
                            r = num1 - num2;
                            Console.WriteLine("A subtração entre " + num1 + " e " + num2 + " é " + r);
                            c = 20;
                            break;
                        case "*":
                            r = num1 * num2;
                            Console.WriteLine("A multiplicação entre " + num1 + " e " + num2 + " é " + r);
                            c = 20;
                            break;
                        case "/":
                            r = num1 / num2;
                            Console.WriteLine("A divisão entre " + num1 + " e " + num2 + " é " + r);
                            c = 20;
                            break;
                        default:
                            Console.WriteLine("Operação incorreta, utilize apenas +, -, *, /");
                            break;
                    }
                }
                Console.ReadKey();
            }
        }
    }


