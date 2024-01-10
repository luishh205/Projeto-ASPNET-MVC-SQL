using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BDProjeto;


namespace BDProjeto.Repositorio
{
    public class bd : IDisposable
    {
        private readonly SqlConnection conexao;

        public  bd()/*conexao com banco*/
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString);
            conexao.Open();
        }

        /*metodo executar*/
        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = conexao

            };
            { cmdComando.ExecuteNonQuery(); }
        }
        /*metodo executar com retorno*/
        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var cmdComandoSelect = new SqlCommand(strQuery, conexao);
            return cmdComandoSelect.ExecuteReader();
        }


        public void Dispose()

        {
            /*verifica conexao*/
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
