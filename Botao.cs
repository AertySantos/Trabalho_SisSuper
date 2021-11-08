using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_SisSuper
{
    class Botao
    {
        private bool acao;
        private bool estado;
        private bool btup;
        private bool btdown;
        public Botao()
        {
            SetAcao(false);
            SetEstado(false);
            SetBtdown(false);
            SetBtup(false);
        }

        public void SetBtup(bool u)
        {
            this.btup = u;
        }

        public void SetBtdown(bool d)
        {
            this.btdown = d;
        }

        public void SetAcao(bool a)
        {
            this.acao = a;
        }

        public void SetEstado(bool e)
        {
            this.estado = e;
        }

        public bool GetAcao()
        {
            return this.acao;
        }

        public bool GetEstado()
        {
            return this.estado;
        }

        public bool GetBtup()
        {
            return this.btup;
        }

        public bool GetBtdown()
        {
            return this.btdown;
        }
    }
}
