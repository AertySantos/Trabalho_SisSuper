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
            //this.teste.Start();

        }

       private void Form1_Load(object sender, EventArgs e)
        {
            this.teste.Start();
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

            
                this.Invoke((MethodInvoker)delegate ()
                {
                    andar.Text = simulador.GetMaiorBti().ToString();
                    l1.Text = simulador.GetBti(0).ToString();
                    l2.Text = simulador.GetBti(1).ToString();
                    l3.Text = simulador.GetBti(2).ToString();
                    l4.Text = simulador.GetBti(3).ToString();
                    l5.Text = simulador.GetBti(4).ToString();
                });
            


        }

        private void bti0_Click(object sender, EventArgs e)
        {
            simulador.setBti(0,true);
            bti0.BackColor = System.Drawing.Color.Red;
        }

        private void bti1_Click(object sender, EventArgs e)
        {
            simulador.setBti(1, true);
            bti1.BackColor = System.Drawing.Color.Red;
        }

        private void bti2_Click(object sender, EventArgs e)
        {
            simulador.setBti(2, true);
            bti2.BackColor = System.Drawing.Color.Red;
        }

        private void bti3_Click(object sender, EventArgs e)
        {
            simulador.setBti(3, true);
            bti3.BackColor = System.Drawing.Color.Red;
        }

        private void bti4_Click(object sender, EventArgs e)
        {
            simulador.setBti(4, true);
            bti4.BackColor = System.Drawing.Color.Red;
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
