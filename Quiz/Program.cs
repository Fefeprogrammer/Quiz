using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Classes;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            int cont = 0;
            char v;
            Score score = new Score();

            List<string> Perguntas = new List<string>();
            Perguntas.Add("Qual a capital de São Paulo?");
            Perguntas.Add("Qual a capital de Minas Gerais?");
            Perguntas.Add("Em que ano os portugueses chegaram no Brasil?");


            do
            {
                while(cont < Perguntas.Count)
                {
                    Console.WriteLine("Score: " + score.pontos);
                    Console.WriteLine(Perguntas[cont]);
                    Alternativas alterna = new Alternativas(cont);
                    Console.Clear();
                    cont++;
                }
                
                Console.WriteLine("Deseja jogar novamente[s/n]");
                v = Convert.ToChar(Console.ReadLine());
                if(v == 's' || v == 'S')
                {
                    sair = false;
                    cont = 0;
                    Console.Clear();
                }else if(v == 'n' || v == 'N')
                {
                    sair = true;
                    Console.WriteLine("Precione qualquer tecla para sair...");
                }else
                {
                    Console.WriteLine("Valor incorreto");
                }

            } while (sair == false);

            Console.ReadLine();
        }
    }
}
