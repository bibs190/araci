using ARACI.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ARACI.DAO
{
    class UsuarioDAO
    {

        SqlConnection conection; //nomeou a conexão
        SqlCommand comando;// nomeou o comando

        public UsuarioDAO() { }

        public Usuario Login(Usuario usuario)
        {

            try
            {
                conection = Conexão.ConectaBanco();
                comando = conection.CreateCommand();
                comando.CommandText = "select id_usuario, Nome, email_usuario from usuario where email_usuario = @email_usuario and senha_usuario = @senha_usuario";
                comando.Parameters.AddWithValue("email_usuario", usuario.Email);
                comando.Parameters.AddWithValue("senha_usuario", usuario.Senha);
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows) {
                    Usuario usuarioLogado = new Usuario();
                    while (dr.Read())
                    {
                        usuarioLogado.Id =  dr.GetInt32(0);
                        usuarioLogado.Nome = dr.GetString(1);
                        usuarioLogado.Email = dr.GetString(2);

                    }
                    return usuarioLogado;
                }
                else {
                    return null;
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                comando.Connection.Close();
            }
            return null;

        }

        public Boolean Cadastrar(Usuario usuario){

            try
            {
                //cadastra o usuário no sistema
                conection = Conexão.ConectaBanco(); // chama a classe conexão para conectar com o banco
                comando = conection.CreateCommand();//iguala a variavel de comando com a de conexao, acessando o método para criar comandos
                comando.CommandType = CommandType.Text; ; // o tipo do comando será igual a CommandType.Text
                String strSQL = "insert into usuario(Nome, email_usuario, senha_usuario) values(@Nome, @email_usuario, @senha_usuario)"; //executa pesquisa no banco
                strSQL += ";";
                strSQL += "SELECT SCOPE_IDENTITY()"; //pega o ultimo id gravado na tabela
                comando.CommandText = strSQL; // deu o insert para a strSQL

                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = usuario.Nome;//iguala o valr digitado pelo usuário ao tipo de dado do banco
                comando.Parameters.Add("@email_usuario", SqlDbType.VarChar).Value = usuario.Email;//iguala o valr digitado pelo usuário ao tipo de dado do banco
                comando.Parameters.Add("@senha_usuario", SqlDbType.VarChar).Value = usuario.Senha;//iguala o valr digitado pelo usuário ao tipo de dado do banco


                Object a = comando.ExecuteScalar(); // executa a query
                int i = int.Parse(Convert.ToString(a) );
                //comando.CommandText = "select * from usuario"; // seleciona todos os registros da tabela
                if (i > 0) {
                    CriarPontuacao(i);
                }
               
                return i > 0;            
            }

            catch (Exception ex)//se houver algum erro, este metodo sera executado
            {

                MessageBox.Show("Parece que este email já esta cadastrado... Tente outro.", ex.Message); //mensagem padrão de erro

            }
            finally
            {
                comando.Connection.Close(); //fecha a conexao com o banco
            }
            
            return false;
        }

        private void CriarPontuacao(int idUsuario)
        {
            
            String strSQL = "insert into USUARIO_JOGO(ID_jogo, ID_usuario, ponto_nivel_jogo) values(@ID_jogo, @ID_usuario, @ponto_nivel_jogo)"; //executa pesquisa no banco



            for (int idJogo = 1;idJogo <= 5 ;idJogo++)
            {
                comando = conection.CreateCommand();//iguala a variavel de comando com a de conexao, acessando o método para criar comandos
                comando.CommandType = CommandType.Text; ; // o tipo do comando será igual a CommandType.Text
                comando.CommandText = strSQL;
                comando.Parameters.Add("@ID_jogo", SqlDbType.Int).Value = idJogo;//iguala o valr digitado pelo usuário ao tipo de dado do banco
                comando.Parameters.Add("@ID_usuario", SqlDbType.Int).Value = idUsuario;
                comando.Parameters.Add("@ponto_nivel_jogo", SqlDbType.Int).Value = 0;//iguala o valr digitado pelo usuário ao tipo de dado do banco
                comando.ExecuteNonQuery();
            }

            
            



        }

    }
}
