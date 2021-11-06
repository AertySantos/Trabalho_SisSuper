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

        List<Botao> bt = new List<Botao>();//lista de botoes

        public Elevador(int num, bool md, int a)
        {

            this.modo = md;
            this.andar = a;
            Botao bts = new Botao();
            int contador = num;

            while (contador > 0)
            {
                bt.Add(bts);//gera uma lista de botoes
                contador--;
            }

        }

        public void SetModo(bool m)
        {
            this.modo = m;
        }

        public void SetAndar(int a)
        {
            this.andar = a;
        }

        public bool GetModo()
        {
            return this.modo;
        }

        public int GetAndar()
        {
            return this.andar;
        }
    }

}
