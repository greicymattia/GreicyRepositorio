using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Unidades
{
    class Unidade_Complementar
    {
        static void Main1(string[] args)
        {
            ArrayList vetor = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                vetor.Add(i*3);
            }
            Console.WriteLine("Decrescente: ");
            for (int i = 99; i > -1; i--){
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Crescente: ");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            var numReal = new List<double>(80);
            Random gerador = new Random();
            double maior = 0;
            double menor = 0;
            double soma = 0;
            double media = 0;
            for (int i = 0; i < 80; i++)
            {
                numReal.Add(gerador.NextDouble());
                if (i == 0)
                {
                    maior = numReal[i];
                    menor = numReal[i];
                }
                soma += numReal[i];

            }
            media = soma / 80;
            for (int i = 0; i < 80; i++)
            {
                maior = (numReal[i] > maior) ? numReal[i] : maior;
                menor = (numReal[i] < menor) ? numReal[i] : menor;
            }
            Console.WriteLine("Maior: {0:F2}", maior);
            Console.WriteLine("Menor: {0:F2}", menor);
            Console.WriteLine("Soma: {0:F2}", soma);
            Console.WriteLine("Media: {0:F2}", media);
            Console.ReadKey();
        }
        static void Main3(string[] args)
        {
            int quantidade = 0;
            var nomes = new List<string>();
            Console.WriteLine("Quantos nomes você deseja cadastrar? ");
            quantidade = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o nome {0}", i + 1);
                nomes.Add(Console.ReadLine());
            }
            nomes.Sort();
            Console.Clear();
            for(int i = 0; i<nomes.Count;i++){
                Console.WriteLine(nomes[i]);
            }
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            List<string> list = new List<string>() {"Maria", "Carlos", "Glauber", "Karen", "Douglas", "Renan", "Marlos", "Dayse"};
            ArrayList arraylist = new ArrayList() {"Maria", "Carlos", "Glauber", "Karen", "Douglas", "Renan", "Marlos", "Dayse"};
            IList ilist = new List<string>() {"Maria", "Carlos", "Glauber", "Karen", "Douglas", "Renan", "Marlos", "Dayse"};
            Dictionary<int,string> dictionary= new Dictionary<int, string>(){{1,"Maria"}, {2,"Carlos"}, {3,"Glauber"}, {4,"Karen"}, {5,"Douglas"}, {6,"Renan"}, {7,"Marlos"}, {8,"Dayse"}};
            Console.WriteLine("List...");
            foreach (var lista in list)
            {
                Console.WriteLine(lista);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("ArrayList...");
            foreach (var lista in arraylist)
            {
                Console.WriteLine(lista);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Dictionary...");
            foreach (var lista in dictionary)
            {
                Console.WriteLine(lista);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            List<string> selecoes = new List<string>();
            List<char> grupos = new List<char>() {'A','B','C','D','E','F','G','H'};                        
            var CopadoMundo = new Dictionary<string, char>();
            Random gerador = new Random();
            selecoes.Add("Brasil");
            selecoes.Add("Croácia");
            selecoes.Add("México");
            selecoes.Add("Camarões");
            selecoes.Add("Espanha");
            selecoes.Add("Holanda");
            selecoes.Add("Chile");
            selecoes.Add("Austrália");
            selecoes.Add("Colômbia");
            selecoes.Add("Grécia");
            selecoes.Add("Costa do Marfim");
            selecoes.Add("Japão");
            selecoes.Add("Uruguai");
            selecoes.Add("Costa Rica");
            selecoes.Add("Inglaterra");
            selecoes.Add("Itália");
            selecoes.Add("Suíça");
            selecoes.Add("Equador");
            selecoes.Add("França");
            selecoes.Add("Honduras");
            selecoes.Add("Argentina");
            selecoes.Add("Bósnia-Herzegovina");
            selecoes.Add("Irã");
            selecoes.Add("Nigéria");
            selecoes.Add("Alemanha");
            selecoes.Add("Portugal");
            selecoes.Add("Gana");
            selecoes.Add("Estados Unidos");
            selecoes.Add("Bélgica");
            selecoes.Add("Argélia");
            selecoes.Add("Rússia");
            selecoes.Add("Coreia do Sul");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sorteio = gerador.Next(0, selecoes.Count);
                    CopadoMundo.Add(selecoes[sorteio], grupos[i]);
                    selecoes.Remove(selecoes[sorteio]);
                }
            }
            int count = 0;
            foreach (var t in CopadoMundo)
            {
                if (count % 4 == 0)
                {
                    Console.WriteLine("\n\n\tGRUPO {0}\n",t.Value);
                }
                Console.WriteLine("\t{0}",t.Key);
                count++;
            }
            Console.ReadKey();
        }
    }
}
