using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n1;
         Console.WriteLine("Digite um número para saber se é ímpar ou par");
         n1 = Convert.ToInt32(Console.ReadLine());
         
         if (n1 % 2==0) {
             Console.WriteLine("O numero e par:" );
         }
         else {
             Console.WriteLine("O numero e impar");
         }
    }
         
}