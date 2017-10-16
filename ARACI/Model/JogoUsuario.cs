using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARACI.Model
{
    class JogoUsuario
    {
        private int idJogo;
        private int idUsuario ;
        private int pontos;

        public JogoUsuario(int idJogo, int idUsuario, int pontos)
        {
            this.idJogo = idJogo;
            this.idUsuario = idUsuario;
            this.pontos = pontos;
        }

        public int IdJogo { get => idJogo;  }
        public int IdUsuario { get => idUsuario;  }
        public int Pontos { get => pontos; }
    }
}
