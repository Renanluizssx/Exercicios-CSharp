using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {   string nome;
    double salariominimo;
    double salariorecebido;
    double resultado;
    Console.WriteLine("Digite seu nome");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o valor do salario minimo:");
    salariominimo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o valor do salario recebido");
    salariorecebido = Convert.ToDouble(Console.ReadLine());
    resultado = (salariorecebido/salariominimo);
    Console.WriteLine("Quantidade de salario minimo    " + resultado);
    
    
        
    }
}