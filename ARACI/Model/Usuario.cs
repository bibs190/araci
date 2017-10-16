using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARACI.Model
{
    class Usuario
    {
        private int id;
        private string email;
        private string nome;
        private string senha;
        private int qntd_pontos = 0;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public int Qntd_pontos
        {
            get
            {
                return qntd_pontos;
            }

            set
            {
               this.qntd_pontos = qntd_pontos;
            }
        }
    }

      
}

