using ARACI.Model;
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
using ARACI.Service;

namespace ARACI
{
    public partial class MenuPrincipal : Form
    {

        
        private Usuario usuario;
        private AtualizarPontosServices atualizaPontosService = new AtualizarPontosServices();
        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public void atualizarPontuacao_NIVEL4()
        {
            JogoUsuario jogoUsuario = new JogoUsuario(Jogo.MEMORIA, usuario.Id, Pontuacao.JOGO_4);
            atualizaPontosService.atualizarPontos(jogoUsuario);
        }

        public void atualizarPontuacao_NIVEL5()
        {
            JogoUsuario jogoUsuario = new JogoUsuario(Jogo.QUEBRA_CABECA, usuario.Id, Pontuacao.JOGO_5);
            atualizaPontosService.atualizarPontos(jogoUsuario);
        }
        public MenuPrincipal()
        {
            InitializeComponent();
           
        }

        


        private void btn1nivel_Click(object sender, EventArgs e)
        {
            

            Nivel1 nivel1 = new Nivel1();
            nivel1.Usuario = usuario;
            nivel1.atualizarPontuacao();
            nivel1.Show();
            MessageBox.Show("´Bem-vindo ao mundo dos números!");
            //ABRE O NIVEL 1
        }

        private void btn2_nivelCLICK(object sender, EventArgs e)
        {
          

            Nivel2 nivel2 = new Nivel2();
            nivel2.Usuario = usuario;
            MessageBox.Show("Repita os sons dos números quantas vezes quiser!");
            nivel2.Show();
            //ABRE O NIVEL 2
        }

        private void btn3nivel_Click(object sender, EventArgs e)
        {

            Nivel3_numero0 nivel = new Nivel3_numero0();
            MessageBox.Show("Acerte os números");
            nivel.Usuario = usuario;
            nivel.Show();
            //ABRE O NIVEL 3
        }


        private void btn4nivel_Click(object sender, EventArgs e)
        {
        
            Nivel4 nivel4 = new Nivel4();
            MessageBox.Show("Exercite sua memória!");
            atualizarPontuacao_NIVEL4();
            nivel4.Show();
            //ABRE O NIVEL 4
        }

        private void btn5NivelCLICK(object sender, EventArgs e)
        {
           

            Nivel5 nivel5 = new Nivel5();
            MessageBox.Show("Monte a imagem!");
            atualizarPontuacao_NIVEL5();
            nivel5.Show();
            //ABRE O NIVEL 5
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //this.Close();
            //login.Close();
            Environment.Exit(0);
            //fecha o formulário
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Classificacao classificacao = new Classificacao();
            classificacao.Show();
        }
    }
}
