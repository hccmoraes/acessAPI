using Acess_API.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

// classe faz a conexão com o banco de dados.

namespace Acess_API.Dao
{
    public class DaoDados
    {
        string conexao = @"Data Source=DESKTOP-N3CC29H\SQLSERVER;Initial Catalog=ACESS_API;Integrated Security=True";

        public List<Dados> GetDados()
        {
            List<Dados> dados = new List<Dados>();

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetDados", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var dado = new Dados();
                                dado.Nome = reader["Nome"].ToString();
                                dado.Cpf = reader["Cpf"].ToString();
                                dado.Sexo = reader["Sexo"].ToString();
                                dados.Add(dado);
                            }
                        }
                    }
                }
            }

            return dados;
        }

        public void InserDados(Dados dados)
        {
            List<Dados> dados1 = new List<Dados>();

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("InserirDados", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOME", dados.Nome);
                    cmd.Parameters.AddWithValue("@CPF", dados.Cpf);
                    cmd.Parameters.AddWithValue("@SEXO", dados.Sexo);
                    cmd.ExecuteNonQuery();

                }
            }
        }

    }
}
