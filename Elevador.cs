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
        private bool movimento;

        public List<Botao> bti = new List<Botao>();//lista de botoes internos
        public List<Botao> bte = new List<Botao>();//lista de botoes externos


        public Elevador()
        {

            this.modo = false;
            this.andar = 0;
            Botao bts = new Botao();

            bti.Add(bts);//gera uma lista com 5 botões internos
            bti.Add(bts);
            bti.Add(bts);
            bti.Add(bts);
            bti.Add(bts);

            bte.Add(bts);//gera uma lista com 5 botões externos
            bte.Add(bts);
            bte.Add(bts);
            bte.Add(bts);
            bte.Add(bts);

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
    }

}
