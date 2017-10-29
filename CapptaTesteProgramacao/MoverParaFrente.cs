using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaTesteProgramacao
{
    class MoverParaFrente : Mover
    {
        public void Mover(Sonda sonda)
        {

            switch (sonda.direcaoFinal)
            {
                case "N":
                    int somaYFinal = Convert.ToInt32(sonda.yFinal) + 1;
                    sonda.yFinal = somaYFinal.ToString();
                    break;
                case "E":
                    sonda.xFinal = (Convert.ToInt32(sonda.xFinal) + 1).ToString();
                    break;
                case "S":
                    sonda.yFinal = (Convert.ToInt32(sonda.yFinal) - 1).ToString();
                    break;
                case "W":
                    sonda.xFinal = (Convert.ToInt32(sonda.xFinal) - 1).ToString();
                    break;
            }
        }

    }
}
