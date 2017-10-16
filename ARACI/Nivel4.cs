using ARACI.Model;
using ARACI.Service;
using System;
using System.Collections;
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
    public partial class Nivel4 : Form
    {
     
       
       


        int tamanhoColunasFileiras = 4;
        int movimentos = 0;
        int quantidadeCartasViradas = 0;

        List<string> CartasEnumeradas;
        List<string> CartasViradas;

        ArrayList CartasSelecionadas;

        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;

        int cartaAtual = 0;

       

        public Nivel4()
        {
            InitializeComponent();
            IniciarJogo();
            
        }

        public void IniciarJogo()
        {
            timer1.Enabled = false;
            timer1.Stop();

            lblRecordNumero.Text = "0";

            quantidadeCartasViradas = 0;
            movimentos = 0;

            PainelJogo.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasViradas = new List<string>();
            CartasSelecionadas = new ArrayList();

            for(int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }

            var NumeroAleatorio = new Random();
            var resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());

            foreach (string valorCarta in resultado)
            {
                CartasViradas.Add(valorCarta);
            }

            var TablePainel = new TableLayoutPanel();
            TablePainel.RowCount = tamanhoColunasFileiras;
            TablePainel.ColumnCount = tamanhoColunasFileiras;

            for (int i = 0; i < tamanhoColunasFileiras; i ++)
            {
                var porcentagem = 150f / (float)tamanhoColunasFileiras - 10;
                TablePainel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, porcentagem));
                TablePainel.RowStyles.Add(new RowStyle(SizeType.Percent, porcentagem));
            }

            int contadorCartas = 0;
            for (var i = 0; i < tamanhoColunasFileiras; i ++)
            {
                for (var j = 0; j < tamanhoColunasFileiras; j++)
                {
                    var CartasJogo = new PictureBox();
                    CartasJogo.Name = string.Format("{0}", contadorCartas);
                    CartasJogo.Dock = DockStyle.Fill;
                    CartasJogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJogo.Image = Properties.Resources.Girada;
                    CartasJogo.Cursor = Cursors.Hand;
                    CartasJogo.Click += btnCarta_Click;
                    TablePainel.Controls.Add(CartasJogo, j, i);
                    contadorCartas++;
                }
            }
            TablePainel.Dock = DockStyle.Fill;
            PainelJogo.Controls.Add(TablePainel);


        }

        private void Nivel5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (CartasSelecionadas.Count < 2)
            {
                movimentos++;
                lblRecordNumero.Text = Convert.ToString(movimentos);
                var CartasSelecionadasUsuario = (PictureBox)sender;
                var nn = CartasSelecionadasUsuario.Name;
                cartaAtual = Convert.ToInt32(CartasViradas[Convert.ToInt32(nn)]);
                CartasSelecionadasUsuario.Image = RecuperarImagem(cartaAtual);
                CartasSelecionadas.Add(CartasSelecionadasUsuario);

                // dois eventos se realizaram
                if (CartasSelecionadas.Count == 2) {

                    CartaTemporal1 = (PictureBox)CartasSelecionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSelecionadas[1];
                    int carta1 = Convert.ToInt32(CartasViradas[Convert.ToInt32(CartaTemporal1.Name)]);
                    int carta2 = Convert.ToInt32(CartasViradas[Convert.ToInt32(CartaTemporal2.Name)]);

                    if (carta1 != carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        quantidadeCartasViradas++;
                        if (quantidadeCartasViradas> 7)
                        {
                            MessageBox.Show("O jogo Terminou");
                           
                        }
                        CartaTemporal1.Enabled = false;
                        CartaTemporal2.Enabled = false;

                        CartasSelecionadas.Clear();
                    }
                }
            }
        }

        public Bitmap RecuperarImagem(int NumeroImagem) {
            Bitmap tmpImg = new Bitmap(200, 100);
            switch (NumeroImagem) {
                case 0: tmpImg = Properties.Resources.numero9;
                    break;
                default: tmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("numero" + NumeroImagem);
                    break;
            }
            return tmpImg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tempoVirarCarta = 1;
            if (tempoVirarCarta == 1) {
                CartaTemporal1.Image = Properties.Resources.Girada;
                CartaTemporal2.Image = Properties.Resources.Girada;
                CartasSelecionadas.Clear();

                timer1.Stop();
            }
        }
    }
}
