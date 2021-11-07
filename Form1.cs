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
            simulador.bti[0].SetEstado(true);
        }

        private void bti1_Click(object sender, EventArgs e)
        {
            simulador.bti[1].SetEstado(true);
        }

        private void bti2_Click(object sender, EventArgs e)
        {
            simulador.bti[2].SetEstado(true);
        }

        private void bti3_Click(object sender, EventArgs e)
        {
            simulador.bti[3].SetEstado(true);
        }

        private void bti4_Click(object sender, EventArgs e)
        {
            simulador.bti[4].SetEstado(true);
        }

        private void manual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void automatico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btesobe1_Click(object sender, EventArgs e)
        {

        }

        private void btedesce1_Click(object sender, EventArgs e)
        {

        }

        private void btesobe2_Click(object sender, EventArgs e)
        {

        }

        private void btedesce2_Click(object sender, EventArgs e)
        {

        }

        private void btesobe3_Click(object sender, EventArgs e)
        {

        }

        private void btedesce3_Click(object sender, EventArgs e)
        {

        }

        private void bteandar4_Click(object sender, EventArgs e)
        {

        }

        private void bteterreo_Click(object sender, EventArgs e)
        {

        }

        private void andar_Click(object sender, EventArgs e)
        {

        }

        private void estado_Click(object sender, EventArgs e)
        {

        }
    }
}
