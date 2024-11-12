using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MucoaSystem.model
{
    public class Cliente
    {
        // Propriedades da classe Cliente
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Contato { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}
