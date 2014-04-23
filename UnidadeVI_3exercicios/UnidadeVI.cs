using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeVI_3exercicios
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
    }
}
