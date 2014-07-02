using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    //EXERCICIO FIXAÇÃO UNIDADE IX

    //1)	Na pasta arrays, crie um arquivo chamado SequenciaQualquer.cs. Implemente um programa em C# que armazene 10 números inteiros em um array. Todas as posições do array devem ser preenchidas e o valor armazenado fica à sua escolha. Após preencher o array, exiba os seus valores no terminal.

    //2)	Na pasta arrays, crie um arquivo chamado SequenciaCrescente.cs. Implemente um programa em C# que armazene 10 números inteiros em um array. Preencha todas as posições do array com valores sequenciais. Ao final, exiba no terminal esses valores.

    //3)	Na pasta arrays, crie um arquivo chamado SequenciaDecrescente.cs. Implemente um programa em C# que armazene 10 números inteiros em um array. Preencha todas as posições do array com valores sequenciais descrescentes. Ao final, exiba no terminal esses valores.

    class ArrayList_ou_List
    {
        static void Main1(string[] args)
        {
            //SEQUENCIA QUALQUER
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um numero inteiro para a posicao {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Vetor... ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetor[i] + "\t");
            }
            Console.ReadKey();
        }
        //ARRAYLIST
        static void Main12(string[] args)
        {
            ArrayList vetor = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um numero inteiro para a posicao {0}: ", i + 1);
                vetor.Add(int.Parse(Console.ReadLine()));
            }
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetor[i]+"\t");
            }
            Console.ReadKey();


        }
        //--------------------------------------------------

        //arraylist
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
                Console.Write("{0}  ", vetor[i]);
            }
            Console.ReadKey();
        }

        static void Main21(string[] args)
        {
            //SEQUENCIA CRESCENTE
            ArrayList vetor = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                vetor.Add(i+5);              
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", vetor[i]);
            }
            Console.ReadKey();
        }

        //----------------------------------------------------

        static void Main3(string[] args)
        {
            //SEQUENCIA DECRESCENTE
            int[] vetor = new int[10];
            for (int i = 9; i >= 0; i--)
            {
                vetor[i] = i - 1;
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.Write("{0}  ", vetor[i]);
            }
            Console.ReadKey();
        }
        //ARRAYLIST
        static void Main31(string[] args)
        {
            //SEQUENCIA DECRESCENTE
            ArrayList vetor = new ArrayList();
            for (int i = 9; i >= 0; i--)
            {
                vetor.Add(i - 1);
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.Write("{0}  ", vetor[i]);
            }
            Console.ReadKey();
        }
    }
}
