using System;
using System.Globalization;

namespace uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {

            double salarioTotal, salarioFixo = 0, totaldevendas;
            string nome;

            Console.WriteLine("Digite o nome do funcionario");
            nome = (Console.ReadLine());


            Console.WriteLine("SALARIO FIXO = ? ");
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("DIGITE O TOTAL DE VENDAS EFETUADAS NO MÊS: ");
            totaldevendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioTotal = salarioFixo + totaldevendas * 0.15;




            Console.Write("O NOME DO FUNCIONARIO É: " + nome + "O SALARIO TOTAL É DE: " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
