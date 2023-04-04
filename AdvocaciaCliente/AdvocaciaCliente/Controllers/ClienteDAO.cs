using System;
using Dapper;
using AdvocaciaCliente.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocaciaCliente.DAL
{
    public class ClienteDAO
    {
        private SqlConnection _conexao;
        public ClienteDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Cliente> getTodosClientes()
        {
            string sql = "select * from cliente";
            var dados = (List<Cliente>)_conexao.Query<Cliente>(sql);
            return dados;
        }
        public bool inserirCliente(Cliente cliente)
        {
            try
            {
                string sql = "INSERT INTO [dbo].[Cliente]  ([CLINOME],[CLIENDERECO] ,[CLINUMEROENDERECO], " +
                    "[CIDADE]  ,[ESTADOSIGLA]     ,[CLICPF]  ,[CLICNPJ]) " +
                    "VALUES  @CLINOME, @CLIENDERECO,  @CLINUMEROENDERECO , @CIDADE, @ESTADOSIGLA, @CLICPF, @CLICNPJ ";
                int qtdInserida = _conexao.Execute(sql, cliente);
                if (qtdInserida > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {

                return false;
            }
        }

        internal bool inserirCliente(object categoriaDocumento)
        {
            throw new NotImplementedException();
        }
    }
}
