using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARACI.DAO;
using ARACI.Model;
using System.Data.SqlClient;
using System.Data;

namespace ARACI.DAO
{
    class PontuarDAO
    {
        SqlConnection conection; //nomeou a conexão
        SqlCommand comando;// nomeou o comando


        public PontuarDAO()
        { }

        public int ConsultarPontuacaoAnterior(JogoUsuario jogoUsuario)
        {
            
            conection = Conexão.ConectaBanco(); // chama a classe conexão para conectar com o banco
            comando = conection.CreateCommand();//iguala a variavel de comando com a de conexao, acessando o método para criar comandos
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select ponto_nivel_jogo from USUARIO_JOGO  where  ID_jogo = @ID_jogo and ID_usuario = @ID_usuario ";
            comando.Parameters.AddWithValue("ID_jogo", jogoUsuario.IdJogo);
            comando.Parameters.AddWithValue("ID_usuario", jogoUsuario.IdUsuario);


            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                
                while (dr.Read())
                {
                    return dr.GetInt32(0);   

                }
                
            }
            return 0;

        }

        public void AtualizarPontos(JogoUsuario jogoUsuario)
        {
           
            conection = Conexão.ConectaBanco(); // chama a classe conexão para conectar com o banco
            comando = conection.CreateCommand();//iguala a variavel de comando com a de conexao, acessando o método para criar comandos
            comando.CommandType = CommandType.Text;
            comando.CommandText = "update USUARIO_JOGO SET ponto_nivel_jogo = @ponto_nivel_jogo where ID_jogo = @ID_jogo and ID_usuario = @ID_usuario; "; //executa pesquisa no banco
            comando.Parameters.Add("@ID_jogo", SqlDbType.Int).Value = jogoUsuario.IdJogo;//iguala o valr digitado pelo usuário ao tipo de dado do banco
            comando.Parameters.Add("@ID_usuario", SqlDbType.Int).Value = jogoUsuario.IdUsuario;//iguala o valr digitado pelo usuário ao tipo de dado do banco
            comando.Parameters.Add("@ponto_nivel_jogo", SqlDbType.Int).Value = jogoUsuario.Pontos;//iguala o valr digitado pelo usuário ao tipo de dado do banco

            comando.ExecuteNonQuery();
        }


        public void Pontuar(int id_jogo, int id_usuario)
        {
            conection = Conexão.ConectaBanco(); // chama a classe conexão para conectar com o banco
            comando = conection.CreateCommand();//iguala a variavel de comando com a de conexao, acessando o método para criar comandos
            comando.CommandType = CommandType.Text;  // o tipo do comando será igual a CommandType.Text
            String strSQL = "insert into USUARIO_JOGO(ID_jogo, ID_usuario, nivel_jogo, ponto_nivel_jogo) values(@ID_jogo, @nivel_jogo, @ponto_nivel_jogo)"; //executa pesquisa no banco
            strSQL += ";";
            strSQL += "SELECT SCOPE_IDENTITY()";
            comando.CommandText = strSQL;

            comando.Parameters.Add("@ID_jogo", SqlDbType.Int).Value = id_jogo;//iguala o valr digitado pelo usuário ao tipo de dado do banco
            comando.Parameters.Add("@ID_usuario", SqlDbType.Int).Value = id_usuario;//iguala o valr digitado pelo usuário ao tipo de dado do banco
            comando.Parameters.Add("@nivel_jogo", SqlDbType.Int).Value = 1;//iguala o valr digitado pelo usuário ao tipo de dado do banco
            comando.Parameters.Add("@ponto_nivel_jogo", SqlDbType.Int).Value = 0;//iguala o valr digitado pelo usuário ao tipo de dado do banco


            Object a = comando.ExecuteScalar(); // executa a query
            int i = int.Parse(Convert.ToString(a));
            //comando.CommandText = "select * from usuario"; // seleciona todos os registros da tabela

        }


    }
}