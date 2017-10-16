using ARACI.DAO;
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
    public partial class Nivel1 : Form
    {
        private Usuario usuario;
        internal Usuario Usuario { get => usuario; set => usuario = value; }
        private AtualizarPontosServices atualizaPontosService = new AtualizarPontosServices();

        public Nivel1()
        {
            InitializeComponent();

        }

        public void atualizarPontuacao()
        {
            JogoUsuario jogoUsuario = new JogoUsuario(Jogo.VIDEO, usuario.Id, Pontuacao.JOGO_1);
            atualizaPontosService.atualizarPontos(jogoUsuario);
        }

        private void Nivel1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
