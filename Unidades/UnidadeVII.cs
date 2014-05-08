using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class UnidadeVII
    {
        static void Main1(string[] args)
        {
            int i = 0;
            int[] codigo = new int[15];
            double[] preco = new double[15];
            double media = 0;
            double maior = 0;
            int codMaior = 0;
            for (i = 0; i < 15; i++)
            {
                Console.Write("\nDigite o código do produto {0}: ", i + 1);
                codigo[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite o preço do produto {0}: ", i + 1);
                preco[i] = double.Parse(Console.ReadLine());
                media += preco[i];                              
                maior = preco[i]>maior ? preco[i] : maior;                                                      
            }
            Console.Clear();
            media /= 3;
            Console.WriteLine("O maior preço foi do código {0}: R$ {1:F2}", codMaior, maior);
            Console.WriteLine("Média aritmética dos preços dos produtos: R$ {0:F2}", media);
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            double salario = 0;
            double salarioMaior = 0;
            double mediaSalario = 0;
            double mediaFilhos = 0;
            int totalPessoas = 0;
            int salarioMenor = 0;
            double percentual = 0;
            double filhos = 0;
            do{
                Console.Write("Digite o salário: ");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0)
                {
                    Console.Clear();
                    break;
                }
                salarioMaior = salario > salarioMaior ? salario : salarioMaior;
                Console.Write("Digite a quantidade de filhos: ");
                filhos = int.Parse(Console.ReadLine());
                mediaSalario = salario > 0 ? mediaSalario + salario : mediaSalario;
                totalPessoas = salario >= 0 ? totalPessoas + 1 : totalPessoas;
                salarioMenor = salario < 150 && 0 <= salario ? salarioMenor + 1 : salarioMenor;
                mediaFilhos += filhos;
                Console.Clear();
                Console.WriteLine("\t\t(Para terminar a coleta de dados digite um salário negativo!)\n");
                Console.ReadKey();
            }while(salario>=0);
            if (totalPessoas > 0)
            {
                mediaSalario /= totalPessoas;
                mediaFilhos /= totalPessoas;
                percentual = (salarioMenor * 100) / totalPessoas;
                Console.WriteLine("Média Salário da população: R$ {0:F2}", mediaSalario);
                Console.WriteLine("Média Filhos da população: {0:F1}", mediaFilhos);
                Console.WriteLine("Maior Sálario entre os habitantes: R$ {0:F2}", salarioMaior);
                Console.WriteLine("Percentual de pessas com salário menor que R$ 150,00: {0:F2}%", percentual); ;
                Console.ReadKey();
            }
        }
        static void Main3(string[] args)
        {
            Console.WriteLine("Digite a quantidade total de mercadorias: ");
            int total = int.Parse(Console.ReadLine());
            int i = 0;
            double preco = 0;
            double media = 0;
            for (i = 0; i < total; i++)
            {
                Console.Write("Digite o valor da mercadoria {0}: ", i + 1);
                preco = double.Parse(Console.ReadLine());
                media += preco;               
            }            
            Console.WriteLine("Média de valores das mercadorias: {0:F2}",media/total);
            Console.WriteLine("Valor total em estoque: {0:F2}",media);
            Console.WriteLine("Quantidade {0}: ", total);
            Console.ReadKey();

        }
    }
}
