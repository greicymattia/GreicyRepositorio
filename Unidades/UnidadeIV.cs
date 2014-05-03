using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class UnidadeIV
    {
        static void Main1(string[] args)
        {
            string[] vetor = new string[10];
            int i = 0;
            Console.WriteLine("Digite 10 elementos:");
            for (i=0; i<10; i++){
                vetor[i] = Console.ReadLine();
            }
            Console.Clear();
            i=9;
            do
            {
                Console.WriteLine(vetor[i]);
                i--;
            } while (i >= 0);
            Console.ReadKey();
        }
        static void Main2 (string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            Console.WriteLine("Digite 10 valores...");
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                vet1[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                if (vet1[i] < 0)
                {
                    vet2[i] = 1;
                }
                else
                {
                    vet2[i] = vet1[i];
                }
            }
            Console.ReadKey();
            Console.Clear();
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(vet2[i]);
            }
            Console.ReadKey();
        }
        static void Main3(string[] args)
        {
            int[,] mat1 = new int[3, 4];
            int[,] mat2 = new int[3, 4];
            int i = 0;
            int j = 0;
            Console.WriteLine("Digite 12 numeros inteiros: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    mat1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.ReadKey();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (mat1[i, j] < 0)
                    {
                        mat2[i, j] = 0;
                    }
                    else
                    {
                        mat2[i, j] = mat1[i, j];
                    }
                }
            }
            Console.Clear();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(mat1[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(mat2[i, j]+"\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            int[] vet = new int[20];
            int i = 0;
            int cont = 0;
            Console.WriteLine("Digite 20 numeros inteiros... ");
            for (i = 0; i < 20; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] % 2 == 0)
                {
                    cont = cont + 1;
                }
            }
            Console.Clear();
            Console.WriteLine(cont + " numeros são pares.");
            Console.ReadKey();
        }
        static void Main5(string[] args)
        {
            double[] vet = new double[50];
            int i = 0;
            Console.WriteLine("Digite 50 numeros...");
            for (i = 0; i < 50; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("0 - interrompe;");
            Console.WriteLine("1 - apresenta o vetor na ordem direta;");
            Console.WriteLine("2 - apresenta o vetor na ordem inversa;");
            Console.Write("Escolha uma opção: ");
            int resp = int.Parse(Console.ReadLine());
            Console.Clear();
            if (resp == 1)
            {
                for (i = 0; i < 50; i++)
                {
                    Console.WriteLine(vet[i]);
                }
                Console.ReadKey();
            }
            else
            {
                if (resp == 2)
                {
                    i = 49;
                    do
                    {
                        Console.WriteLine(vet[i]);
                        i--;
                    } while (i >= 0);
                    Console.ReadKey();
                }
            } 
        }
        static void Main6(string[] args)
        {
            string[,] nomes = new string[3, 5];
            int i = 0;
            int j = 0;
            Console.WriteLine("Digite os nomes...");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    nomes[i, j] = Console.ReadLine();
                }
            }
        }
        
    }
}
