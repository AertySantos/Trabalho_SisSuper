using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_SisSuper
{
    class Elevador
    {
        private bool modo;//automatico ou manual
        private int andar;//onde esta o elevador

        private bool movimento;//esta em movimento?
        private bool acaoMovimento;//esta subindo ou descendo?
        public bool statusE = false;

        public List<Botao> bti = new List<Botao>();//lista de botoes internos
        public List<Botao> bte = new List<Botao>();//lista de botoes externos


        public Elevador()
        {

            this.modo = false;
            this.andar = 0;

            Botao bts0 = new Botao();
            Botao bts1 = new Botao();
            Botao bts2 = new Botao();
            Botao bts3 = new Botao();
            Botao bts4 = new Botao();
            Botao bts5 = new Botao();
            Botao bts6 = new Botao();
            Botao bts7 = new Botao();
            Botao bts8 = new Botao();
            Botao bts9 = new Botao();

            bti.Add(bts0);//gera uma lista com 5 botões internos
            bti.Add(bts1);
            bti.Add(bts2);
            bti.Add(bts3);
            bti.Add(bts4);

            bte.Add(bts5);//gera uma lista com 5 botões externos
            bte.Add(bts6);
            bte.Add(bts7);
            bte.Add(bts8);
            bte.Add(bts9);

        }

        public void SetModo(bool m)
        {
            this.modo = m;
        }

        public void SetAndar(int a)
        {
            this.andar = a;
        }

        public void SetMovimento(bool m)
        {
            this.movimento = m;
        }

        public void SetAcaoMovimento(bool am)
        {
            this.acaoMovimento = am;
        }

        public bool GetAcaoMovimento()
        {
            return this.acaoMovimento;
        }

        public bool GetMovimento()
        {
            return this.movimento;
        }

        public bool GetModo()
        {
            return this.modo;
        }

        public int GetAndar()
        {
            return this.andar;
        }

        public void setBti(int bt, bool e)
        {
            this.bti[bt].SetEstado(e);
        }

        public void setBte(int bt, bool e)
        {
            this.bte[bt].SetEstado(e);
        }

        public int GetMaiorBti()
        {
            int contador = 0;
            int maior = 0;
            bool naoAcionou = true;

            for(int i = 0;i < 5; i++)
            {
                if (GetBti(i))
                {
                    if(contador > maior)
                    {
                        maior = contador;
                    }

                    naoAcionou = false;
                }

                contador++;
            }

            if(naoAcionou)//se num teve acionamento interno
            {
                return GetAndar();
            }

            return maior;
        }
        public int GetMaiorBte()
        {
            int contador = 0;
            int maior = 0;
            bool naoAcionou = true;

            for (int i = 0; i < 5; i++)
            {
                if (GetBte(i))
                {
                    if (contador > maior)
                    {
                        maior = contador;
                    }

                    naoAcionou = false;
                }

                contador++;
            }

            if (naoAcionou)//se num teve acionamento externo
            {
                return GetAndar();
            }

            return maior;
        }

        public int GetMenorBti()
        {
            int contador = 0;
            int menor = 4;//maior andar
            bool naoAcionou = true;

            for (int i = 0; i < 5; i++)
            {
                if (GetBti(i))
                {
                    if (contador < menor)
                    {
                        menor = contador;
                    }

                    naoAcionou = false;
                }

                contador++;
            }

            if (naoAcionou)//se num teve acionamento interno
            {
                return GetAndar();
            }

            return menor;
        }

        public int GetMenorBte()
        {
            int contador = 0;
            int menor = 4;//maior andar
            bool naoAcionou = true;

            for (int i = 0; i < 5; i++)
            {
                if (GetBte(i))
                {
                    if (contador < menor)
                    {
                        menor = contador;
                    }

                    naoAcionou = false;
                }

                contador++;
            }

            if (naoAcionou)//se num teve acionamento interno
            {
                return GetAndar();
            }

            return menor;
        }

        public bool GetBti(int bt)
        {
            return this.bti[bt].GetEstado();
        }

        public bool GetBte(int bt)
        {
            return this.bte[bt].GetEstado();
        }

        public bool GetBteUp(int bt)
        {
            return this.bte[bt].GetBtup();
        }

        public bool GetBteDown(int bt)
        {
            return this.bte[bt].GetBtdown();
        }

        public Botao GetBtin(int bt)
        {
            return bti[bt];
        }

        public Botao GetBtex(int bt)
        {
            return bte[bt];
        }

        public void setBtes(int bt, bool e, bool a, bool sd)//bt> o botao acinado, e> se foi apertado, a> sobe ou desce
        {
            this.bte[bt].SetEstado(e);
            this.bte[bt].SetAcao(a);
            this.bte[bt].SetBtup(sd);
        }

        public void setBted(int bt, bool e, bool a, bool sd)//bt> o botao acinado, e> se foi apertado, a> sobe ou desce
        {
            this.bte[bt].SetEstado(e);
            this.bte[bt].SetAcao(a);
            this.bte[bt].SetBtdown(sd);
        }

        public void setBte(int bt, bool e, bool a)//bt> o botao acinado, e> se foi apertado, a> sobe ou desce
        {
            this.bte[bt].SetEstado(e);
            this.bte[bt].SetAcao(a);
        }

        public void setBteTotal(int bt, bool e, bool a)//bt> o botao acinado, e> se foi apertado, a> sobe ou desce
        {
            this.bte[bt].SetEstado(e);
            this.bte[bt].SetAcao(a);
            this.bte[bt].SetBtdown(false);
            this.bte[bt].SetBtup(false);
        }

    }

}
