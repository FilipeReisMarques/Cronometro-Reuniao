using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Relogio
{
    public partial class Form1 : Form
    {
        int seg = 60;
        int min;
        int horas = 0;


        public Form1()
        {
            InitializeComponent();
            //seg = min = horas = 0;
        }

        Stopwatch Relogio = new Stopwatch();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Tempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == 8)
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            seg -= 1;
            string minutos = appendZero(min);
            string hor = appendZero(horas);
            string segundos = appendZero(seg);

            if (horas < 10) { hor = "0" + horas.ToString(); }
            if (min < 10) { minutos = "0" + min.ToString(); }
            if (seg < 10) { segundos = "0" + seg.ToString(); }


            if (seg == 60)
            {
                seg = 0;//repor os segundos a 0
                min++; //adicionar +1 aos minutos
            }
            if (min == 59)
            {
                min = 0;
                horas++;
            }
            if (seg > 59)
            {
                min++;
                seg = 0;
            }

            if (min > 60)
            {
                min = 0;
                horas = 1;
            }


            if (seg == 0 && min > 0)
            {
                min -= 1;
                seg = 60;
            }

            if (min == 0 && horas > 0 && seg == 0)
            {
                seg = 60;
                horas -= 1;
                min = 59;
            }

            temporizador.Text = hor + ":" + minutos + ":" + segundos;

            if (min == 0 && horas == 0 && seg == 0)
            {
                timer1.Stop();
                MessageBox.Show("O tempo acabou!", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string appendZero(double str)
        {
            if (str <= 9)
                return "0" + str;
            else
                return str.ToString();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (min > 60)
            {
                MessageBox.Show("","");
            }
            else
            {
                min = int.Parse(Tempo.Text) - 1;
                //tempo_tempo = Convert.ToInt32(Tempo.Text);

                if (btniniciar.Text == "Pausar")
                {
                    Relogio.Start();
                    btniniciar.Text = "Iniciar";
                    timer1.Enabled = false;
                }
                else
                {
                    btniniciar.Text = "Pausar";
                    timer1.Enabled = true;
                    Relogio.Stop();
                    btniniciar.Enabled = true;
                }
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btnreninciar_Click(object sender, EventArgs e)
        {
            Relogio.Stop();
            temporizador.Text = "00:00:00";

            horas = 0;
            min = int.Parse(Tempo.Text) - 1;
            seg = 60;

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            painelTopo.Visible = false;
            painelRodape.Visible = false;
        }

        private void Tempo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

