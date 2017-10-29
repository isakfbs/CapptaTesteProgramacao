using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaTesteProgramacao
{
    class MovimentarSonda
    {
        public void realizarMovimento(Sonda sonda,char comando)
        {

            MoverParaDireita moverParaDireita = new MoverParaDireita();
            MoverParaEsquerda moverParaEsquerda = new MoverParaEsquerda();
            MoverParaFrente moverParaFrente = new MoverParaFrente();

            
                    switch (comando)
                    {
                        case 'M':
                            moverParaFrente.Mover(sonda);
                            break;
                        case 'R':
                            moverParaDireita.Mover(sonda);
                            break;
                        case 'L':
                            moverParaEsquerda.Mover(sonda);
                            break;
                    }
                
            






        }

     
    }
}
