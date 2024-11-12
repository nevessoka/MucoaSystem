using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MucoaSystem.model
{
    public class Encomenda
    {
        // Propriedades da Encomenda
        public int IdEncomenda { get; set; }
        public Cliente Cliente { get; set; }
        public Menu Menu { get; set; } // Nome do item principal ou cardápio
        public string EnderecoEntrega { get; set; }
        public DateTime DataEncomenda { get; set; }
        public DateTime? DataEntrega { get; set; }
        public decimal ValorTotal { get; private set; }
        public decimal ValorPago { get; set; } // Valor que o cliente efetivamente pagou
        public int Quantidade { get; private set; } // Quantidade total de itens na encomenda
        public string Status { get; set; }
    }
}
