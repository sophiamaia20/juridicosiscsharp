using AdvocaciaCliente.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocaciaCliente.DAL
{
    public class TipoPessoaDAO
    {

        private SqlConnection _conexao;

        public TipoPessoaDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<TipoPessoa> getTodosTipoPessoa()
        {
            string sql = "select * from TipoPessoa";
            var dados = (List<TipoPessoa>)_conexao.Query<TipoPessoa>(sql);
            return dados;
        }
    }
}
