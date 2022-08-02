using Exercicio02.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercicio02
{
    public partial class frmHome : Form
    {
        public Lanterna Lanterna { get; set; }
        public frmHome()
        {
            InitializeComponent();
            Lanterna = new Lanterna();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                if (timer1.Enabled)
                    progressBar1.Value -= 1;

                if (progressBar1.Value == 0)
                {
                    Lanterna.Status = false;
                    btnLigaDesliga.Enabled = false;
                    CorBotao();
                }
            }
            timer1.Enabled = Lanterna.Status;
            lblCapacidade.Text = $"{progressBar1.Value}%";
        }

        void CorBotao()
        {
            if (Lanterna.Status)
            {
                btnLigaDesliga.Text = "Ligado";
                btnLigaDesliga.BackColor = Color.Green;
            }
            else
            {
                btnLigaDesliga.Text = "Desligado";
                btnLigaDesliga.BackColor = Color.Red;
            }
        }

        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {
            if (Lanterna.Status)
                Lanterna.Status = false;
            else
                Lanterna.Status = true;

            timer1.Enabled = Lanterna.Status;
            CorBotao();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            progressBar1.Value = Lanterna.capacidade;
            lblCapacidade.Text = string.Format($"{progressBar1.Value}%", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = Lanterna.capacidade;
            btnLigaDesliga.Enabled = true;
        }
    }
}
