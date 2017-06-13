using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto99Pet
{
    public class TipoServico
    {
        public int IdTipoServico { get; set; }
        public bool Passeio { get; set; }
        public bool Banho { get; set; }
        public bool Tosa { get; set; }
        public bool Hospedagem { get; set; }
        public bool CuidadosMedicos { get; set; }
    }
}
