using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double num = 1000000000000;
        double numa = 1000000000000;
       
     
       
       
       
       
        for (int c = 1; c<=5; c++) {
              Console.WriteLine("Digite um numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num<numa) {
               
                numa = num;
            }
        }
       
        Console.WriteLine("O menor numero e: " + numa);
    }
}