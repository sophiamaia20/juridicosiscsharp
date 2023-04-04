using AdvocaciaCliente.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocaciaCliente.DAL
{
    public class CategoriaDocumentoDAO
    {
        public class CategoriaDocumento
        {
            private SqlConnection _conexao;

            public CategoriaDocumento()
            {
                _conexao = ConexaoBD.getConexao();
            }

            public List<CategoriaDocumento> getTodosCategoriaDocumento()
            {
                string sql = "select * from CategoriaDocumento";
                var dados = (List<CategoriaDocumento>)_conexao.Query<CategoriaDocumento>(sql);
                return dados;
            }
        }

        internal dynamic getTodosCategoriaDocumento()
        {
            throw new NotImplementedException();
        }
    }   }
