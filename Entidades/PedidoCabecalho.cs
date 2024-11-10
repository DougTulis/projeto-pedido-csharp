using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pedido_4lions.Entidades {
    internal class PedidoCabecalho {

        public string Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente _Cliente { get; set; }
        public double ValorTotal { get; set; }
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();

        public PedidoCabecalho(string id, DateTime data, Cliente cliente, double valorTotal, PedidoItem item) {
            Id = id;
            Data = data;
            _Cliente = cliente;
            ValorTotal = valorTotal;
            Item = item;
        }
    }
}
