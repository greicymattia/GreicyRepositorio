using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medindo_a_Febre
{    

    class Medindo_a_Febre_UnidadesIXeX
    {
        public static int[] idade = new int[50];
        public static string[] nome = new string[50];
        public static char[] sexo = new char[50];
        public static double[] altura = new double[50];
        public static bool[] maioridade = new bool[50];
        static void Name()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Digite o nome da pessoa {0}: ", i + 1);
                nome[i] = Console.ReadLine();
            }
        }
        static void aleatorio()
        {
            int x = 0;
            Random gerador = new Random();
            for (int i = 0; i < 50; i++)
            {
                idade[i] = gerador.Next(0, 91);
                maioridade[i] = (idade[i] >= 21) ? true : false;
                altura[i] = gerador.NextDouble();
                altura[i] += 1;
                x = gerador.Next(0, 2);
                if (x == 0)
                {
                    sexo[i] = 'F';
                }
                else
                {
                    sexo[i] = 'M';
                }                
            }
        }
        static double adultos (){
            int ad = 0;
            for (int i = 0; i < 50; i++)
            {
                ad += (maioridade[i] == true) ? 1 : 0;
            }
            double porcento = (100 * ad) / 50;
            return porcento;
        }
        static double altos()
        {
            int alt = 0;
            for (int i = 0; i < 50; i++)
            {
                alt += (altura[i] > 1.7) ? 1 : 0;
            }
            double porcento = (100 * alt) / 50;
            return porcento;
        }
        static double mulher()
        {
            int fem = 0;
            for (int i = 0; i < 50; i++)
            {
                fem += (sexo[i] == 'F') ? 1 : 0;
            }
            double porcento = (100 * fem) / 50;
            return porcento;
        }
        static void maisAlt()
        {
            int posicao = 0;
            for (int i = 1; i < 50; i++)
            {
                posicao = (altura[i] > altura[posicao]) ? i : posicao;
            }
            Console.WriteLine("Pessoa mais alta...");
            Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}, Altura: {4:F2}",nome[posicao],idade[posicao],sexo[posicao],maioridade[posicao],altura[posicao]);
        }
        static void maisBaixo()
        {
            int posicao = 0;
            for (int i = 1; i < 50; i++)
            {
                posicao = (altura[i] < altura[posicao]) ? i : posicao;
            }
            Console.WriteLine("\nPessoa mais baixa...");
            Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}, Altura: {4:F2}", nome[posicao], idade[posicao], sexo[posicao], maioridade[posicao],altura[posicao]);
        }
        static void velhos()
        {
            int[] poscicao = new int[10];
            for (int i = 0; i < 50; i++)
            {
                for (int i = 1; j < 50; j++)
                {
                    if (idade[j] < idade[i])
                    {
                        int aux = idade[j];
                        idade[j] = idade[i];
                        idade[i] = aux;

                        string aux1 = nome[j];
                        nome[j] = nome[i];
                        nome[i] = aux1;

                        double aux2 = altura[j];
                        altura[j] = altura[i];
                        altura[i] = aux2;

                        char aux3 = sexo[j];
                        sexo[j] = sexo[i];
                        sexo[i] = aux3;

                        bool aux4 = maioridade[j];
                        maioridade[j] = maioridade[i];
                        maioridade[i] = aux4;
                    }
                }
            }
            Console.WriteLine("\n\nOs 10 mais velhos são: ");
            for (int i = 9; i >=0; i--)
            {
                Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}, Altura: {4:F2}", nome[i], idade[i], sexo[i], maioridade[i],altura[i]);
            }
            Console.WriteLine("\n\nOs 5 mais novos são: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}, Altura: {4:F2}", nome[i], idade[i], sexo[i], maioridade[i],altura[i]);
            }
        }
        static void Main(string[] args)
        {
            Name();
            Console.Clear();
            aleatorio();
            double porcAdult = adultos();
            double porcNAdult = 100 - porcAdult;
            double porcAltos = altos();
            //double porcBaixos = 100 - porcAltos;
            double sexoF = mulher();
            double sexoM = 100 - sexoF;
            maisAlt();
            maisBaixo();
            Console.WriteLine("\n\nPorcentagem de pessoas que são adultos: {0:F2}%",porcAdult);
            Console.WriteLine("Porcentagem de pessoas que não são adultos: {0:F2}%", porcNAdult);
            Console.WriteLine("Porcentagem de pessoas do sexo Feminino: {0:F2}%", sexoF);
            Console.WriteLine("Porcentagem de pessoas do sexo Masculino: {0:F2}%", sexoM);
            Console.WriteLine("Porcentagem de pessoas mais altas que 1,70: {0:F2}%\n\n", porcAltos);
            for (int i = 0; i < 50; i++) {
                Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: '{2}', Adulto: {3}", nome[i], idade[i], sexo[i], maioridade[i]);
            }
            velhos();
            Console.ReadKey();
        }
        
    }
}
