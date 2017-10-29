using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaTesteProgramacao
{
    class MoverParaEsquerda : Mover
    {
        public void Mover(Sonda sonda)
        {
            switch (sonda.direcaoFinal)
            {
                case "N":
                    sonda.direcaoFinal = "W";
                    break;
                case "W":
                    sonda.direcaoFinal = "S";
                    break;
                case "S":
                    sonda.direcaoFinal = "E";
                    break;
                case "E":
                    sonda.direcaoFinal = "N";
                    break;
            }
        }

    }
}
