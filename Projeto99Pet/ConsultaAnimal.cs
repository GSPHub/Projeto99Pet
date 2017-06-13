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
    public partial class ConsultaAnimal : Form
    {
        public ConsultaAnimal()
        {
            InitializeComponent();
            CarregarListView();
        }

        private void CarregarListView()
        {
            DadosAnimal objDadosAnimal = new DadosAnimal();
            List<Projeto99Pet.DadosAnimal.Animal> listaAnimal = new List<DadosAnimal.Animal>();
            listaAnimal = objDadosAnimal.Consultar();

            foreach (var itemLista in listaAnimal)
            {
                ListViewItem objListViewItem = new ListViewItem();

                objListViewItem.Text = itemLista.IdAnimal.ToString();
                objListViewItem.SubItems.Add(itemLista.Nome);
                objListViewItem.SubItems.Add(itemLista.Sexo);
                objListViewItem.SubItems.Add(itemLista.Especie);
                objListViewItem.SubItems.Add(itemLista.Peso.ToString());
                objListViewItem.SubItems.Add(itemLista.Idade);
                objListViewItem.SubItems.Add(itemLista.Tipo);
                objListViewItem.SubItems.Add(itemLista.Raca);
                objListViewItem.SubItems.Add(itemLista.Observacao);

                lstAnimais2.Items.Add(objListViewItem);
            }
        }

        private void EditarRegistro()
        {
        
            int IdAnimal;
            string Nome;
            string Sexo;
            string Especie;
            float Peso;
            string Idade;
            string Tipo;
            string Raca;
            string Observacao;

            try
            {
                if(lstAnimais2.SelectedItems.Count > 0)
                {
                    IdAnimal = Convert.ToInt32(lstAnimais2.SelectedItems[0].Text);
                    Nome = lstAnimais2.SelectedItems[0].SubItems[1].Text;
                    Sexo = lstAnimais2.SelectedItems[0].SubItems[2].Text;
                    Especie = lstAnimais2.SelectedItems[0].SubItems[3].Text;
                    Peso = float.Parse(lstAnimais2.SelectedItems[0].SubItems[4].Text);
                    Idade = lstAnimais2.SelectedItems[0].SubItems[5].Text;
                    Tipo = lstAnimais2.SelectedItems[0].SubItems[6].Text;
                    Raca = lstAnimais2.SelectedItems[0].SubItems[7].Text;
                    Observacao = lstAnimais2.SelectedItems[0].SubItems[8].Text;

                    CadastroAnimal objCadastroAnimal = new CadastroAnimal();
                    objCadastroAnimal.IdAnimal = IdAnimal;
                    objCadastroAnimal.Nome = Nome;
                    objCadastroAnimal.Sexo = Sexo;
                    objCadastroAnimal.Especie = Especie;
                    objCadastroAnimal.Peso = Peso;
                    objCadastroAnimal.Idade = Idade;
                    objCadastroAnimal.Tipo = Tipo;
                    objCadastroAnimal.Raca = Raca;
                    objCadastroAnimal.Observacao = Observacao;
                    objCadastroAnimal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void ExcluirRegistro()
        {
            int IdAnimal = 0;

            try
            {
                if (lstAnimais2.SelectedItems.Count > 0)
                    IdAnimal = Convert.ToInt32(lstAnimais2.SelectedItems[0].Text);

                DadosAnimal objDadosAnimal = new DadosAnimal();

                if (IdAnimal > 0)
                    objDadosAnimal.Excluir(IdAnimal);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            EditarRegistro();
        }
    }
}
