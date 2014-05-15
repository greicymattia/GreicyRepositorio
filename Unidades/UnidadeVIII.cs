using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class UnidadeVIII
    {
        static void Main1(string[] args)
        {
            Random gerador = new Random();
            int PRIMEIRO = gerador.Next();
            int SEGUNDO = gerador.Next();
            if (PRIMEIRO > SEGUNDO)
            {
                Console.WriteLine("PRIMEIRO > SEGUNDO\n{0} > {1}",PRIMEIRO,SEGUNDO);
            }else if(SEGUNDO>PRIMEIRO){
                Console.WriteLine("SEGUNDO>PRIMEIRO\n{0} > {1}",SEGUNDO,PRIMEIRO);
            }else{
                Console.WriteLine("PRIMEIRO = SEGUNDO\n{0} = {1}",PRIMEIRO,SEGUNDO);
            }
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            string asterisco = "**********";
            string espaco = null;            
            int i = 0;
            int j = 0;
            for (i = 0; i < 3;i++ )
            {
                for (j = 0; j < 5; j++)
                {
                    if (j == 0){
                     espaco = null;
                    }
                    else if (j == 1)
                    {
                        espaco = " ";
                    }
                    else if (j == 2)
                    {
                        espaco = "  ";
                    }else if(j == 3){
                        espaco = "   ";
                    }
                    else
                    {
                        espaco = "    ";
                    }
                    Console.WriteLine("{0}{1}",espaco,asterisco);
                }
            }
            Console.ReadKey();
        }
        static void Main3(string[] args)
        {
            int i,j,z = 0;
            int bloco = 0;
            int andar = 0;
            int apartamento = 0;
            for (i = 1; i < 4; i++)
            {
                Console.WriteLine("\n");
                bloco = i;
                Console.WriteLine("****Bloco: {0}****", bloco);
                for (j = 1; j < 10; j++)
                {                    
                    andar = j;
                    Console.WriteLine("--Andar: {0}--", andar);
                    for (z = 1; z < 5;z++ )
                    {                        
                        apartamento = z + (10*j);
                        Console.WriteLine("Apartamento: {0}",apartamento);                        
                    }
                }                
            }
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            int i, j = 0;
            for (i = 1; i < 11; i++)
            {
                for (j = 0; j < 11; j++)
                {
                    Console.WriteLine("{0}x{1} = {2}",i,j,i*j);
                }
                Console.WriteLine("\t");
            }
            Console.ReadKey();
        }
        static void Main5(string[] args)
        {
            Random gerador = new Random();
            int dado = 0;
            int i = 0;
            int cont = 0;
            int soma = 0;
            for (i = 0; i < 10; i++)
            {
                dado = gerador.Next(1, 7);
                Console.WriteLine("Dado: " + dado);
                if (dado == 1)
                {
                    continue;
                }
                else if (dado == 6)
                {
                    cont += 1;
                    if (cont == 2)
                    {
                        break;
                    }
                }                
                soma += dado;               
            }
            if (cont == 2)
            {
                Console.WriteLine("Você perdeu, pois tirou duas vezes o numero 6 no dado!");
            }
            else if (soma % 2 != 0)
            {
                Console.WriteLine("Você venceu, soma = {0}", soma);
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }
            Console.ReadKey();
        }
        static void Main6(string[] args)
        {
            Random gerador = new Random();
            int numero = gerador.Next(0,99999999);
            string num = numero.ToString();
            bool resultado = num.Contains("1");
            if (resultado == true)
            {
                Console.WriteLine();
            }
        }
    }
}
