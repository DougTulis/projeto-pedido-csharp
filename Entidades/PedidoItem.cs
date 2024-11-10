using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pedido_4lions.Entidades {
    internal class PedidoItem {
        public int Sequencia { get; set; }
        public Produto Produto { get; set; }
        public int Qtde { get; set; }
        public double ValorUnit { get; set; }

        public PedidoItem(int sequencia, Produto produto, int qtde, double valorUnit) {
            Sequencia = sequencia;
            Produto = produto;
            Qtde = qtde;
            ValorUnit = valorUnit;
        }
    }
}
