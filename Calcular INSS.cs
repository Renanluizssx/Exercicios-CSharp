


public class HelloWorld

{

public static void Main(string[] args)


{

double salapess,

salaliquido = 0;


Console.WriteLine("Digite o seu salario");

salapess = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("O seu salario bruto e:" + salapess);


if (salapess<=600) {

Console.WriteLine("Você esta isento");

salaliquido = salapess;


}

else if(salapess>600 && salapess<=12000){

Console.WriteLine("Vai descontar 20% do salario");


salaliquido = salapess*0.8 ;



}

else if(salapess>12000 && salapess<=2000) {

Console.WriteLine("Vai descontar 25% do salario");

salaliquido = salapess*0.75;


}

else {

Console.WriteLine("Vai descontar 30%");

salaliquido = salapess*0.70;

}


Console.WriteLine("O seu salario liquido e " + salaliquido);







}

}


