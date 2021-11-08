using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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

            this.Invoke((MethodInvoker)delegate ()
            {
                    andar.Text = simulador.GetAndar().ToString();
                    estadoAtual();
                    l1.Text = simulador.GetBteUp(1).ToString();
                    l2.Text = simulador.GetBteDown(1).ToString();
                    l3.Text = simulador.GetBteUp(2).ToString();
                    l4.Text = simulador.GetBteDown(2).ToString();
                    l5.Text = simulador.GetBteUp(3).ToString();
                    terr.Text = simulador.GetBteDown(3).ToString();

                    corAnterior();

             });
            


        }

        private void bti0_Click(object sender, EventArgs e)
        {
           
            if(simulador.GetAndar() != 0)
            {
                simulador.setBti(0, true);
                bti0.BackColor = System.Drawing.Color.Red;
            }
            
        }

        private void bti1_Click(object sender, EventArgs e)
        {
            if (simulador.GetAndar() != 1)
            {
                simulador.setBti(1, true);
                bti1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bti2_Click(object sender, EventArgs e)
        {
            if (simulador.GetAndar() != 2)
            {
                simulador.setBti(2, true);
                bti2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bti3_Click(object sender, EventArgs e)
        {
            if (simulador.GetAndar() != 3)
            {
                simulador.setBti(3, true);
                bti3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bti4_Click(object sender, EventArgs e)
        {
            if (simulador.GetAndar() != 4)
            {
                simulador.setBti(4, true);
                bti4.BackColor = System.Drawing.Color.Red;
            }
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
            if (simulador.GetAndar() != 1)
            {
                simulador.setBtes(1, true, true, true);
                btesobe1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btedesce1_Click(object sender, EventArgs e)
        {
            if (simulador.GetAndar() != 1)
            {
                simulador.setBted(1, true, false, true);
                btedesce1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btesobe2_Click(object sender, EventArgs e)
        {
           
            if (simulador.GetAndar() != 2)
            {
                simulador.setBtes(2, true, true, true);
                btesobe2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btedesce2_Click(object sender, EventArgs e)
        {
           
            if (simulador.GetAndar() != 2)
            {
                simulador.setBted(2, true, false, true);
                btedesce2.BackColor = System.Drawing.Color.Red;
            }

        }

        private void btesobe3_Click(object sender, EventArgs e)
        {
           
            if (simulador.GetAndar() != 3)
            {
                simulador.setBtes(3, true, true, true);
                btesobe3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btedesce3_Click(object sender, EventArgs e)
        {
            
            if (simulador.GetAndar() != 3)
            {
                simulador.setBted(3, true, false, true);
                btedesce3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bteandar4_Click(object sender, EventArgs e)
        {
           
            if (simulador.GetAndar() != 4)
            {
                simulador.setBte(4, true, false);
                bteandar4.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bteterreo_Click(object sender, EventArgs e)
        {
            
            if (simulador.GetAndar() != 0)
            {
                simulador.setBte(0, true, true);
                bteterreo.BackColor = System.Drawing.Color.Red;
            }
        }

        public void estadoAtual()
        {
            if (simulador.GetMovimento())
            {
                if (simulador.GetAcaoMovimento())
                {
                    estado.Text = "Subindo";
                }
                else
                {
                    estado.Text = "Descendo";
                }
            }
            else
            {
                estado.Text = "Parado";
            }
        }

        private void corAnterior()
        {
            if ((bti0.BackColor == System.Drawing.Color.Red) && (!simulador.GetBti(0)))
            {
                bti0.BackColor = System.Drawing.Color.LightGray;
            }

            if ((bti1.BackColor == System.Drawing.Color.Red) && (!simulador.GetBti(1)))
            {
                bti1.BackColor = System.Drawing.Color.LightGray;
            }

            if ((bti2.BackColor == System.Drawing.Color.Red) && (!simulador.GetBti(2)))
            {
                bti2.BackColor = System.Drawing.Color.LightGray;
            }

            if ((bti3.BackColor == System.Drawing.Color.Red) && (!simulador.GetBti(3)))
            {
                bti3.BackColor = System.Drawing.Color.LightGray;
            }

            if ((bti4.BackColor == System.Drawing.Color.Red) && (!simulador.GetBti(4)))
            {
                bti4.BackColor = System.Drawing.Color.LightGray;
            }

            if ((btesobe1.BackColor == System.Drawing.Color.Red) && (!simulador.GetBteUp(1)))
            {
                btesobe1.BackColor = System.Drawing.Color.LightGray;
            }

            if ((btedesce1.BackColor == System.Drawing.Color.Red) && (!simulador.GetBteDown(1)))
            {
                btedesce1.BackColor = System.Drawing.Color.LightGray;
            }

            if ((btesobe2.BackColor == System.Drawing.Color.Red) && (!simulador.GetBteUp(2)))
            {
                btesobe2.BackColor = System.Drawing.Color.LightGray;
            }

            if ((btedesce2.BackColor == System.Drawing.Color.Red) && (!simulador.GetBteDown(2)))
            {
                btedesce2.BackColor = System.Drawing.Color.LightGray;
            }

            if ((btesobe3.BackColor == System.Drawing.Color.Red) && (!simulador.GetBteUp(3)))
            {
                btesobe3.BackColor = System.Drawing.Color.LightGray;
            }

            if ((btedesce3.BackColor == System.Drawing.Color.Red) && (!simulador.GetBteDown(3)))
            {
                btedesce3.BackColor = System.Drawing.Color.LightGray;
            }

            if ((bteterreo.BackColor == System.Drawing.Color.Red) && (!simulador.GetBte(0)))
            {
                bteterreo.BackColor = System.Drawing.Color.LightGray;
            }

            if ((bteandar4.BackColor == System.Drawing.Color.Red) && (!simulador.GetBte(4)))
            {
                bteandar4.BackColor = System.Drawing.Color.LightGray;
            }

        }


    }
}
