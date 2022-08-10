using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {  
        // Aqui foi o cálculo da Área
        double  Base, Altura, Area;
        Console.WriteLine("Digite a Base Frederico");
        Base = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Boa Frederico, agora escreva a Altura");
        Altura = Convert.ToDouble(Console.ReadLine());
       
        Area = Base*Altura;
       
        Console.WriteLine("A base que voce digitou e: " + Base);
        Console.WriteLine("A Altura que voce digitou e: " + Altura);
        Console.WriteLine("A Area entao e:" + Area);
   
       
       
    }
}

