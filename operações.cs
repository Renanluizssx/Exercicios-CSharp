using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   double n1, n2, soma, sub, multi, divi;
   
        Console.WriteLine("Digite um numero");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro numero");
        n2 = Convert.ToDouble(Console.ReadLine());
       
        soma = n1 + n2;
        sub = n1 - n2;
        multi = n1 * n2;
        divi = n1 / n2;
       
            Console.WriteLine(" Soma e: " + soma + " Subtracao: " + sub + " Multiplicacao: " + multi + " divisao " + divi);

    }
}
