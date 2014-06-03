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
        static double SomaElementos(double[] array)
        {
            double soma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }
                return soma;
        }
        static double MediaElementos(double[] array)
        {
            double media = SomaElementos(array);
            media /= array.Length;
            return media;
        }
        static void Troca(int i, int j, double[] array)
        {
            double aux = array[i];
            array[i] = array[j];
            array[j] = aux;

        }
        static void Ordenar(double[] array)
        {
            for (int j = 1; j<array.Length; j++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int menor = (array[i] < array[j]) ? i : j;
                    Troca(menor, j, array);
                }
            }
        }
        static void Main1(string[] args)
        {
            double[] vetor = new double[10];
            Console.WriteLine("Digite 10 valores...");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
            }
            int Maior = MaiorElemento(vetor);
            Console.WriteLine("Maior numero: {0}", vetor[Maior]);
            Console.ReadKey();
            int Menor = MenorElemento(vetor);
            Console.WriteLine("Menor numero: {0}", vetor[Menor]);
            Console.ReadKey();
            double Soma = SomaElementos(vetor);
            Console.WriteLine("Soma dos elementos: {0}", Soma);
            Console.ReadKey();
            double Media = MediaElementos(vetor);
            Console.WriteLine("Media dos elementos: {0:F2}", Media);
            Console.ReadKey();
            Ordenar(vetor);
            Console.WriteLine("Vetor ordenado: \n");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();
        }
    }
}
