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
    public partial class Nivel3_numero0 : Form
    {
        private Usuario usuario;

        private AtualizarPontosServices atualizaPontosService = new AtualizarPontosServices();

        internal Usuario Usuario { set => usuario = value; }

        public Nivel3_numero0()
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
            pictureBox1.Image = Properties.Resources._0;
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
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Enabled = false;
                MessageBox.Show("Você não conseguiu atingir o número 0", "Fim de jogo");
                this.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //se o timer começar a rodar(sendo igual a true)
            {
                pictureBox1.Image = Properties.Resources.boom; // quando se clicar na imagem do picture box, ela irá ser igual a imagem boom
                timer1.Enabled = false; //o timer vai parar de rodar
                timer2.Enabled = false; //o timer vai parar de rodar

                MessageBox.Show("Você conseguiu acertar o número 0. Parabéns!!", "fim de jogo"); //a mensagem aparecerá em seguida
                progressBar1.Value = 0; // o representante do timer irá zerar
                Icon a = Properties.Resources.alvo; // deixa  cursor com a imagem de alvo novamente
                this.Cursor = new Cursor(a.Handle);
                atualizarPontuacao();


                Nivel3_numero1 numero1 = new Nivel3_numero1();
                numero1.Usuario = usuario;
                numero1.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Aperte o botão 'começar' "); // se a pessoa não clicar no botao começar, esta mensagem aparecerá e  jogo não vai executar
            }

        }

        private void Nivel3_numero0_Load(object sender, EventArgs e)
        {

        }
    }
}
