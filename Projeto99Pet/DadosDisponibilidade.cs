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
    class DadosDisponibilidade
    {

        #region String de Conexão   

        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        #endregion

        #region Variáveis Constantes

        public const string strDelete = "DELETE FROM Disponibilidade WHERE IdDisponibilidade = @IdDisponibilidade";
        public const string strInsert = "INSERT INTO Disponibilidade OUTPUT  INSERTED.IdDisponibilidade VALUES" +
            "(@Segunda, @Terca, @Quarta, @Quinta, @Sexta, @Sabado, @Domingo)";
        public const string strSelect = "SELECT IdDisponibilidade, Segunda, Terca, Quarta, Quinta, Sexta," +
            " Sabado, Domingo FROM Disponibilidade";
        public const string strUptade = "UPDATE Disponibilidade SET Segunda = @Segunda, Terca = @Terca," +
            " Quarta = @Quarta, Quinta = @Quinta, Sexta = @Sexta, Sabado = @Sabado," +
            " Domingo = @Domingo WHERE IdDisponibilidade = @IdDisponibilidade";

        #endregion

        public void Atualizar(Disponibilidade disponibilidade)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strUptade, objConexao))
                {

                    objComand.Parameters.AddWithValue("@IdDisponibilidade", disponibilidade.IdDisponibilidade);
                    objComand.Parameters.AddWithValue("@Segunda", disponibilidade.Segunda);
                    objComand.Parameters.AddWithValue("@Terca", disponibilidade.Terca);
                    objComand.Parameters.AddWithValue("@Quarta", disponibilidade.Quarta);
                    objComand.Parameters.AddWithValue("@Quinta", disponibilidade.Quinta);
                    objComand.Parameters.AddWithValue("@Sexta", disponibilidade.Sexta);
                    objComand.Parameters.AddWithValue("@Sabado", disponibilidade.Sabado);
                    objComand.Parameters.AddWithValue("@Domingo", disponibilidade.Domingo);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }
        }

        public void Excluir(Disponibilidade disponibilidade)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strDelete, objConexao))
                {
                    objComand.Parameters.AddWithValue("@IdDisponibilidade", disponibilidade.IdDisponibilidade);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }

        }

        public int Gravar(Disponibilidade disponibilidade)
        {
            int id = 0;
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strInsert, objConexao))
                {
                    objComand.Parameters.AddWithValue("@Segunda", disponibilidade.Segunda);
                    objComand.Parameters.AddWithValue("@Terca", disponibilidade.Terca);
                    objComand.Parameters.AddWithValue("@Quarta", disponibilidade.Quarta);
                    objComand.Parameters.AddWithValue("@Quinta", disponibilidade.Quinta);
                    objComand.Parameters.AddWithValue("@Sexta", disponibilidade.Sexta);
                    objComand.Parameters.AddWithValue("@Sabado", disponibilidade.Sabado);
                    objComand.Parameters.AddWithValue("@Domingo", disponibilidade.Domingo);

                    objConexao.Open();

                    //objComand.ExecuteNonQuery();
                    id = (int)objComand.ExecuteScalar();

                    objConexao.Close();

                }
            }
            return id;
        }
    }
}
