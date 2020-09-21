using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Classes
{
    class Score
    {
        public int pontos = 0;

        public int getPontos()
        {
            return this.pontos;
        }

        public void setPontos(int pontos)
        {
            this.pontos = pontos;
        }
    }
}
