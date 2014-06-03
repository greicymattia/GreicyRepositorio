using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class UnidadeXI
    {
        static int MaiorElemento(double[] array)
        {
            int maior = 0;            
            for (int i = 1; i < array.Length; i++)
            {
                maior = (array[i] > array[maior]) ? i : maior;
            }
            return maior;
        }
        static int MenorElemento(double[] array)
        {
            int menor = 0;
            for (int i = 1; i < array.Length; i++)
            {
                menor = (array[i] < array[menor]) ? i : menor;
            }
                return menor;
        }
        static void Main(string[] args)
        {
            double[] vetor = new double[10];
            Console.WriteLine("Digite 10 valores...");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
            }
            double Maior = MaiorElemento(vetor);
            Console.WriteLine("Maior numero: {0}", Maior);
            Console.ReadKey();

        }
    }
}
