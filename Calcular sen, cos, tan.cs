using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {   double angs,seno,angc,cosseno,angt,tangente;
       
        Console.WriteLine ("Hello Mono World");
        Console.WriteLine ("Digite o angulo do seno");
        angs = Convert.ToDouble(Console.ReadLine());
        seno = Math.Sin(angs);
        Console.WriteLine("Digite o angulo do Cosseno");
        angc = Convert.ToDouble(Console.ReadLine());
        cosseno = Math.Cos(angc);
        Console.WriteLine("Digite o angulo do Tangente");
        angt = Convert.ToDouble(Console.ReadLine());
        tangente = Math.Tan(angt);
        
        Console.WriteLine("seno e" + seno + "Cosseno e" + cosseno + "tangente e" + tangente);
        
        
        
        
    }
}