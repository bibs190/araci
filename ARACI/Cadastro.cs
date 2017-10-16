using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ARACI
{
    public partial class Cadastro : Form
    {

        private DAO.UsuarioDAO usuarioDAO;

        public Cadastro()
        {
            InitializeComponent();
            usuarioDAO = new DAO.UsuarioDAO();
        }      
       

        private void btnOK_Click(object sender, EventArgs e)
        {
            Model.Usuario usuario = new Model.Usuario();
            usuario.Nome = TxtNome.Text;
            usuario.Email = TxtEmail.Text;
            usuario.Senha = TxtSenha.Text;

            if (usuarioDAO.Cadastrar(usuario))
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
                Close();
            }
           
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); //fecha o formulário
        }
    }
}
