using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class Complementar_UnidadeX
    {
        public static int ano = 0;
        public static string a = null;
        public static int condicao = 0;
        public static int dia = 0;
        public static int mes = 0;
        public static int maior = 0;
        public static int menor = 0;
        public static double media = 0;
        public static int[] pessoas = new int[20];
        public static int res = 0;
        static void verificaano()
        {
            if (ano % 400 == 0)
            {
                Console.WriteLine("Ano bissexto!");
            }
            else if (ano % 100 == 0)
            {
                Console.WriteLine("Ano bissexto!");
            }
            else if (ano % 4 == 0)
            {
                Console.WriteLine("Ano bissexto!");
            }
            else
            {
                Console.WriteLine("Não é um ano bissexto!");
            }
            Console.ReadKey();
        }
        static void Main1(string[] args)
        {
            Console.Write("Digite um ano para verificar se é bissexto: ");
            ano = int.Parse(Console.ReadLine());
            verificaano();            
        }
        static void Ano()
        {
            do
            {
                Console.Write("Digite o ano: ");
                ano = int.Parse(Console.ReadLine());
                a = Convert.ToString(ano);
                if (a.Length != 4)
                {
                    Console.WriteLine("Ano invalido... Digite novamente!");
                }
            } while (a.Length != 4);
            if (ano % 400 == 0)
            {
                condicao = 1;
            }
            else if (ano % 100 == 0)
            {
                condicao = 1;
            }
            else if (ano % 4 == 0)
            {
                condicao = 1;
            }            
        }
        static void Mes()
        {
            do
            {
                Console.Write("Digite o mês: ");
                mes = int.Parse(Console.ReadLine());
                if (mes < 1 || mes > 12)
                {
                    Console.WriteLine("Mês invalido... Digite novamente!");
                }
            } while (mes < 1 || mes > 12);
        }
        static void Dia()
        {
            if (mes == 2)
            {
                if (condicao == 1)
                {
                    do
                    {
                        Console.Write("Digite o dia: ");
                        dia = int.Parse(Console.ReadLine());
                        if (dia > 29 || dia < 1)
                        {
                            Console.WriteLine("Dia invalido... Digite novamente!");
                        }
                    } while (dia > 29 || dia < 1);
                }
                else
                {
                    do
                    {
                        Console.Write("Digite o dia: ");
                        dia = int.Parse(Console.ReadLine());
                        if (dia > 28 || dia < 1)
                        {
                            Console.WriteLine("Dia invalido... Digite novamente!");
                        }
                    } while (dia > 28 || dia < 1);
                }
            }
            else if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                do
                {
                    Console.Write("Digite o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia > 31 || dia < 1)
                    {
                        Console.WriteLine("Dia invalido... Digite novamente!");
                    }
                } while (dia > 31 || dia < 1);
            }
            else
            {
                do
                {
                    Console.Write("Digite o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia > 30 || dia < 1)
                    {
                        Console.WriteLine("Dia invalido... Digite novamente!");
                    }
                } while (dia > 30 || dia < 1);
            }
        }
        static void Main2(string[] args)
        {                                  
            ano = 0;
            Console.WriteLine("Digite uma data...");
            Ano();
            Mes();
            Dia();                                    
            Console.Clear();
            Console.WriteLine("Data valida! {0}/{1}/{2}",dia, mes, ano);
            Console.ReadKey();
        }
        static void MaiorIdade(){
            for(int i = 0; i<20; i++){
                if( i == 0){
                    maior = pessoas[i];                                     
                }else{
                    maior = (pessoas[i] > maior) ? pessoas[i] : maior;
                }
            }
            Console.WriteLine("Maior idade: {0}", maior);
        }
        static void MenorIdade()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i == 0)
                {
                    menor = pessoas[i];
                }
                else
                {
                    menor = (pessoas[i] < menor) ? pessoas[i] : menor;
                }
            }
            Console.WriteLine("Menor idade: {0}", menor);
        }
        static void Media()
        {
            for (int i = 0; i < 20; i++)
            {
                media += pessoas[i];
            }
            media /= 20;
            Console.WriteLine("Média das idades: {0:F2}", media);
        }
        static void Main3(string[] args)
        {
            Console.WriteLine("Digite a idade das 20 pessoas...");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Pessoas {0}: ", i + 1);
                pessoas[i] = int.Parse(Console.ReadLine());                
            }
            MaiorIdade();
            MenorIdade();
            Media();
            Console.ReadKey();
        }
        static int tabuada(int y,int x)
        {          
                return y * x;            
        }
        static void Main4(string[] args)
        {
            Console.Write("Digite qual o numero da tabua: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",i,x,tabuada(x,i));
            }
            Console.ReadKey();
        }
    }
}
