using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class UnidadeVII
    {
        static void Main(string[] args)
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
    }
}
