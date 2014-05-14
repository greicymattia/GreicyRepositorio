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
        static void Main(string[] args)
        {
            string asterisco = "**********";
            string[] espaco = new string[1];
            espaco[0] = " ";
            int i = 0;
            int j = 0;
            for (i = 0; i < 5;i++ )
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(espaco[0]);
                }
            }

        }
    }
}
