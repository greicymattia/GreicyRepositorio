using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medindo_a_Febre
{
    class Medindo_a_FebreV
    {
        static void Main7(string[] args)
        {
            //QUESTÃO NUMERO 7
            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            string identificacao = idade >= 21 ? "Adulto!" : "Não é ADULTO!";
            Console.Clear();
            Console.WriteLine(identificacao);
            Console.WriteLine("Idade: {0}", idade);
            Console.ReadKey();
        }
        static void Main8(string[] args)
        {
            //QUESTÃO 8
            int i = 0;
            int hora = 0;
            int minutos = 0;
            int valido = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a entrada da {0} pessoa: ", i + 1);
                do{
                    Console.Write("Digite a hora (formato 24h): ");               
                    hora = int.Parse(Console.ReadLine());
                    if (hora > 23 || hora < 0)
                    {
                        Console.WriteLine("Hora invalida. Tente novamente.");
                    }
                }while(hora>23 || hora<0);
                do
                {
                    Console.Write("Digite os minutos: ");
                    minutos = int.Parse(Console.ReadLine());
                    if (minutos > 59 || minutos < 0)
                    {
                        Console.WriteLine("Minutos invalidos. Tente novamente.");
                    }
                }while(minutos>59 || minutos<0);
                Console.Clear();
                valido = ((hora >= 10 && 16>hora) || (hora == 16 && 00 == minutos )) ? valido + 1 : valido;                          
            }
            Console.WriteLine("{0} pessoas entraram no horario de expediente (entre as 10:00 e 16:00).",valido);
            Console.ReadKey();
        }
        static void Main9(string[] args)
        {
            double desconto = 0;
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a quantidade de compra: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Digite o preco unitário do produto: ");
            double preco = double.Parse(Console.ReadLine());
            desconto = quantidade <= 5 ? 0.02 : desconto;
            desconto = quantidade > 5 && 10 >= quantidade ? 0.03 : desconto;
            desconto = quantidade > 10 ? 0.05 : desconto;
            double total = (quantidade * preco);
            desconto = total * desconto;
            Console.Clear();
            Console.WriteLine("Compra de {0}...", nome);
            Console.WriteLine("Valor total: R$ {0:F2}",total);
            Console.WriteLine("Valor do desconto: R$ {0:F2}", desconto);
            Console.WriteLine("Pagar: R$ {0:F2}", total - desconto);
            Console.ReadKey();
        }

    }
}
