using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto99Pet
{
    public partial class CadastroAnimal : Form
    {
        public CadastroAnimal()
        {
            InitializeComponent();
            cbEspecie.SelectedIndex = 0;
        }

        #region Variáveis Públicas

        public int IdAnimal = 0;
        public string Nome;
        public string Sexo;
        public string Especie;
        public float Peso;
        public string Idade;
        public string Tipo;
        public string Raca;
        public string Observacao;

        #endregion

        private void Atualizar (int IdAnimal, string Nome, string Sexo, string Especie, float Peso, string Idade, string Tipo, string Raca, string Observacao)
        {
            try
            {
                DadosAnimal objDadosAnimal = new DadosAnimal();
                objDadosAnimal.Atualizar(IdAnimal, Nome, Sexo, Especie, Peso, Idade, Tipo, Raca, Observacao);
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void Gravar(string Nome, string Sexo, string Especie, float Peso, string Idade, string Tipo, string Raca, string Observacao)
        {
            try
            {
                DadosAnimal objDadosAnimal = new DadosAnimal();
                objDadosAnimal.Gravar(Nome, Sexo, Especie, Peso, Idade, Tipo, Raca, Observacao);
                MessageBox.Show("Animal Cadastrado com Sucesso!");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNome.Text) &&
                !String.IsNullOrEmpty(txtRaca.Text))
            {
                string strSexo = string.Empty;
                string strTipo = string.Empty;
                string strEspecie = string.Empty;

                if (rbMasculino.Checked)
                    strSexo = "Masculino";
                else
                    strSexo = "Feminino";

                if (rbFilhote.Checked)
                    strTipo = "Filhote";
                else
                    strTipo = "Adulto";

                strEspecie = cbEspecie.SelectedItem.ToString();


                if (IdAnimal == 0)
                    Gravar(txtNome.Text, strSexo, strEspecie, float.Parse(txtPeso.Text), txtIdade.Text, strTipo, txtRaca.Text, txtObservacao.Text);
                else
                    Atualizar(IdAnimal, txtNome.Text, strSexo, strEspecie, float.Parse(txtPeso.Text), txtIdade.Text, strTipo, txtRaca.Text, txtObservacao.Text);
            }
            else
            {

                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    epErro.SetError(txtNome, "Informe o Nome!");
                }
                if (String.IsNullOrEmpty(txtRaca.Text))
                {
                    epErro.SetError(txtRaca, "Informe a Raça!");
                }
                
            }
        }


        private void CadastroAnimal_Load(object sender, EventArgs e)
        {
            if (IdAnimal > 0)
            {
                btCadastrar.Text = "Atualizar";
                txtNome.Text = Nome;

                if (Sexo.Equals("Masculino"))
                    rbMasculino.Checked = true;
                else
                    rbFeminino.Checked = true;

                cbEspecie.SelectedItem = Especie;

                txtPeso.Text = Peso.ToString();
                txtIdade.Text = Idade;

                if (Tipo.Equals("Filhote"))
                    rbFilhote.Checked = true;
                else
                    rbAdulto.Checked = true;

                txtRaca.Text = Raca;
                txtObservacao.Text = Observacao;

            }
            else
                btCadastrar.Text = "Cadastrar";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
