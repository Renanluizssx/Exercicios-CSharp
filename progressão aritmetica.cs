using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int r = 0;
        Console.WriteLine("Progressao aritmetica");
       
        for (int c = 0; c<=100; c++) {
            r = r + c;
            Console.WriteLine("A soma de 0 a 100   " + r);
        };
    }
}

