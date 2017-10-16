using ARACI.DAO;
using ARACI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARACI
{
    public partial class Classificacao : Form
    {
        private string strCon = @"Data Source=LAPTOP-IOR439CC;Initial Catalog=bancoaraci;Integrated Security=True";
        SqlConnection objConect = null; //nomeou a conexão
        SqlCommand objCommand = null;// nomeou o comand
        UsuarioDAO usuario = new UsuarioDAO();
       

        public Classificacao()
        {
            InitializeComponent();
        }

        public void ClassificarPontuacao()
        {
            string strSQL = "SELECT USUARIO.Nome, SUM(USUARIO_JOGO.ponto_nivel_jogo) "
                + "as 'Quantidade de Pontos' FROM USUARIO"
                + " JOIN USUARIO_JOGO on USUARIO_JOGO.ID_usuario = USUARIO.ID_usuario "
                + "GROUP BY USUARIO.Nome ORDER BY 2 desc";

            objConect = new SqlConnection(strCon);
            objCommand = new SqlCommand(strSQL, objConect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dtList = new DataTable();

                objAdp.Fill(dtList);

                dgDados.DataSource = dtList;
            }
            catch
            {
                MessageBox.Show("Falha na classificação!");
            }

        }
        private void Classificacao_Load(object sender, EventArgs e)
        {
            ClassificarPontuacao();
        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
