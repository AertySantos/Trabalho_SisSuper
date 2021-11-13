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
                if (statusE)
                {
                    Thread.Sleep(3000);
                    statusE = false;
                    Monitor(this, EventArgs.Empty);
                }
                else
                {
                    Thread.Sleep(3000);

                    if (Monitor != null)
                    {
                        if (GetModo())
                        {
                            automatico();
                        }
                        else
                        {
                            manual();
                        }

                        Monitor(this, EventArgs.Empty);
                    }
                }
                

                
               
            }
        }

        public void subindo()
        {
            if (GetAndar() < 4)
            {
                SetAndar(GetAndar() + 1);
            }
        }

        public void descendo()
        {
            if (GetAndar() > 0)
            {
                SetAndar(GetAndar() - 1);
            }
        }

        public void acaoElevador()
        {
            if ((GetAndar() > GetMaiorBti()) || (GetAndar() > GetMaiorBte()))
            {
                SetMovimento(true);
                SetAcaoMovimento(false);//desce
            }
            else if ((GetAndar() < GetMaiorBti())|| (GetAndar() < GetMaiorBte()))
            {
                SetMovimento(true);
                SetAcaoMovimento(true);//sobe
            }
            else
            {
                SetMovimento(false); //parado

            }
        }

        public void automatico()
        {

            manual();

            Random rnd = new Random();
            int indice = rnd.Next(5);

            Random rnd2 = new Random();
            int pre = rnd.Next(10);

            if ((GetAndar() != indice)&&(pre >= 5))
            {
                setBtes(indice, true, true, true);

            }else if (GetAndar() != indice)
            {
                setBted(indice, true, true, true);
            }
        }

        public void manual()
        {
           

            if (GetMovimento())//vejo se ele esta em movimento
            {

                if (GetAcaoMovimento())//se esta subindo
                {
                    subindo();//andar atual

                    if ((GetMaiorBti() == GetAndar()) && (GetMaiorBti() >= GetMaiorBte()))//se chegou no maior andar desejado
                    {
                        acaoElevador();
                        setBti(GetAndar(), false);//desaciono o andar
                        setBteTotal(GetAndar(), false, false);//desaciono o andar
                        statusE = true;

                    }
                    else if ((GetMaiorBte() == GetAndar()) && (GetMaiorBte() >= GetMaiorBti()))
                    {
                        acaoElevador();
                        setBteTotal(GetAndar(), false, false);//desaciono o andar
                        setBti(GetAndar(), false);//desaciono o andar
                        statusE = true;
                    }
                    else
                    {
                        if (GetBtin(GetAndar()).GetEstado())//se este anda esta acionado
                        {
                            setBti(GetAndar(), false);//desaciono o andar
                            statusE = true;
                        }

                        if ((GetBtex(GetAndar()).GetEstado()) && (GetAndar() == 0 || GetAndar() == 4))//se este anda esta acionado
                        {
                            setBte(GetAndar(), false);//desaciono o andar
                            
                            statusE = true;

                        }
                        else if (GetBtex(GetAndar()).GetEstado())//se tiver subindo e apertou para subir
                        {
                            if (GetBteDown(GetAndar()))
                            {
                                setBtes(GetAndar(), true, false, false);
                                statusE = true;
                            }
                            else
                            {
                                setBtes(GetAndar(), false, false, false);
                                statusE = true;
                            }
                        }
                    }

                }
                else
                {
                    descendo();//andar atual

                    if ((GetMenorBti() == GetAndar()) && (GetMenorBti() <= GetMenorBte()))//se chegou no menor andar desejado
                    {
                        acaoElevador(); //parado
                        setBti(GetAndar(), false);//desaciono o andar
                        setBteTotal(GetAndar(), false, false);//desaciono o andar
                        statusE = true;
                    }
                    else if ((GetMenorBte() == GetAndar()) && (GetMenorBte() <= GetMenorBti()))
                    {
                        acaoElevador();
                        setBteTotal(GetAndar(), false, false);//desaciono o andar
                        setBti(GetAndar(), false);//desaciono o andar
                        statusE = true;
                    }
                    else
                    {
                        if (GetBtin(GetAndar()).GetEstado())//se este anda esta desejado
                        {
                            setBti(GetAndar(), false);//desaciono o andar
                            statusE = true;
                        }

                        if ((GetBtex(GetAndar()).GetEstado()) && (GetAndar() == 0 || GetAndar() == 4))//se este anda esta no andar desejado

                        {
                            setBte(GetAndar(), false);//desaciono o andar
                            statusE = true;

                        }
                        else if (GetBtex(GetAndar()).GetEstado())//se tiver descendo e apertou para descer
                        {
                            if (GetBteUp(GetAndar()))
                            {
                                setBted(GetAndar(), true, false, false);
                                statusE = true;
                            }
                            else
                            {
                                setBted(GetAndar(), false, false, false);
                                statusE = true;
                            }
                        }
                    }
 
                }
            }
            else//se ele nao esta em movimento vejo onde esta,coloco o elevador para subir ou descer
            {
                acaoElevador();
            }
        }

        
    }
}
