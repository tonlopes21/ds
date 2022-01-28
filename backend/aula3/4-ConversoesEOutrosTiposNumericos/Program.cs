using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // O int é um tipo de variável que suporta valores ate 32 bits, este tipo de conversão
            // é chamado de casting.
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variavel de 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);


            //A diferença para o double é que tem uma precisão curta após a casa decimal. 
            //O float não é muito usual. 
            float altura = 1.80f;
            Console.WriteLine(altura);



            Console.ReadLine();
        }
    }
}
