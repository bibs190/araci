using ARACI.DAO;
using ARACI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARACI.Service
{
    class AtualizarPontosServices
    {

        private PontuarDAO pontuarDAO = new DAO.PontuarDAO();

        public void atualizarPontos(JogoUsuario jogoAtual)
        {
            int pontoOld  = pontuarDAO.ConsultarPontuacaoAnterior(jogoAtual);

            JogoUsuario jogoUpdate =
                new JogoUsuario(jogoAtual.IdJogo, jogoAtual.IdUsuario, jogoAtual.Pontos + pontoOld);

           pontuarDAO.AtualizarPontos(jogoUpdate);
        }
    }
}
