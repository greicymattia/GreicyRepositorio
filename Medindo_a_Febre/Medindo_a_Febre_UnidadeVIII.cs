using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medindo_a_Febre
{
    class Medindo_a_Febre_UnidadeVIII
    {
        static void Main12(string[] args)
        {

            //exercicio 12
            int[] matricula = new int[100];
            int[] aulas = new int[100];
            double[,] notas = new double[100, 3];
            double[] notaFinal = new double[100];
            double maiorNota = 0;
            double menorNota = 0;
            double media = 0;
            int maxAlunos = 100; 
            string[] codigo = new string[100];
            int reprovados = 0;

            //PARA TESTAR
            Console.WriteLine("Quantos alunos você deseja cadastrar?  (1-100)");
            do{
            maxAlunos = int.Parse(Console.ReadLine());
            if (maxAlunos < 1 || maxAlunos > 100)
            {
                Console.Write("Quantiade incorreta, digite novamente: ");
            }
            }while(maxAlunos<1 || maxAlunos>100);
            Console.Clear();

            //---------------------------------------------------------
            for (int i = 0; i < maxAlunos; i++)
            {
                Console.Write("Digite a matricula do aluno {0}: ",i+1);
                matricula[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite o numero de aulas frequentadas: ");
                aulas[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite a primeira nota do aluno: ",i);
                notas[i, 0] = double.Parse(Console.ReadLine());
                Console.Write("Digite a segunda nota do aluno: ");
                notas[i, 1] = double.Parse(Console.ReadLine());
                Console.Write("Digite a terceira nota do aluno: ");
                notas[i, 2] = double.Parse(Console.ReadLine());
                notaFinal[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                if (i == 0)
                {
                    maiorNota = notaFinal[i];
                    menorNota = notaFinal[i];
                }
                media += notaFinal[i];
                maiorNota = (notaFinal[i] > maiorNota) ? notaFinal[i] : maiorNota;
                menorNota = (notaFinal[i] < menorNota) ? notaFinal[i] : menorNota;
                codigo[i] = (notaFinal[i] >= 6 && aulas[i] >= 40) ? "Aprovado" : "Reprovado";
                if (codigo[i] == "Reprovado")
                {
                    reprovados++;
                }
                Console.Clear();
            }
            media /= maxAlunos;
            Console.WriteLine("Total de alunos: {0}.", maxAlunos);
            Console.WriteLine("Maior nota: {0:F2}.\tMenor nota: {1:F2}.", maiorNota, menorNota);
            Console.WriteLine("Média da turma: {0:F2}.", media);
            Console.WriteLine("Total de alunos reprovados: {0}\n\n", reprovados);
            for (int i = 0; i < maxAlunos; i++)
            {
                Console.WriteLine("Matricula: {0}", matricula[i]);
                Console.WriteLine("Aulas frequentadas: {0}", aulas[i]);
                Console.WriteLine("Nota final: {0:F2}", notaFinal[i]);
                Console.WriteLine("{0}!\n\n", codigo[i]);
            }

            Console.ReadKey();
        }
        static void Main13(string[] args)
        {

            //EXEMPLO DA QUESTÃO 13
            int quant = 0;
            Console.WriteLine("Digite a quantidade que deseja cadastrar (1~10): ");
            do
            {
                quant = int.Parse(Console.ReadLine());
                if (quant > 10 || quant < 1)
                {
                    Console.WriteLine("Quantidade incorreta, digite novamente!");
                }
            } while (quant < 1 || quant > 10);
            for (int i = 0; i < quant; i++)
            {
                //COMANDOS PARA CADASTRO...
            }                
            Console.ReadKey();
        }
    }


}
