using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class Complemetar_UnidadeIX
    {
        static void Main1(string[] args)
        {
            int[] questoes = new int[10];
            Random gerador = new Random();
            int num =0;
            for (int i = 0; i < 10; i++)
            {                
                    num = gerador.Next(1, 4);
                    questoes[i] = num;
                    Console.Write("Questão: {0} \t Alternativa: {1}\n\n",i+1,questoes[i]);             
            }
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            string[,] vagas = new string[4, 10];
            Random gerador = new Random();
            int situacao = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\n\n~~~~~~~~~~ Andar: {0} ~~~~~~~~~~\n",i+1);
                for (int j = 0; j < 10; j++)
                {
                    situacao = gerador.Next(0, 2);
                    if (situacao == 0)
                    {
                        vagas[i, j] = "Livre";
                    }
                    else
                    {
                        vagas[i, j] = "Ocupado";
                    }
                    Console.Write("Vaga {0}: {1}\n\n",j+1,vagas[i,j]);
                }
            }
            Console.ReadKey();
        }
        static void Main3(string[] args)
        {
            int menor = 0;
            int posicao = 0;
            int[] vetor = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Digite um numero inteiro: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    menor = vetor[i];
                    posicao = i;
                }
                else if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao = i;
                }
            }
            Console.Clear();
            Console.Write("Menor numero: {0} \t Posição: {1}", menor, posicao+1);
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            int[] vetor1 = new int[12];
            int[] vetor2 = new int[12];
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Digite um numero inteiro: ");
                vetor1[i] = int.Parse(Console.ReadLine());
                if (vetor1[i] == 0)
                {
                    vetor2[i] = 1;
                }
                else
                {
                    vetor2[i] = vetor1[i];
                }
            }
            Console.Clear();
            Console.WriteLine("Vetor Original: ");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("{0}  ",vetor1[i]);
            }
            Console.WriteLine("\n\nNovo Vetor: ");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("{0}  ", vetor2[i]);
            }
            Console.ReadKey();
        }
        static void Main5(string[] args)
        {
            int alunos = 20;
            char[] gabarito = new char[10];
            char[,] respostas = new char[alunos, 10];
            int[] acertos = new int[alunos];
            Console.WriteLine("Digite o gabarito da prova: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Quantão {0}: ", i + 1);
                gabarito[i] = char.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < alunos; i++)
            {
                Console.WriteLine("Digite as alternativas do aluno {0}",i+1);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("Questão {0}: ", j + 1);
                    respostas[i, j] = char.Parse(Console.ReadLine());
                    if (respostas[i, j] == gabarito[j])
                    {
                        acertos[i] += 1;
                    }

                }
            }
            Console.Clear();
            Console.WriteLine("Gabarito: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Questão {0}: {1}", i + 1, gabarito[i]);
            }
            for (int i = 0; i < alunos; i++)
            {
                 Console.WriteLine("\n\nAluno {0} \t Acertos: {1} \t Nota: {2}", i + 1, acertos[i],acertos[i]);
                 if (acertos[i] >= 6)
                 {
                     Console.WriteLine("APROVADO!");
                 }
                 else
                 {
                     Console.WriteLine("REPROVADO!");
                 }
            }
                Console.ReadKey();
        }
        static void Main6(string[] args)
        {             
            int[] retirados = new int[50];
            int[] promocao = new int[50];
            Random gerador = new Random();
            int num = 0;
            for (int i = 0; i < 50; i++)
            {
                num = gerador.Next(1, 100);
                retirados[i] = num;                
                int res = retirados[i]/10;
                promocao[i] = res;
            }
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Cliente :{0}\tFilmes Retirados: {1}\tDireito à promoção: {2}\n\n", i + 1,retirados[i],promocao[i]);               
            }
            Console.ReadKey();
        }
        static void Main7(string[] args)
        {
            int[] A = new int[50];
            int[] B = new int[50];
            int soma = 0;
            Random gerador = new Random();
            int num = 0;           
            Console.WriteLine(" A    B");
            for (int i = 0; i < 50; i++)
            {
                num = gerador.Next(0,101);
                A[i] = num;
                num = gerador.Next(0,101);
                B[i] = num;
                Console.WriteLine("{0}    {1}", A[i], B[i]);
            }
            for (int i = 0; i < 50; i++)
            {
                for (int j = 49; j >= 0; j--)
                {
                    soma -= B[j] - A[i];
                }
            }
            Console.WriteLine("\n\nSoma: {0}",soma);
            Console.ReadKey();
        }
        static void Main8(string[] args)
        {
            int num = 6;            
            int[,] gabarito = new int[13,3];
            int[,] resposta = new int[13, 3];
            int[] acertos = new int[num];
            int[] cartao = new int[num];
            Random gerador = new Random();
            Console.WriteLine("Digite o gabarito (0 p/ vazio ou 1 p/ preenchido): ");
            for (int i = 0; i < 13; i++)
            {
                Console.Write("Linha: {0}  ", i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Coluna: {0}", j);
                    gabarito[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int i = 0; i < num; i++)
            {
                
                Console.WriteLine("Digite o numero do cartão do apostador {0}: ", i + 1);
                cartao[i] = int.Parse(Console.ReadLine());
                Console.Clear();
                for (int j = 0; j < 13; j++)
                {
                    Console.Write("\nLinha {0}",j+1);
                    for (int y = 0; y < 3; y++)
                    {
                        Console.WriteLine("  Coluna {0}",y+1);
                        resposta[i, j] = int.Parse(Console.ReadLine());
                        if (resposta[i, j] == gabarito[i, j])
                        {
                            acertos[i] += 1;
                        }

                    }
                }
                Console.Clear();
            }
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("");
            }
        }
    }
}
