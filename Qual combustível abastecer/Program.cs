using System;
using System.Net.NetworkInformation;

namespace Qual_combustível_abastecer { }

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("qual combustível abastecer?");
        float preco_gasolina;
        float preco_alcool;
        string novo_calculo = "sim";

        while (novo_calculo == "sim")
        {
            Console.WriteLine("digite o preço da gasolina");
            preco_gasolina = float.Parse(Console.ReadLine());

            Console.WriteLine("digite o preço do alcool");
            preco_alcool = float.Parse(Console.ReadLine());

            if ((preco_alcool / preco_gasolina) > 0.7)
            {
                Console.WriteLine("abasteça com gasolina");
                _ = Console.ReadLine();
            }
            else if ((preco_alcool / preco_gasolina) < 0.7)
            {
                Console.WriteLine("abasteça com alcool");
                _ = Console.ReadLine();
            }
            else
            {
                _ = (preco_alcool / preco_gasolina) == 0.7;

                Console.WriteLine("valor equivalente! abasteça com o que preferir");
                _ = Console.ReadLine();
            }
            Console.WriteLine("deseja efetuar um novo cálculo?");
            novo_calculo = Console.ReadLine();
        }
    }
}