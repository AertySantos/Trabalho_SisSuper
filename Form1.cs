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
using log4net;

namespace Trabalho_SisSuper
{
    public partial class Form1 : Form
    {
        private static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        Simulador simulador;
        Task paralelo;
        public Form1()
        {
            InitializeComponent();
            simulador = new Simulador();

            this.simulador.Monitor += Monitora_Elevador;
            paralelo = new Task(simulador.doSimulador);
            

        }

       private void Form1_Load(object sender, EventArgs e)
        {
            this.paralelo.Start();
            Log.Info("Log do painel interno do elevador iniciado");
        }

        private void Monitora_Elevador(object sender, EventArgs e)
        {

            this.Invoke((MethodInvoker)delegate ()
            {
                    andar.Text = simulador.GetAndar().ToString();
                    estadoAtual();
                    corAnterior();

                if (simulador.GetModo())//automatico
                {
                    modoAuto();
                }

             });
            


        }

        private void bti0_Click(object sender, EventArgs e)
        {
           
            if(simulador.GetAndar() != 0)
            {
                Log.Info("Andar 0 acionado");
                simulador.setBti(0, true);
                bti0.BackColor = System.Drawing.Color.Red;
            }
            
        }

        private void bti1_Click(object sender, EventArgs e)
        {
            if (simulador.GetAndar() != 1)
            {
                Log.Info("Andar 1 acionado");
                simulador.setBti(1, true);
                bti1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bti2_Click(object sender, EventArgs e)
        {
            if (simulador.GetAndar() != 2)
            {
                Log.Info("Andar 2 acionado");
                simulador.setBti(2, true);
                bti2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bti3_Click(object sender, EventArgs e)
        {
            if (simulador.GetAndar() != 3)
            {
                Log.Info("Andar 3 acionado");
                simulador.setBti(3, true);
                bti3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bti4_Click(object sender, EventArgs e)
        {
            if (simulador.GetAndar() != 4)
            {
                Log.Info("Andar 4 acionado");
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
            if ((simulador.GetAndar() != 1)&&(!simulador.GetModo()))
            {
                simulador.setBtes(1, true, true, true);
                btesobe1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btedesce1_Click(object sender, EventArgs e)
        {
            if ((simulador.GetAndar() != 1)&&(!simulador.GetModo()))
            {
                simulador.setBted(1, true, false, true);
                btedesce1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btesobe2_Click(object sender, EventArgs e)
        {
           
            if ((simulador.GetAndar() != 2)&&(!simulador.GetModo()))
            {
                simulador.setBtes(2, true, true, true);
                btesobe2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btedesce2_Click(object sender, EventArgs e)
        {
           
            if ((simulador.GetAndar() != 2)&&(!simulador.GetModo()))
            {
                simulador.setBted(2, true, false, true);
                btedesce2.BackColor = System.Drawing.Color.Red;
            }

        }

        private void btesobe3_Click(object sender, EventArgs e)
        {
           
            if ((simulador.GetAndar() != 3)&& (!simulador.GetModo()))
            {
                simulador.setBtes(3, true, true, true);
                btesobe3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btedesce3_Click(object sender, EventArgs e)
        {
            
            if ((simulador.GetAndar() != 3)&&(!simulador.GetModo()))
            {
                simulador.setBted(3, true, false, true);
                btedesce3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bteandar4_Click(object sender, EventArgs e)
        {
           
            if ((simulador.GetAndar() != 4)&& (!simulador.GetModo()))
            {
                simulador.setBte(4, true, false);
                bteandar4.BackColor = System.Drawing.Color.Red;
            }
        }

        private void bteterreo_Click(object sender, EventArgs e)
        {
            
            if ((simulador.GetAndar() != 0)&& (!simulador.GetModo()))
            {
                simulador.setBte(0, true, true);
                bteterreo.BackColor = System.Drawing.Color.Red;
            }
        }

        public void estadoAtual()
        {
            if (simulador.GetMovimento())
            {
                if (simulador.statusE)
                {
                    estado.Text = "Parado";
                }
                else
                if (simulador.GetAcaoMovimento())
                {
                    estado.Text = "Subindo...";
                }
                else
                {
                    estado.Text = "Descendo...";
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

        private void modoAuto()
        {
            
            if ((btesobe1.BackColor != System.Drawing.Color.Red) && (simulador.GetBteUp(1)))
            {
                btesobe1.BackColor = System.Drawing.Color.Red;
            }

            if ((btedesce1.BackColor != System.Drawing.Color.Red) && (simulador.GetBteDown(1)))
            {
                btedesce1.BackColor = System.Drawing.Color.Red;
            }

            if ((btesobe2.BackColor != System.Drawing.Color.Red) && (simulador.GetBteUp(2)))
            {
                btesobe2.BackColor = System.Drawing.Color.Red;
            }

            if ((btedesce2.BackColor != System.Drawing.Color.Red) && (simulador.GetBteDown(2)))
            {
                btedesce2.BackColor = System.Drawing.Color.Red;
            }

            if ((btesobe3.BackColor != System.Drawing.Color.Red) && (simulador.GetBteUp(3)))
            {
                btesobe3.BackColor = System.Drawing.Color.Red;
            }

            if ((btedesce3.BackColor != System.Drawing.Color.Red) && (simulador.GetBteDown(3)))
            {
                btedesce3.BackColor = System.Drawing.Color.Red;
            }

            if ((bteterreo.BackColor != System.Drawing.Color.Red) && (simulador.GetBte(0)))
            {
                bteterreo.BackColor = System.Drawing.Color.Red;
            }

            if ((bteandar4.BackColor != System.Drawing.Color.Red) && (simulador.GetBte(4)))
            {
                bteandar4.BackColor = System.Drawing.Color.Red;
            }

        }


    }
}
