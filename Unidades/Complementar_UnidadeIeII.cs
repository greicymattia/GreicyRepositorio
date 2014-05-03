using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class Complementar_UnidadeIeII
    {
        static void Main1 (string[] args)
        {
            Console.Write("Digite um valor: ");
            double num = double.Parse(Console.ReadLine());
            num = num - 1;
            Console.WriteLine("Seu antecessor é: " + num);
            Console.ReadKey();
        }
        static void Main2 (string[] args)
        {
            Console.WriteLine("Digite a base de um triangulo: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do triangulo: ");
            double h = double.Parse(Console.ReadLine());
            double A = (b * h) / 2;
            Console.WriteLine("A área do triangulo é: " + A+" cm²");
            Console.ReadKey();
        }
        static void Main3 (string[] args)
        {
            Console.Write("Quantos anos você tem? ");
            int anos = int.Parse(Console.ReadLine());
            Console.Write("Quantos meses você tem? ");
            int meses = int.Parse(Console.ReadLine());
            Console.Write("Quantos dias você tem? ");
            int dias = int.Parse(Console.ReadLine());
            int total = anos * 365 + meses * 30 + dias;
            Console.WriteLine("Sua idade expressa em dias é: " + total);
            Console.ReadKey();
        }
        static void Main4 (string[] args)
        {
            Console.Write("Digite a quantidade total de votos validos: ");
            int valido = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de votos em branco: ");
            int branco = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de votos nulos: ");
            int nulo = int.Parse(Console.ReadLine());
            int total = valido+nulo+branco;
            double pBranco = (branco * 100) / total;
            double pNulo = (nulo * 100) / total;
            double pValido = (valido * 100) / total;
            Console.Clear();
            Console.Write(" O percentual de votos validos foi: " + pValido + "% \n O percentual de votos nulos foi: " + pNulo + "% \n O percentual de votos brancos foi: " + pBranco + "%\n De um total de " + total + " votos.");
            Console.ReadKey();

        }
        static void Main5 (string[] args)
        {
            int total = 0;
            Console.Write("Digite a hora de inicio do jogo: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite a hora de termino do jogo: ");
            int fim = int.Parse(Console.ReadLine());
            if (inicio <= fim)
            {
                total = fim - inicio;
            }
            else
            {
                total = (24-inicio) + fim;
            }
            Console.Write("A duração do jogo foi: " + total + " horas.");
            Console.ReadKey();
        }
        static void Main6 (string[] args)
        {
            double total = 0;
            Console.Write("Quantas horas o funcionario trabalhou no mes? ");
            double horas = double.Parse(Console.ReadLine());
            Console.Write("Qual o salario fixo do funcionario? ");
            double sal = double.Parse(Console.ReadLine());
            if (horas > 40) {
                horas = horas - 40;
                total = (sal * 0.5) * horas + sal;                
            }
            Console.Write("O total que o funcionario tem a receber é: R$ " + total);
            Console.ReadKey();
        }
        static void Main7 (string[] args)
        {
            Console.Write("Digite o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Digite seu saldo: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.Write("Digite seu débito: ");
            double debito = double.Parse(Console.ReadLine());
            Console.Write("Digite seu crédito: ");
            double credito = double.Parse(Console.ReadLine());
            double saldoAtual = saldo - debito + credito;
            Console.Clear();
            if (saldoAtual >= 0)
            {
                Console.Write("R$ "+saldoAtual+"; Saldo Positivo!");
            }
            else
            {
                Console.Write("R$ "+saldoAtual+"; Saldo Negativo!");
            }
            Console.ReadKey();
        }
        static void Main8 (string[] args)
        {
            Console.Write("Digite a quantidade atual em estoque: ");
            int qAtual = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade maxima: ");
            int qMax = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade minima: ");
            int qMin = int.Parse(Console.ReadLine());
            double qMed = (qMax + qMin) / 2;
            Console.Clear();
            if (qAtual >= qMed)
            {
                Console.Write("Não Efetuar Compra!");
            }
            else
            {
                Console.Write("Efetuar Compra!");
            }
            Console.ReadKey();
        }
        static void Main9 (string[] args)
        {
            double desc = 0;
            double vAlcool = 2.9;
            double vGas = 3.3;
            Console.Write("Qual o tipo de gasolina  (A - álcool / G - gasolina): ");
            string tipo = Console.ReadLine();
            Console.Write("Qual a quantidade em litros: ");
            double litros = double.Parse(Console.ReadLine());
            if (tipo == "A" || tipo == "a") {
                if (litros <= 20)
                {
                     desc = vAlcool - (vAlcool * 0.03);
                }
                else
                {
                     desc = vAlcool - (vAlcool * 0.05);
                }
            }
            else
            {
                if (litros <= 20)
                {
                     desc = vGas - (vGas * 0.04);
                }
                else
                {
                     desc = vGas - (vGas * 0.06);
                }
                
            }
            double total = litros * desc;
            Console.Write("O total a pagar é: R$ " + total);
            Console.ReadKey();
        }
    }   
}
