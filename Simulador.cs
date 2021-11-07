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
        public int andar = 0;
        public delegate void Monitoramento(object sender, EventArgs args);
        public event Monitoramento Monitor;
       
        public void doSimulador()
        {
            while (true)
            {
                if (Monitor != null)
                {
                    Monitor(this, EventArgs.Empty);
                }
                Thread.Sleep(3000);
            }
        }

        
    }
}
