using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = 1270.50;
            int valor = (int)salario;

            Console.WriteLine("O valor é: " + valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            double pontoFlutuante = 3.14;
            Console.WriteLine(pontoFlutuante);

            _ = Console.ReadLine();
        }
    }
}
