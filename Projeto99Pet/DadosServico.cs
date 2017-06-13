using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto99Pet
{
    class DadosServico
    {
        #region String de Conexão   

        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        #endregion

        #region Query

        public const string strDelete = "DELETE FROM Servico WHERE IdServico = @IdServico";
        public const string strInsert = "INSERT INTO Servico OUTPUT INSERTED.IdServico VALUES" +
            "(@IdDisponibilidade, @IdCuidar_Especie, @IdTipo_Servico, @Descricao)";
        public const string strSelect = "SELECT IdServico, IdDisponibilidade, IdCuidar_Especie," + 
            " IdTipo_Servico, Descricao  FROM  Servico";
        public const string strUptade = "UPDATE Servico SET Descricao = @Descricao," +
            " WHERE IdServico = @IdServico";

        #endregion

        public void Atualizar(Servico servico)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strUptade, objConexao))
                {

                    objComand.Parameters.AddWithValue("@IdServico", servico.IdServico);
                    objComand.Parameters.AddWithValue("@Descricao", servico.Descricao);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }
        }

        public void Excluir(Servico servico)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strDelete, objConexao))
                {
                    objComand.Parameters.AddWithValue("@IdServico", servico.IdServico);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }

        }

        public int Gravar(Servico servico)
        {
            int id = 0;
            var dadosDisponibilidade = new DadosDisponibilidade();
            var dadosCuidarEspecie = new DadosCuidarEspecie();
            var dadosTipoServico = new DadosTipoServico();

            var idDisponibilidade = dadosDisponibilidade.Gravar(servico.Disponibilidade);
            var idCuidarEspecie = dadosCuidarEspecie.Gravar(servico.CuidarEspecie);
            var idTipoServico = dadosTipoServico.Gravar(servico.TipoServico);

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strInsert, objConexao))
                {
                    

                    objComand.Parameters.AddWithValue("@IdDisponibilidade", idDisponibilidade);
                    objComand.Parameters.AddWithValue("@IdCuidar_Especie", idCuidarEspecie);
                    objComand.Parameters.AddWithValue("@IdTipo_Servico", idTipoServico);
                    objComand.Parameters.AddWithValue("@Descricao", servico.Descricao);

                    objConexao.Open();

                    //Console.WriteLine(objComand.ExecuteScalar());
                    id = (int)objComand.ExecuteScalar();
                    //ExecuteNonQuery();

                    objConexao.Close();

                }
            }
            return id;
        }
    }
}
