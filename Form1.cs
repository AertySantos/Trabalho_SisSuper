using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_SisSuper
{
    public partial class Form1 : Form
    {
        Simulador simulador;
        Task teste;
        public Form1()
        {
            InitializeComponent();
            simulador = new Simulador();

            this.simulador.Monitor += Monitora_Elevador;
            teste = new Task(simulador.doSimulador);

        }

        private void Monitora_Elevador(object sender, EventArgs e)
        {
            
            /*if (tBmensagem.BackColor == System.Drawing.Color.Red)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    tBmensagem.BackColor = System.Drawing.Color.Green;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    tBmensagem.BackColor = System.Drawing.Color.Red;
                });
            }*/


        }


        private void bt1_Click(object sender, EventArgs e)
        {
           
        }

    
    }
}
