using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARACI.DAO;
using ARACI.Model;
using ARACI.Service;

namespace ARACI
{
    public partial class Nivel2 : Form
    {

        private Usuario usuario;

        private AtualizarPontosServices atualizaPontosService = new AtualizarPontosServices();

        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public Nivel2()
        {
            InitializeComponent();
        }

        private void atualizarPontuacao()
        {
            JogoUsuario jogoUsuario = new JogoUsuario(Jogo.AUDIO, usuario.Id, Pontuacao.JOGO_2);
            atualizaPontosService.atualizarPontos(jogoUsuario);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero1.wav");//acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();
        }

       
        private void btn2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero2.wav");//acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero3.wav");//acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero4.wav");//acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero5.wav");//acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero6.wav");//acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); //cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero7.wav"); //acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero8.wav");//acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero9.wav");//acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//cria a variavel de midia com o nome dialog
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\audioNumeros\numero0.wav");//acessa o arquivo de adio do tipo wav
            MeuPlayer.Play();
            atualizarPontuacao();
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            Close(); //fecha o formulário
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
