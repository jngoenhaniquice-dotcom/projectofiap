using  MeuPrimeiroPrograma.Teste;
using MeuPrimeiroPrograma.Caneta;

class Program
{

    static void Main()
    {

        //  var calc = new Calculadora();

        // Console.WriteLine(calc.Somar(1, 1).ToString());
        // Console.WriteLine(calc.Multiplicar(2, 2).ToString());
        //Console.WriteLine(calc.Subtrair(3, 2).ToString());
        // Console.WriteLine(calc.Dividir(1, 1).ToString());



        var canetaAzul = new Caneta("azul", true);
        var canetaVermelha = new Caneta("vermelha", false);


        Console.WriteLine(canetaAzul.Chamar());

        Console.WriteLine(canetaVermelha.Chamar());
    }

   
}
