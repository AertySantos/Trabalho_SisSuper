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

        private void bti0_Click(object sender, EventArgs e)
        {
            simulador.setBti(0,true);
        }

        private void bti1_Click(object sender, EventArgs e)
        {
            simulador.setBti(1, true);
        }

        private void bti2_Click(object sender, EventArgs e)
        {
            simulador.setBti(2, true);
        }

        private void bti3_Click(object sender, EventArgs e)
        {
            simulador.setBti(3, true);
        }

        private void bti4_Click(object sender, EventArgs e)
        {
            simulador.setBti(4, true);
        }

        private void manual_CheckedChanged(object sender, EventArgs e)
        {
            simulador.SetModo(false);//manual
        }

        private void automatico_CheckedChanged(object sender, EventArgs e)
        {
            simulador.SetModo(true);//automatico
        }

        private void btesobe1_Click(object sender, EventArgs e)
        {
            simulador.setBte(1, true, true);
        }

        private void btedesce1_Click(object sender, EventArgs e)
        {
            simulador.setBte(1, true, false);
        }

        private void btesobe2_Click(object sender, EventArgs e)
        {
            simulador.setBte(2, true, true);
        }

        private void btedesce2_Click(object sender, EventArgs e)
        {
            simulador.setBte(2, true, false);
        }

        private void btesobe3_Click(object sender, EventArgs e)
        {
            simulador.setBte(3, true, true);
        }

        private void btedesce3_Click(object sender, EventArgs e)
        {
            simulador.setBte(3, true, false);
        }

        private void bteandar4_Click(object sender, EventArgs e)
        {
            simulador.setBte(4, true, false);
        }

        private void bteterreo_Click(object sender, EventArgs e)
        {
            simulador.setBte(0, true, true);
        }


    }
}
