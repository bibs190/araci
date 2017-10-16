using ARACI.Model;
using ARACI.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARACI
{
    public partial class Nivel3_numero3 : Form
    {
        private Usuario usuario;
        private AtualizarPontosServices atualizaPontosService = new AtualizarPontosServices();

        internal Usuario Usuario { set => usuario = value; }

        public Nivel3_numero3()
        {
            InitializeComponent();
            Icon a = Properties.Resources.alvo;
            this.Cursor = new Cursor(a.Handle);
        }

        private void atualizarPontuacao()
        {
            JogoUsuario jogoUsuario = new JogoUsuario(Jogo.TIRO_ALVO, usuario.Id, Pontuacao.JOGO_3);
            atualizaPontosService.atualizarPontos(jogoUsuario);
        }

        private void btncomecar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            pictureBox1.Image = Properties.Resources._3;
            timer1.Enabled = true;
            timer2.Enabled = true; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox1.Top = rd.Next(Height - pictureBox1.Height);
            pictureBox1.Left = rd.Next(Width - pictureBox1.Width);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Enabled = false;
                MessageBox.Show("Você não conseguiu atingir o número 3", "Fim de jogo");
                this.Close();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                pictureBox1.Image = Properties.Resources.boom;
                timer1.Enabled = false;
                timer2.Enabled = false;

                MessageBox.Show("Você conseguiu acertar o número 3. Parabéns!!", "fim de jogo");
                progressBar1.Value = 0;
                Icon a = Properties.Resources.alvo;
                this.Cursor = new Cursor(a.Handle);
                atualizarPontuacao();


                Nivel3_numero4 numero4 = new Nivel3_numero4();
                numero4.Usuario = usuario;
                numero4.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Aperte o botão 'começar' ");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Nivel3_numero2 numero2 = new Nivel3_numero2();
            numero2.Show();
            this.Close();
        }
    }
}
