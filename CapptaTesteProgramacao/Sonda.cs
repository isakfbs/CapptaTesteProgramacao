using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaTesteProgramacao
{
    class Sonda
    {
       private string posicaoInicial;
        private string posicaoFinal { get; set; }
       private string nome;

        public Sonda(string posicaoInicial, string nome)
        {
            this.posicaoInicial = posicaoInicial;
            this.nome = nome;
        }
    }
}
