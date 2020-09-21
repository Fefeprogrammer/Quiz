using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Classes
{
    class Alternativas
    {
        private int alternativa;
        private string[] alt = { " ", "  ", " ", " ", " " };
        private int respostaCerta;
        private int resposta;

        Score score = new Score();

        public Alternativas(int alternativa)
        {
            this.alternativa = alternativa;

            switch (alternativa) {
                case 0:
                    alt[0] = "Sao Paulo";
                    alt[1] = "Campinas";
                    alt[2] = "Sao Carlos";
                    alt[3] = "Sao Jose do Rio Preto";
                    alt[4] = "Rio Claro";
                    for(int x=0; x < alt.Length; x++)
                    {
                        Console.WriteLine(x + " - " + alt[x]);
                    }
                    checarResposta(0);
                break;
                case 1:
                    alt[0] = "Minas Gerais";
                    alt[1] = "Belo Horizonte";
                    alt[2] = "Fronteira";
                    alt[3] = "exemplo";
                    alt[4] = "exemplo02";
                    for(int x=0; x<alt.Length; x++)
                    {
                        Console.WriteLine(x + " - " + alt[x]);
                    }
                    checarResposta(1);
                break;
                case 2:
                    alt[0] = "1800";
                    alt[1] = "1000";
                    alt[2] = "0";
                    alt[3] = "2000";
                    alt[4] = "1500";
                    for(int x=0; x< alt.Length; x++)
                    {
                        Console.WriteLine(x + " - " + alt[x]);
                    }
                    checarResposta(4);
                break;
                default:
                    Console.WriteLine("Valor incorreto");
                break;
            }
        }

        private void checarResposta(int certa)
        {
            Console.Write("Digite a resposta: ");
            this.resposta = Convert.ToInt32(Console.ReadLine());

            if(this.resposta == certa)
            {
                Console.WriteLine("Voce acertou!");
                //int atual = score.getPontos();
                score.setPontos(score.pontos++);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Voce errou!");
                Console.ReadLine();
            }
        }
    }
}
