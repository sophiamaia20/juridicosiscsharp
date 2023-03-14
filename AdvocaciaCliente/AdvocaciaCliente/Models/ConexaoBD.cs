using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocaciaCliente.Models
{
    public class ConexaoBD
    {
        public class ConexaoBD
        {
            private static SqlConnection banco;

            public static SqlConnection getConexao()
            {
                if (banco == null)
                {
                    banco = new SqlConnection(@"Server=.\SENAI2022; Database=BDJURIDICO; User Id =sa; Password=senai.123;");
                }

                return banco;
            }
        }

        internal static SqlConnection getConexao()
        {
            throw new NotImplementedException();
        }
    }
}
