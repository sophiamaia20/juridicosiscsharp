using AdvocaciaCliente.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocaciaCliente.DAL
{
    public class ClienteDao
    {
        private SqlConnection _conexao;

        public ClienteDao()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Cliente> getTodosClientes()
        {
            string sql = "select * from Cliente";
            var dados = (List<Cliente>)_conexao.Query<Cliente>(sql);
            return dados;
        }
    }
}
