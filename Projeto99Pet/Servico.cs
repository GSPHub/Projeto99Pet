using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto99Pet
{
    public class Servico
    {
        public int IdServico { get; set; }
        public CuidarEspecie CuidarEspecie { get; set; }
        public TipoServico TipoServico { get; set; }
        public Disponibilidade Disponibilidade { get; set; }
        public string Descricao { get; set; }
    }
}
