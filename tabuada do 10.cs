susing System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
   
       
        Console.WriteLine ("Hello Mono World");
        Console.WriteLine("Digite um número para fazer a tabuada do 10");
        num = Convert.ToInt32(Console.ReadLine());
       
        for (int c = 0; c<=10; c++) {
            Console.WriteLine(num + "x" + c + "=" + num*c);
        }
    }
}