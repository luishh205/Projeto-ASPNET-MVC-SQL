using BDProjeto.Dominio;
using BDProjeto;
using System;
using System.Data.SqlClient;
using BDProjeto.Aplicacao;
using DBProjeto.Aplicacao;

namespace DOS
{
    class Program
    {
       public static void Main(string[] args)
        {
            var app = UsuarioAplicaçãoConstrutor.UsuarioApADO();

            SqlConnection conexao
                = new SqlConnection(@"data source=DESKTOP-DSU1QDR\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=ExemploBD;");
            conexao.Open();
            
            Console.Write("digite o nome do usuario: ");
            string nome = Console.ReadLine();

            Console.Write("digite o cargo do usuario: ");
            string cargo = Console.ReadLine();

            Console.Write("digite a data de cadastro: ");
            string data = Console.ReadLine();
          
            var usuarios = new Usuarios
            {
                Nome = nome,
                Cargo = cargo,
                Data = DateTime.Parse(data)
            };

            //usuarios.Id = 5;

           app.Salvar(usuarios); 
            
          

            /*metodo select*/

            var dados = app.ListarTodos();

            foreach (var usuario in dados)
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Cargo:{2}, Data:{3}", usuario.Id, usuario.Nome, usuario.Cargo, usuario.Data);
            }
        }
    }
}
