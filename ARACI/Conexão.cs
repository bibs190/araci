using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ARACI
{
    class Conexão
    {
        public static SqlConnection ConectaBanco()
        {
            string strCon = @"Data Source=LAPTOP-IOR439CC;Initial Catalog=bancoaraci;Integrated Security=True"; //conecta a string de conexão
           // string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C: \Users\Bianca Pereira\Desktop\TCC\App\ARACI - Version 10\ARACI\ARACI.mdf"";Integrated Security=True;Connect Timeout=30"; //conecta a string de conexão
            SqlConnection cn = new SqlConnection(strCon); // criou uma instancia(obj) da classe SqlConnection que recebeu como retorno a string de conexao(strCon)
            cn.Open();// abre a conexao
            return cn;//retorna a conexão
        }
    }
        
}

