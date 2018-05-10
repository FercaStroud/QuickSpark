using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QuickSpark
{
    public partial class Form1 : Form
    {
        bool bandera;
        int contadoropo = 20;
        int contador = 20;
        Random r = new Random();
        Carta[] pb = new Carta[8];
        int[] VarOponente = new int[4];
        Carta cartasel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iniSlotsPozo();
            iniSlotsUser();
            pb[0].Enabled = false;
            pb[1].Enabled = false;
            pb[2].Enabled = false;
            pb[3].Enabled = false;
            WMPl("Megaman 2");
        }
        public void iniSlotsPozo()
        {

            int x = 110, y = 173;
            for (int k = 0; k <= 3; k++)
            {
                y = 173;
                x += 90;

                pb[k] = new Carta();
                pb[k].Location = new Point(x, y);
                pb[k].Size = new Size(78, 101);
                pb[k].BorderStyle = BorderStyle.FixedSingle;
                pb[k].Image = Image.FromFile("Carta0.jpg");
                pb[k].Cursor = System.Windows.Forms.Cursors.Hand;
                pb[k].Click += new EventHandler(GameopoClick);
                this.Controls.Add(pb[k]);
                pb[k].BringToFront();
                pb[k].Pos = k;
            }
        }

        public void iniSlotsUser()
        {
            int a = 110, b = 173;
            for (int i = 4; i <= 7; i++)
            {
                a += 90;
                b = 320;
                pb[i] = new Carta();
                pb[i].Location = new Point(a, b);
                pb[i].Size = new Size(78, 101);
                pb[i].BorderStyle = BorderStyle.FixedSingle;
                pb[i].Image = Image.FromFile("Carta0.jpg");
                pb[i].Cursor = System.Windows.Forms.Cursors.Hand;
                pb[i].Click += new EventHandler(GameClick);
                this.Controls.Add(pb[i]);
                pb[i].BringToFront();
                pb[i].Pos = i;
            }
        }

        void JuegaOponente()
        {
            if (contadoropo == 1)
            {
                F1.Text = "PERDISTE";
                label1.Text = "Perdiste";
                timerOponente.Enabled = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        int operador = 0;
                        if (pb[k].Bandera)
                            operador = 1;
                        else
                            operador = -1;
                        if (VarOponente[i] == pb[k].Valor + operador)
                        {
                            contadoropo--;
                            label1.Text = "Restan: " + contadoropo;
                            lboponente.Visible = true;
                            pb[k].Valor = VarOponente[i];
                            pb[k].Image = Image.FromFile("Carta" + VarOponente[i] + ".jpg");
                            VarOponente[i] = r.Next(1, 14);
                            WMP("Track 7");
                            return;
                        }
                    }
                }

            }
        }

        void GameClick(object sender, EventArgs e)
        {
            if (label2.Text == "GANASTE!!!!!!")
            {
                bandera = true;
            }
            else
            {
                cartasel = ((Carta)sender);
                bandera = false;
                lbuser.Visible = false;
                lboponente.Visible = false;
                pb[0].Enabled = true;
                pb[1].Enabled = true;
                pb[2].Enabled = true;
                pb[3].Enabled = true;
                
#if DEBUG
                pictureBox8.Image = cartasel.Image;
#endif
            }

        }
        void GameopoClick(object sender, EventArgs e)
        {
            if (contador == 1)
            {
                MessageBox.Show("Ganaste");
                label2.Text = "GANASTE!!!!!!";
                F1.Text = "GANASTE";

                timer1.Enabled = false;
                timerOponente.Enabled = false;
                timer1.Enabled = false;
                timer2.Enabled = false;

            }
            else
            {
                int pos = ((Carta)sender).Pos;
                if (bandera != true && cartasel.Valor == pb[pos].Valor - 1 && pb[pos].Bandera == false)
                {
                    bandera = true;
                    pb[pos].Image = cartasel.Image;
                    pb[pos].Valor = cartasel.Valor;
                    contador--;
                    label2.Text = "Restan: " + contador.ToString();
                    lbuser.Visible = true;
                    asignar(cartasel.Pos);
                    WMP("Track 8");
                }
                else if (bandera != true && cartasel.Valor == pb[pos].Valor + 1 && pb[pos].Bandera == true)
                {
                    bandera = true;
                    pb[pos].Image = cartasel.Image;
                    pb[pos].Valor = cartasel.Valor;
                    contador--;
                    label2.Text = "Restan: " + contador.ToString();
                    lbuser.Visible = true;
                    asignar(cartasel.Pos);
                    WMP("Track 8");

                }
            }

        }
        public void RandOponente()
        {
            int j = 0;
            for (int i = 0; i < 4; i++, j++)
            {
                VarOponente[i] = r.Next(1, 14);
            }
        }

        public void RandPozo()
        {
            int j = 0;
            for (int i = 0; i < 4; i++, j++)
            {
                asignar(j);
            }
        }

        public void RandUser()
        {
            int j = 4;
            for (int i = 0; i < 4; i++, j++)
            {
                asignar(j);
            }
        }
        private void asignar(int j)
        {
            pb[j].Valor = r.Next(1, 14);
            pb[j].Image = Image.FromFile("Carta" + pb[j].Valor + ".jpg");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Repartir_Click(object sender, EventArgs e)
        {
            RandOponente();
            RandPozo();
            RandUser();
            
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timerOponente.Enabled = true;
            Repartir.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int flecha1 = r.Next(0, 100);
            int flecha2 = r.Next(0, 100);
            int flecha3 = r.Next(0, 100);
            int flecha4 = r.Next(0, 100);
            if (flecha1 % 2 == 0)
            {
                FLECHA1.Image = Image.FromFile("UP.png");
                pb[0].Bandera = true;
            }
            else
            {
                FLECHA1.Image = Image.FromFile("DOWN.png");
                pb[0].Bandera = false;
            }
            if (flecha2 % 2 == 0)
            {
                FLECHA2.Image = Image.FromFile("UP.png");
                pb[1].Bandera = true;
            }
            else
            {
                FLECHA2.Image = Image.FromFile("DOWN.png");
                pb[1].Bandera = false;
            }
            if (flecha3 % 2 == 0)
            {
                FLECHA3.Image = Image.FromFile("UP.png");
                pb[2].Bandera = true;
            }
            else
            {
                FLECHA3.Image = Image.FromFile("DOWN.png");
                pb[2].Bandera = false;
            }
            if (flecha4 % 2 == 0)
            {
                FLECHA4.Image = Image.FromFile("UP.png");
                pb[3].Bandera = true;
            }
            else
            {
                FLECHA4.Image = Image.FromFile("DOWN.png");
                pb[3].Bandera = false;
            }
        }

        private void timerOponente_Tick(object sender, EventArgs e)
        {
            JuegaOponente();  
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            RandPozo();
            pictureBox6.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
        }

        void WMP(string sonidito)
        {
            if (sonidito == "Track 8")
            {
                WMP1.URL = Directory.GetCurrentDirectory() + "/Track 8.mp3";
                WMP1.Ctlcontrols.play();
            }
            else if (sonidito == "Track 7")
            {
                WMP1.URL = Directory.GetCurrentDirectory() + "/Track 7.mp3";
                WMP1.Ctlcontrols.play();
            }
        }

        void WMPl(string sonidito2)
        {
            if (sonidito2 == "Megaman 2")
            {
                WMP2.URL = Directory.GetCurrentDirectory() + "/Megaman 2 .mp3";
                WMP2.Ctlcontrols.play();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            F1.Visible = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            F1.Visible = false;
        }




    }
}