﻿using AdvocaciaCliente.Models;
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
                    "VALUES  (@CLINOME, @CLIENDERECO,  @CLINUMEROENDERECO , @CIDADE, @ESTADOSIGLA, @CLICPF, @CLICNPJ) ";
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
    }
}
