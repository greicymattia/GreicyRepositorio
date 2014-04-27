using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVI_continuacao_3
{
    class UnidadeVI
    {
        static void Main8(string[] args)
        {
            string[] nome = new string[3];
            double[] vendas = new double[3];
            double[] comissao = new double[3];
            double total = 0;
            int i = 0;
            for (i = 0; i < 3; i++)
            {
                int j = i + 1;
                Console.Write("Digite o nome do vendedor " + j+":");
                nome[i] = Console.ReadLine();
                Console.Write("Valor de suas vendas: ");
                vendas[i] = double.Parse(Console.ReadLine());
                if (vendas[i] > 50000)
                {
                    comissao[i] = vendas[i] * 0.12;
                }
                else if (vendas[i] >= 30000)
                    {
                        comissao[i] = vendas[i] * 0.095;
                    }
                    else
                    {
                        comissao[i] = vendas[i] * 0.07;
                    }
                total = total + vendas[i];
            }
            Console.Clear();
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("Vendas: R$ " + vendas[i]);
                Console.WriteLine("Comissão: R$ " + comissao[i] +"\n");
                if (i == 2)
                {
                    Console.WriteLine("Total de vendas: R$ " + total);
                }
                Console.ReadKey();
            }
        }
        static void Main9(string[] args)
        {
            Console.Write("Digite um valor para A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor para B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor para C: ");
            double C = double.Parse(Console.ReadLine());
            double soma = A + B;
            if (soma > C)
            {
                Console.WriteLine("Soma de A e B maior que C!");
            }
            else if (soma == C)
            {
                Console.WriteLine("Soma de A e B igual a C!");
            }
            else
            {
                Console.WriteLine("Soma de A e B menor que C!");
            }
            Console.ReadKey();
        }
        static void Main10(string[] args)
        {
            string[] nome = new string[4];
            double[] preco = new double[4];
            double[] desc = new double[4];
            int i = 0;
            double total = 0;
            for (i = 0; i < 4; i++)
            {
                int j = i+1;
                Console.Write("Digite o nome do artigo " + j + ": ");
                nome[i] = Console.ReadLine();
                Console.Write("Digite o preço do artigo " + j + ": ");
                preco[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite o percentual de desconto do artigo "+j+": ");
                desc[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                desc[i] = preco[i] - ((preco[i] * desc[i]) / 100);
                total = total + desc[i];
            }
            Console.Clear();
            for(i=0; i<4;i++)
            {
                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("Preço: R$" + preco[i]);
                Console.WriteLine("Valor com desconto: R$" + desc[i]+"\n");
            }
            Console.WriteLine("Total a pagar: R$" + total);
            Console.ReadKey();
            

        }
    }
}
