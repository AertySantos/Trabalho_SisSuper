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
        public Botao()
        {
            SetAcao(false);
            SetEstado(false);
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
    }
}
