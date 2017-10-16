using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using ARACI.Model;
using ARACI.DAO;

namespace ARACI
{
    public partial class Login : Form
    {

        private UsuarioDAO usuarioDAO;

        public Login()
        {
            InitializeComponent();
            usuarioDAO = new UsuarioDAO();
        }
        

        private void btn1Ok_Click(object sender, EventArgs e)
        {
            Usuario usuario  = new Usuario();

            usuario.Email = txtUserID.Text;
            usuario.Senha = txtSenha.Text;

            usuario = usuarioDAO.Login(usuario);

           if ( usuario != null )
            {
                MenuPrincipal objFormulario2 = new MenuPrincipal(); //criou um objeto do forulário 2
                objFormulario2.Usuario = usuario;
                objFormulario2.Show(); // chamou o método "show" para exibir o formulário 2
               
                Hide(); // metodo chamado para fechar este formulário(o form 1) e ficar aberto
                        // apenas o que estará em uso (form 2)  
            }
            else
            {
                MessageBox.Show("Email / Senha incorreto!");
            }

           

        }

        private void btn2Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
