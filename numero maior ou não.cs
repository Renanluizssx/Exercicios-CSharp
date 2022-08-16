using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n1, n2;
        Console.WriteLine("Digite um numero");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro numero");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        if (n1>n2) {
            Console.WriteLine("O numero " + n1 + " é maior que " + n2);
        }
        else {
            Console.WriteLine("O numero " + n1 + " não é maior que " + n2);
        }
        
         
    }
    
         
}