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

        public List<Botao> bt = new List<Botao>();//lista de botoes

        public Elevador()
        {

            this.modo = false;
            this.andar = 0;
            Botao bts = new Botao();

            bt.Add(bts);//gera uma lista com 5 botões
            bt.Add(bts);
            bt.Add(bts);
            bt.Add(bts);
            bt.Add(bts);

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
