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
    public partial class CadastroServico : Form
    {
        public CadastroServico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar(Servico servico)
        {
            /*
            DadosTipoServico dadosTipoServico = new DadosTipoServico();
            DadosDisponibilidade dadosDisponibilidade = new DadosDisponibilidade();
            DadosCuidarEspecie dadosCuidarEspecie = new DadosCuidarEspecie();
            dadosTipoServico.Gravar(servico.TipoServico);
            dadosDisponibilidade.Gravar(servico.Disponibilidade);
            dadosCuidarEspecie.Gravar(servico.CuidarEspecie);
            
            */

            DadosServico dadosServico = new DadosServico();
            dadosServico.Gravar(servico);

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            // Como garantir q pelo menos uma opção esteja marcada em cada
            
            var disponibilidade = new Disponibilidade {
                Segunda  = cbSegunda.Checked,
                Terca = cbTerca.Checked,
                Quarta = cbQuarta.Checked,
                Quinta = cbQuinta.Checked,
                Sexta = cbSexta.Checked,
                Sabado = cbSabado.Checked,
                Domingo = cbDomingo.Checked
            };

            var cuidarEspecie = new CuidarEspecie {
                Caes = cbCaes.Checked,
                Gatos = cbGatos.Checked,
                Roedores = cbRoedores.Checked,
                Aves =  cbAves.Checked,
                Outros = cbOutros.Checked
            };

            var tipoServico = new TipoServico {
                Passeio =  cbPasseio.Checked,
                Banho = cbBanho.Checked,
                Hospedagem =  cbHospedagem.Checked,
                Tosa = cbTosa.Checked,
                CuidadosMedicos = cbCuidados.Checked
            };
            
            var servico = new Servico {
                Disponibilidade = disponibilidade,
                CuidarEspecie = cuidarEspecie,
                TipoServico = tipoServico,
                Descricao = txtDescricao.Text
            };

            Cadastrar(servico);
      
        }
    }
}
