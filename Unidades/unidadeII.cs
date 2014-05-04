using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class UnidadeII
    {
        public static int num1 = 0;
        public static int num2 = 0;
        public static int soma = 0;
        public static int multiplicacao = 0;
        public static int subtracao = 0;
        public static double divisao = 0;
        public static double d = 0;
        public static double TotalCombustivel = 0;
        public static double ConsumoMedio = 0;
        public static string nome = "";
        static void Main1(string[] args)
        {
            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.Write("Sua soma é: " + soma);
            Console.ReadKey();

        }

        static void Main2(string[] args)
        {
            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("Sua soma é: " + soma);
            multiplicacao = num1 * num2;
            Console.WriteLine("Sua multiplicacao é: " + multiplicacao);
            subtracao = num1 - num2;
            Console.WriteLine("Sua subtracao é: " + subtracao);
            divisao = (double)num1 / num2;
            divisao = Math.Round(divisao, 2); // PARA APARECER APENAS 2 NUMEROS DPS DA VIRGULA
            Console.WriteLine("Sua divisao é: " + divisao);
            Console.ReadKey();
        }
        static void Main3(string[] args)
        {
            Console.Write("Digite a distancia percorrida pelo automovel em km: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Digite o total de combustivel gasto em litros: ");
            TotalCombustivel = int.Parse(Console.ReadLine());
            ConsumoMedio = TotalCombustivel / d;
            ConsumoMedio = Math.Round(ConsumoMedio, 2); // PARA APARECER APENAS 2 NUMEROS DPS DA VIRGULA
            Console.WriteLine("O consumo medio do automovel é: " + ConsumoMedio + " l/km.");
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            Console.Write("Digite o nome do vendedor: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu salario fixo: R$ ");
            double sal = double.Parse(Console.ReadLine());
            Console.Write("Total de vendas efetuadas no mês: R$ ");
            double vendas = double.Parse(Console.ReadLine());
            double comicao = vendas * 0.15;
            double total = comicao + sal;
            total = Math.Round(total, 2);
            sal = Math.Round(sal, 2);
            Console.WriteLine("O funcionario " + nome + ", tem o salario fixo de R$ " + sal + ".\n Com a sua comicao, recebera um total de R$" + total);
            Console.ReadKey();
        }
        static void Main5(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota do aluno: ");
            double nota3 = double.Parse(Console.ReadLine());
            double media = (double)(nota1 + nota2 + nota3) / 3;
            media = Math.Round(media, 2);
            Console.WriteLine(" O aluno " + nome + " ficou com media " + media + ".");
            Console.ReadKey();
        }
        static void Main6(string[] args)
        {
            Console.Write("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            num2 = int.Parse(Console.ReadLine());
            int aux = num1;
            num1 = num2;
            num2 = aux;
            Console.WriteLine("" + num1 + "   " + num2);
            Console.ReadKey();
        }
        static void Main7(string[] args)
        {
            Console.Write("Digite a termperatura em ºC: ");
            double TC = double.Parse(Console.ReadLine());
            double TF = (double)(9 * TC + 160) / 5;
            Console.WriteLine("Temperatura em Fahrenheit: " + TF);
            Console.ReadKey();
        }
        static void Main8(string[] args)
        {
            Console.Write("Digite o valor da cotação do dólar: US$ ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de dólar: US$ ");
            double dolar = double.Parse(Console.ReadLine());
            double reais = dolar / cotacao;
            reais = Math.Round(reais, 2);
            Console.WriteLine("Você tem R$ " + reais + " reais.");
            Console.ReadKey();
        }
        static void Main9(string[] args)
        {
            Console.WriteLine("Digite o valor que foi depositado: ");
            double valor = double.Parse(Console.ReadLine());
            double rend = valor * 0.7 + valor;
            rend = Math.Round(rend, 2);
            Console.WriteLine("O valor apos um mês é: " + rend);
            Console.ReadKey();

        }
        static void Main10(string[] args)
        {
            Console.Write("Digite o valor total das compras: R$ ");
            double total = double.Parse(Console.ReadLine());
            total = (double)total / 5;
            Console.WriteLine("O valor das prestações ficaram: 5x R$ " + total);
            Console.ReadKey();
        }
        static void Main11 (string[] args)
        {
            Console.Write("Digite o percentual de acrescimo: ");
            double pc = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de custo do produto: ");
            double valor = double.Parse(Console.ReadLine());
            valor = (valor * pc) / 100 + valor;
            valor = Math.Round(valor, 2);
            Console.WriteLine("O valor de venda do produto ficou: R$ " + valor);
            Console.ReadKey();
        }
        static void Main12 (string[] args)
        {
            Console.Write("Digite o custo de fabrica do automovel: ");
            double precoCusto = double.Parse(Console.ReadLine());
            double total = precoCusto * 0.28 + precoCusto;
            total = total * 0.45 + total;
            Console.WriteLine("O preço total a pagar é: R$ " + total);
            Console.ReadKey();

        }
        static void Main13 (string[] args)
        {
            string palavra1 = "Curso ";
            string palavra2 = "NDDigital ";
            string palavra3 = "Beginner ";
            int palavra4 = 2014;
            Console.WriteLine(palavra1 + palavra2 + palavra3 + palavra4);
            Console.ReadKey();
        }
        static void Main14 (string[] args)
        {
            Console.Write("Digite um numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            double num2 = double.Parse(Console.ReadLine());
            bool resp = false;
            if (num1 > num2)
            {
                resp = true;
            }
            Console.WriteLine(!resp);
            Console.ReadKey();
        }
        static void Main15 (string[] args)
        {
            int i = 0;
            string[] nomes = new string[15]; // declarar vetor;
            Console.Write("Digite o nome do instrutor: ");
            nomes[0] = Console.ReadLine();
            Console.Write("Digite o nome dos alunos: ");
            for (i = 1; i <= 14; i++)
            {
                nomes[i] = Console.ReadLine();
            }
            Console.Clear(); //limpatela;
            for (i = 14; i >= 0; i--)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.ReadKey();

        }
        static void Main16(string[] args)
        {
            Console.Write("Digite um numero inteiro e positivo para A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Digite um numero inteiro e positivo para B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Digite um numero inteiro e positivo para C: ");
            double C = double.Parse(Console.ReadLine());
            double R = A + B;
            R = Math.Pow(R, 2);
            double S = B + C;
            S = Math.Pow(S,2);
            double D = (R + S) / 2;
            Console.WriteLine("O resultado da expressão D = ((A+B)²)+(B+C)²)/2  é: " + D);
            Console.ReadKey();
        }



    }
}
