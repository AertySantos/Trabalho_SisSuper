using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trabalho_SisSuper
{
    class Simulador:Elevador
    {
        
        public delegate void Monitoramento(object sender, EventArgs args);
        public event Monitoramento Monitor;
       
        public void doSimulador()
        {
            while (true)
            {
                if (Monitor != null)
                {/*
                    if (GetMovimento())//vejo se ele esta em movimento
                    {
                        

                        if (GetAcaoMovimento())//se esta subindo
                        {
                            subindo();//andar atual

                            if (GetMaiorBti() == GetAndar())//se chegou no maior andar desejado
                            {
                                //SetMovimento(false); //parado
                            }
                            

                            if (GetBtin(GetAndar()).GetEstado())//se este anda esta acionado
                            {
                                setBti(GetAndar(),false);//desaciono o andar
                            }
                        }
                        else
                        {

                        }
                    }
                    else//se ele nao esta em movimento vejo onde esta,coloco o elevador para subir ou descer
                    {
                        acaoElevador();
                    }
                    */

                    
                    Monitor(this, EventArgs.Empty);
                }
                Thread.Sleep(3000);
            }
        }

        public void subindo()
        {
            if (GetAndar() < 4)
            {
                SetAndar(GetAndar() + 1);
            }
        }

        public void acaoElevador()
        {
            if (GetAndar() > GetMaiorBti())
            {
                SetMovimento(true);
                SetAcaoMovimento(false);//desce
            }
            else if (GetAndar() < GetMaiorBti())
            {
                SetMovimento(true);
                SetAcaoMovimento(true);//sobe
            }
            else
            {
                SetMovimento(false); //parado

            }
        }

        
    }
}
