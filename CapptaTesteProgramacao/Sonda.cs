using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaTesteProgramacao
{
    class Sonda
    {
       public string xInicial { get;}
       public string yInicial { get; }
       public string direcao { get; set; }

       

       public string xFinal { get; set; }
       public string yFinal { get; set; }
       public string direcaoFinal { get; set; }
      
       public string nome { get; set; }

        public Sonda(string xInicial, string yInicial,string direcao, string nome)
        {
            this.xInicial = xInicial;
            this.yInicial = yInicial;
            this.direcao = direcao;

            this.xFinal = xInicial;
            this.yFinal = yInicial;
            this.direcaoFinal = direcao;
            this.nome = nome;    
        }


    }
}
