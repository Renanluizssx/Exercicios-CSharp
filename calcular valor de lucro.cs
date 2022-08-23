public class HelloWorld

{

public static void Main(string[] args)

{ double valorcompra, valorvenda;

Console.WriteLine("Entre com o valor de compra");

valorcompra = Convert.ToDouble(Console.ReadLine());


if (valorcompra<10) {

valorvenda = valorcompra*0.70;

Console.WriteLine("O valor da venda foi " + valorvenda);

}

else if (valorcompra>=10 && valorcompra<30) {

valorvenda = valorcompra*0.50;

Console.WriteLine("O valor da venda foi " + valorvenda);

}

else if (valorcompra>=30 && valorcompra<50) {

valorvenda = valorcompra*0.40;

Console.WriteLine("O valor da venda foi " + valorvenda);

}

else {

valorvenda = valorcompra*0.30;

Console.WriteLine("O seu lucro foi " + valorvenda);

}



}
}