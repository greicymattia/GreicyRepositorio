using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class Complementar_UnidadeXI
    {
        static void Main1(string[] args)
        {
            int[] aposta = new int[6];
            int acertos = 0;          
            Random gerador = new Random();
            int[] sorteios = new int[6];
            Console.WriteLine("Digite 6 numeros para a sua aposta de 0 a 60");
            for (int i = 0; i < 6; i++)
            {
                sorteios[i] = gerador.Next(0, 61);                
            }
            for (int j = 0; j < 6; j++)
            {                
                do{
                    aposta[j] = int.Parse(Console.ReadLine());
                    if (aposta[j] > 60 || aposta[j] < 0)
                    {
                        Console.WriteLine("Digite novamente entre um intervalo de 0 a 60: ");
                    }
                }while(aposta[j] >60 || aposta[j] <0);
                for (int i = 0; i < 6; i++)
                {
                    if (aposta[j] == sorteios[i])
                    {
                        acertos += 1;
                    }                    
                }                    
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if(sorteios[i]>sorteios[j]){
                        int menor = sorteios[i];
                        sorteios[i] = sorteios[j];
                        sorteios[j] = menor;
                    }
                }
            }          
            Console.WriteLine("Voce acertou: {0} numeros.", acertos);
            if (acertos >= 5)
            {
                Console.WriteLine("Você ganhou a quina!");
            }
            Console.WriteLine("Numeros sorteados: ");

            for (int i = 5; i >=0; i--)
            {
                Console.Write("{0}   ",sorteios[i]);
            }
            Console.ReadKey();
        }      
    }
}
