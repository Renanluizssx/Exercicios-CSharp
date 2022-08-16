using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double n1;
        Console.WriteLine("Digite um numero");
        n1 = Convert.ToDouble(Console.ReadLine());
        
        if (n1%3==0) {
            Console.WriteLine("E multiplo de 3");
            
        
        }
        else {
            Console.WriteLine("Nao e multiplo de 3");
        }
         
    }
    
         
}