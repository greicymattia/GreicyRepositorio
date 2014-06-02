using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class UnidadeX
    {
        public static double valor = 0;
        public static double juros =0;
        public static double M =0;
        public static int tempo = 0;
        public static double RA = 0;
        public static int filhos = 0;
        public static double desc = 0;
        public static double IR = 0;
        public static double imc = 0;
        public static double peso = 0;
        public static double altura = 0;
        public static int[] vetor = new int[10];
        static double ConsumodeCombustivel(double x, double y)
        {            
            return y/x;
        }
        static double JurosComposto()
        {
            M = valor * (tempo + (juros/100));
            return M;
        }
        static void IRPF(){
            IR = ((RA*juros)/100) - filhos * desc;            
        }
        static void IMC()
        {
            imc = peso / Math.Pow(altura, 2);
        }
        static void situacao()
        {
            if (imc < 17)
            {
                Console.WriteLine("Muito abaixo do peso do peso ideal!");
            }
            else if (imc <= 18.49)
            {
                Console.WriteLine("Abaixo do peso ideal!");
            }
            else if (imc <= 24.99)
            {
                Console.WriteLine("Peso normal!");
            }
            else if (imc < 29.99)
            {
                Console.WriteLine("Acima do peso ideal!");
            }
            else if (imc < 34.99)
            {
                Console.WriteLine("Obesidade I!");
            }
            else if(imc < 39.99)
            {
                Console.WriteLine("Obesidade II (severa)!");
            }
            else
            {
                Console.WriteLine("Obesidade III (mórbida)!");
            }
        }
        static void inscreverArrays()
        {
            Random gerador = new Random();
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = gerador.Next(0, 100);
            }
        }
        static void mostraArrays()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
        static void Main1(string[] args)
        {            
            Console.Write("Digite quantos km você andou: ");
            double dist = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de combustivel gastro (em litros): ");
            double litros = double.Parse(Console.ReadLine());
            double resp = ConsumodeCombustivel(litros,dist);
            Console.WriteLine("O consumo de combustivel é: {0:F2} l/km",resp);
            Console.ReadKey();
            Console.Clear();
            Console.Write("Digite o valor do capital: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de meses: ");
            tempo = int.Parse(Console.ReadLine());
            Console.Write("Digite o percentual de juros ao mês: ");
            juros = double.Parse(Console.ReadLine());
            JurosComposto();
            Console.WriteLine("O montante foi de: R$ {0}",M);
            Console.ReadKey();
            Console.Clear();
            Console.Write("Digite a sua renda anual: ");
            RA = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de filhos: ");
            filhos = int.Parse(Console.ReadLine());
            Console.Write("Digite o juros para o valor da renda anual: ");
            juros = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de desconto por numero de filhos: ");
            desc = double.Parse(Console.ReadLine());
            IRPF();
            Console.WriteLine("Imposto de Renda: R$ {0:F2}", IR);
            Console.ReadKey();
            Console.Clear();
            Console.Write("Digite seu peso em kg: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());
            IMC();
            situacao();
            Console.ReadKey();
            Console.Clear();
            inscreverArrays();
            mostraArrays();
            Console.ReadKey();
        }
    }
}
