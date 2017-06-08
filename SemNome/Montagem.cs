using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemNome
{
    public partial class Montagem : Form
    {
        int qDias = 0, periodo = 0, dias = 0;

        private void timer8h_Tick(object sender, EventArgs e)
        {
            timer8h.Stop();
            dias = dias + 1;

            switch (qDias)
            {
                case 1:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    MessageBox.Show("Acabou o período programado.");
                    qDias = 0;
                    dias = 0;
                    break;

                case 2:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer8h.Start();
                    if (dias == 2)
                    {
                        timer8h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 3:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer8h.Start();
                    if (dias == 3)
                    {
                        timer8h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 4:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer8h.Start();
                    if (dias == 4)
                    {
                        timer8h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 5:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer8h.Start();
                    if (dias == 5)
                    {
                        timer8h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 6:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer8h.Start();
                    if (dias == 6)
                    {
                        timer8h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 7:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer8h.Start();
                    if (dias == 7)
                    {
                        timer8h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;
            }

        }

        private void timer12h_Tick(object sender, EventArgs e)
        {
            timer12h.Stop();
            dias = dias + 1;

            switch (qDias)
            {
                case 1:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    MessageBox.Show("Acabou o período programado.");
                    qDias = 0;
                    dias = 0;
                    break;

                case 2:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer12h.Start();
                    if (dias == 2)
                    {
                        timer12h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 3:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer12h.Start();
                    if (dias == 3)
                    {
                        timer12h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 4:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer12h.Start();
                    if (dias == 4)
                    {
                        timer12h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 5:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer12h.Start();
                    if (dias == 5)
                    {
                        timer12h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 6:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer12h.Start();
                    if (dias == 6)
                    {
                        timer12h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 7:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer12h.Start();
                    if (dias == 7)
                    {
                        timer12h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;
            }
        }

        private void timer24h_Tick(object sender, EventArgs e)
        {
            timer24h.Stop();
            dias = dias + 1;

            switch (qDias)
            {
                case 1:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    MessageBox.Show("Acabou o período programado.");
                    qDias = 0;
                    dias = 0;
                    break;

                case 2:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer24h.Start();
                    if (dias == 2)
                    {
                        timer24h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 3:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer24h.Start();
                    if (dias == 3)
                    {
                        timer24h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 4:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer24h.Start();
                    if (dias == 4)
                    {
                        timer24h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 5:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer24h.Start();
                    if (dias == 5)
                    {
                        timer24h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 6:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer24h.Start();
                    if (dias == 6)
                    {
                        timer24h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;

                case 7:
                    MessageBox.Show("Olá, vamos aproveitar que "+ txtDeixa1.Text + " e " + txtRotina1.Text +" para "+ txtRecompensa1.Text +" :)");
                    timer24h.Start();
                    if (dias == 7)
                    {
                        timer24h.Stop();
                        MessageBox.Show("Acabou o período programado.");
                        qDias = 0;
                        dias = 0;
                    }
                    break;
            }
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbDias.Text = "";
            cmbPeriodo.Text = "";
            txtDeixa1.Text = "";
            txtRotina1.Text = "";
            txtRecompensa1.Text = "";
        }

        public Montagem()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbDias.Text != "" && cmbPeriodo.Text != "")
            {
                qDias = Convert.ToInt32(cmbDias.Text);
                periodo = Convert.ToInt32(cmbPeriodo.Text);

                switch (qDias)
                {
                    case 1:
                        switch (periodo)
                        {
                            case 8:
                                timer8h.Start();
                                break;
                            case 12:
                                timer12h.Start();
                                break;
                            case 24:
                                timer24h.Start();
                                break;
                        }
                        break;

                    case 2:
                        switch (periodo)
                            {
                                case 8:
                                    timer8h.Start();
                                    break;
                                case 12:
                                    timer12h.Start();
                                    break;
                                case 24:
                                    timer24h.Start();
                                    break;
                            }
                        break;

                    case 3:
                        switch (periodo)
                        {
                            case 8:
                                timer8h.Start();
                                break;
                            case 12:
                                timer12h.Start();
                                break;
                            case 24:
                                timer24h.Start();
                                break;
                        }
                        break;

                    case 4:
                        switch (periodo)
                        {
                            case 8:
                                timer8h.Start();
                                break;
                            case 12:
                                timer12h.Start();
                                break;
                            case 24:
                                timer24h.Start();
                                break;
                        }
                        break;

                    case 5:
                        switch (periodo)
                        {
                            case 8:
                                timer8h.Start();
                                break;
                            case 12:
                                timer12h.Start();
                                break;
                            case 24:
                                timer24h.Start();
                                break;
                        }
                        break;

                    case 6:
                        switch (periodo)
                        {
                            case 8:
                                timer8h.Start();
                                break;
                            case 12:
                                timer12h.Start();
                                break;
                            case 24:
                                timer24h.Start();
                                break;
                        }
                        break;

                    case 7:
                        switch (periodo)
                        {
                            case 8:
                                timer8h.Start();
                                break;
                            case 12:
                                timer12h.Start();
                                break;
                            case 24:
                                timer24h.Start();
                                break;
                        }
                        break;
                }
            }
            else
                MessageBox.Show("Quantidade de dias ou horário não definidos, escolha e tente novamente.");

        }
    }
}
