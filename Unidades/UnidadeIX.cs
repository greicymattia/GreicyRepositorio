using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class UnidadeIX
    {
        static void Main1(string[] args)
        {
            //SEQUENCIA QUALQUER
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um numero inteiro para a posicao {0}: ",i+1);
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Vetor... ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetor[i]+"\t");
            }
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            //SEQUENCIA CRESCENTE
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = i + 5;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ",vetor[i]);
            }
            Console.ReadKey();
        }
        static void Main3(string[] args)
        {
            //SEQUENCIA DECRESCENTE
            int[] vetor = new int[10];
            for(int i =9; i>=0; i--){
                vetor[i] = i-1;
            }
            for (int i = 9; i >=0; i--)
            {
                Console.Write("{0}  ",vetor[i]);
            }
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            //SEQUENCIA IMPAR
            int[] vetorimpar = {1,3, 5,7,9,11,13,15,17,19};
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", vetorimpar[i]);
            }
            Console.ReadKey();
        }
        static void Main5(string[] args)
        {
            //SEQUENCIA ALEATORIA
            Random gerador = new Random();
            int[] vetor = new int[10];
            int num = 0;
            for (int i = 0; i < 10; i++)
            {
               num = gerador.Next(1, 11);
                vetor[i] = num;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", vetor[i]);
            }
            Console.ReadKey();
        }
        static void Main6(string[] args)
        { 
            //TABELA QUALQUER
            int[,] matriz = new int[10,10];
            for(int i = 0; i<10;i++){
                for(int j =0; j<10; j++){
                    matriz[i,j] = i-j;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0}  ", matriz[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        static void Main7(string[] args)
        {
            //TABELA ALEATORIA
            Random gerador = new Random();
            int num = 0;
            int[,] matriz = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    num = gerador.Next(0, 10);
                    matriz[i, j] = num;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0}  ", matriz[i, j]);
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();
        }
        static void Main8(string[] args)
        {
            //TABUADA
            int[,] tabuada = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuada[i, j] = (i+1) * (j+1);
                    Console.WriteLine("{0} x {1} = {2}",i+1,j+1,tabuada[i,j]);
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();
        }
    }
}
