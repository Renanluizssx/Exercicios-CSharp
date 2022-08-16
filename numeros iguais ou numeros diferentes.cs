public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n1, n2;
        Console.WriteLine("Entre com um numero");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entre com outro numero");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        if (n1==n2) {
            Console.WriteLine("Os numeros sao iguais");
        }
        else {
            Console.WriteLine("Os numeros sao diferente");
        }
    
         
    }
    
         
}