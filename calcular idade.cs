public class HelloWorld

{

public static void Main(string[] args)

{ double idade;


Console.WriteLine("Digite sua Idade");

idade = Convert.ToDouble(Console.ReadLine());


if(idade>=5 && idade<=7) {

Console.WriteLine("Infantil A");

}

else if(idade>=8 && idade<=10) {

Console.WriteLine("Infantil B");

}

else if(idade>=11 && idade<=13) {

Console.WriteLine("Juvenil A");


}

else if (idade>=14 && idade<=17) {

Console.WriteLine("Juvenil B");


}

else if (idade>=18){


Console.WriteLine("Maiores de 18");

}

else {

Console.WriteLine("Não pode participar");

}

}

}


