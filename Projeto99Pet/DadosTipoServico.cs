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
    class DadosTipoServico
    {
        #region String de Conexão   

        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        #endregion

        #region Variáveis Constantes

        public const string strDelete = "DELETE FROM Tipo_Servico WHERE IdTipo_Servico = @IdTipo_Servico";
        public const string strInsert = "INSERT INTO Tipo_Servico OUTPUT  INSERTED.IdTipo_Servico VALUES" +
            "(@Passeio, @Banho, @Hospedagem, @Tosa, @Cuidados_Medicos)";
        public const string strSelect = "SELECT IdTipo_Servico, Passeio, Banho, Hospedagem, Tosa," +
            " Cuidados_Medicos, FROM  Tipo_Servico";
        public const string strUptade = "UPDATE Tipo_Servico SET Passeio = @Passeio, Banho = @Banho," +
            " Hospedagem = @Hospedagem, Tosa = @Tosa, Cuidados_Medicos = @Cuidados_Medicos," +
            " WHERE IdTipo_Servico = @IdTipo_Servico";

        #endregion

        public void Atualizar(TipoServico tipoServico)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strUptade, objConexao))
                {

                    objComand.Parameters.AddWithValue("@IdTipo_Servico", tipoServico.IdTipoServico);
                    objComand.Parameters.AddWithValue("@Passeio", tipoServico.Passeio);
                    objComand.Parameters.AddWithValue("@Banho", tipoServico.Banho);
                    objComand.Parameters.AddWithValue("@Hospedagem", tipoServico.Hospedagem);
                    objComand.Parameters.AddWithValue("@Tosa", tipoServico.Tosa);
                    objComand.Parameters.AddWithValue("@Cuidados_Medicos", tipoServico.CuidadosMedicos);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }
        }

        public void Excluir(TipoServico tipoServico)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strDelete, objConexao))
                {
                    objComand.Parameters.AddWithValue("@IdTipo_Servico", tipoServico.IdTipoServico);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }

        }

        public int Gravar(TipoServico tipoServico)
        {
            int id = 0;
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strInsert, objConexao))
                {
                   
                    objComand.Parameters.AddWithValue("@Passeio", tipoServico.Passeio);
                    objComand.Parameters.AddWithValue("@Banho", tipoServico.Banho);
                    objComand.Parameters.AddWithValue("@Hospedagem", tipoServico.Hospedagem);
                    objComand.Parameters.AddWithValue("@Tosa", tipoServico.Tosa);
                    objComand.Parameters.AddWithValue("@Cuidados_Medicos", tipoServico.CuidadosMedicos);

                    objConexao.Open();

                    //Console.WriteLine(objComand.ExecuteScalar());
                    id = (int) objComand.ExecuteScalar();
                    //ExecuteNonQuery();

                    objConexao.Close();

                }
            }
            return id;
        }
    }
}
