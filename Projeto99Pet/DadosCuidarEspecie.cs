using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Projeto99Pet
{
    class DadosCuidarEspecie
    {
        #region String de Conexão   

        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        #endregion

        #region Variáveis Constantes

        public const string strDelete = "DELETE FROM Cuidar_Especie WHERE IdCuidar_Especie = @IdCuidar_Especie";
        public const string strInsert = "INSERT INTO Cuidar_Especie OUTPUT  INSERTED.IdCuidar_Especie VALUES" +
            "(@Caes, @Gatos, @Roedores, @Aves, @Outros)";
        public const string strSelect = "SELECT IdCuidar_Especie, Caes, Gatos, Roedores, Aves," +
            " Outros, FROM  Cuidar_Especie";
        public const string strUptade = "UPDATE Cuidar_Especie SET Caes = @Caes, Gatos = @Gatos," +
            " Roedores = @Roedores, Aves = @Aves, Outros = @Outros," +
            " WHERE IdCuidar_Especie = @IdCuidar_Especie";

        #endregion

        public void Atualizar(CuidarEspecie cuidarEspecie)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strUptade, objConexao))
                {

                    objComand.Parameters.AddWithValue("@IdCuidar_Especie", cuidarEspecie.IdCuidarEspecie);
                    objComand.Parameters.AddWithValue("@Caes", cuidarEspecie.Caes);
                    objComand.Parameters.AddWithValue("@Gatos", cuidarEspecie.Gatos);
                    objComand.Parameters.AddWithValue("@Roedores", cuidarEspecie.Roedores);
                    objComand.Parameters.AddWithValue("@Aves", cuidarEspecie.Aves);
                    objComand.Parameters.AddWithValue("@Outros", cuidarEspecie.Outros);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }
        }

        public void Excluir(CuidarEspecie cuidarEspecie)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strDelete, objConexao))
                {
                    objComand.Parameters.AddWithValue("@IdCuidar_Especie", cuidarEspecie.IdCuidarEspecie);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }

        }

        public int Gravar(CuidarEspecie cuidarEspecie)
        {
            int id = 0;
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strInsert, objConexao))
                {
                    objComand.Parameters.AddWithValue("@Caes", cuidarEspecie.Caes);
                    objComand.Parameters.AddWithValue("@Gatos", cuidarEspecie.Gatos);
                    objComand.Parameters.AddWithValue("@Roedores", cuidarEspecie.Roedores);
                    objComand.Parameters.AddWithValue("@Aves", cuidarEspecie.Aves);
                    objComand.Parameters.AddWithValue("@Outros", cuidarEspecie.Outros);

                    objConexao.Open();

                    id = (int)objComand.ExecuteScalar();
                    //objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }
            return id;

        }
    }
}
