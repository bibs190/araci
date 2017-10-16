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
    public partial class Nivel5 : Form
    {
        private Usuario usuario;
        private AtualizarPontosServices atualizaPontosService = new AtualizarPontosServices();

        private void atualizarPontuacao()
        {
            JogoUsuario jogoUsuario = new JogoUsuario(Jogo.QUEBRA_CABECA, usuario.Id, Pontuacao.JOGO_5);
            atualizaPontosService.atualizarPontos(jogoUsuario);
        }

        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> ListaOriginaldeFotos = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        internal Usuario Usuario { set => usuario = value; }

        public Nivel5()
        {
            InitializeComponent();
            ListaOriginaldeFotos.AddRange(new Bitmap[] {Properties.Resources.numero1Nivel4, Properties.Resources.numero2Nivel4, Properties.Resources.numero3Nivel4,
                Properties.Resources.numero4Nivel4, Properties.Resources.numero5Nivel4, Properties.Resources.numero6Nivel4, Properties.Resources.numero7Nivel4,
                Properties.Resources.numero8Nivel4, Properties.Resources.numero9Nivel4, Properties.Resources.black });

            lblMovimentosFeitos.Text += inmoves;
            lblTimeElapse.Text = "00:00:00";
        }

        private void Nivel4_Load(object sender, EventArgs e)
        {
            Embaralhar();
        }

        void Embaralhar()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 }); // 8 nao esta presente - pois é a ultima parte da foto
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = ListaOriginaldeFotos[j];
                    if (j == 9) inNullSliceIndex = i; //indice do pictureBox vazio
                }
            } while (VerificarVitoria());
        }

        private void btnSuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapse.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Tem certeza de que deseja reiniciar o nível?", "Quebra-cabeça", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (YesOrNo == DialogResult.Yes || lblTimeElapse.Text == "00:00:00")
            {
                Embaralhar();
                timer.Reset();
                lblTimeElapse.Text = "00:00:00";
                inmoves = 0;
                lblMovimentosFeitos.Text = "Movimentos Feitos: 0";
            }
        }

        private void  PedirPermissaoAntesSair(object sender, FormClosingEventArgs e)
        {
            DialogResult SimOuNao = MessageBox.Show("Tem certeza de que deseja sair ?", "Quebra-Cabeça", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != BtnSair && SimOuNao == DialogResult.No) e.Cancel = true;
            if (sender as Button == BtnSair && SimOuNao == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void SwitcPictureBox(object sender, EventArgs e)
        {
            if (lblTimeElapse.Text == "00:00:00")
                timer.Start();

            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrother = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrother.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = ListaOriginaldeFotos[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovimentosFeitos.Text = "Movimentos Feitos:" + (++inmoves);
                    if (VerificarVitoria())
                    {
                        MessageBox.Show("executado");
                        timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = ListaOriginaldeFotos[8];
                        MessageBox.Show("Parabéns! Você conseguiu montar \n o quebra-cabeça em : " + timer.Elapsed.ToString().Remove(8)
                            + "\nTotal de movimentos feito: " + inmoves, "Rabbit Puzzle");
                        inmoves = 0;
                        lblMovimentosFeitos.Text = "Movimentos Feitos: 0";
                        lblTimeElapse.Text = "00:00:00";
                        timer.Reset();
                        Embaralhar();
                    }
                }
            }

        }

        bool VerificarVitoria()
        {
            int i;
            for (i = 0; i == 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != ListaOriginaldeFotos[i]) break;

            }

            if (i == 8) return true;
            else return false;
        }


        private void UpdateTimeElapse(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapse.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "3")
            {
                timer.Reset();
                lblMovimentosFeitos.Text = "Movimentos Feito: 0";
                lblTimeElapse.Text = "00:00:00";
                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("O tempo acabou! Tente Novamente", "Quebra-cabeça");
                Embaralhar();
            }
        }

        private void lblTimeElapse_Click(object sender, EventArgs e)
        {

        }

        private void lblMovimentosFeitos_Click(object sender, EventArgs e)
        {

        }

        private void Nivel5_Load(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pausar")
            {
                timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Reiniciar";
            }
            else
            {
                timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pausar";
            }
        }
    }
}
