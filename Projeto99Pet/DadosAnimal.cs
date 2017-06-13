using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Projeto99Pet
{
    public class DadosAnimal
    {
        #region String de Conexão   

        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        #endregion

        #region Variáveis Constantes

        public const string strDelete = "DELETE FROM Animal WHERE IdAnimal = @IdAnimal";
        public const string strInsert = "INSERT INTO Animal VALUES" + 
            "(@Nome, @Sexo, @Especie, @Peso, @Idade, @Tipo, @Raca, @Observacao)";
        public const string strSelect = "SELECT IdAnimal, Nome, Sexo, Especie, Peso, Idade," + 
            " Tipo, Raca, Observacao  FROM Animal";
        public const string strUptade = "UPDATE Animal SET Nome = @Nome, Sexo = @Sexo," + 
            " Especie = @Especie, Peso = @Peso, Idade = @Idade, Tipo = @Tipo," +
            " Raca = @Raca, Observacao = @Observacao WHERE IdAnimal = @IdAnimal";

        #endregion

        public class Animal
        {
            public int IdAnimal { get; set; }
            public string Nome { get; set; }
            public string Sexo { get; set; }
            public string Especie { get; set; }
            public float Peso { get; set; }
            public string Idade { get; set; }
            public string Tipo { get; set; }
            public string Raca { get; set; }
            public string Observacao { get; set; }

        }

        #region Métodos

        public void Atualizar (int IdAnimal, string Nome, string Sexo, string Especie, float Peso, string Idade, string Tipo, string Raca, string Observacao)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strUptade, objConexao))
                {

                    objComand.Parameters.AddWithValue("@IdAnimal", IdAnimal);
                    objComand.Parameters.AddWithValue("@Nome", Nome);
                    objComand.Parameters.AddWithValue("@Sexo", Sexo);
                    objComand.Parameters.AddWithValue("@Especie", Especie);
                    objComand.Parameters.AddWithValue("@Peso", Peso);
                    objComand.Parameters.AddWithValue("@Idade", Idade);
                    objComand.Parameters.AddWithValue("@Tipo", Tipo);
                    objComand.Parameters.AddWithValue("@Raca", Raca);
                    objComand.Parameters.AddWithValue("@Observacao", Observacao);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }
        }

        public List<Animal> Consultar()
        {
            List<Animal> lstAnimal = new List<Animal>();

            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strSelect, objConexao))
                {
                    objConexao.Open();

                    SqlDataReader objDataReader = objComand.ExecuteReader();

                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            Animal objAnimal = new Animal();
                            objAnimal.IdAnimal = Convert.ToInt32(objDataReader["IdAnimal"].ToString());
                            objAnimal.Nome = objDataReader["Nome"].ToString();
                            objAnimal.Sexo = objDataReader["Sexo"].ToString();
                            objAnimal.Especie = objDataReader["Especie"].ToString();
                            objAnimal.Peso = float.Parse(objDataReader["Peso"].ToString());
                            objAnimal.Idade = objDataReader["Idade"].ToString();
                            objAnimal.Tipo = objDataReader["Tipo"].ToString();
                            objAnimal.Raca = objDataReader["Raca"].ToString();
                            objAnimal.Observacao = objDataReader["Observacao"].ToString();

                            lstAnimal.Add(objAnimal);
                        }
                        objDataReader.Close();
                    }

                    objConexao.Close();
                }

            }
                    return lstAnimal;
        }

        public void Excluir (int IdAnimal)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strDelete, objConexao))
                {
                    objComand.Parameters.AddWithValue("@IdAnimal", IdAnimal);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }

        }

        public void Gravar (string Nome, string Sexo, string Especie, float Peso, string Idade, string Tipo, string Raca, string Observacao)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComand = new SqlCommand(strInsert, objConexao))
                {
                    objComand.Parameters.AddWithValue("@Nome", Nome);
                    objComand.Parameters.AddWithValue("@Sexo", Sexo);
                    objComand.Parameters.AddWithValue("@Especie", Especie);
                    objComand.Parameters.AddWithValue("@Peso", Peso);
                    objComand.Parameters.AddWithValue("@Idade", Idade);
                    objComand.Parameters.AddWithValue("@Tipo", Tipo);
                    objComand.Parameters.AddWithValue("@Raca", Raca);
                    objComand.Parameters.AddWithValue("@Observacao", Observacao);

                    objConexao.Open();

                    objComand.ExecuteNonQuery();

                    objConexao.Close();

                }
            }

        }

        #endregion
    }
}
